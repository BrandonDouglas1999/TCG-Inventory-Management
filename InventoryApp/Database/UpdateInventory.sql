Alter proc UpdateInventory 
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
		Set store_price = ROUND(@S_price, 2), copies = @Copies
		where user_id = @UID and card_id = @CID and set_code = @Set_code and rarity = @Rarity

		Set @Status = 1
	End Try
	Begin Catch 
		Set @Status = 0
	End Catch 
End