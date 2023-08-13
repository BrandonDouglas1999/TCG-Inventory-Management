Alter Proc SalesHistory 
@UID varchar(64),
@Start date,
@End date
as Begin 
	Select date as Date, transaction_id as 'Transaction ID', items as 'Number of Item', total_price as 'Total' from dbo.Receipt where date <= @End and date >= @Start and user_id = @UID

	Select Top 5 C.card_name as 'Card Name', US.set_code as 'Set Code', US.rarity as ' Rarity', US.[Unit Sold] from (Select card_id, set_code, rarity, SUM(quantity) as "Unit Sold" from (Select card_id, set_code, rarity, quantity from ReceiptInfo as R1 inner join 
	(Select transaction_id, user_id, items, total_price from dbo.Receipt where date <= @End and date >= @Start and user_id = @UID) as R2 on R1.transaction_id = R2.transaction_id and R1.user_id = R2.user_id) as Q group by card_id, set_code, rarity) as US
	inner join YGOCardsInfo as C on US.card_id = C.card_id order by US.[Unit Sold] desc
End


Select Top 5 C.card_name, R.set_code, R.rarity, R.count as 'Unit Sold' from (Select card_id, set_code, rarity, SUM(quantity) as count from ReceiptInfo where user_id = @UID group by card_id, set_code, rarity) as R inner join dbo.YGOCardsInfo as C on C.card_id = R.card_id order by 'Unit Sold' desc


Select Top 5 C.card_name, US.set_code, US.rarity, US.[Unit Sold]
from (Select card_id, set_code, rarity, SUM(quantity) as "Unit Sold" from (Select card_id, set_code, rarity, quantity from ReceiptInfo as R1 inner join 
(Select transaction_id, user_id, items, total_price from dbo.Receipt where date <= '2023-08-13' and date >= '2023-08-01' and user_id = '101164323405038069020') as R2 on R1.transaction_id = R2.transaction_id and R1.user_id = R2.user_id) as Q group by card_id, set_code, rarity) as US
inner join YGOCardsInfo as C on US.card_id = C.card_id order by US.[Unit Sold] desc

exec SalesHistory '2023-08-13', '2023-08-01', '101164323405038069020'