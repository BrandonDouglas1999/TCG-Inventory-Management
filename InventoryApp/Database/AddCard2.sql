/* 
Insert card info into the YGOCardsInfo
Insert Market price into YGOMarketPrice
Insert store price and copies into YGOStorePrice
*/

Create Proc AddCard
@SID int, /*Store id*/
@CID int,
@Set_Code varchar(50),
@Rarity varchar(20),
@Game varchar(20),
@C_name varchar(MAX),
@C_type varchar(MAX),
@C_race varchar(MAX),
@Set_Name varchar(MAX),
@M_price money,
@s_price money, /*default value is null no value is given*/
@Copies int, 
@image varchar(MAX),
@Status int output /*stored procedure will output this value*/
as
Begin
	declare @date date
	set @date = GETDATE()
	/*Check if card in store inventory*/
	if not exists (select  store_id, card_id, set_code, rarity from dbo.YGOStorePrice where store_id = @SID and card_id = @CID and set_code = @Set_Code and rarity = @Rarity)
		Begin
			Insert into dbo.YGOStorePrice 
				(store_id, card_id, set_code, rarity, store_price, copies) 
			values 
				(@SID, @CID, @Set_Code, @Rarity, @s_price, @Copies)

			/*Add market price to YGOMarketPrice*/
			Insert into dbo.YGOMarketPrice
				(update_date, card_id, set_code, rarity, market_price, set_name)
			values
				(@date, @CID, @Set_Code, @Rarity, @M_price, @Set_Name)

			/*Check if cards info is in database*/
			if not exists(select card_id from YGOCardsInfo where card_id = @CID)	
				Begin
					Insert into dbo.YGOCardsInfo 
						(card_id, game,card_name, card_race, card_type, image)
					values
						(@CID, @Game, @C_name, @C_race, @C_type, @image)
				End
			select @Status = 1
		End
	else 
		Begin
			select @Status = 0
		End
End

/*
drop proc AddCard
delete from YGOCardsInfo
delete from YGOMarketPrice
delete from YGOStorePrice
*/

/*May materialized view on this join*/
select I.image, I.card_id, M.set_code, M.rarity,I.card_name, I.card_race, I.card_type, M.set_name, M.market_price
from YGOCardsInfo as I
inner join (select * from YGOMarketPrice where update_date = '2023-07-21') as M on M.card_id = I.card_id

select MI.image, MI.card_id, MI.card_name, MI.set_code, S.rarity, MI.set_name, MI.market_price, S.store_price, S.copies from YGOStorePrice as S inner join (select I.image, I.card_id, M.set_code, M.rarity,I.card_name, I.card_race, I.card_type, M.set_name, M.market_price from YGOCardsInfo as I inner join (select * from YGOMarketPrice where update_date = '2023-07-21') as M on M.card_id = I.card_id) as MI on S.card_id = MI.card_id and S.set_code = MI.set_code and S.rarity = MI.rarity where store_id = 2


select * from YGOMarketPrice

select * from YGOCardsInfo

select * from YGOStorePrice