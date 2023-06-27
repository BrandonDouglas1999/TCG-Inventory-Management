Create Proc AddCard
@CID int,
@Set_Code varchar(50),
@Rarity varchar(20),
@Game varchar(20),
@C_name varchar(MAX),
@C_type varchar(MAX),
@C_race varchar(MAX),
@Set_Name varchar(MAX),
@C_price money,
@s_price money, 
@Copies int, 
@image varchar(MAX),
@Status int output /*stored procedure will output this value*/
as
Begin
	declare @date date
	if not exists (select card_id, set_code, rarity, game from CardsInfo where card_id = @CID and set_code = @Set_Code and rarity = @Rarity and game = @Game)
		Begin
			set @date = GETDATE()
			Insert into CardsInfo 
			(card_id, set_code, rarity, game, card_name, card_type, card_race, set_name, current_price, store_price, copies, update_date, image) 
			values 
			(@CID, @Set_Code, @Rarity, @Game, @C_name, @C_type, @C_race,  @Set_Name, @C_price, @s_price, @Copies, @date, @image)
			select @Status = 1
		End
	else 
		Begin
			select @Status = 0
		End
End

--drop procedure AddCard
--delete from CardsInfo

--Declare @stat as int;
--Execute AddCard 123, 'Set', 'rare', 'YGO', 'name', 'type', 'race',  'beybe', 2.33,  3, 3, 'image.jpg', @stat output
--print @stat

--select * from CardsInfo
