/*
Add new card into user inventory table, if card does not exist in database then it will be add and its price keep track of from then on with daily market price update
*/
Alter Proc AddCard
@UID varchar(64), /*Store id*/
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
	if not exists (select  user_id, card_id, set_code, rarity from dbo.YGOStorePrice where user_id = @UID and card_id = @CID and set_code = @Set_Code and rarity = @Rarity)
		Begin
			Insert into dbo.YGOStorePrice 
				(user_id, card_id, set_code, rarity, store_price, copies) 
			values 
				(@UID, @CID, @Set_Code, @Rarity, ROUND(@s_price, 2), @Copies)

			/*Add market price to YGOMarketPrice*/
			If not exists (select update_date, card_id, set_code, rarity from YGOMarketPrice where update_date = @date and card_id = @CID and set_code = @Set_Code and rarity= @Rarity)
				Begin 
					Insert into dbo.YGOMarketPrice
						(update_date, card_id, set_code, rarity, market_price, set_name)
					values
						(@date, @CID, @Set_Code, @Rarity, @M_price, @Set_Name)
				End
			/*Check if cards info is in database*/
			If not exists(select card_id from YGOCardsInfo where card_id = @CID)	
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