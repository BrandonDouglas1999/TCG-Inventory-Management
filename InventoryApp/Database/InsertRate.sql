Create Proc InsertRate 
@Api_Rate float
as
Begin
	declare @C_Date date, @C_rate float
	set @C_Date = GETDATE()
	/*The if condition will compare the latest rate in the database with the latest rate acquire from api
		if the rate is different, then the new rate will be inserted into the database*/
	if not exists (select Rate from ConversionRate where Date = @C_Date)
	Begin 
		insert into ConversionRate values(@C_Date, @Api_Rate)	 
	End
	/* If database contain no rate, then the rate from api will be inserted and return*/
End

/*For testing purposes*/
select * from ConversionRate
drop proc InsertRate
delete from ConversionRate where Date = '2023-06-22'
Exec InsertRate 0.7
select * from ConversionRate

Create Proc InsertRate
@api_rate float,
@db_rate float output
as 
Begin 
	declare @C_Date date
	set @C_date = GETDATE()
	/*Check and retrieve the latest rate currently in the database*/
	if exists (Select Rate from ConversionRate where Date = (Select MAX(Date) from ConversionRate))
	Begin 
		set @db_rate = (Select Rate from ConversionRate where Date = (Select MAX(Date) from ConversionRate))
		/*if api_rate is different from the latest rate in the db then insert the api_rate into the database*/
		if (@db_rate != @api_rate) and not exists (select * from ConversionRate where Date = @C_Date)
		Begin
			Insert into ConversionRate(Date, Rate) values (@C_Date, @api_rate)
		End
		return 
	End
	/*if database is empty then insert and return the current rate*/
	else
	Begin 
		set @db_rate = @api_rate
		Insert into ConversionRate(Date, Rate) values (@C_Date, @api_rate)
	End 
End

declare @rate float
Exec InsertRate 0.9, @rate output
print @rate 

select * from ConversionRate