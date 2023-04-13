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
@telefono					   numeric(10,0),
@esadmin					   int,
@correo						   varchar(255),
@contrasena					   varchar(255)
)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into Usuario (RFC, nombre, apellidop, apellidom, nomina, fnacimiento, domicilio, telefono, esadmin, correo, contrasena)
				       	Values (@RFC, @nombre, @apellidop, @apellidom, @nomina, @fnacimiento, @domicilio, @telefono, @esadmin, @correo, @contrasena)
	End

	IF @Op = 'U' --update
	Begin
		Update Usuario set nombre = @nombre, apellidop = @apellidop, apellidom = @apellidom, nomina = @nomina,
						   fnacimiento = @fnacimiento, telefono = @telefono,
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
		select contrasena, RFC, concat(nombre, ' ', apellidop, ' ', apellidom) as nombreCom, esadmin from  Usuario
		where  correo=@correo
go

If OBJECT_ID ('sp_Get_Usuario') is not null
	Drop procedure sp_Get_Usuario;
go

create proc sp_Get_Usuario
as
	select Case esadmin 
	when 0 then 'Operador' 
	when 1 then 'Administrador' 
	ELSE 'Desconocido' END AS Puesto, 
	RFC, nombre as Nombre, apellidop as 'Apellido Paterno',  apellidom as 'Apellido Materno',
	nomina as Nomina, fnacimiento as 'Fecha de nacimiento', domicilio as Domicilio, telefono as 'Telefono celular', correo as Correo, contrasena as Contaseña 
	     from  Usuario;
go

--------------------------------------------------------------------------Hotel--------------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('sp_Hotel') is not null
	Drop procedure sp_Hotel;
go


create proc sp_Hotel
(
@Op							   CHAR(1),
@id_hotel					   int,
@nombreH					   varchar(255),
@ubicacion					   varchar(255),
@domicilioH					   varchar(255),
@numPiso					   numeric(3,0),
@canHabitacion				   numeric(2,0),
@zonaTuris					   Bit,
@servicioAdi				   Bit,
@frentePlaya				   Bit,
@salonEventos				   Bit,
@fechaReg					   DATE, 
@fechaInicioOp				   DATE,
@regAdim					   varchar(13)
)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into Hotel (nombreH, ubicacion, domicilioH, numPiso, canHabitacion, zonaTuris, servicioAdi, frentePlaya, salonEventos, fechaReg, fechaInicioOp, regAdim)
				       	Values (@nombreH, @ubicacion, @domicilioH, @numPiso, @canHabitacion, @zonaTuris, @servicioAdi, @frentePlaya, @salonEventos, @fechaReg, @fechaInicioOp, @regAdim)
	End

	IF @Op = 'U' --update
	Begin
		Update Hotel set nombreH = @nombreH, ubicacion = @ubicacion, domicilioH = @domicilioH, numPiso = @numPiso,
						   canHabitacion = @canHabitacion, zonaTuris = @zonaTuris,
						   servicioAdi = @servicioAdi, frentePlaya = @frentePlaya, salonEventos = @salonEventos
		where id_hotel = @id_hotel	
	End

	IF @Op = 'D' --delete
	Begin
		delete from Hotel  where id_hotel = @id_hotel	
	End

End;
go


If OBJECT_ID ('sp_Get_Hotel') is not null
	Drop procedure sp_Get_Hotel;
go

create proc sp_Get_Hotel
as
	select * from  Hotel;
go