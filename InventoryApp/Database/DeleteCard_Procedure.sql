/*Delete card from database, stored procedure return status code to indicate whether the card exists and has been deleted or not and will also return the image file name of the 
	deleted card for deleting the image in folder*/
Create Proc deleteCard
@CID int,
@Setcode varchar(20),
@Rarity varchar(20), 
@image_file varchar(max) output,
@status int output
as Begin
	Begin Try
		set @image_file = (select image from CardsInfo where card_id = @CID and set_code = @Setcode and rarity = @Rarity)
		delete from CardsInfo where card_id = @CID and set_code = @Setcode and rarity = @Rarity
		If exists (select image from CardsInfo where image = @image_file) /*Check if image file is still use by other variants of the same card*/
			Begin
				set @image_file = 'n/a' /*remove file name from return*/
				set @status = 2
			End
		Else
			Begin
				set @status = 1
			End
	End Try
	Begin Catch /*failed*/
		set @image_file = 'n/a'
		set @status = -1
	End Catch
End

drop proc deleteCard

declare @image as varchar(max), @stat as int
exec deleteCard 8124921, 'LDK2-ENY07', '(C)', @image output, @stat output
print @image
print @stat

select * from CardsInfo
select * from YGOMarketPrice
