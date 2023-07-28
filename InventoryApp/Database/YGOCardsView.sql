create view YGOCurrentMarket
with Schemabinding
as
Select C.image, M.card_id, M.set_code, M.rarity, C.card_name, C.card_type, C.card_race, M.set_name, M.market_price
from dbo.YGOCardsInfo as C 
inner join (select card_id, set_code, rarity, set_name, market_price from dbo.YGOMarketPrice where update_date = (select MAX(update_date) from dbo.YGOMarketPrice)) as M on C.card_id = M.card_id

drop view YGOCurrentMarket

select * from YGOCurrentMarket order by set_name
select * from YGOMarketPrice

select CM.image, S.card_id, S.set_code, S.rarity, CM.card_name, CM.market_price, S.store_price, S.copies from YGOStorePrice as S inner join YGOCurrentMarket as CM on S.card_id = CM.card_id and S.set_code = CM.set_code and S.rarity = CM.rarity where S.store_id = 1

SELECT COUNT(store_id) as num from YGOStorePrice where store_id = 1