/*Store content of the receipt in a datatable then insert the entire table into ReceiptInfo*/
Create Type ReceiptContent as Table 
(
	card_id int not null,
	set_code varchar(50) not null,
	rarity varchar(50) not null,
	quantity int not null,
	price money not null,
	transaction_id int not null,
	user_id varchar(64) not null
)
drop Type ReceiptContent
drop proc AddReceipt

Create Proc AddReceipt
@tid int, /*transaction id*/
@uid varchar(64),
@table ReceiptContent Readonly ,
@status int output
as 
Begin
	declare @date date
	declare @count int
	declare @total money
	Begin Try 
		Begin Transaction
			set @date = GETDATE()
			set @count = (select SUM(quantity) from @table)
			set @total = (select SUM(price) from @table)
			Insert into dbo.Receipt(transaction_id, user_id, date, items, total_price) values (@tid, @uid, @date, @count, @total) /*Insert receipt info*/
			Insert into dbo.ReceiptInfo(transaction_id, user_id, card_id, set_code, rarity, quantity, price) Select transaction_id, user_id, card_id, set_code, rarity, quantity, price from @table
			delete from dbo.ShoppingCart where user_id = @uid /*remove info from shoppingcart*/
		Commit Transaction /*Commit action*/
		set @status = 1 /*Successfully insert receipt info*/
	End Try

	Begin Catch
		DECLARE @ErrorMessage NVARCHAR(4000),
            @ErrorSeverity INT,
            @ErrorState INT;

		 SELECT @ErrorMessage = ERROR_MESSAGE(),
           @ErrorSeverity = ERROR_SEVERITY(),
           @ErrorState = ERROR_STATE();

    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
		ROLLBACK TRANSACTION
		set @status = 0 /*Failed to complete transaction, restore all table to before insert*/
	End Catch 
End

select * from dbo.ShoppingCart where user_id = '1'
select * from Receipt
select * from ReceiptInfo
