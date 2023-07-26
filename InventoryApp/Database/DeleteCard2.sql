/*Delete card from database, stored procedure return status code to indicate whether the card exists and has been deleted or not and will also return the image file name of the 
	deleted card for deleting the image in folder*/
Create Proc deleteCard
@SID int, 
@CID int,
@Setcode varchar(20),
@Rarity varchar(20), 
@image_file varchar(max) output,
@status int output
as Begin
	Begin Try
		delete from dbo.YGOStorePrice where card_id = @CID and set_code = @Setcode and rarity = @Rarity and store_id = @SID
		set @status = 1
	End Try
	Begin Catch /*failed*/
		set @status = 0
	End Catch
End

drop proc deleteCard
select * from YGOCardsInfo
select * from YGOCards
select * from YGOCardsJoin