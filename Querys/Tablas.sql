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
	ciudad varchar(255) not null,
	estado varchar(255) not null,
	pais varchar(255) not null,
	telefono numeric(10,0) not null,
	esadmin int not null,
	correo varchar(255) not null,
	contrasena varchar(255) not null
);

drop table Usuario;

select * from Usuario;

truncate table Usuario;

