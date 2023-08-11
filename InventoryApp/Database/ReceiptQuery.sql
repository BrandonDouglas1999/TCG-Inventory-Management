/*Store content of the receipt in a datatable then insert the entire table into ReceiptInfo*/
Create Type ReceiptContent as Table 
(
	transaction_id int not null,
	user_id varchar(64) not null,
	card_id int not null,
	set_code varchar(50) not null,
	rarity varchar(50) not null,
	quantity int not null,
	price money not null

)

Create Proc AddReceipt
@tid int, /*transaction id*/
@uid varchar(64),
@date date,
@count int,
@total money,
@table ReceiptContent READONLY,
@status int output
as 
Begin
	Begin Try 
		Begin Transaction
			Insert into dbo.Receipt(transaction_id, user_id, date, items, total_price) values (@tid, @uid, @date, @count, @total) /*Insert receipt info*/
			Insert into dbo.Receipt Select * from @table
		Commit Transaction /*Commit action*/
		set @status = 1 /*Successfully insert receipt info*/
	End Try

	Begin Catch
		ROLLBACK TRANSACTION
		set @status = 0 /*Failed to complete transaction, restore all table to before insert*/
	End Catch 
End

