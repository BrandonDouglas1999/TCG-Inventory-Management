/*
 Update the market price of a single card
*/
Create Proc UpdateOnlinePrice 
@CID int,
@Setcode varchar(20),
@Rarity varchar(20),
@new_price money
as Begin 
	declare @c_price money
	declare @date date
	set @date = GETDATE()
	set @c_price= (select current_price from CardsInfo where card_id = @CID and set_code = @Setcode and rarity = @Rarity)
	if (@new_price != @c_price)
		begin
			update CardsInfo 
			set old_price = @c_price, current_price = @new_price, update_date = @date
			where card_id = @CID and set_code = @Setcode and rarity = @Rarity
		end
end 