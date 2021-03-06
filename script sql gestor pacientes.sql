USE [master]
GO
/****** Object:  Database [Gestor_de_pacientes]    Script Date: 4/21/2021 9:20:35 PM ******/
CREATE DATABASE [Gestor_de_pacientes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gestor_de_pacientes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Gestor_de_pacientes.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Gestor_de_pacientes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Gestor_de_pacientes_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Gestor_de_pacientes] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestor_de_pacientes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gestor_de_pacientes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Gestor_de_pacientes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gestor_de_pacientes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gestor_de_pacientes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Gestor_de_pacientes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gestor_de_pacientes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gestor_de_pacientes] SET  MULTI_USER 
GO
ALTER DATABASE [Gestor_de_pacientes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gestor_de_pacientes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gestor_de_pacientes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gestor_de_pacientes] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Gestor_de_pacientes] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Gestor_de_pacientes]
GO
/****** Object:  Table [dbo].[citas]    Script Date: 4/21/2021 9:20:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[citas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [int] NULL,
	[idDoctor] [int] NULL,
	[fechaHoraCita] [varchar](30) NULL,
	[causaCita] [varchar](max) NULL,
	[estadoCita] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[medicos]    Script Date: 4/21/2021 9:20:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[medicos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[correo] [varchar](30) NULL,
	[telefono] [varchar](13) NULL,
	[cedula] [varchar](12) NULL,
	[linkFoto] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pacientes]    Script Date: 4/21/2021 9:20:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pacientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[telefono] [varchar](30) NULL,
	[direccion] [varchar](13) NULL,
	[cedula] [varchar](12) NULL,
	[fechaNacimiento] [varchar](12) NULL,
	[fumador] [varchar](6) NULL,
	[alergias] [varchar](max) NULL,
	[linkFoto] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pruebas_laboratorio]    Script Date: 4/21/2021 9:20:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pruebas_laboratorio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[resultados_pruebas_laboratorio]    Script Date: 4/21/2021 9:20:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[resultados_pruebas_laboratorio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [int] NULL,
	[idCita] [int] NULL,
	[idPrueba_lab] [int] NULL,
	[idDoctor] [int] NULL,
	[resultados] [varchar](max) NULL,
	[estado] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 4/21/2021 9:20:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[correo] [varchar](30) NULL,
	[usuario] [varchar](15) NULL,
	[user_password] [varchar](50) NULL,
	[tipoUsuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[citas]  WITH CHECK ADD FOREIGN KEY([idDoctor])
REFERENCES [dbo].[medicos] ([id])
GO
ALTER TABLE [dbo].[citas]  WITH CHECK ADD FOREIGN KEY([idPaciente])
REFERENCES [dbo].[pacientes] ([id])
GO
ALTER TABLE [dbo].[resultados_pruebas_laboratorio]  WITH CHECK ADD FOREIGN KEY([idCita])
REFERENCES [dbo].[citas] ([id])
GO
ALTER TABLE [dbo].[resultados_pruebas_laboratorio]  WITH CHECK ADD FOREIGN KEY([idDoctor])
REFERENCES [dbo].[medicos] ([id])
GO
ALTER TABLE [dbo].[resultados_pruebas_laboratorio]  WITH CHECK ADD FOREIGN KEY([idPaciente])
REFERENCES [dbo].[pacientes] ([id])
GO
ALTER TABLE [dbo].[resultados_pruebas_laboratorio]  WITH CHECK ADD FOREIGN KEY([idPrueba_lab])
REFERENCES [dbo].[pruebas_laboratorio] ([id])
GO
USE [master]
GO
ALTER DATABASE [Gestor_de_pacientes] SET  READ_WRITE 
GO
