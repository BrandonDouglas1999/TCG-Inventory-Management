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
@s_price money = null, /*default value is null no value is given*/
@Copies int = null, 
@image varchar(MAX),
@Status int output /*stored procedure will output this value*/
as
Begin
	declare @date date
	if not exists (select card_id, set_code, rarity, game from CardsInfo where card_id = @CID and set_code = @Set_Code and rarity = @Rarity and game = @Game)
		Begin
			set @date = GETDATE()
			if (@Copies is null and @s_price is null)
				Begin 
					Insert into CardsInfo 
					(card_id, set_code, rarity, game, card_name, card_type, card_race, set_name, current_price, update_date, image) 
					values 
					(@CID, @Set_Code, @Rarity, @Game, @C_name, @C_type, @C_race,  @Set_Name, @C_price, @date, @image)
				End
			else
				Begin
					Insert into CardsInfo 
					(card_id, set_code, rarity, game, card_name, card_type, card_race, set_name, current_price, store_price, copies, update_date, image) 
					values 
					(@CID, @Set_Code, @Rarity, @Game, @C_name, @C_type, @C_race,  @Set_Name, @C_price, @s_price, @Copies, @date, @image)
				End
			select @Status = 1
		End
	else 
		Begin
			select @Status = 0
		End
End

--drop procedure AddCard
--delete from CardsInfo where card_id = 123

Declare @stat as int;
Execute AddCard @CID = 456, @Set_Code = 'Set', @Rarity = 'rare', @Game = 'YGO', @C_name = 'name', @C_type = 'type', @C_race = 'race', @Set_Name = 'SetName', @C_price = 2.33, @image = 'image.jpg', @Status = @stat output
print @stat

Declare @stat as int;
Execute AddCard 123, 'Set', 'rare', 'YGO', 'name', 'type', 'race', 'SetName', 2.33, 2.00, 3,'image.jpg', @stat output
print @stat

select * from CardsInfo where card_id = 123 or card_id = 456
