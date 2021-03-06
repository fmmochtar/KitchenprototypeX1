USE [master]
GO
/****** Object:  Database [kitchenprotox1]    Script Date: 22/04/2019 12:17:18 ******/
CREATE DATABASE [kitchenprotox1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kitchenprotox1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\kitchenprotox1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'kitchenprotox1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\kitchenprotox1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [kitchenprotox1] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kitchenprotox1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kitchenprotox1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kitchenprotox1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kitchenprotox1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kitchenprotox1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kitchenprotox1] SET ARITHABORT OFF 
GO
ALTER DATABASE [kitchenprotox1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [kitchenprotox1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kitchenprotox1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kitchenprotox1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kitchenprotox1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kitchenprotox1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kitchenprotox1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kitchenprotox1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kitchenprotox1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kitchenprotox1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [kitchenprotox1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kitchenprotox1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kitchenprotox1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kitchenprotox1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kitchenprotox1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kitchenprotox1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kitchenprotox1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kitchenprotox1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [kitchenprotox1] SET  MULTI_USER 
GO
ALTER DATABASE [kitchenprotox1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kitchenprotox1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kitchenprotox1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kitchenprotox1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [kitchenprotox1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [kitchenprotox1] SET QUERY_STORE = OFF
GO
USE [kitchenprotox1]
GO
/****** Object:  Schema [incseq]    Script Date: 22/04/2019 12:17:18 ******/
CREATE SCHEMA [incseq]
GO
USE [kitchenprotox1]
GO
/****** Object:  Sequence [dbo].[orderid_seq]    Script Date: 22/04/2019 12:17:18 ******/
CREATE SEQUENCE [dbo].[orderid_seq] 
 AS [bigint]
 START WITH 110001
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [kitchenprotox1]
GO
/****** Object:  Sequence [incseq].[sequence_1]    Script Date: 22/04/2019 12:17:18 ******/
CREATE SEQUENCE [incseq].[sequence_1] 
 AS [bigint]
 START WITH 19001
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[admins]    Script Date: 22/04/2019 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admins](
	[id_admin] [int] NOT NULL,
	[username] [varchar](64) NOT NULL,
	[pass] [varchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_admin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 22/04/2019 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id_customer] [varchar](16) NOT NULL,
	[name_customer] [varchar](64) NOT NULL,
	[seat_customer] [varchar](16) NULL,
	[id_admin] [int] NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id_customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menus]    Script Date: 22/04/2019 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menus](
	[id_menu] [varchar](32) NOT NULL,
	[name_menu] [varchar](64) NOT NULL,
	[type_menu] [varchar](32) NOT NULL,
 CONSTRAINT [PK_menus] PRIMARY KEY CLUSTERED 
(
	[id_menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 22/04/2019 12:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[id_orders] [int] NOT NULL,
	[id_customer] [varchar](64) NOT NULL,
	[id_menu] [varchar](64) NOT NULL,
	[type_order] [varchar](32) NOT NULL,
	[quantity_order] [int] NOT NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[id_orders] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [kitchenprotox1] SET  READ_WRITE 
GO
