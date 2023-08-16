create view YGOCurrentMarket
with Schemabinding
as
Select C.image, M.card_id, M.set_code, M.rarity, C.card_name, C.card_type, C.card_race, M.set_name, M.market_price
from dbo.YGOCardsInfo as C 
inner join (select card_id, set_code, rarity, set_name, market_price from dbo.YGOMarketPrice where update_date = (select MAX(update_date) from dbo.YGOMarketPrice)) as M on C.card_id = M.card_id

select CM.image, S.card_id, CM.card_name, S.set_code, CM.set_name, S.rarity,  CM.market_price, S.store_price, S.copies from YGOStorePrice as S inner join  
(Select Y.image, Y.card_id, Y.set_code, Y.rarity, Y.card_name, Y.card_type, Y.card_race, Y.set_name, ROUND(Y.market_price / C.rate, 2) as market_price
from YGOCurrentMarket as Y, dbo.ConversionRate as C
where C.update_date = ((select MAX(update_date) from dbo.ConversionRate))) as CM
on S.card_id = CM.card_id and S.set_code = CM.set_code and S.rarity = CM.rarity where S.user_id = '101164323405038069020'

select * from ShoppingCart

update YGOStorePrice
set store_price = C.market_price
from YGOStorePrice S
inner join 
YGOCurrentMarket as C 
on
S.card_id = C.card_id and S.set_code = C.set_code and S.rarity = C.rarity



/*------------------------------------------------------------------Market Price Average View----------------------------------------------------------------------------*/
create view YGOPriceAVG
with Schemabinding 
as 
Select CM.card_id, CM.set_code, CM.rarity, YM.lastWeekAVG, CM.thisWeekAVG, ROUND((YM.lastWeekAVG * ((CM.thisWeekAVG - YM.lastWeekAVG)/YM.lastWeekAVG)), 2) as differ
from 
(Select C.card_id, C.set_code, C.rarity, ROUND(AVG(C.market_price), 2) as thisWeekAVG
from 
(Select card_id, set_code, rarity, market_price from dbo.YGOMarketPrice where update_date > DATEADD(week, -1, format(GETDATE(), 'yyyy-MM-dd')))
as C
group by C.card_id, C.set_code, C.rarity) as CM
inner join 
(Select Y.card_id, Y.set_code, Y.rarity, Round(AVG(Y.market_price), 2) as lastWeekAVG
from 
(Select card_id, set_code, rarity, market_price from dbo.YGOMarketPrice where update_date <= DATEADD(week, -1, format(GETDATE(), 'yyyy-MM-dd')) and update_date > DATEADD(week, -2, format(GETDATE(), 'yyyy-MM-dd')))
as Y
group by Y.card_id, Y.set_code, Y.rarity) as YM
on CM.card_id = YM.card_id and CM.set_code = YM.set_code and CM.rarity = YM.rarity

drop view YGOPriceAVG
select * from YGOPriceAVG

select SP.card_id, AP.card_name, SP.set_code, SP.rarity, AP.lastWeekAVG, AP.thisWeekAVG, AP.differ from YGOStorePrice as SP 
inner join 
(select C.card_name, A.card_id, A.set_code, A.rarity, A.lastWeekAVG, A.thisWeekAVG, A.differ from YGOPriceAVG as A inner join  YGOCardsInfo as C on  A.card_id = C.card_id where A.differ > 4 or A.differ < -4)
as AP on SP.card_id = AP.card_id and SP.set_code = AP.set_code and SP.rarity = AP.rarity and SP.user_id = '1'
