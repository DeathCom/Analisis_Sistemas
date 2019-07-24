use master;  
go           

IF NOT EXISTS(SELECT * FROM sysdatabases WHERE name = 'DB_Tiquetes')
	BEGIN
		create database DB_Tiquetes
		ON(
			NAME = 'DBTiquetes',
			FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DB_Tiquetes.mdf',
			SIZE = 1MB,
			MAXSIZE = 10MB,
			FILEGROWTH = 5
		)
		LOG ON(
			NAME = 'DB_Tiquetes_log',
			FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\Log\DB_Tiquetes_log.ldf',
			SIZE = 1MB,
			MAXSIZE = 10MB,
			FILEGROWTH = 5
		)
	END
ELSE
	BEGIN
		print 'Base de datos EntidadFinanciera ya existe'
	END
go

use DB_Tiquetes 
go

IF NOT EXISTS(select * from sysobjects where type = 'U' and name = 'T_Aplicacion')
	BEGIN
		CREATE table T_Aplicacion					  
		(				     
			 Id_Aplicacion      	int primary key,
             Nombre_Aplicacion 		nvarchar(50) not null,
			 Descripcion_Aplicacion	nvarchar(50) not null
		)
	END
ELSE
	BEGIN
		print 'Tabla T_Aplicacion ya existe'
	END
go

IF NOT EXISTS(select * from sysobjects where type = 'U' and name = 'T_Cliente')
	BEGIN
		CREATE table T_Cliente				  
		(				     
			 Id_Cliente     	int primary key,
             Nombre_Cliente 	nvarchar(50) not null,
			 Telefono_Cliente   nvarchar(50) not null,
             Correo_Cliente 	nvarchar(50) not null,
             Region_Cliente 	nvarchar(50) not null,
             Pais_Cliente       nvarchar(50) not null,
             Focal_Cliente      nvarchar(50) not null,
             Tipo_Servidor		nvarchar(50) not null,
             Nombre_Servidor	nvarchar(50) not null,
             Ip_Servidor		nvarchar(50) not null,
             Estado_Servidor	nvarchar(50) not null
		)
	END
ELSE
	BEGIN
		print 'Tabla T_Cliente ya existe'
	END
go

IF NOT EXISTS(select * from sysobjects where type = 'U' and name = 'T_Estado_Tiquetes')
	BEGIN
		create table T_Estado_Tiquetes
		(
			Id_Estado_Tiquete 			int primary key,
			Descripcion_Estado_Tiquete  nvarchar(100) not null
		)
	END
ELSE
	BEGIN
		print 'Tabla T_Estado_Tiquetes ya existe'
	END
go

IF NOT EXISTS(select * from sysobjects where type = 'U' and name = 'T_Severidades')
	BEGIN
		create table T_Severidades
		(
			Severidad			int primary key,
			Descripcion_Severidad 	nvarchar(20) not null
		)
	END
ELSE
	BEGIN
		print 'Tabla T_Severidades ya existe'
	END
go

IF NOT EXISTS(select * from sysobjects where type = 'U' and name = 'T_Usuarios')
	BEGIN
		CREATE table T_Usuarios					  
		(				     
			 Id_Usuario 		int primary key,
			 Usuario 			nvarchar(50) not null,
             Nombre_Usuario 	nvarchar(50) not null,
             Contrasena_Usuario	nvarchar(50) not null,
             Estado_Usuario		nvarchar(50) not null,
             Tipo_Usuario		nvarchar(50) not null
		)
	END
ELSE
	BEGIN
		print 'Tabla T_Usuarios ya existe'
	END
go

IF NOT EXISTS(select * from sysobjects where type = 'U' and name = 'T_Tiquete')
	BEGIN
		create table T_Tiquete
		(
			Id_Tiquete 			int primary key,
			Id_Supervisor		int not null,
		    Nombre_Usuario 		nvarchar(50) not null,
		    Nombre_Cliente 		nvarchar(50) not null,
		    Nombre_Aplicacion 	nvarchar(50) not null,
		    Numero_Tiquete		nvarchar(200) not null,
		    Severidad_Tiquete 	int not null,
		    Estado_Tiquete 		nvarchar(50) not null,
		    Comentarios_Tiquete	nvarchar(100) not null,
		    HorayFecha_Apertura datetime,
		    HorayFecha_Cierre datetime
		)
	END
ELSE
	BEGIN
		print 'Tabla T_Tiquete ya existe'
	END
go

--Crear Procedimiento almacenado para el Login
use DB_Tiquetes 
go
Create proc LOGIN
@IDUSER nvarchar(50),
@PASSW nvarchar(50)
AS
SELECT Usuario, Nombre_Usuario, Contrasena_Usuario, Estado_Usuario, Tipo_Usuario
FROM T_Usuarios WHERE Usuario=@IDUSER AND Contrasena_Usuario=@PASSW 
GO