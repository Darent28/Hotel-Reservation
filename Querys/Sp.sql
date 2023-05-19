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
	select regAdim as 'Admin de Registro', id_hotel as ID, nombreH as 'Nombre del hotel', ubicacion as Ubicacion,
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
@canPers					  numeric(1,0),
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
	inner join Habitacion Hab on H.id_habitacion= Hab.id_habitacion
	WHERE _status = 1;
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
@id_checkin					   int,
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

		select C.id_checkin as 'ID del Check in', 
				CASE 
				   When C.asistio = 0 Then 'No asistio' 
			       When C.asistio = 1 Then 'Si asistio'
				else 'No ha confirmado' END as Asistio, 
			   R.codigo as 'Codigo Reservacion', R.mPago as 'Metodo de pago', R.canPers as 'Cantidad de personas',
			   R.rfcCliente as 'RFC del cliente'
			   from Checkin C inner join Reservacion R on C.codigo = R.codigo

End;
go

If OBJECT_ID ('sp_Checkout') is not null
	Drop procedure sp_Checkout;
go

create proc sp_Checkout
(
@id_checkout				   int,
@extendio					   int,
@fFinC						   DATE = NULL,
@id_checkin					   int
)
as
Begin

		insert into Checkout (extendio, id_checkin, fFinC)
				    VALUES (@extendio, @id_checkin, @fFinC)

End;
go

If OBJECT_ID ('sp_Get_Checkout') is not null
	Drop procedure sp_Get_Checkout;
go

create proc sp_Get_Checkout

as
Begin

		select  
			CO.id_checkout as 'ID del Check out', 
			CI.id_checkin as 'ID del Check in',
				CASE 
				   When CI.asistio = 0 Then 'No asistio' 
			       When CI.asistio = 1 Then 'Si asistio'
				else 'No ha confirmado' END as Asistio, 
				CASE 
				   When CO.extendio = 0 Then 'No Extendio' 
			       When CO.extendio = 1 Then 'Si Extendio'
				else 'No ha Decidido' END as 'Extendio el plazo de hospedaje', 
			   R.codigo as 'Codigo Reservacion', R.mPago as 'Metodo de pago', R.canPers as 'Cantidad de personas',
			   R.rfcCliente as 'RFC del cliente', Hab.preXpersXnoc as 'Precio de persona por noche', Hab.canXpersXhab as 'Cantidad de persona por habitacion'
		from Checkout CO 
		inner join Checkin CI on CO.id_checkout = CI.id_checkin
		inner join Reservacion R on CI.codigo = R.codigo
		inner join HabitacionHotel HH on R.id_HH = HH.id_HH
		inner join Habitacion Hab on HH.id_habitacion = Hab.id_habitacion

End;
go

------------------------------------------------------------------------------------- Factura ---------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('sp_Factura') is not null
	Drop procedure sp_Factura;
go

create proc sp_Factura
(
@Op							   CHAR(1),
@numFactura					   numeric(5,0),
@servUsado					   varchar(255),
@precio						   float,
@descuento					   float,
@montoTotal					   float,
@servadd					   float,
@cod_reser					   varchar(9),
@id_checkout				   int
)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into Factura (numFactura, servUsado, precio, descuento, montoTotal, servadd, cod_reser, id_checkout)
				    VALUES (@numFactura, @servUsado, @precio, @descuento, @montoTotal, @servadd, @cod_reser, @id_checkout)
	End

	IF @Op = 'U' --update
	Begin
		Update Factura set servUsado = @servUsado, precio = @precio, descuento = @descuento,
		                   montoTotal = @montoTotal, cod_reser = @cod_reser, id_checkout = @id_checkout
		where numFactura = @numFactura	
	End

	IF @Op = 'D' --delete
	Begin
		delete from Factura  where numFactura = @numFactura		
	End

End;
go

------------------------------------------------------------------------------------ Triggers ---------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('tg_Checkin') is not null
	Drop trigger tg_Checkin;
go

CREATE TRIGGER tg_Checkin
ON Checkin 
AFTER INSERT
AS
BEGIN
	IF EXISTS (SELECT id_checkin, asistio, codigo FROM inserted WHERE asistio = 0)
	BEGIN
		UPDATE Reservacion SET _status = 0 WHERE codigo IN (SELECT codigo FROM inserted WHERE asistio = 0) 
	END
END


If OBJECT_ID ('tg_Checkout') is not null
	Drop trigger tg_Checkout;
go

CREATE TRIGGER tg_Checkout
ON Checkout 
AFTER INSERT
AS
BEGIN
Declare @fFin DATE

set @fFin = (select fFinC from inserted)

	IF EXISTS (SELECT id_checkout, extendio, id_checkin FROM inserted WHERE extendio = 1)
	BEGIN
		UPDATE Reservacion SET fFin = @fFin WHERE codigo IN (SELECT R.codigo FROM inserted I 
															   inner join Checkin CI on I.id_checkin = CI.id_checkin
															   inner join Reservacion R on CI.codigo = R.codigo WHERE extendio = 1) 
	END
END

------------------------------------------------------------------------------------- Reportes ---------------------------------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('sp_Get_Rhotel') is not null
	Drop procedure sp_Get_Rhotel;
go

create proc sp_Get_Rhotel
@pais		varchar(250),
@ciudad		varchar(250),
@hotel		varchar(250),
@fecha		Date
as
Begin
	SELECT DISTINCT
		   Hot.domicilioH as Ciudad, Hot.ubicacion as Pais, Hot.nombreH as Hotel, Hot.fechaInicioOp as 'Fecha de inicio de operiacion',
		   HH.tipoHab as 'Tipo de habitacion', Hot.canHabitacion as 'Cantidad de habitacion',
		   COUNT(R.canPers) as 'Cantidad de personas hospedadas', (COUNT(R.canPers) * 100) / Hab.canXpersXhab as 'Porcentaje de ocupación'
	FROM Reservacion R
	inner join HabitacionHotel HH ON R.id_HH = HH.id_HH
	inner join Hotel Hot ON HH.id_hotel = Hot.id_hotel
	inner join Habitacion Hab ON HH.id_habitacion = Hab.id_habitacion
	WHERE Hot.ubicacion like '%' + @pais + '%' and Hot.domicilioH like '%' + @ciudad + '%' and 
		  Hot.nombreH like '%' + @hotel + '%' and YEAR(Hot.fechaInicioOp) = YEAR(@fecha) 
	GROUP BY Hot.ubicacion, Hot.domicilioH, Hot.nombreH, Hot.fechaInicioOp, HH.tipoHab, Hot.canHabitacion, Hab.canXpersXhab
	ORDER BY Hot.nombreH ASC; 
End;
go

If OBJECT_ID ('sp_Get_Rhotelall') is not null
	Drop procedure sp_Get_Rhotelall;
go

create proc sp_Get_Rhotelall
@pais		varchar(250),
@ciudad		varchar(250),
@fecha		Date
as
Begin
	SELECT DISTINCT
		   Hot.domicilioH as Ciudad, Hot.ubicacion as Pais, Hot.nombreH as Hotel, Hot.fechaInicioOp as 'Fecha de inicio de operiacion',
		   HH.tipoHab as 'Tipo de habitacion', Hot.canHabitacion as 'Cantidad de habitacion',
		   COUNT(R.canPers) as 'Cantidad de personas hospedadas', (COUNT(R.canPers) * 100) / Hab.canXpersXhab as 'Porcentaje de ocupación'
	FROM Reservacion R
	inner join HabitacionHotel HH ON R.id_HH = HH.id_HH
	inner join Hotel Hot ON HH.id_hotel = Hot.id_hotel
	inner join Habitacion Hab ON HH.id_habitacion = Hab.id_habitacion
	WHERE Hot.ubicacion like '%' + @pais + '%' and Hot.domicilioH like '%' + @ciudad + '%' and YEAR(Hot.fechaInicioOp) = YEAR(@fecha) 
	GROUP BY Hot.ubicacion, Hot.domicilioH, Hot.nombreH, Hot.fechaInicioOp, HH.tipoHab, Hot.canHabitacion, Hab.canXpersXhab
End;
go


If OBJECT_ID ('sp_Get_Rventas') is not null
	Drop procedure sp_Get_Rventas;
go

create proc sp_Get_Rventas
@pais		varchar(250),
@ciudad		varchar(250),
@hotel		varchar(250),
@fecha		Date
as
Begin
	SELECT Hot.domicilioH as Ciudad, Hot.ubicacion as Pais, Hot.nombreH as Hotel, concat( '$',Format(SUM(F.precio), 'N2')) as 'Ingresos por hospedaje',
		   concat( '$',Format(SUM(F.servadd), 'N2'))  as 'Ingresos por servicios adicionales', concat( '$',Format(SUM(F.montoTotal), 'N2')) as 'Ingresos totales'
	FROM Factura F
	inner join Reservacion R ON F.cod_reser = R.codigo
	inner join HabitacionHotel HH ON R.id_HH = HH.id_HH
	inner join Hotel Hot ON HH.id_hotel = Hot.id_hotel
	inner join Habitacion Hab ON HH.id_habitacion = Hab.id_habitacion
	WHERE Hot.ubicacion like '%' + @pais + '%' and Hot.domicilioH like '%' + @ciudad + '%' and 
		  Hot.nombreH like '%' + @hotel + '%' and YEAR(Hot.fechaInicioOp) = YEAR(@fecha)
    GROUP BY Hot.domicilioH, Hot.ubicacion, Hot.nombreH;
End;
go

If OBJECT_ID ('sp_Get_Rventasall') is not null
	Drop procedure sp_Get_Rventasall;
go

create proc sp_Get_Rventasall
@pais		varchar(250),
@ciudad		varchar(250),
@fecha		Date
as
Begin
	SELECT Hot.domicilioH as Ciudad, Hot.ubicacion as Pais, Hot.nombreH as Hotel, concat( '$',Format(SUM(F.precio), 'N2')) as 'Ingresos por hospedaje',
		   concat( '$',Format(SUM(F.servadd), 'N2'))  as 'Ingresos por servicios adicionales', concat( '$',Format(SUM(F.montoTotal), 'N2')) as 'Ingresos totales'
	FROM Factura F
	inner join Reservacion R ON F.cod_reser = R.codigo
	inner join HabitacionHotel HH ON R.id_HH = HH.id_HH
	inner join Hotel Hot ON HH.id_hotel = Hot.id_hotel
	inner join Habitacion Hab ON HH.id_habitacion = Hab.id_habitacion
	WHERE Hot.ubicacion like '%' + @pais + '%' and Hot.domicilioH like '%' + @ciudad + '%'
	and YEAR(Hot.fechaInicioOp) = YEAR(@fecha)
    GROUP BY Hot.domicilioH, Hot.ubicacion, Hot.nombreH;
End;
go

If OBJECT_ID ('sp_Get_Rcliente') is not null
	Drop procedure sp_Get_Rcliente;
go

create proc sp_Get_Rcliente
@cliente	varchar(250),
@fecha		Date
as
Begin
	SELECT C.RFC as RFC, Concat(C.nombre, ' ', C.apellidoP, ' ', C.apellidoM) as 'Nombre del cliente',  Hot.domicilioH as Ciudad,  Hot.nombreH as Hotel,
		   HH.tipoHab as 'Tipo de habitacion', Hab.id_habitacion as 'Nmero de habitación', R.canPers as 'Numero de personas hospedadas',
		   R.codigo as 'Código de reservación', R.fReser as 'Fecha dereservación', CIN.fCIN as 'Fecha de Check in', COUT.fCOUT as 'Fecha de Check out',
		   CASE
		   WHEN R._status = 0 THEN 'No asistio'
		   WHEN R._status = 1 THEN 'Si asistio' 
		   ELSE 'No ha confirmado' 
	END as 'Estatus de la reservación',  R.anticipo as Anticipo, concat( '$',Format(SUM(F.precio), 'N2')) as 'Ingresos por hospedaje',
		   concat( '$',Format(SUM(F.servadd), 'N2'))  as 'Ingresos por servicios adicionales', concat( '$',Format(SUM(F.montoTotal), 'N2')) as 'Ingresos totales'
	FROM Factura F
	inner join Checkout COUT ON F.id_checkout = COUT.id_checkout
	inner join Checkin CIN ON COUT.id_checkin = CIN.id_checkin
	inner join Reservacion R ON F.cod_reser = R.codigo
	inner join Cliente C ON R.rfcCliente = C.RFC
	inner join HabitacionHotel HH ON R.id_HH = HH.id_HH
	inner join Hotel Hot ON HH.id_hotel = Hot.id_hotel
	inner join Habitacion Hab ON HH.id_habitacion = Hab.id_habitacion
	WHERE C.RFC like '%' + @cliente + '%' and YEAR(Hot.fechaInicioOp) = YEAR(@fecha) AND MONTH(Hot.fechaInicioOp) = MONTH(@fecha)
    GROUP BY  C.RFC, Concat(C.nombre, ' ', C.apellidoP, ' ', C.apellidoM), Hot.domicilioH, Hot.nombreH, HH.tipoHab, Hab.id_habitacion, R.canPers, R.codigo, R.fReser, CIN.fCIN, COUT.fCOUT, R._status, R.anticipo
    ORDER BY R.fReser;
End;
go

If OBJECT_ID ('sp_Get_Rclienteall') is not null
	Drop procedure sp_Get_Rclienteall;
go

create proc sp_Get_Rclienteall
@cliente	varchar(250)
as
Begin
	SELECT C.RFC as RFC, Concat(C.nombre, ' ', C.apellidoP, ' ', C.apellidoM) as 'Nombre del cliente',  Hot.domicilioH as Ciudad,  Hot.nombreH as Hotel,
		   HH.tipoHab as 'Tipo de habitacion', Hab.id_habitacion as 'Nmero de habitación', R.canPers as 'Numero de personas hospedadas',
		   R.codigo as 'Código de reservación', R.fReser as 'Fecha dereservación', CIN.fCIN as 'Fecha de Check in', COUT.fCOUT as 'Fecha de Check out',
		   CASE
		   WHEN R._status = 0 THEN 'No asistio'
		   WHEN R._status = 1 THEN 'Si asistio' 
		   ELSE 'No ha confirmado' 
	END as 'Estatus de la reservación',  R.anticipo as Anticipo, concat( '$',Format(SUM(F.precio), 'N2')) as 'Ingresos por hospedaje',
		   concat( '$',Format(SUM(F.servadd), 'N2'))  as 'Ingresos por servicios adicionales', concat( '$',Format(SUM(F.montoTotal), 'N2')) as 'Ingresos totales'
	FROM Factura F
	inner join Checkout COUT ON F.id_checkout = COUT.id_checkout
	inner join Checkin CIN ON COUT.id_checkin = CIN.id_checkin
	inner join Reservacion R ON F.cod_reser = R.codigo
	inner join Cliente C ON R.rfcCliente = C.RFC
	inner join HabitacionHotel HH ON R.id_HH = HH.id_HH
	inner join Hotel Hot ON HH.id_hotel = Hot.id_hotel
	inner join Habitacion Hab ON HH.id_habitacion = Hab.id_habitacion
	WHERE C.RFC like '%' + @cliente + '%'
    GROUP BY  C.RFC, Concat(C.nombre, ' ', C.apellidoP, ' ', C.apellidoM), Hot.domicilioH, Hot.nombreH, HH.tipoHab, Hab.id_habitacion, R.canPers, R.codigo, R.fReser, CIN.fCIN, COUT.fCOUT, R._status, R.anticipo
    ORDER BY R.fReser;
End;
go