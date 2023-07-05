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

--drop proc UpdateOnlinePrice
--exec UpdateOnlinePrice 'Cyber Dragon', 'BP02-EN039', 6.91
/*
select current_price from CardsInfo where card_id = 3410461 and set_code = 'DIFO-EN035' and rarity = '(StR)' and update_date < GETDATE()

select current_price from CardsInfo where card_id = @CID and set_code = @Setcode and rarity = @Rarity and update_date < @date or update_date is null
*/
exec UpdateOnlinePrice 3410461, 'DIFO-EN035', '(StR)', 0

select * from CardsInfo

update CardsInfo 
set old_price = current_price, current_price = 11.15, update_date = GETDATE()
where card_id = 3410461 and set_code = 'DIFO-EN035' and rarity = '(StR)'

update CardsInfo set current_price = 0
select distinct set_name from CardsInfo
select * from CardsInfo where card_id = 73642296