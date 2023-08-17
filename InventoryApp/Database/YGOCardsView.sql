/*Materialized view for the current market price of all cards*/
create view YGOCurrentMarket
with Schemabinding
as
Select C.image, M.card_id, M.set_code, M.rarity, C.card_name, C.card_type, C.card_race, M.set_name, M.market_price
from dbo.YGOCardsInfo as C 
inner join (select card_id, set_code, rarity, set_name, market_price from dbo.YGOMarketPrice where update_date = (select MAX(update_date) from dbo.YGOMarketPrice)) as M on C.card_id = M.card_id

/*Materialized view showing the card average price change from last 7 days and current 7 days*/
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
