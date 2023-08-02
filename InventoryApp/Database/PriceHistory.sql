Create Proc CardPriceHistory 
@CID int, 
@SC varchar(50), 
@R varchar(50),
@Start date,
@End date
as 
Begin
	Select update_date, market_price from dbo.YGOMarketPrice where card_id = @CID and set_code = @SC and rarity = @R and update_date <= @End and update_date >= @Start order by update_date desc
End

/*Load card prices from the last 7 days and return the min and max date range of that card*/
Create Proc DateRange
@CID int, 
@SC varchar(50),
@R varchar(50),
@Start varchar(50) output,
@End varchar(50)  output
as
Begin 
	set @Start = (Select Min(update_date) from dbo.YGOMarketPrice where card_id = @CID and set_code = @SC and rarity = @R)
	set @End = (Select Max(update_date) from dbo.YGOMarketPrice where card_id = @CID and set_code = @SC and rarity = @R)
End

drop proc DateRange
drop proc CardPriceHistory
select Top 7 update_date, market_price from dbo.YGOMarketPrice where card_id = 3410461 and set_code = 'DIFO-EN035' and rarity = '(ScR)' order by update_date desc

exec CardPriceHistory 3410461, 'DIFO-EN035', '(ScR)', '2023-07-25', '2023-07-29'
