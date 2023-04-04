If OBJECT_ID ('sp_Usuario') is not null
	Drop procedure sp_Usuario;
go


create proc sp_Usuario
(
@Op							   CHAR(1),
@RFC						   varchar(250),
@nombre			               varchar(250),
@apellidop					   varchar(250),
@apellidom                     varchar(250),
@nomina                        numeric(5,0),
@fnacimiento				   DATE,
@domicilio					   varchar(255),
@ciudad						   varchar(255),
@estado						   varchar(255),
@pais						   varchar(255),
@telefono					   numeric(10,0),
@esadmin					   int,
@correo						   varchar(255),
@contrasena					   varchar(255)
)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into Usuario (RFC, nombre, apellidop, apellidom, nomina, fnacimiento, domicilio, ciudad, estado, pais, telefono, esadmin, correo, contrasena)
				       	Values (@RFC, @nombre, @apellidop, @apellidom, @nomina, @fnacimiento, @domicilio, @ciudad, @estado, @pais, @telefono, @esadmin, @correo, @contrasena)
	End

	IF @Op = 'U' --update
	Begin
		Update Usuario set nombre = @nombre, apellidop = @apellidop, apellidom = @apellidom, nomina = @nomina,
						   fnacimiento = @fnacimiento, ciudad = @ciudad,  estado = @estado, pais = @pais, telefono = @telefono,
						   esadmin = @esadmin, correo = @correo, contrasena = @contrasena
		where RFC = @RFC	
	End

	IF @Op = 'D' --delete
	Begin
		delete from Usuario  where RFC = @RFC
	End

End;
go

If OBJECT_ID ('sp_Login_Usuario') is not null
	Drop procedure sp_Login_Usuario;
go

create proc sp_Login_Usuario
@Correo varchar (50)
as
		select contrasena, RFC from  Usuario
		where  correo=@correo
go

If OBJECT_ID ('sp_Get_Usuario') is not null
	Drop procedure sp_Get_Usuario;
go

create proc sp_Get_Usuario
as
	select * from  Usuario;
go