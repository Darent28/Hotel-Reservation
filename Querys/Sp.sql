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
@fechaReg					   DATE = NULL, 
@fechaInicioOp				   DATE = NULL,
@regAdim					   varchar(13) = NULL
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
						 canHabitacion = @canHabitacion, zonaTuris = @zonaTuris, servicioAdi = @servicioAdi, 
						 frentePlaya = @frentePlaya, salonEventos = @salonEventos
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
	select regAdim as 'Admin de Registro', id_hotel as ID, nombreH as 'Nombre del hotel', ubicacion as Ubicación,
	domicilioH as Domicilio, numPiso as 'Numero de piso', canHabitacion as 'Cantidad de habitación', fechaInicioOp as 'Inicio de operaciones', fechaReg as Registro  
	from  Hotel;
go

--------------------------------------------------------------------------Habitación--------------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('sp_Habitacion') is not null
	Drop procedure sp_Habitacion;
go

create proc sp_Habitacion
(
@Op							   CHAR(1),
@id_habitacion				   int,
@numCamas					   numeric(1,0),
@tipoCama					   varchar(255),
@preXpersXnoc				   float,
@canXpersXhab				   numeric(1,0),
@nivelHab					   varchar(255),
@frente						   int,
@regAdim					   varchar(13)
)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into Habitacion (numCamas, tipoCama, preXpersXnoc, canXpersXhab, nivelHab, frente, regAdim)
				       	Values (@numCamas, @tipoCama, @preXpersXnoc, @canXpersXhab, @nivelHab, @frente, @regAdim)
	End

	IF @Op = 'U' --update
	Begin
		Update Habitacion set numCamas = @numCamas, tipoCama = @tipoCama, preXpersXnoc = @preXpersXnoc, canXpersXhab = @canXpersXhab,
						 nivelHab = @nivelHab, frente = @frente
		where id_habitacion = @id_habitacion	
	End

	IF @Op = 'D' --delete
	Begin
		delete from Habitacion  where id_habitacion = @id_habitacion	
	End

End;
go

If OBJECT_ID ('sp_Get_Habitacion') is not null
	Drop procedure sp_Get_Habitacion;
go

create proc sp_Get_Habitacion
as
	select regAdim as 'Admin que lo registra', id_habitacion as ID, numCamas as 'Numero de camas',
		   tipoCama as 'Tipo de cama', Format(preXpersXnoc, 'N2') as 'Precio por persona', canXpersXhab as 'Cantidad de personas', 
		   nivelHab as 'Nivel de Habitacion', frente as Frente
	from  Habitacion;
go

--------------------------------------------------------------------------Cliente--------------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('sp_Cliente') is not null
	Drop procedure sp_Cliente;
go

create proc sp_Cliente
(
@Op							   CHAR(1),
@RFC						   varchar(250),
@nombre			               varchar(250),
@apellidoP					   varchar(250),
@apellidoM                     varchar(250),
@domicilio					   varchar(255),
@correo						   varchar(255),
@telefono					   numeric(10,0),
@referencia					   varchar(255),
@fNacimiento				   DATE,
@eCivil						   varchar(255),
@fRegistro					   DATE,
@regAdim					   varchar(13)
)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into Cliente (RFC, nombre, apellidoP, apellidoM, domicilio, correo, telefono, referencia, fNacimiento, eCivil, fRegistro, regAdim)
				    Values (@RFC, @nombre, @apellidoP, @apellidoM, @domicilio, @correo, @telefono, @referencia, @fNacimiento, @eCivil, @fRegistro, @regAdim)
	End

	IF @Op = 'U' --update
	Begin
		Update Cliente set nombre = @nombre, apellidoP = @apellidoP, apellidoM = @apellidoM,
						 domicilio = @domicilio, correo = @correo, telefono = @telefono, referencia = @referencia, 
						 fNacimiento = @fNacimiento, eCivil = @eCivil, fRegistro = @fRegistro
		where RFC = @RFC	
	End

	IF @Op = 'D' --delete
	Begin
		delete from Cliente  where RFC = @RFC	
	End

End;
go

If OBJECT_ID ('sp_Get_Cliente') is not null
	Drop procedure sp_Get_Cliente;
go

create proc sp_Get_Cliente
as
	select * from Cliente;
go
