USE [master]
GO
/****** Object:  Database [BD_Medical]    Script Date: 12/06/2019 10:38:18 ******/
CREATE DATABASE [BD_Medical]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_Medical', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BD_Medical.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_Medical_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BD_Medical_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BD_Medical] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_Medical].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_Medical] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_Medical] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_Medical] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_Medical] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_Medical] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_Medical] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_Medical] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_Medical] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_Medical] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_Medical] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_Medical] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_Medical] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_Medical] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_Medical] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_Medical] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_Medical] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_Medical] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_Medical] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_Medical] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_Medical] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_Medical] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_Medical] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_Medical] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_Medical] SET  MULTI_USER 
GO
ALTER DATABASE [BD_Medical] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_Medical] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_Medical] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_Medical] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_Medical] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_Medical] SET QUERY_STORE = OFF
GO
USE [BD_Medical]
GO
/****** Object:  Table [dbo].[t_atencion_medica]    Script Date: 12/06/2019 10:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_atencion_medica](
	[cod_aten_medica] [int] NOT NULL,
	[num_solicitud] [int] NOT NULL,
	[num_dni_medico] [int] NOT NULL,
	[des_observacion] [nvarchar](50) NOT NULL,
	[fec_registro] [nvarchar](50) NOT NULL,
	[des_hora_inicio] [nvarchar](50) NOT NULL,
	[des_hora_fin] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_t_atencion_medica] PRIMARY KEY CLUSTERED 
(
	[cod_aten_medica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_cliente]    Script Date: 12/06/2019 10:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_cliente](
	[cod_cliente] [int] NOT NULL,
	[des_nombres] [nvarchar](50) NOT NULL,
	[des_ape_paterno] [nvarchar](50) NOT NULL,
	[des_ape_materno] [nvarchar](50) NOT NULL,
	[fec_nacimiento] [nvarchar](50) NOT NULL,
	[des_direccion] [nvarchar](50) NOT NULL,
	[des_distrito] [nvarchar](50) NOT NULL,
	[num_telefono] [int] NOT NULL,
	[des_email] [nvarchar](50) NOT NULL,
	[ind_estado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_t_cliente] PRIMARY KEY CLUSTERED 
(
	[cod_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_medico]    Script Date: 12/06/2019 10:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_medico](
	[nu_dni] [int] NOT NULL,
	[tx_nombre] [nvarchar](50) NOT NULL,
	[tx_apellidopaterno] [nvarchar](50) NOT NULL,
	[tx_apellidomaterno] [nvarchar](50) NOT NULL,
	[tx_sexo] [nchar](10) NOT NULL,
	[fe_nacimiento] [date] NOT NULL,
	[tx_especialidad] [nvarchar](50) NOT NULL,
	[tx_correo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_t_medico] PRIMARY KEY CLUSTERED 
(
	[nu_dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_solicitud]    Script Date: 12/06/2019 10:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_solicitud](
	[num_solicitud] [int] NOT NULL,
	[cod_cliente] [int] NOT NULL,
	[des_direccion] [nvarchar](50) NOT NULL,
	[des_distrito] [nvarchar](50) NOT NULL,
	[fec_registro] [nvarchar](50) NOT NULL,
	[nu_dni_medico] [int] NOT NULL,
	[des_observacion] [nvarchar](50) NOT NULL,
	[ind_estado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_t_solicitud] PRIMARY KEY CLUSTERED 
(
	[num_solicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[t_medico] ([nu_dni], [tx_nombre], [tx_apellidopaterno], [tx_apellidomaterno], [tx_sexo], [fe_nacimiento], [tx_especialidad], [tx_correo]) VALUES (47034422, N'Edgar Martins', N'Torres', N'Salazar', N'M         ', CAST(N'1992-01-10' AS Date), N'Pediatra', N'etorres@medical.com')
INSERT [dbo].[t_medico] ([nu_dni], [tx_nombre], [tx_apellidopaterno], [tx_apellidomaterno], [tx_sexo], [fe_nacimiento], [tx_especialidad], [tx_correo]) VALUES (67684941, N'Juan', N'Caceres', N'Rocha', N'M         ', CAST(N'1996-05-10' AS Date), N'Pediatra', N'jrocha@medical.com')
INSERT [dbo].[t_medico] ([nu_dni], [tx_nombre], [tx_apellidopaterno], [tx_apellidomaterno], [tx_sexo], [fe_nacimiento], [tx_especialidad], [tx_correo]) VALUES (67848843, N'Martha', N'Gomez', N'Flores', N'F         ', CAST(N'1994-04-29' AS Date), N'Psicologo', N'mgomez@medical.com')
INSERT [dbo].[t_medico] ([nu_dni], [tx_nombre], [tx_apellidopaterno], [tx_apellidomaterno], [tx_sexo], [fe_nacimiento], [tx_especialidad], [tx_correo]) VALUES (83929272, N'Valeria', N'Rosales', N'Guido', N'F         ', CAST(N'1986-01-16' AS Date), N'Psicologa', N'vrosales@medical.com')
USE [master]
GO
ALTER DATABASE [BD_Medical] SET  READ_WRITE 
GO
