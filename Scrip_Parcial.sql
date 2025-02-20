USE [master]
GO
/****** Object:  Database [AlquilerEquiposDb]    Script Date: 12/01/2025 12:25:56 ******/
CREATE DATABASE [AlquilerEquiposDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AlquilerEquiposDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AlquilerEquiposDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AlquilerEquiposDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AlquilerEquiposDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AlquilerEquiposDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AlquilerEquiposDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AlquilerEquiposDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AlquilerEquiposDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AlquilerEquiposDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AlquilerEquiposDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AlquilerEquiposDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET RECOVERY FULL 
GO
ALTER DATABASE [AlquilerEquiposDb] SET  MULTI_USER 
GO
ALTER DATABASE [AlquilerEquiposDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AlquilerEquiposDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AlquilerEquiposDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AlquilerEquiposDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AlquilerEquiposDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AlquilerEquiposDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AlquilerEquiposDb', N'ON'
GO
ALTER DATABASE [AlquilerEquiposDb] SET QUERY_STORE = OFF
GO
USE [AlquilerEquiposDb]
GO
/****** Object:  Table [dbo].[Alquileres]    Script Date: 12/01/2025 12:25:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alquileres](
	[ID] [int] NULL,
	[ClienteID] [int] NULL,
	[EquipoID] [int] NULL,
	[FechaAlquiler] [datetime] NULL,
	[FechaDevolucion] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 12/01/2025 12:25:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID] [int] NULL,
	[Nombre] [nchar](100) NULL,
	[Telefono] [nchar](15) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 12/01/2025 12:25:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[ID] [int] NULL,
	[Nombre] [nvarchar](100) NULL,
	[Disponible] [bit] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [AlquilerEquiposDb] SET  READ_WRITE 
GO
