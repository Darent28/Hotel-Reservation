Create DataBase MAD_HOTEL;
USE MAD_HOTEL;

create table Usuario (
	RFC varchar(13) primary key,
	nombre varchar(255) not null,
	apellidop varchar(255) not null,
	apellidom varchar(255) not null,
	nomina numeric(5,0) not null,
	fnacimiento DATE not null,
	domicilio varchar(255) not null,
	telefono numeric(10,0) not null,
	esadmin int not null,
	correo varchar(255) not null,
	contrasena varchar(255) not null
);

drop table Usuario;

alter table usuario drop column ciudad, estado, pais;

select * from Usuario;

truncate table Usuario;

update Usuario set correo = 'operador@mail.com', contrasena = 'aei', nombre = 'Operador', apellidop = 'Primer', apellidom = 'Prueba' where RFC = 'EIRD012807MDA';

------------------------------------------------------------------- Cliente-------------------------------------------------------------------------------------------------

create table Cliente(
	RFC varchar(13) primary key,
	nombre varchar(255) not null,
	apellidoP varchar(255) not null,
	apellidoM varchar(255) not null,
	domicilio varchar(255) not null,
	correo varchar(255) not null,
	telefono numeric(10,0) not null,
	referencia varchar(255) not null,
	fNacimiento DATE,
	eCivil varchar(255) not null,
	fRegistro DATE,
	regAdim varchar(13),
	foreign key (regAdim) REFERENCES Usuario(RFC)
);

drop table Cliente
------------------------------------------------------------------- Hotel-------------------------------------------------------------------------------------------------

create table Hotel(
	id_hotel int primary key identity,
	nombreH  varchar(255) not null,
	ubicacion varchar(255) not null,
	domicilioH varchar(255) not null,
	numPiso numeric(3,0) not null,
	canHabitacion numeric(2,0) not null,
	zonaTuris int DEFAULT 0,
	servicioAdi int DEFAULT 0,
	frentePlaya int DEFAULT 0,
	salonEventos int DEFAULT 0,
	fechaReg DATE, 
	fechaInicioOp DATE,
	regAdim varchar(13),
	foreign key (regAdim) REFERENCES Usuario(RFC)
);

drop table Hotel
select * from Hotel
alter table Hotel drop column servicioAdi;

------------------------------------------------------------------- Habitación-------------------------------------------------------------------------------------------------

create table Habitacion(
	id_habitacion int primary key identity,
	numCamas numeric(1,0) not null,
	tipoCama varchar(255) not null,	
	preXpersXnoc float not null, --precio de persona por noche
	canXpersXhab numeric(1,0) not null, --cantidad de persona por habitacion
	nivelHab varchar(255) not null,	
	frente int not null,
	regAdim varchar(13),
	foreign key (regAdim) REFERENCES Usuario(RFC)
);
 
ALTER TABLE Habitacion
DROP COLUMN precio; 
drop table Habitacion;

------------------------------------------------------------------- HabitacionHotel -------------------------------------------------------------------------------------------------

create table HabitacionHotel(
	id_HH int primary key identity,
	id_habitacion int not null,
	id_hotel int not null,
	tipoHab varchar(255) not null,	
	caract varchar(255) not null,	
	amenidades varchar(255) not null,	
	foreign key (id_hotel) REFERENCES Hotel(id_hotel),
	foreign key (id_habitacion) REFERENCES Habitacion(id_habitacion)
);

drop table HabitacionHotel;
------------------------------------------------------------------- Reservacion-------------------------------------------------------------------------------------------------

create table Reservacion(
	codigo varchar(9) primary key not null,
	fReser DATE,
	fInicio DATE,
	fFin DATE,
	canPers numeric(1,0) not null,
	anticipo float not null,
	mPago varchar(255) not null,
	regAdim varchar(13) not null,
	rfcCliente varchar(13) not null,
	id_HH int not null,
	foreign key (regAdim) REFERENCES Usuario(RFC),
	foreign key (rfcCliente) REFERENCES Cliente(RFC),
	foreign key (id_HH) REFERENCES HabitacionHotel(id_HH)

); 

ALTER TABLE Reservacion
DROP COLUMN habitacion; 

drop table Reservacion;
------------------------------------------------------------------- Check in-------------------------------------------------------------------------------------------------

create table Checkin(
	id_checkin int primary key identity,
	asistio int DEFAULT 0,
	codigo varchar(9),
	foreign key (codigo) REFERENCES Reservacion(codigo)

);

drop table Checkin

------------------------------------------------------------------- Check out-------------------------------------------------------------------------------------------------

create table Checkout(
	id_checkout int primary key identity,
	extendio int DEFAULT 0,
	id_checkin int, 
	foreign key (id_checkin) REFERENCES Checkin(id_checkin)
);

drop table Checkout
------------------------------------------------------------------- Factura-------------------------------------------------------------------------------------------------

create table Factura(
	numFactura numeric(5,0) primary key,
	cod_reser varchar(9) not null,
	servUsado varchar(255) not null, 
	precio float not null,
	descuento float not null,
	montoTotal float not null,
	id_checkout int,
	foreign key (cod_reser) REFERENCES Reservacion(codigo),
	foreign key (id_checkout) REFERENCES Checkout(id_checkout)

);

drop table Factura;
