/*
Return list of receipt and the list of store's top seller cards along with total units sold
*/
Alter Proc SalesHistory 
@UID varchar(64),
@Start date,
@End date
as Begin 
	Select date as Date, transaction_time as 'Transaction Time' ,transaction_id as 'Transaction ID', items as 'Number of Item', total_price as 'Total' from dbo.Receipt where date <= @End and date >= @Start and user_id = @UID order by date desc, transaction_time desc

	Select Top 5 C.card_name as 'Card Name', US.[Unit Sold] from (Select card_id, SUM(quantity) as "Unit Sold" from (Select card_id, set_code, rarity, quantity from ReceiptInfo as R1 inner join 
	(Select transaction_id, user_id, items, total_price from dbo.Receipt where date <= @End and date >= @Start and user_id = @UID) as R2 on R1.transaction_id = R2.transaction_id and R1.user_id = R2.user_id) as Q group by card_id) as US
	inner join YGOCardsInfo as C on US.card_id = C.card_id order by US.[Unit Sold] desc
End