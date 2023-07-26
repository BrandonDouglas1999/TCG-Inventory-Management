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

drop proc InsertRate
declare @rate float
Exec InsertRate 0.9, @rate output
print @rate 

select * from ConversionRate 

delete from ConversionRate where date < (select DATEADD(day, -7, GETDATE()) as daterange) /*delete record that is older than 7 days old from current date*/