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

		End Transaction 
	End Try
	Begin Catch
		ROLLBACK TRANSACTION
		set @status = 0 /*Failed to complete transaction, restore all table to before insert*/
	End Catch 
End

