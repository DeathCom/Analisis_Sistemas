USE [master]
GO
/****** Object:  Database [DB_Tiquetes]    Script Date: 7/30/2019 4:41:09 PM ******/
CREATE DATABASE [DB_Tiquetes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBTiquetes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DB_Tiquetes.mdf' , SIZE = 8192KB , MAXSIZE = 10240KB , FILEGROWTH = 5120KB )
 LOG ON 
( NAME = N'DB_Tiquetes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\Log\DB_Tiquetes_log.ldf' , SIZE = 1024KB , MAXSIZE = 10240KB , FILEGROWTH = 5120KB )
GO
ALTER DATABASE [DB_Tiquetes] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Tiquetes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Tiquetes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_Tiquetes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Tiquetes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Tiquetes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_Tiquetes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Tiquetes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_Tiquetes] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Tiquetes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Tiquetes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Tiquetes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Tiquetes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_Tiquetes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_Tiquetes] SET QUERY_STORE = OFF
GO
USE [DB_Tiquetes]
GO
/****** Object:  Table [dbo].[T_Aplicacion]    Script Date: 7/30/2019 4:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Aplicacion](
	[Id_Aplicacion] [int] NOT NULL,
	[Nombre_Aplicacion] [nvarchar](50) NOT NULL,
	[Descripcion_Aplicacion] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Aplicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Cliente]    Script Date: 7/30/2019 4:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Cliente](
	[Id_Cliente] [int] NOT NULL,
	[Nombre_Cliente] [nvarchar](50) NOT NULL,
	[Telefono_Cliente] [nvarchar](50) NOT NULL,
	[Correo_Cliente] [nvarchar](50) NOT NULL,
	[Region_Cliente] [nvarchar](50) NOT NULL,
	[Pais_Cliente] [nvarchar](50) NOT NULL,
	[Focal_Cliente] [nvarchar](50) NOT NULL,
	[Tipo_Servidor] [nvarchar](50) NOT NULL,
	[Nombre_Servidor] [nvarchar](50) NOT NULL,
	[Ip_Servidor] [nvarchar](50) NOT NULL,
	[Estado_Servidor] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Estado_Tiquetes]    Script Date: 7/30/2019 4:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Estado_Tiquetes](
	[Id_Estado_Tiquete] [int] NOT NULL,
	[Descripcion_Estado_Tiquete] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Estado_Tiquete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Severidades]    Script Date: 7/30/2019 4:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Severidades](
	[Severidad] [int] NOT NULL,
	[Descripcion_Severidad] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Severidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Tiquete]    Script Date: 7/30/2019 4:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Tiquete](
	[Numero_Tiquete] [nvarchar](150) NOT NULL,
	[Nombre_Supervisor] [nvarchar](50) NOT NULL,
	[Nombre_Usuario] [nvarchar](50) NOT NULL,
	[Nombre_Cliente] [nvarchar](50) NOT NULL,
	[Nombre_Aplicacion] [nvarchar](50) NOT NULL,
	[Severidad_Tiquete] [nvarchar](50) NOT NULL,
	[Estado_Tiquete] [nvarchar](50) NOT NULL,
	[Comentarios_Tiquete] [nvarchar](100) NOT NULL,
	[HorayFecha_Apertura] [datetime] NULL,
	[HorayFecha_Cierre] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Numero_Tiquete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Usuarios]    Script Date: 7/30/2019 4:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Usuarios](
	[Id_Usuario] [int] NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Nombre_Usuario] [nvarchar](50) NOT NULL,
	[Contrasena_Usuario] [nvarchar](250) NOT NULL,
	[Estado_Usuario] [nvarchar](50) NOT NULL,
	[Tipo_Usuario] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[T_Aplicacion] ([Id_Aplicacion], [Nombre_Aplicacion], [Descripcion_Aplicacion]) VALUES (1, N'Test', N'Test de ingreso de aplicaciones')
INSERT [dbo].[T_Aplicacion] ([Id_Aplicacion], [Nombre_Aplicacion], [Descripcion_Aplicacion]) VALUES (2, N'test2', N'test2')
INSERT [dbo].[T_Cliente] ([Id_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Region_Cliente], [Pais_Cliente], [Focal_Cliente], [Tipo_Servidor], [Nombre_Servidor], [Ip_Servidor], [Estado_Servidor]) VALUES (1, N'test', N'test', N'test', N'LATAM', N'test', N'test', N'Production', N'test', N'1.1.1.1', N'DECOMMISSIONING')
INSERT [dbo].[T_Estado_Tiquetes] ([Id_Estado_Tiquete], [Descripcion_Estado_Tiquete]) VALUES (1, N'Open')
INSERT [dbo].[T_Estado_Tiquetes] ([Id_Estado_Tiquete], [Descripcion_Estado_Tiquete]) VALUES (2, N'Closed')
INSERT [dbo].[T_Severidades] ([Severidad], [Descripcion_Severidad]) VALUES (1, N'Alta Prioridad')
INSERT [dbo].[T_Tiquete] ([Numero_Tiquete], [Nombre_Supervisor], [Nombre_Usuario], [Nombre_Cliente], [Nombre_Aplicacion], [Severidad_Tiquete], [Estado_Tiquete], [Comentarios_Tiquete], [HorayFecha_Apertura], [HorayFecha_Cierre]) VALUES (N'IN00232540', N'Carlos', N'Allan Leitón', N'test', N'Test', N'Alta Prioridad', N'Closed', N'Tiquete cerrado por falta de tiempo', CAST(N'2019-07-25T07:50:18.000' AS DateTime), CAST(N'2019-07-25T11:34:43.330' AS DateTime))
INSERT [dbo].[T_Tiquete] ([Numero_Tiquete], [Nombre_Supervisor], [Nombre_Usuario], [Nombre_Cliente], [Nombre_Aplicacion], [Severidad_Tiquete], [Estado_Tiquete], [Comentarios_Tiquete], [HorayFecha_Apertura], [HorayFecha_Cierre]) VALUES (N'IN00232541', N'Carlos', N'Allan Leitón', N'test', N'test2', N'Alta Prioridad', N'Open', N'Urgente', CAST(N'2019-07-25T08:46:50.477' AS DateTime), CAST(N'2000-01-01T07:50:18.483' AS DateTime))
INSERT [dbo].[T_Tiquete] ([Numero_Tiquete], [Nombre_Supervisor], [Nombre_Usuario], [Nombre_Cliente], [Nombre_Aplicacion], [Severidad_Tiquete], [Estado_Tiquete], [Comentarios_Tiquete], [HorayFecha_Apertura], [HorayFecha_Cierre]) VALUES (N'IN00232542', N'Carlos', N'Byon Delgado', N'test', N'Test', N'Alta Prioridad', N'Closed', N'Urgente', CAST(N'2019-07-25T09:52:43.553' AS DateTime), CAST(N'2000-01-01T07:50:18.483' AS DateTime))
INSERT [dbo].[T_Usuarios] ([Id_Usuario], [Usuario], [Nombre_Usuario], [Contrasena_Usuario], [Estado_Usuario], [Tipo_Usuario]) VALUES (0, N'Root', N'Root', N'UgBvAG8AdAA=', N'ACTIVO', N'ADMIN')
INSERT [dbo].[T_Usuarios] ([Id_Usuario], [Usuario], [Nombre_Usuario], [Contrasena_Usuario], [Estado_Usuario], [Tipo_Usuario]) VALUES (1, N'Carlos', N'Carlos', N'QwBhAHIAbABvAHMA', N'ACTIVO', N'SUPERVISOR')
INSERT [dbo].[T_Usuarios] ([Id_Usuario], [Usuario], [Nombre_Usuario], [Contrasena_Usuario], [Estado_Usuario], [Tipo_Usuario]) VALUES (2, N'Allan', N'Allan Leitón', N'QQBsAGwAYQBuADIAMgA=', N'ACTIVO', N'USER')
INSERT [dbo].[T_Usuarios] ([Id_Usuario], [Usuario], [Nombre_Usuario], [Contrasena_Usuario], [Estado_Usuario], [Tipo_Usuario]) VALUES (3, N'Byron', N'Byon Delgado', N'QgB5AHIAbwBuADIAMgA=', N'ACTIVO', N'USER')
/****** Object:  StoredProcedure [dbo].[LOGIN]    Script Date: 7/30/2019 4:41:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LOGIN]
@IDUSER nvarchar(50),
@PASSW nvarchar(50)
AS
SELECT Usuario, Nombre_Usuario, Contrasena_Usuario, Estado_Usuario, Tipo_Usuario
FROM T_Usuarios WHERE Usuario=@IDUSER AND Contrasena_Usuario=@PASSW 
GO
USE [master]
GO
ALTER DATABASE [DB_Tiquetes] SET  READ_WRITE 
GO
