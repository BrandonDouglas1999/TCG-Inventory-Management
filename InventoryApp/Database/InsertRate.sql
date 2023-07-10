Create Proc InsertRate
@api_rate float,
@db_rate float output
as 
Begin 
	declare @C_Date date
	set @C_date = GETDATE()

	/*Check and retrieve the latest rate currently in the database*/
	If exists (Select Rate from ConversionRate where Date = (Select MAX(Date) from ConversionRate))
		Begin 
			set @db_rate = (Select Rate from ConversionRate where Date = (Select MAX(Date) from ConversionRate))
			/*if api_rate is different from the latest rate in the db then insert the api_rate into the database*/
			If (@db_rate != @api_rate) and not exists (select * from ConversionRate where Date = @C_Date)
				Begin
					Insert into ConversionRate(Date, Rate) values (@C_Date, @api_rate)
				End
			return 
		End

	/*If database is empty then insert and return the current rate*/
	Else
		Begin 
			set @db_rate = @api_rate
			Insert into ConversionRate(Date, Rate) values (@C_Date, @api_rate)
		End 
End

declare @rate float
Exec InsertRate 0.9, @rate output
print @rate 

select * from ConversionRate 

delete from ConversionRate where date < (select DATEADD(day, -7, GETDATE()) as daterange) /*delete record that is older than 7 days old from current date