create type UpdateTable as Table
(
	update_date date not null,
	card_id int not null,
	set_code varchar(50) not null,
	rarity varchar(20) not null,
	current_price money not null, 
	set_name varchar(MAX) not null
)

create proc UpdateDB 
@datatable UpdateTable READONLY/*passing a table as parameter*/
as
Begin
	if ((select MAX(update_date) as latest from dbo.YGOMarketPrice) != (select MAX(update_date) as latest from @datatable))
		Begin 
			Insert into dbo.YGOMarketPrice Select * from @datatable /*Insert card into table*/
		End
End

create proc UpdateDB2 
@datatable UpdateTable READONLY/*passing a table as parameter*/
as
Begin
		Insert into dbo.YGOMarketPrice Select * from @datatable /*Insert card into table*/
End

drop type UpdateTable
drop proc UpdateDB2
select * from YGOCards
select distinct card_id, set_code, rarity from dbo.YGOMarketPrice where set_name = 'wing raiders'
select distinct card_id, set_code, rarity from dbo.YGOMarketPrice where update_date < (select max(update_date) from YGOMarketPrice)
select card_id from YGOCardsInfo
select * from dbo.UpdateMarket
select * from YGOMarketPrice where  update_date='2023-07-26'
delete from YGOMarketPrice where  update_date='2023-07-26'
select * from YGOMarketPrice where update_date='2023-07-25' order by set_name
select distinct(set_name) from YGOMarketPrice

select distinct card_id, set_code, rarity from dbo.YGOMarketPrice


