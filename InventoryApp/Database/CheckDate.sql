USE [TCG_Inventory3]
GO
/****** Object:  StoredProcedure [dbo].[CheckIfUpdated]    Script Date: 2023-08-17 5:08:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[CheckIfUpdated]
@Status int output /*stored procedure will output this value*/
as
Begin
    declare @date date
    set @date = GETDATE()
    if (select distinct update_date from dbo.YGOMarketPrice where update_date = @date) = @date
        begin
            select @Status = 1
        end
    else 
        Begin
            select @Status = 0
        End
End