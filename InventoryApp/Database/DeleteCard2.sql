/*
Delete card from database, stored procedure return status code to indicate whether the card exists 
and has been deleted or not, will also delete card from shopping cart
*/
Alter Proc deleteCard
@UID varchar(64), 
@CID int,
@Setcode varchar(20),
@Rarity varchar(20), 
@status int output
as Begin
	Begin Try
		Begin Transaction
			delete from dbo.YGOStorePrice where card_id = @CID and set_code = @Setcode and rarity = @Rarity and user_id = @UID
			delete from dbo.ShoppingCart where card_id = @CID and set_code = @Setcode and rarity = @Rarity and user_id = @UID
		Commit transaction 
		set @status = 1
	End Try
	Begin Catch /*failed*/
		RollBack Transaction
		set @status = 0
	End Catch
End