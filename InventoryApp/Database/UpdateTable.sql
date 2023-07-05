/*Take in datatable as parameter and update cards in CardsInfo table  */
/* Table valued parameter*/

/*This is a user define table, it will be use as a parameter, the parameter datatable column must match this*/
create type UpdateTable as Table
(
	card_id int not null,
	set_code varchar(50) not null,
	rarity varchar(20) not null,
	current_price money not null
)

create proc UpdateDB 
@datatable UpdateTable READONLY /*passing a table as parameter*/
as
Begin
	declare @date date
	set @date = GETDATE()
	Insert into CardsUpdate Select * from @datatable /*Insert card into table*/
	if exists (select * from CardsUpdate)
	Begin
		
		Update CardsInfo Set old_price = C1.current_price, current_price = C2.current_price, update_date = @date
		From CardsInfo as C1 INNER Join CardsUpdate as C2 on C1.card_id = C2.card_id and C1.set_code = C2.set_code and C1.rarity = C2.rarity

		delete from CardsUpdate
	End 
End

drop proc UpdateDB
delete from CardsUpdate
select * from CardsUpdate
select * from CardsInfo
update CardsInfo set current_price = 0
update CardsInfo set old_price = current_price
select * from CardsInfo where card_name = 'Number 39: Utopia'