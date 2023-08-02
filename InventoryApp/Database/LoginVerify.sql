create proc LoginVerification
@user_name varchar(50),
@pw varchar(50),
@status int output, /*output or validation*/
@UID varchar(64) output
as Begin
	set @UID = 0
	if exists (select user_name from dbo.UserLogin where user_name = @user_name)
		Begin
			if exists (select password from dbo.UserLogin where user_name = @user_name and password = @pw)
				Begin
					set @status = 1 /*Success*/
					set @UID = (select user_id from dbo.UserLogin where user_name = @user_name and password = @pw)
				End
			else 
				Begin 
					set @status = 2 /*Invalid Password*/
				End
		End
	else
		Begin 
			set @status = 0 /*Invalid username*/
		End
End

drop proc LoginVerification

create proc ExternalLogin
@GID varchar(64),
@auth_type varchar(50),
@status int output, 
@UID varchar(64) output
as Begin 
	set @UID = 0
	if exists (select user_id from UserLogin where user_id = @GID and auth_type = @auth_type)
	Begin
		Set @status = 1 /*Success*/
		Set @UID = (select user_id from UserLogin where user_id = @GID and auth_type = @auth_type)
	End
	else 
	Begin
		set @status = 0 /*Account does not exist*/
	End
End

create proc CreateExternalLogin
@GID varchar(64),
@auth_type varchar(50),
@Email varchar(MAX),
@Username varchar(50),
@status int output
as Begin 
	if not exists (select user_id from UserLogin where user_id = @GID and auth_type = @auth_type)
	Begin 
		Insert into UserLogin(user_id, email, user_name, auth_type) values (@GID, @Email, @Username, @auth_type)
		Set @status = 1 /*Success creating account with the login*/ 
	End
	Else 
	Begin
		Set @status = 0
	End
End


declare @stat as int, @userid as int
exec LoginVerification 'Boss_man', '12345', @stat output, @userid output
print @stat
print @userid
SELECT COUNT(card_id) as num from YGOStorePrice where store_id = 1
