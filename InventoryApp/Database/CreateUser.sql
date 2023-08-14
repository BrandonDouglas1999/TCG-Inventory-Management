Create Proc CreateUser
@UN varchar(50), /*username*/
@PW varchar(50),
@REPW varchar(50),
@EMAIL varchar(MAX), 
@Status int output
as Begin

	if (@PW != @REPW)
	Begin
		set @Status = -1 /*Password not matched*/
		return 
	End
	if exists (select email from UserLogin where email = @EMAIL)
	Begin 
		set @Status = -2 /*Email exist in database*/
		return
	End

	if exists (select user_name from UserLogin where user_name = @UN)
	Begin
		set @Status = -3 /*Username taken*/
		return
	End
	
	declare @UID varchar(64)
	set @UID = (SELECT CAST(FLOOR(RAND()*(1000-1+1))+1 as varchar))

	while exists (select user_id from UserLogin where user_id = @UID)
	Begin 
		set @UID = (SELECT CAST(FLOOR(RAND()*(1000-1+1))+1 as varchar))
	End 

	Insert into UserLogin(user_id, password, email, user_name) values (@UID, @PW, @EMAIL, @UN)
	set @Status = 1
End

select * from UserLogin
delete from UserLogin where user_id = '91'

declare @stat int
Exec CreateUser 'anothernew_man', 'Random', 'randon', 'anothernew_man@mail.com', @stat output
print @stat