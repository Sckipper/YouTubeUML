USE MASTER
DROP DATABASE [YouTubeUML]
CREATE DATABASE [YouTubeUML]
USE [YouTubeUML]
GO
/****** Object:  User [IIS APPPOOL\DefaultAppPool]    Script Date: 15-Jan-19 11:30:56 PM ******/
CREATE USER [IIS APPPOOL\DefaultAppPool] FOR LOGIN [IIS APPPOOL\DefaultAppPool] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Sckipper]    Script Date: 15-Jan-19 11:30:56 PM ******/
CREATE USER [Sckipper] FOR LOGIN [Sckipper] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_datareader] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_owner] ADD MEMBER [Sckipper]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Sckipper]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Sckipper]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Sckipper]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Sckipper]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Sckipper]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Sckipper]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [Sckipper]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [Sckipper]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 15-Jan-19 11:30:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Users]    Script Date: 15-Jan-19 11:30:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Type] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Logs](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Type] [int] NOT NULL,
	[Action] [nvarchar](512) NULL,
	[UserId] [int] NOT NULL FOREIGN KEY REFERENCES Users(Id)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Videos]    Script Date: 15-Jan-19 11:30:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videos](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[URL] [nvarchar](512) NOT NULL,
	[Likes] [int] NULL,
	[Dislikes] [int] NULL,
	[Views] [int] NULL,
	[UploaderId] [int] NOT NULL FOREIGN KEY REFERENCES Users(Id)
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Videos]    Script Date: 15-Jan-19 11:30:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VideoId] [int] NOT NULL FOREIGN KEY REFERENCES Videos(Id),
	[Message] [nvarchar](512) NOT NULL,
	[UserId] [int] NULL FOREIGN KEY REFERENCES Users(Id)
) ON [PRIMARY]
GO

