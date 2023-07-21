create proc LoginVerification
@user_name varchar(50),
@pw varchar(50),
@status int output, /*output or validation*/
@UID int output
as Begin
	set @UID = 0
	if exists (select user_name from dbo.StoreLogin where user_name = @user_name)
		Begin
			if exists (select password from dbo.StoreLogin where user_name = @user_name and password = @pw)
				Begin
					set @status = 1 /*Success*/
					set @UID = (select user_id from dbo.StoreLogin where user_name = @user_name and password = @pw)
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

declare @stat as int, @userid as int
exec LoginVerification 'Boss_man', '12345', @stat output, @userid output
print @stat
print @userid
