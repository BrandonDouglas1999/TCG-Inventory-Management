Create Proc AddCard
@CID int,
@Set_Code varchar(50),
@Game varchar(50),
@C_name varchar(MAX),
@C_type varchar(MAX),
@C_race varchar(MAX),
@Rarity varchar(50),
@Set_Name varchar(MAX),
@C_price money,
@inventory int, 
@image varchar(MAX),
@s_price money, 
@Status int output /*stored procedure will output this value*/
as
Begin
	if not exists (select Card_ID, Set_Code, Game from CardsInfo where Card_ID = @CID and Set_Code = @Set_Code and Game = @Game)
		Begin
			Insert into CardsInfo 
			(Card_ID, Set_Code, Game, Card_Name, Card_Type, Card_Race, Rarity, Set_Name, Current_Price, Inventory, Image, Store_Price) 
			values 
			(@CID, @Set_Code, @Game, @C_name, @C_type, @C_race, @Rarity, @Set_Name, @C_price, @inventory, @image, @s_price)
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
--Execute AddCard 123, 'Set', 'YGO', 'name', 'type', 'race', 'rare', 'beybe', 2.33, 3, 'image.jpg', 3, @stat output
--print @stat

--select * from CardsInfo
