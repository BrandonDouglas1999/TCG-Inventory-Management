USE [TCG_Inventory3]
GO
/****** Object:  StoredProcedure [dbo].[AddToCart]    Script Date: 2023-08-11 9:24:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Proc [dbo].[AddToCart]
@UID varchar(64), /*Store id*/
@CID int,
@Set_Code varchar(50),
@Rarity varchar(20),
@Quantity int,
@status int output
as
Begin
    /*Check if card is in the shopping cart*/
    if not exists (select user_id, card_id, set_code, rarity from dbo.ShoppingCart where user_id = @UID and card_id = @CID and set_code = @Set_Code and rarity = @Rarity) 
        Begin
			if ((Select copies from dbo.YGOStorePrice where card_id = @CID and set_code = @Set_Code and rarity = @Rarity and user_id = @UID) >= @Quantity)
			Begin
				Insert into dbo.ShoppingCart 
					(user_id, card_id, set_code, rarity, quantity) 
				values 
					(@UID, @CID, @Set_Code, @Rarity, @Quantity)
				set @status = 1
			End
			else 
			Begin 
				set @status = 0	
			End 
        End
    /*Update quantity if in shopping cart*/
    else
        Begin
			declare @current_qty int
			set @current_qty = (Select quantity from dbo.ShoppingCart where card_id = @CID and set_code = @Set_Code and rarity = @Rarity and user_id = @UID) + @Quantity
			if ((Select copies from dbo.YGOStorePrice where card_id = @CID and set_code = @Set_Code and rarity = @Rarity and user_id = @UID) >= @current_qty)
			Begin 
				Update dbo.ShoppingCart
				SET quantity = quantity + @Quantity
				where card_id = @CID and set_code = @Set_Code and rarity = @Rarity and user_id = @UID
				set @status = 1 /*Successfully updated*/
			End
			else 
			Begin 
				set @status = 0
			End
        End
End