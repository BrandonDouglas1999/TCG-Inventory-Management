/*
Retrieve the user shopping cart along with the price of those card
*/
USE [TCG_Inventory3]
GO
/****** Object:  StoredProcedure [dbo].[GetCart]    Script Date: 2023-08-11 9:25:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Proc [dbo].[GetCart]
@UID varchar(64) /*Store id*/
as
Begin
		Select P.card_name, P.image, SH.card_id, SH.set_code, SH.rarity, SH.quantity, (SH.quantity * P.store_price) as price
		from dbo.ShoppingCart as SH
		inner join (Select C.card_name, C.image, S.card_id, S.set_code, S.rarity, S.store_price, S.user_id from dbo.YGOStorePrice as S inner join dbo.YGOCardsInfo as C on S.card_id = C.card_id and user_id = @UID) as P on 
		SH.card_id = P.card_id and SH.set_code = P.set_code and SH.rarity = P.rarity
End