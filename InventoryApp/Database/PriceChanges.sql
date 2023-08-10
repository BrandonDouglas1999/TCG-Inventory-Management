Select * from YGOCurrentMarket
Select * from YGOMarketPrice where update_date < DATEADD(day, -7, format(GETDATE(), 'yyyy-MM-dd')) order by set_code

/*One day changes check*/
select M.card_id, M.set_code, M.rarity, M.market_price as new_price, Y.market_price as old_price, ((M.market_price - Y.market_price)/Y.market_price)*100 as Percent_change from YGOCurrentMarket as M
inner join (Select * from YGOMarketPrice where update_date = DATEADD(day, -1, format(GETDATE(), 'yyyy-MM-dd'))) as Y
on M.card_id = Y.card_id and M.set_code = Y.set_code and M.rarity = Y.rarity and Y.market_price != M.market_price order by set_code

/*Average of 7 days changes*/
Select * from YGOMarketPrice where update_date > DATEADD(day, -7, format(GETDATE(), 'yyyy-MM-dd')) order by set_code
Select * from YGOMarketPrice where update_date > DATEADD(week, -1, format(GETDATE(), 'yyyy-MM-dd')) order by set_code

Select * from YGOMarketPrice where update_date <= DATEADD(day, -7, format(GETDATE(), 'yyyy-MM-dd')) and update_date > DATEADD(day, -14, format(GETDATE(), 'yyyy-MM-dd')) order by set_code
Select * from YGOMarketPrice where update_date <= DATEADD(week, -1, format(GETDATE(), 'yyyy-MM-dd')) and update_date > DATEADD(week, -2, format(GETDATE(), 'yyyy-MM-dd')) order by set_code

/*Past Week*/
Select Y.card_id, Y.set_code, Y.rarity, AVG(Y.market_price) as AVG_price
from 
(Select card_id, set_code, rarity, market_price from YGOMarketPrice where update_date <= DATEADD(day, -7, format(GETDATE(), 'yyyy-MM-dd')) and update_date > DATEADD(day, -14, format(GETDATE(), 'yyyy-MM-dd')))
as Y
group by Y.card_id, Y.set_code, Y.rarity order by Y.set_code

/*Recent 7 days*/

select SP.user_id, SP.card_id, SP.set_code, SP.rarity, AV.lastWeekAVG, AV.thisWeekAVG, AV.shift_percentage
from YGOStorePrice as SP
inner join 
(
Select CM.card_id, CM.set_code, CM.rarity, YM.lastWeekAVG, CM.thisWeekAVG,  ((CM.thisWeekAVG - YM.lastWeekAVG)/YM.lastWeekAVG) * 100 as shift_percentage, ROUND((YM.lastWeekAVG * ((CM.thisWeekAVG - YM.lastWeekAVG)/YM.lastWeekAVG)), 2) as dollars
from 
(Select C.card_id, C.set_code, C.rarity, ROUND(AVG(C.market_price), 2) as thisWeekAVG
from 
(Select card_id, set_code, rarity, market_price from YGOMarketPrice where update_date > DATEADD(week, -1, format(GETDATE(), 'yyyy-MM-dd')))
as C
group by C.card_id, C.set_code, C.rarity) as CM
inner join 
(Select Y.card_id, Y.set_code, Y.rarity, Round(AVG(Y.market_price), 2) as lastWeekAVG
from 
(Select card_id, set_code, rarity, market_price from YGOMarketPrice where update_date <= DATEADD(week, -1, format(GETDATE(), 'yyyy-MM-dd')) and update_date > DATEADD(week, -2, format(GETDATE(), 'yyyy-MM-dd')))
as Y
group by Y.card_id, Y.set_code, Y.rarity) as YM
on CM.card_id = YM.card_id and CM.set_code = YM.set_code and CM.rarity = YM.rarity
) as AV
on SP.card_id = AV.card_id and SP.set_code = AV.set_code and SP.rarity = AV.rarity and SP.user_id = '1' order by set_code

select * from YGOPriceAVG where shift_percentage > 10 or shift_percentage < -10


