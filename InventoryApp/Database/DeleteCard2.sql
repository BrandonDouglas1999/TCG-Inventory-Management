/*Delete card from StorePrice table for a specific user*/
Create Proc deleteCard
@SID int, /*Store id*/
@CID int,
@Setcode varchar(20),
@Rarity varchar(20), 
@status int output
as Begin
	Begin Try
		if exists (select card_id, set_code, rarity from YGOStorePrice where card_id = @CID and set_code = @Setcode and rarity = @Rarity)
		Begin 
			delete from YGOStorePrice where store_id = @SID and card_id = @CID and set_code = @Setcode and rarity = @Rarity
			set @status = 1
		End
	End Try
	Begin Catch /*failed*/
		set @status = -1
	End Catch
End

select * from YGOStorePrice where store_id = 2