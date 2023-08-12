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
    Select C.card_name, C.image, S.card_id, S.set_code, S.rarity, S.quantity, S.price
	from dbo.ShoppingCart as S inner join dbo.YGOCardsInfo as C on S.card_id = C.card_id where user_id = @UID
End

Select C.card_name, C.image, S.card_id, S.set_code, S.rarity, S.quantity, S.price
from dbo.ShoppingCart as S inner join dbo.YGOCardsInfo as C on S.card_id = C.card_id where user_id = '101164323405038069020'

select * from ShoppingCart