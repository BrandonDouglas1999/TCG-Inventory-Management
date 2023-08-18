/*
Update the user's item in the shopping cart
*/

USE [TCG_Inventory3]
GO
/****** Object:  StoredProcedure [dbo].[EditCart]    Script Date: 2023-08-14 12:29:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Alter Proc [dbo].[EditCart]
@UID varchar(64), /*Store id*/
@CID int,
@Set_Code varchar(50),
@Rarity varchar(20),
@Quantity int,
@status int output
as
Begin
    if (@Quantity = 0)
    Begin
        Delete from dbo.ShoppingCart where card_id = @CID and set_code = @Set_Code and rarity = @rarity
        set @status = 2
    End
    else
    Begin
        if ((Select copies from dbo.YGOStorePrice where card_id = @CID and set_code = @Set_Code and rarity = @Rarity and user_id = @UID) >= @Quantity)
        Begin 
            Update dbo.ShoppingCart
            SET quantity = @Quantity
            where card_id = @CID and set_code = @Set_Code and rarity = @Rarity and user_id = @UID
            set @status = 1 /*Successfully updated*/
        End

        else 
        Begin 
            set @status = 0
        End
    End
End