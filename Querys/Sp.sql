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
		   tipoCama as 'Tipo de cama', concat( '$',Format(preXpersXnoc, 'N2')) as 'Precio por persona', canXpersXhab as 'Cantidad de personas', 
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
	select regAdim as 'Admin que lo registro', RFC, nombre as 'Nombre del cliente', apellidoP as 'Apellido paterno',
	apellidoM as 'Apellido materno', domicilio as Domicilio, correo as Correo, telefono as Telefono,
	referencia as Referencia, fNacimiento as 'Fecha de nacimiento', eCivil as 'Estado civil', fRegistro as 'fecha de registro' 
	from Cliente;
go


-------------------------------------------------------------------- HabitacionHotel ------------------------------------------------------------------------------------------------------------


If OBJECT_ID ('sp_HabitacionHotel') is not null
	Drop procedure sp_HabitacionHotel;
go

create proc sp_HabitacionHotel
(
@Op							   CHAR(1),
@id_HH						   int,
@id_habitacion				   int,
@id_hotel					   int,
@tipoHab				       varchar(255),
@caract						   varchar(255),
@amenidades					   varchar(255)
)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into HabitacionHotel (id_habitacion, id_hotel, tipoHab, caract, amenidades)
				    VALUES (@id_habitacion, @id_hotel, @tipoHab, @caract, @amenidades)
	End

	IF @Op = 'U' --update
	Begin
		Update HabitacionHotel set id_habitacion = @id_habitacion, id_hotel = @id_hotel, tipoHab = @tipoHab,
						 caract = @caract, amenidades = @amenidades
		where id_HH = @id_HH	
	End

	IF @Op = 'D' --delete
	Begin
		delete from HabitacionHotel  where id_HH = @id_HH	
	End

End;
go

If OBJECT_ID ('sp_Get_HabitacionHotel') is not null
	Drop procedure sp_Get_HabitacionHotel;
go


create proc sp_Get_HabitacionHotel
as
	select id_HH as ID, id_habitacion as Habitacion, id_hotel as Hotel,
		tipoHab as 'Tipo de habitacion', caract as Caracteristicas, amenidades as Amenidades
	from HabitacionHotel;
go

-------------------------------------------------------------------- Reservacion ---------------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('sp_Reservacion') is not null
	Drop procedure sp_Reservacion;
go

create proc sp_Reservacion
(
@Op							   CHAR(1),
@codigo						   varchar(9),
@fReser						   DATE,
@fInicio					   DATE,
@fFin						   DATE,
@canPers					   varchar(255),
@anticipo					   float,
@mPago						   varchar(255),
@regAdim					   varchar(13),
@rfcCliente 				   varchar(13),
@id_HH						   int
)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into Reservacion (codigo, fReser, fInicio, fFin, canPers, anticipo, mPago, regAdim, rfcCliente, id_HH)
				    VALUES (@codigo, @fReser, @fInicio, @fFin, @canPers, @anticipo, @mPago, @regAdim, @rfcCliente, @id_HH)
	End

	IF @Op = 'U' --update
	Begin
		Update Reservacion set fReser = @fReser, fInicio = @fInicio,
						 fFin = @fFin, canPers = @canPers, anticipo = @anticipo, mPago = @mPago,
						 regAdim = @regAdim, rfcCliente = @rfcCliente, id_HH = @id_HH
		where codigo = @codigo	
	End

	IF @Op = 'D' --delete
	Begin
		delete from Reservacion  where codigo = @codigo	
	End

End;
go

If OBJECT_ID ('sp_Get_Reservacion') is not null
	Drop procedure sp_Get_Reservacion;
go


create proc sp_Get_Reservacion
as
	select R.codigo as Codigo, concat(C.nombre, ' ', C.apellidoP, ' ', C.apellidoM) as 'Nombre del Cliente', C.correo as Correo, 
	R.fInicio as 'Fecha de inicio', R.fFin as 'Fecha de Fin', R.canPers as 'Cantidad de personas', 
	concat( '$',Format(R.anticipo, 'N2')) as 'Anticipo', R.mPago as 'Metodo de pago', H.tipoHab as 'Tipo de habitacion',
	Hot.nombreH as 'Nombre del hotel', Hot.domicilioH as 'Domicilio del hotel',  Hab.nivelHab as 'Nivel de Habitacion',
	Hab.numCamas as 'Numero de camas', concat( '$',Format(Hab.preXpersXnoc, 'N2')) as 'Precio de persona por noche'
	from Reservacion R 
	inner join Cliente C on R.rfcCliente = C.RFC
	inner join HabitacionHotel H on R.id_HH = H.id_HH
	inner join Hotel Hot on H.id_hotel = Hot.id_hotel
	inner join Habitacion Hab on H.id_habitacion= Hab.id_habitacion;
go

If OBJECT_ID ('sp_Get_ClienteR') is not null
	Drop procedure sp_Get_ClienteR;
go

create proc sp_Get_ClienteR
(
	@parametro			varchar(250)
)
as
	select 
	RFC, Concat(nombre, ' ', apellidoP, ' ', apellidoM) as 'Nombre completo', domicilio as Domicilio,
	correo as Correo, telefono as Telefono, referencia as Referencia, eCivil as 'Estado civil'
	from Cliente where RFC like '%' + @parametro + '%';
go

If OBJECT_ID ('sp_Get_CiudadR') is not null
	Drop procedure sp_Get_CiudadR;
go

create proc sp_Get_CiudadR
(
	@parametro			varchar(250)
)
as
	select 
    HH.id_HH as ID, H.ubicacion as Ubicación, H.domicilioH as Domicilio, Hab.nivelHab as 'Nivel de Habitacion', Hab.tipoCama as 'Tipo de cama',
	Hab.numCamas as 'Numero de camas', concat( '$',Format(Hab.preXpersXnoc, 'N2')) as 'Precio de persona por noche', H.nombreH as 'Nombre del hotel', 
	H.numPiso as 'Numero de piso', H.canHabitacion as 'Cantidad de habitación', HH.caract as Caracteristicas, HH.amenidades as Amenidades
	from HabitacionHotel HH 
	inner join Hotel H on HH.id_hotel = H.id_hotel 
	inner join Habitacion Hab on HH.id_habitacion = Hab.id_habitacion
	where ubicacion like '%' + @parametro + '%';
go


If OBJECT_ID ('sp_Checkin') is not null
	Drop procedure sp_Checkin;
go

create proc sp_Checkin
(
@asistio					   int,
@codigo						   varchar(9)
)
as
Begin

		insert into Checkin (asistio, codigo)
				    VALUES (@asistio, @codigo)

End;
go

If OBJECT_ID ('sp_Get_Checkin') is not null
	Drop procedure sp_Get_Checkin;
go

create proc sp_Get_Checkin

as
Begin

		select C.id_checkin, C.asistio, R.codigo, R.mPago, R.canPers, R.rfcCliente
			   from Checkin C inner join Reservacion R on C.codigo = R.codigo

End;
go

If OBJECT_ID ('sp_Checkout') is not null
	Drop procedure sp_Checkout;
go

create proc sp_Checkout
(
@extendio					   int,
@id_checkin					   int
)
as
Begin

		insert into Checkout (extendio, id_checkin)
				    VALUES (@extendio, @id_checkin)

End;
go