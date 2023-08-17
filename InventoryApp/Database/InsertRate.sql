Create Proc InsertRate
@api_rate float
as 
Begin 
	declare @C_Date date
	set @C_date = GETDATE()
	If not exists (select rate from ConversionRate where update_date = @C_Date)
	Begin 
		Insert into ConversionRate(update_date, rate) values (@C_Date, @api_rate)
	End
End