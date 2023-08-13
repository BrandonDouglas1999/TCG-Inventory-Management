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

Alter Proc AddReceipt
@tid int, /*transaction id*/
@uid varchar(64),
@table ReceiptContent Readonly,
@total money,
@status int output
as 
Begin
	declare @date date
	declare @count int
	Begin Try 
		Begin Transaction
			set @date = GETDATE()
			set @count = (select SUM(quantity) from @table)
			Insert into dbo.Receipt(transaction_id, user_id, date, items, total_price) values (@tid, @uid, @date, @count, @total) /*Insert receipt info*/
			Insert into dbo.ReceiptInfo(transaction_id, user_id, card_id, set_code, rarity, quantity, price) Select transaction_id, user_id, card_id, set_code, rarity, quantity, price from @table
			Update dbo.YGOStorePrice set copies = (copies - quantity)
					from dbo.YGOStorePrice SP inner join dbo.ReceiptInfo R on SP.card_id = R.card_id and SP.set_code = R.set_code and SP.rarity = R.rarity where transaction_id = @tid and SP.user_id = @uid
			Delete from dbo.ShoppingCart where user_id = @uid /*remove info from shoppingcart*/
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