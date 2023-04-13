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
	regAdim varchar(13) not null,
	foreign key (regAdim) REFERENCES Usuario(RFC)
);

------------------------------------------------------------------- Hotel-------------------------------------------------------------------------------------------------

create table Hotel(
	id_hotel int primary key identity,
	nombreH  varchar(255) not null,
	ubicacion varchar(255) not null,
	domicilioH varchar(255) not null,
	numPiso numeric(3,0) not null,
	canHabitacion numeric(2,0) not null,
	zonaTuris Bit DEFAULT 0,
	servicioAdi Bit DEFAULT 0,
	frentePlaya Bit DEFAULT 0,
	salonEventos Bit DEFAULT 0,
	fechaReg DATE, 
	fechaInicioOp DATE,
	regAdim varchar(13) not null,
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
	preXpersXnoc numeric(5,2) not null, --precio de persona por noche
	canXpersXhab numeric(1,0) not null, --cantidad de persona por habitacion
	nivelHab varchar(255) not null,	
	frente int not null,
	rfcCliente varchar(13) not null,
	id_hotel int not null,
	foreign key (id_hotel) REFERENCES Hotel(id_hotel),
	foreign key (rfcCliente) REFERENCES Cliente(RFC)
);
 
ALTER TABLE Habitacion
DROP COLUMN precio; 
drop table Habitacion;
------------------------------------------------------------------- Reservacion-------------------------------------------------------------------------------------------------

create table Reservacion(
	codigo varchar(9) primary key not null,
	fReser DATE,
	fInicio DATE,
	fFin DATE,
	nombreC varchar(255) not null,	
	nombreH varchar(255) not null,	
	habitacion varchar(255) not null,	
	canPers numeric(1,0) not null,
	anticipo numeric(5,2) not null,
	mPago varchar(255) not null,
	regAdim varchar(13) not null,
	rfcCliente varchar(13) not null,
	id_hotel int not null,
	foreign key (regAdim) REFERENCES Usuario(RFC),
	foreign key (rfcCliente) REFERENCES Cliente(RFC),
	foreign key (id_hotel) REFERENCES Hotel(id_hotel)

); 

ALTER TABLE Reservacion
DROP COLUMN descuento; 

drop table Reservacion;
------------------------------------------------------------------- Check in-------------------------------------------------------------------------------------------------

create table Checkin(
	id_checkin int primary key identity,
	asistio Bit DEFAULT 0,
	RFC_Cliente varchar(13),
	foreign key (RFC_Cliente) REFERENCES Cliente(RFC)

);

drop table Checkin

------------------------------------------------------------------- Check out-------------------------------------------------------------------------------------------------

create table Checkout(
	id_checkout int primary key identity,
	extendio Bit DEFAULT 0,
	id_checkin int, 
	foreign key (id_checkin) REFERENCES Checkin(id_checkin)
);

drop table Checkout
------------------------------------------------------------------- Factura-------------------------------------------------------------------------------------------------

create table Factura(
	numFactura numeric(5,0) primary key,
	id_hotel int not null,
	id_cliente varchar(13)  not null,
	cod_reser varchar(9) not null,
	servUsado varchar(255) not null, 
	precio numeric(5,2) not null,
	descuento numeric(5,2) not null,
	montoTotal numeric(5,2) not null,
	id_checkout int,
	foreign key (id_hotel) REFERENCES Hotel(id_hotel),
	foreign key (id_cliente) REFERENCES Cliente(RFC),
	foreign key (cod_reser) REFERENCES Reservacion(codigo),
	foreign key (id_checkout) REFERENCES Checkout(id_checkout)

);

drop table Factura;
