create proc UpdateInventory 
@UID varchar(64),
@CID int,
@Set_code varchar(50),
@Rarity varchar(50),
@S_price money,
@Copies int,
@Status int output
as Begin 
	Begin Try
		Update dbo.YGOStorePrice
		Set store_price = @S_price, copies = @Copies
		where user_id = @UID and card_id = @CID and set_code = @Set_code and rarity = @Rarity

		Set @Status = 1
	End Try
	Begin Catch 
		Set @Status = 0
	End Catch 
End

drop proc UpdateInventory

insert into UserLogin(user_id, email, user_name) values ('15d347a392738ded7469c114cadd8dda260a085692061125516e95b6eae181d9', 'somemail@mail.com', 'user_name')

select * from YGOStorePrice where user_id = 1 order by set_code 

declare @stat int
exec UpdateInventory '1', 3410461, 'DIFO-EN035', '(StR)', 90.00, 15, @stat output 
print @stat

Update dbo.YGOStorePrice
		Set store_price = @S_price, copies = @Copies
		where user_id = '1' and card_id = 3410461 and set_code = 'DIFO-EN035' 

select user_id, user_name, rate from UserLogin, ConversionRate where update_date = (select MAX(update_date) from ConversionRate)