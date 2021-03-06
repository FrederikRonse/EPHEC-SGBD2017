USE [master]
GO
/****** Object:  Database [ExamSGBD2017]    Script Date: 30/08/2017 21:05:37 ******/
CREATE DATABASE [ExamSGBD2017]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExamSGBD2017', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ExamSGBD2017.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ExamSGBD2017_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ExamSGBD2017_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ExamSGBD2017] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExamSGBD2017].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ExamSGBD2017] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET ARITHABORT OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ExamSGBD2017] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ExamSGBD2017] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ExamSGBD2017] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ExamSGBD2017] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET RECOVERY FULL 
GO
ALTER DATABASE [ExamSGBD2017] SET  MULTI_USER 
GO
ALTER DATABASE [ExamSGBD2017] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ExamSGBD2017] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ExamSGBD2017] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ExamSGBD2017] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ExamSGBD2017] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ExamSGBD2017', N'ON'
GO
ALTER DATABASE [ExamSGBD2017] SET QUERY_STORE = OFF
GO
USE [ExamSGBD2017]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ExamSGBD2017]
GO
/****** Object:  User [Libadmin]    Script Date: 30/08/2017 21:05:37 ******/
CREATE USER [Libadmin] FOR LOGIN [Libadmin] WITH DEFAULT_SCHEMA=[SchAdmin]
GO
/****** Object:  User [Affiliate]    Script Date: 30/08/2017 21:05:37 ******/
CREATE USER [Affiliate] FOR LOGIN [Affiliate] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [Library Affiliate]    Script Date: 30/08/2017 21:05:37 ******/
CREATE ROLE [Library Affiliate]
GO
/****** Object:  DatabaseRole [Library Admin]    Script Date: 30/08/2017 21:05:37 ******/
CREATE ROLE [Library Admin]
GO
ALTER ROLE [Library Admin] ADD MEMBER [Libadmin]
GO
ALTER ROLE [Library Affiliate] ADD MEMBER [Affiliate]
GO
/****** Object:  Schema [SchAdmin]    Script Date: 30/08/2017 21:05:37 ******/
CREATE SCHEMA [SchAdmin]
GO
/****** Object:  Schema [SchAffiliate]    Script Date: 30/08/2017 21:05:37 ******/
CREATE SCHEMA [SchAffiliate]
GO
/****** Object:  Table [dbo].[Library]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Library](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Code] [nchar](5) NOT NULL,
 CONSTRAINT [PK_Bibliotheque] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [SchAdmin].[vLibrary]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [SchAdmin].[vLibrary]
AS
SELECT Id AS IdLibrary, Name AS NameLibrary, Code AS CodeIdLibrary
FROM     dbo.Library AS Library_1

GO
/****** Object:  Table [dbo].[Tarif]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarif](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Library_Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Year] [smallint] NOT NULL,
	[Duration] [smallint] NOT NULL,
	[Fee] [decimal](8, 2) NOT NULL,
	[DailyPenalty] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_Tarif] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [SchAffiliate].[vTarif]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [SchAffiliate].[vTarif]
AS
SELECT dbo.Tarif.*
FROM     dbo.Tarif



GO
/****** Object:  Table [dbo].[Item]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](20) NOT NULL,
	[Library_Id] [int] NOT NULL,
	[Volume_Id] [int] NOT NULL,
	[BuyDate] [date] NULL,
	[Localisation] [varchar](50) NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Volume]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Volume](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Isbn] [varchar](13) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Cover] [varchar](50) NULL,
 CONSTRAINT [PK_Volume] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [SchAdmin].[vItemDetails]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [SchAdmin].[vItemDetails]
AS
SELECT dbo.Item.*, dbo.Volume.Isbn, dbo.Volume.Title, dbo.Volume.Cover
FROM     dbo.Item INNER JOIN
                  dbo.Volume ON dbo.Item.Volume_Id = dbo.Volume.Id


GO
/****** Object:  Table [dbo].[Person]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[BirthDate] [date] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [SchAdmin].[vPerson]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [SchAdmin].[vPerson]
AS
SELECT dbo.Person.*
FROM     dbo.Person


GO
/****** Object:  Table [dbo].[Reader]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reader](
	[CardNum] [int] IDENTITY(1,1) NOT NULL,
	[Pers_Id] [int] NOT NULL,
	[MainLibrary_Id] [int] NOT NULL,
	[Validity] [date] NULL,
 CONSTRAINT [PK_Reader] PRIMARY KEY CLUSTERED 
(
	[CardNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [SchAdmin].[vReader]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [SchAdmin].[vReader]
AS
SELECT dbo.Reader.*
FROM     dbo.Reader


GO
/****** Object:  View [SchAdmin].[vTarif]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [SchAdmin].[vTarif]
AS
SELECT dbo.Tarif.*
FROM     dbo.Tarif


GO
/****** Object:  View [SchAdmin].[vAffiliate]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [SchAdmin].[vAffiliate]
AS
SELECT dbo.Reader.CardNum, dbo.Reader.Validity, dbo.Reader.MainLibrary_Id, dbo.Person.FirstName, dbo.Person.LastName, dbo.Person.BirthDate
FROM     dbo.Person INNER JOIN
                  dbo.Reader ON dbo.Person.Id = dbo.Reader.Pers_Id


GO
/****** Object:  Table [dbo].[Emprunt]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emprunt](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CardNum] [int] NOT NULL,
	[Item_Id] [int] NOT NULL,
	[Tarif_Id] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[ReturnDate] [date] NULL,
	[LastModified] [datetime] NULL,
 CONSTRAINT [PK_Emprunt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [SchAdmin].[vEmpruntDetails]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [SchAdmin].[vEmpruntDetails]
AS
SELECT dbo.Emprunt.Id AS IdEmprunt, dbo.Emprunt.CardNum, dbo.Emprunt.Item_Id, dbo.Emprunt.Tarif_Id, dbo.Volume.Title, dbo.Emprunt.StartDate, dbo.Tarif.Duration, dbo.Emprunt.ReturnDate, dbo.Tarif.Fee, 
                  dbo.Tarif.DailyPenalty, dbo.Tarif.Name AS NameTarif, dbo.Item.Code, dbo.Item.Library_Id, dbo.Library.Name AS NameLibrary, dbo.Emprunt.LastModified
FROM     dbo.Emprunt INNER JOIN
                  dbo.Tarif ON dbo.Emprunt.Tarif_Id = dbo.Tarif.Id INNER JOIN
                  dbo.Item ON dbo.Emprunt.Item_Id = dbo.Item.Id INNER JOIN
                  dbo.Volume ON dbo.Item.Volume_Id = dbo.Volume.Id INNER JOIN
                  dbo.Library ON dbo.Item.Library_Id = dbo.Library.Id

GO
/****** Object:  Table [dbo].[Author]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Pers_Id] [int] NOT NULL,
	[Volume_Isbn] [varchar](13) NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [SchAdmin].[vAuthor]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [SchAdmin].[vAuthor]
AS
SELECT dbo.Author.Pers_Id, dbo.Author.Volume_Isbn, dbo.Person.FirstName, dbo.Person.LastName, dbo.Person.Id
FROM     dbo.Author INNER JOIN
                  dbo.Person ON dbo.Author.Id = dbo.Person.Id

GO
/****** Object:  View [SchAdmin].[vVolume]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [SchAdmin].[vVolume]
AS
SELECT DISTINCT dbo.Volume.Id, dbo.Volume.Isbn, dbo.Volume.Title, dbo.Volume.Cover, dbo.Author.Pers_Id
FROM         dbo.Author INNER JOIN
                   dbo.Volume ON dbo.Author.Volume_Isbn = dbo.Volume.Isbn

GO
/****** Object:  View [SchAffiliate].[vAffiliate]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [SchAffiliate].[vAffiliate]
AS
SELECT dbo.Reader.CardNum, dbo.Reader.Validity, dbo.Reader.MainLibrary_Id, dbo.Person.FirstName, dbo.Person.LastName, dbo.Person.BirthDate
FROM     dbo.Person INNER JOIN
                  dbo.Reader ON dbo.Person.Id = dbo.Reader.Pers_Id



GO
/****** Object:  View [SchAffiliate].[vEmpruntDetails]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [SchAffiliate].[vEmpruntDetails]
AS
SELECT dbo.Emprunt.Id AS IdEmprunt, dbo.Emprunt.CardNum, dbo.Emprunt.Item_Id, dbo.Emprunt.Tarif_Id, dbo.Volume.Title, dbo.Emprunt.StartDate, dbo.Tarif.Duration, dbo.Emprunt.ReturnDate, dbo.Tarif.Fee, 
                  dbo.Tarif.DailyPenalty, dbo.Tarif.Name AS NameTarif, dbo.Item.Code, dbo.Item.Library_Id, dbo.Library.Name AS NameLibrary, dbo.Emprunt.LastModified
FROM     dbo.Emprunt INNER JOIN
                  dbo.Tarif ON dbo.Emprunt.Tarif_Id = dbo.Tarif.Id INNER JOIN
                  dbo.Item ON dbo.Emprunt.Item_Id = dbo.Item.Id INNER JOIN
                  dbo.Volume ON dbo.Item.Volume_Id = dbo.Volume.Id INNER JOIN
                  dbo.Library ON dbo.Item.Library_Id = dbo.Library.Id


GO
/****** Object:  View [SchAffiliate].[vItemDetails]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [SchAffiliate].[vItemDetails]
AS
SELECT dbo.Item.*, dbo.Volume.Isbn, dbo.Volume.Title, dbo.Volume.Cover
FROM     dbo.Item INNER JOIN
                  dbo.Volume ON dbo.Item.Volume_Id = dbo.Volume.Id



GO
/****** Object:  View [SchAffiliate].[vLibrary]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [SchAffiliate].[vLibrary]
AS
SELECT Id AS IdLibrary, Name AS NameLibrary, Code AS CodeIdLibrary
FROM     dbo.Library AS Library_1


GO
/****** Object:  View [SchAffiliate].[vVolume]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [SchAffiliate].[vVolume]
AS
SELECT dbo.Volume.Id, dbo.Volume.Isbn, dbo.Volume.Title, dbo.Volume.Cover, dbo.Author.Pers_Id, dbo.Person.FirstName, dbo.Person.LastName
FROM     dbo.Author INNER JOIN
                  dbo.Volume ON dbo.Author.Volume_Isbn = dbo.Volume.Isbn INNER JOIN
                  dbo.Person ON dbo.Author.Pers_Id = dbo.Person.Id

GO
/****** Object:  View [SchAffiliate].[vAuthor]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [SchAffiliate].[vAuthor]
AS
SELECT dbo.Author.Pers_Id, dbo.Author.Volume_Isbn, dbo.Person.FirstName, dbo.Person.LastName, dbo.Person.Id
FROM     dbo.Author INNER JOIN
                  dbo.Person ON dbo.Author.Id = dbo.Person.Id


GO
/****** Object:  Table [dbo].[WishList]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WishList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CardNum] [int] NOT NULL,
	[Volume_Id] [int] NOT NULL,
 CONSTRAINT [PK_WhishList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [SchAffiliate].[vWishlist]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [SchAffiliate].[vWishlist]
AS
SELECT dbo.WishList.Id, dbo.WishList.CardNum, dbo.WishList.Volume_Id, dbo.Volume.Isbn, dbo.Volume.Title, dbo.Volume.Cover
FROM     dbo.WishList INNER JOIN
                  dbo.Volume ON dbo.WishList.Volume_Id = dbo.Volume.Id


GO
/****** Object:  Table [dbo].[Affiliate]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Affiliate](
	[CardNum] [int] IDENTITY(1,1) NOT NULL,
	[CardValidity] [date] NULL,
	[MainLibrary_Id] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[BirthDate] [date] NULL,
 CONSTRAINT [PK_Affiliate] PRIMARY KEY CLUSTERED 
(
	[CardNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([Id], [Pers_Id], [Volume_Isbn]) VALUES (2, 1, N'0123456789')
INSERT [dbo].[Author] ([Id], [Pers_Id], [Volume_Isbn]) VALUES (7, 1, N'2222222222')
INSERT [dbo].[Author] ([Id], [Pers_Id], [Volume_Isbn]) VALUES (8, 1, N'3333333333')
INSERT [dbo].[Author] ([Id], [Pers_Id], [Volume_Isbn]) VALUES (9, 1, N'4444444444')
INSERT [dbo].[Author] ([Id], [Pers_Id], [Volume_Isbn]) VALUES (6, 1, N'9782744024320')
INSERT [dbo].[Author] ([Id], [Pers_Id], [Volume_Isbn]) VALUES (3, 2, N'0123456789')
INSERT [dbo].[Author] ([Id], [Pers_Id], [Volume_Isbn]) VALUES (4, 3, N'9876543210')
INSERT [dbo].[Author] ([Id], [Pers_Id], [Volume_Isbn]) VALUES (5, 4, N'0000000000')
SET IDENTITY_INSERT [dbo].[Author] OFF
SET IDENTITY_INSERT [dbo].[Emprunt] ON 

INSERT [dbo].[Emprunt] ([Id], [CardNum], [Item_Id], [Tarif_Id], [StartDate], [ReturnDate], [LastModified]) VALUES (8, 1, 2, 1, CAST(N'2017-01-10' AS Date), CAST(N'2017-08-27' AS Date), CAST(N'2017-02-07T18:47:18.883' AS DateTime))
INSERT [dbo].[Emprunt] ([Id], [CardNum], [Item_Id], [Tarif_Id], [StartDate], [ReturnDate], [LastModified]) VALUES (10, 1, 3, 1, CAST(N'2017-02-06' AS Date), CAST(N'2017-08-27' AS Date), CAST(N'2017-02-07T22:31:32.150' AS DateTime))
INSERT [dbo].[Emprunt] ([Id], [CardNum], [Item_Id], [Tarif_Id], [StartDate], [ReturnDate], [LastModified]) VALUES (13, 1, 5, 1, CAST(N'2017-01-20' AS Date), CAST(N'2017-08-27' AS Date), CAST(N'2017-02-08T02:16:51.673' AS DateTime))
INSERT [dbo].[Emprunt] ([Id], [CardNum], [Item_Id], [Tarif_Id], [StartDate], [ReturnDate], [LastModified]) VALUES (19, 1, 1, 1, CAST(N'2017-08-30' AS Date), CAST(N'2017-08-30' AS Date), CAST(N'2017-08-30T16:48:35.820' AS DateTime))
INSERT [dbo].[Emprunt] ([Id], [CardNum], [Item_Id], [Tarif_Id], [StartDate], [ReturnDate], [LastModified]) VALUES (20, 1, 1, 1, CAST(N'2017-08-30' AS Date), NULL, CAST(N'2017-08-30T16:48:37.380' AS DateTime))
INSERT [dbo].[Emprunt] ([Id], [CardNum], [Item_Id], [Tarif_Id], [StartDate], [ReturnDate], [LastModified]) VALUES (21, 1, 1, 1, CAST(N'2017-08-30' AS Date), NULL, CAST(N'2017-08-30T19:00:59.453' AS DateTime))
INSERT [dbo].[Emprunt] ([Id], [CardNum], [Item_Id], [Tarif_Id], [StartDate], [ReturnDate], [LastModified]) VALUES (22, 1, 1, 1, CAST(N'2017-08-30' AS Date), NULL, CAST(N'2017-08-30T19:04:13.033' AS DateTime))
SET IDENTITY_INSERT [dbo].[Emprunt] OFF
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([Id], [Code], [Library_Id], [Volume_Id], [BuyDate], [Localisation]) VALUES (1, N'1564pojpoj', 1, 1, CAST(N'2017-01-10' AS Date), NULL)
INSERT [dbo].[Item] ([Id], [Code], [Library_Id], [Volume_Id], [BuyDate], [Localisation]) VALUES (2, N'999999', 1, 1, CAST(N'2017-02-04' AS Date), N'1')
INSERT [dbo].[Item] ([Id], [Code], [Library_Id], [Volume_Id], [BuyDate], [Localisation]) VALUES (3, N'88888888', 1, 1, CAST(N'2017-02-04' AS Date), N'1')
INSERT [dbo].[Item] ([Id], [Code], [Library_Id], [Volume_Id], [BuyDate], [Localisation]) VALUES (5, N'0123456', 2, 14, CAST(N'2016-10-24' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Item] OFF
SET IDENTITY_INSERT [dbo].[Library] ON 

INSERT [dbo].[Library] ([Id], [Name], [Code]) VALUES (1, N'Bibliothèque Centrale', N'ABCDE')
INSERT [dbo].[Library] ([Id], [Name], [Code]) VALUES (2, N'Bibliothèque du parc', N'12345')
INSERT [dbo].[Library] ([Id], [Name], [Code]) VALUES (3, N'Bibliothèque du Midi', N'greqn')
SET IDENTITY_INSERT [dbo].[Library] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [BirthDate]) VALUES (1, N'Tom', N'Smith', CAST(N'1985-05-15' AS Date))
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [BirthDate]) VALUES (2, N'Jean-Claude', N'Vandamme', CAST(N'1972-06-23' AS Date))
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [BirthDate]) VALUES (3, N'Jean-Claude', N'Marcourt', CAST(N'1960-08-15' AS Date))
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [BirthDate]) VALUES (4, N'Jean', N'de Lafontaine', CAST(N'1730-07-05' AS Date))
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [BirthDate]) VALUES (5, N'Jean-Charles', N'Dubois', CAST(N'1990-11-02' AS Date))
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [BirthDate]) VALUES (6, N'Maxime', N'Romanus', CAST(N'1979-02-17' AS Date))
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [BirthDate]) VALUES (7, N'Nathalie', N'Buse', CAST(N'1983-11-20' AS Date))
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Reader] ON 

INSERT [dbo].[Reader] ([CardNum], [Pers_Id], [MainLibrary_Id], [Validity]) VALUES (1, 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[Reader] OFF
SET IDENTITY_INSERT [dbo].[Tarif] ON 

INSERT [dbo].[Tarif] ([Id], [Library_Id], [Name], [Year], [Duration], [Fee], [DailyPenalty]) VALUES (1, 1, N'Tarif Standard', 2017, 7, CAST(3.00 AS Decimal(8, 2)), CAST(0.50 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Tarif] OFF
SET IDENTITY_INSERT [dbo].[Volume] ON 

INSERT [dbo].[Volume] ([Id], [Isbn], [Title], [Cover]) VALUES (1, N'0123456789', N'TestTitle', NULL)
INSERT [dbo].[Volume] ([Id], [Isbn], [Title], [Cover]) VALUES (2, N'0000000000', N'Les Fables', NULL)
INSERT [dbo].[Volume] ([Id], [Isbn], [Title], [Cover]) VALUES (3, N'9876543210', N'Mémoires', NULL)
INSERT [dbo].[Volume] ([Id], [Isbn], [Title], [Cover]) VALUES (14, N'9782744024320', N'C# L''essentiel du code', NULL)
INSERT [dbo].[Volume] ([Id], [Isbn], [Title], [Cover]) VALUES (19, N'2222222222', N'tes2', N'')
INSERT [dbo].[Volume] ([Id], [Isbn], [Title], [Cover]) VALUES (20, N'3333333333', N'test3', N'')
INSERT [dbo].[Volume] ([Id], [Isbn], [Title], [Cover]) VALUES (21, N'4444444444', N'testNomauteur', N'')
SET IDENTITY_INSERT [dbo].[Volume] OFF
SET IDENTITY_INSERT [dbo].[WishList] ON 

INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (1, 1, 20)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (2, 1, 21)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (3, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (4, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (5, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (6, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (7, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (8, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (9, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (10, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (11, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (12, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (13, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (14, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (15, 1, 1)
INSERT [dbo].[WishList] ([Id], [CardNum], [Volume_Id]) VALUES (16, 1, 14)
SET IDENTITY_INSERT [dbo].[WishList] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Author]    Script Date: 30/08/2017 21:05:37 ******/
ALTER TABLE [dbo].[Author] ADD  CONSTRAINT [IX_Author] UNIQUE NONCLUSTERED 
(
	[Pers_Id] ASC,
	[Volume_Isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Item]    Script Date: 30/08/2017 21:05:37 ******/
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [IX_Item] UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UniqueCode]    Script Date: 30/08/2017 21:05:37 ******/
ALTER TABLE [dbo].[Library] ADD  CONSTRAINT [IX_UniqueCode] UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UniqueName]    Script Date: 30/08/2017 21:05:37 ******/
ALTER TABLE [dbo].[Library] ADD  CONSTRAINT [IX_UniqueName] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UniquePers_Id]    Script Date: 30/08/2017 21:05:37 ******/
ALTER TABLE [dbo].[Reader] ADD  CONSTRAINT [IX_UniquePers_Id] UNIQUE NONCLUSTERED 
(
	[CardNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Volume]    Script Date: 30/08/2017 21:05:37 ******/
ALTER TABLE [dbo].[Volume] ADD  CONSTRAINT [IX_Volume] UNIQUE NONCLUSTERED 
(
	[Isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Emprunt] ADD  CONSTRAINT [DF_Emprunt_LastModified]  DEFAULT (getdate()) FOR [LastModified]
GO
ALTER TABLE [dbo].[Affiliate]  WITH CHECK ADD  CONSTRAINT [FK_Affiliate_Library] FOREIGN KEY([MainLibrary_Id])
REFERENCES [dbo].[Library] ([Id])
GO
ALTER TABLE [dbo].[Affiliate] CHECK CONSTRAINT [FK_Affiliate_Library]
GO
ALTER TABLE [dbo].[Author]  WITH CHECK ADD  CONSTRAINT [FK_Author_Volume] FOREIGN KEY([Volume_Isbn])
REFERENCES [dbo].[Volume] ([Isbn])
GO
ALTER TABLE [dbo].[Author] CHECK CONSTRAINT [FK_Author_Volume]
GO
ALTER TABLE [dbo].[Emprunt]  WITH CHECK ADD  CONSTRAINT [FK_Emprunt_Item] FOREIGN KEY([Item_Id])
REFERENCES [dbo].[Item] ([Id])
GO
ALTER TABLE [dbo].[Emprunt] CHECK CONSTRAINT [FK_Emprunt_Item]
GO
ALTER TABLE [dbo].[Emprunt]  WITH CHECK ADD  CONSTRAINT [FK_Emprunt_Reader] FOREIGN KEY([CardNum])
REFERENCES [dbo].[Reader] ([CardNum])
GO
ALTER TABLE [dbo].[Emprunt] CHECK CONSTRAINT [FK_Emprunt_Reader]
GO
ALTER TABLE [dbo].[Emprunt]  WITH CHECK ADD  CONSTRAINT [FK_Emprunt_Tarif] FOREIGN KEY([Tarif_Id])
REFERENCES [dbo].[Tarif] ([Id])
GO
ALTER TABLE [dbo].[Emprunt] CHECK CONSTRAINT [FK_Emprunt_Tarif]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Library] FOREIGN KEY([Library_Id])
REFERENCES [dbo].[Library] ([Id])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Library]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Volume] FOREIGN KEY([Volume_Id])
REFERENCES [dbo].[Volume] ([Id])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Volume]
GO
ALTER TABLE [dbo].[Reader]  WITH CHECK ADD  CONSTRAINT [FK_Reader_Library] FOREIGN KEY([MainLibrary_Id])
REFERENCES [dbo].[Library] ([Id])
GO
ALTER TABLE [dbo].[Reader] CHECK CONSTRAINT [FK_Reader_Library]
GO
ALTER TABLE [dbo].[Reader]  WITH CHECK ADD  CONSTRAINT [FK_Reader_Person] FOREIGN KEY([Pers_Id])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Reader] CHECK CONSTRAINT [FK_Reader_Person]
GO
ALTER TABLE [dbo].[Tarif]  WITH CHECK ADD  CONSTRAINT [FK_Tarif_Library] FOREIGN KEY([Library_Id])
REFERENCES [dbo].[Library] ([Id])
GO
ALTER TABLE [dbo].[Tarif] CHECK CONSTRAINT [FK_Tarif_Library]
GO
ALTER TABLE [dbo].[WishList]  WITH CHECK ADD  CONSTRAINT [FK_WhishList_Reader] FOREIGN KEY([CardNum])
REFERENCES [dbo].[Reader] ([CardNum])
GO
ALTER TABLE [dbo].[WishList] CHECK CONSTRAINT [FK_WhishList_Reader]
GO
ALTER TABLE [dbo].[WishList]  WITH CHECK ADD  CONSTRAINT [FK_WhishList_Volume] FOREIGN KEY([Volume_Id])
REFERENCES [dbo].[Volume] ([Id])
GO
ALTER TABLE [dbo].[WishList] CHECK CONSTRAINT [FK_WhishList_Volume]
GO
/****** Object:  StoredProcedure [SchAdmin].[CloseEmprunt]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Description: Clôture un emprunt. 
-- =============================================
CREATE PROCEDURE [SchAdmin].[CloseEmprunt]
@Id  INT,
@LastModified DATETIME

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
 UPDATE  [SchAdmin].vEmpruntDetails
		SET [ReturnDate]=CONVERT(date, getdate())
		WHERE IdEmprunt=@Id AND LastModified=@LastModified
END 


GO
/****** Object:  StoredProcedure [SchAdmin].[GetAffiliateByCardNum]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetAffiliateByCardNum]
@number  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [CardNum],[Validity],[MainLibrary_Id],[FirstName],[LastName],[BirthDate] FROM [SchAdmin].vAffiliate
	WHERE CardNum=@number
END 






GO
/****** Object:  StoredProcedure [SchAdmin].[GetAffiliateByName]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetAffiliateByName]
@firstName  varchar(50),
@lastName  varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [CardNum],[Validity],[MainLibrary_Id],[FirstName],[LastName],[BirthDate] FROM [SchAdmin].vAffiliate
	WHERE FirstName=@firstName AND LastName=@lastName
END 







GO
/****** Object:  StoredProcedure [SchAdmin].[GetAllAuthors]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Description:  Retourne les id, prénoms et noms de tous les auteurs (pour choix liste dans gui).
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetAllAuthors]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT DISTINCT  Id,[FirstName],[LastName] FROM [SchAdmin].vAuthor 
	
END 

GO
/****** Object:  StoredProcedure [SchAdmin].[GetAuthorById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetAuthorById]
@Id  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [FirstName],[LastName],[Volume_Id] FROM [SchAdmin].vAuthor 
	WHERE [Pers_Id]=@Id
END 






GO
/****** Object:  StoredProcedure [SchAdmin].[GetAuthorByVolumeId]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetAuthorByVolumeId]
@VolumeId  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [Pers_Id],[FirstName],[LastName] FROM [SchAdmin].vAuthor
	WHERE Volume_Id=@VolumeId
END 






GO
/****** Object:  StoredProcedure [SchAdmin].[GetAuthorByVolumeIsbn]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetAuthorByVolumeIsbn]
@VolumeIsbn  Varchar(13)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [Pers_Id],[FirstName],[LastName] FROM [SchAdmin].vAuthor
	WHERE Volume_Isbn=@VolumeIsbn
END 







GO
/****** Object:  StoredProcedure [SchAdmin].[GetEmpruntByAffiliate]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Description:  Renvoie les emprunts en cours
--				ou clôturés d'un affilié. 
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetEmpruntByAffiliate]
@Id  INT,
@SelectClosed bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF @SelectClosed =0 --Choisi les emprunts actifs.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAdmin].vEmpruntDetails
		WHERE CardNum=@Id AND ReturnDate IS NULL
	ELSE		--Choisi les emprunts clôturés.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAdmin].vEmpruntDetails
		WHERE CardNum=@Id AND ReturnDate IS NOT NULL
END 







GO
/****** Object:  StoredProcedure [SchAdmin].[GetEmpruntByCode]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Description:  Renvoie les emprunts en cours
--				ou clôturés d'un affilié. 
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetEmpruntByCode]
@Code  INT,
@SelectClosed bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF @SelectClosed =0 --Choisi les emprunts actifs.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAdmin].vEmpruntDetails
		WHERE Code=@Code AND ReturnDate IS NULL
	ELSE		--Choisi les emprunts clôturés.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAdmin].vEmpruntDetails
		WHERE Code=@Code AND ReturnDate IS NOT NULL
END 








GO
/****** Object:  StoredProcedure [SchAdmin].[GetEmpruntById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Description:  Renvoie les emprunts en cours
--				ou clôturés d'un affilié. 
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetEmpruntById]
@Id  INT,
@SelectClosed bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF @SelectClosed =0 --Choisi les emprunts actifs.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAdmin].vEmpruntDetails
		WHERE [IdEmprunt] =@Id AND ReturnDate IS NULL
	ELSE		--Choisi les emprunts clôturés.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAdmin].vEmpruntDetails
		WHERE [IdEmprunt] =@Id AND ReturnDate IS NOT NULL
END 







GO
/****** Object:  StoredProcedure [SchAdmin].[GetItemById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetItemById]
@Iditem  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [Id],[Code],[Library_Id],[Volume_Id] ,[BuyDate] ,[Localisation] ,[Isbn] ,[Title],[Cover] FROM [SchAdmin].vItemDetails
	WHERE Id=@Iditem
END 







GO
/****** Object:  StoredProcedure [SchAdmin].[GetItemByLibAndVol]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetItemByLibAndVol]
@Idlib  INT,
@Idvol  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [Id],[Code],[Library_Id],[Volume_Id] ,[BuyDate] ,[Localisation] ,[Isbn] ,[Title],[Cover] FROM [SchAdmin].vItemDetails
	WHERE [Library_Id]=@Idlib AND [Volume_Id] = @Idvol
END 







GO
/****** Object:  StoredProcedure [SchAdmin].[GetItemByVol]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetItemByVol]
@Idvol  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [Id],[Code],[Library_Id],[Volume_Id] ,[BuyDate] ,[Localisation] ,[Isbn] ,[Title],[Cover] FROM [SchAdmin].vItemDetails
	WHERE [Volume_Id] = @Idvol
END 







GO
/****** Object:  StoredProcedure [SchAdmin].[GetLibraries]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetLibraries]
 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 
	SELECT  IdLibrary,[NameLibrary],[CodeIdLibrary] FROM [SchAdmin].vLibrary
END 










GO
/****** Object:  StoredProcedure [SchAdmin].[GetLibraryById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetLibraryById]
@Id  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT  IdLibrary,[NameLibrary],[CodeIdLibrary] FROM [SchAdmin].vLibrary
	WHERE IdLibrary=@Id
END 






GO
/****** Object:  StoredProcedure [SchAdmin].[GetPersById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetPersById]
@Id  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Id ,[FirstName],[LastName],Birthdate FROM [SchAdmin].vPerson
	WHERE Id=@Id
END 







GO
/****** Object:  StoredProcedure [SchAdmin].[GetReaderById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetReaderById]
@Id  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT CardNum,Pers_Id,MainLibrary_Id FROM [SchAdmin].vReader
	WHERE CardNum=@Id
END 







GO
/****** Object:  StoredProcedure [SchAdmin].[GetRetardByLib]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Description: Renvoie les retards d'une librairie.
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetRetardByLib]
@Id  INT
 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAdmin].vEmpruntDetails
		WHERE [Library_Id] =@Id AND ReturnDate IS NULL AND GETDATE()> DATEADD(day,Duration,[StartDate])
END 


GO
/****** Object:  StoredProcedure [SchAdmin].[GetTarifById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetTarifById]
@Id  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Id,[Library_Id],[Name],[Year], Duration,Fee,DailyPenalty FROM [SchAdmin].vTarif 
	WHERE Id =@Id
END 

GO
/****** Object:  StoredProcedure [SchAdmin].[GetTarifByLibId]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetTarifByLibId]
@Id  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Id,[Library_Id],[Name],[Year], Duration,Fee,DailyPenalty FROM [SchAdmin].vTarif 
	WHERE Library_Id=@Id
END 

GO
/****** Object:  StoredProcedure [SchAdmin].[GetTarifShortById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetTarifShortById]
@Id  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Duration,Fee,DailyPenalty FROM [SchAdmin].vTarif
	WHERE Id =@Id
END 


GO
/****** Object:  StoredProcedure [SchAdmin].[GetVolumeById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetVolumeById]
@Id INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Id,Isbn,Title,[Pers_Id],Cover FROM [SchAdmin].vVolume
	WHERE Id=@Id
END 

GO
/****** Object:  StoredProcedure [SchAdmin].[GetVolumeByIsbn]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetVolumeByIsbn]
@isbn  VARCHAR(13)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Id,Isbn,Title,Cover FROM [SchAdmin].vVolume
	WHERE Isbn=@isbn
END 







GO
/****** Object:  StoredProcedure [SchAdmin].[GetVolumeByTitle]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetVolumeByTitle]
@title  VARCHAR(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SET @title = '%' + @title + '%'
	SELECT TOP 1 Id,Isbn,Title,Cover FROM [SchAdmin].vVolume
	WHERE Title LIKE @title
	END 
GO
/****** Object:  StoredProcedure [SchAdmin].[GetVolumesByTitle]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[GetVolumesByTitle]
@title  VARCHAR(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	 SET @title = '%' + @title + '%'
	SELECT Id,Isbn,Title,Cover FROM [SchAdmin].vVolume
	WHERE Title LIKE  @title
	END 
GO
/****** Object:  StoredProcedure [SchAdmin].[InsertItem]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:  Rajoute un item.
-- =============================================
CREATE PROCEDURE [SchAdmin].[InsertItem]
@Code  VARCHAR(50),
@LibraryId		INT,
@VolumeId		INT,
@BuyDate		DateTime,
@Localisation	VARCHAR(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
 INSERT INTO [SchAdmin].[vItemDetails]([Code],[Library_Id],[Volume_Id],[BuyDate],[Localisation])  VALUES(@Code,@LibraryId,@VolumeId,@BuyDate,@Localisation);

END 


GO
/****** Object:  StoredProcedure [SchAdmin].[InsertVolume]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAdmin].[InsertVolume]
@Isbn  varchar(13),
@Title  varchar(50),
@Cover  varchar(50)
 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	INSERT INTO [SchAdmin].[vVolume]([Isbn],[Title],[Cover])  VALUES(@Isbn, @Title, @Cover);
END




GO
/****** Object:  StoredProcedure [SchAdmin].[linkAuthorToVolume]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Description: Lie un volume à son / ses auteur(s). 
-- =============================================
CREATE PROCEDURE [SchAdmin].[linkAuthorToVolume]
@AuthorId  INT,
@VolumeIsbn  VARCHAR(13)
 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	INSERT INTO [SchAdmin].[vAuthor](Pers_Id,Volume_Isbn)  VALUES(@AuthorId, @VolumeIsbn);
END



GO
/****** Object:  StoredProcedure [SchAffiliate].[DeleteEmprunt]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:  supprime un emprunt. 
-- =============================================
CREATE PROCEDURE [SchAffiliate].[DeleteEmprunt]
@emprunt_Id INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM [SchAffiliate].[vEmpruntDetails] WHERE[IdEmprunt]=@emprunt_Id;
		
END 



GO
/****** Object:  StoredProcedure [SchAffiliate].[DeleteWishById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Description:  supprime un élémeent de la wishlist du lecteur.. 
-- =============================================
CREATE PROCEDURE [SchAffiliate].[DeleteWishById]
@Id  INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 DELETE FROM [SchAffiliate].vWishlist WHERE(Id=@Id); 
		
END 



GO
/****** Object:  StoredProcedure [SchAffiliate].[DeleteWishItem]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:  supprime une entrée de volume souhaité selon son Id. 
-- =============================================
CREATE PROCEDURE [SchAffiliate].[DeleteWishItem]
@wish_Id INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM [SchAffiliate].vWishlist WHERE[Id]=@wish_Id;
		
END 



GO
/****** Object:  StoredProcedure [SchAffiliate].[GetAffiliateByCardNum]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetAffiliateByCardNum]
@number  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [CardNum],[Validity],[MainLibrary_Id],[FirstName],[LastName],[BirthDate] FROM [SchAffiliate].vAffiliate
	WHERE CardNum=@number
END 






GO
/****** Object:  StoredProcedure [SchAffiliate].[GetAffiliateByName]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetAffiliateByName]
@firstName  varchar(50),
@lastName  varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [CardNum],[Validity],[MainLibrary_Id],[FirstName],[LastName],[BirthDate] FROM [SchAffiliate].vAffiliate
	WHERE FirstName=@firstName AND LastName=@lastName
END 








GO
/****** Object:  StoredProcedure [SchAffiliate].[GetAllVolumes]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetAllVolumes]


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Id,Isbn,Title,Cover FROM [SchAffiliate].vVolume
	
END 









GO
/****** Object:  StoredProcedure [SchAffiliate].[GetAuthorByVolumeIsbn]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetAuthorByVolumeIsbn]
@VolumeIsbn  Varchar(13)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [Pers_Id],[FirstName],[LastName] FROM [SchAffiliate].vAuthor
	WHERE Volume_Isbn=@VolumeIsbn
END 








GO
/****** Object:  StoredProcedure [SchAffiliate].[GetEmpruntByAffiliate]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Description:  Renvoie les emprunts en cours
--				ou clôturés d'un affilié. 
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetEmpruntByAffiliate]
@Id  INT,
@SelectClosed bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF @SelectClosed =0 --Choisi les emprunts actifs.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAffiliate].vEmpruntDetails
		WHERE CardNum=@Id AND ReturnDate IS NULL
	ELSE		--Choisi les emprunts clôturés.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAffiliate].vEmpruntDetails
		WHERE CardNum=@Id AND ReturnDate IS NOT NULL
END 








GO
/****** Object:  StoredProcedure [SchAffiliate].[GetEmpruntByCode]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







-- =============================================
-- Description:  Renvoie les emprunts en cours
--				ou clôturés d'un affilié. 
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetEmpruntByCode]
@Code  INT,
@SelectClosed bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF @SelectClosed =0 --Choisi les emprunts actifs.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAffiliate].vEmpruntDetails
		WHERE Code=@Code AND ReturnDate IS NULL
	ELSE		--Choisi les emprunts clôturés.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAffiliate].vEmpruntDetails
		WHERE Code=@Code AND ReturnDate IS NOT NULL
END 









GO
/****** Object:  StoredProcedure [SchAffiliate].[GetEmpruntById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Description:  Renvoie les emprunts en cours
--				ou clôturés d'un affilié. 
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetEmpruntById]
@Id  INT,
@SelectClosed bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF @SelectClosed =0 --Choisi les emprunts actifs.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAffiliate].vEmpruntDetails
		WHERE [IdEmprunt] =@Id AND ReturnDate IS NULL
	ELSE		--Choisi les emprunts clôturés.
		SELECT [IdEmprunt],[CardNum],[Item_Id],[Tarif_Id],[Library_Id],[NameLibrary],[Title],[Code],[StartDate],[Duration],[ReturnDate],[Fee],[DailyPenalty],[NameTarif],LastModified FROM [SchAffiliate].vEmpruntDetails
		WHERE [IdEmprunt] =@Id AND ReturnDate IS NOT NULL
END 








GO
/****** Object:  StoredProcedure [SchAffiliate].[GetItemByLibAndVol]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Description:  Retourne les exemplaires d'un ouvrage, d'une certaine
-- bibliothèque
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetItemByLibAndVol]
@Idlib  INT,
@Idvol  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [Id],[Code],[Library_Id],[Volume_Id] ,[BuyDate] ,[Localisation] ,[Isbn] ,[Title],[Cover] FROM SchAffiliate.vItemDetails
	WHERE [Library_Id]=@Idlib AND [Volume_Id] = @Idvol
END 








GO
/****** Object:  StoredProcedure [SchAffiliate].[GetItemByVol]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetItemByVol]
@Idvol  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT [Id],[Code],[Library_Id],[Volume_Id] ,[BuyDate] ,[Localisation] ,[Isbn] ,[Title],[Cover] FROM [SchAffiliate].vItemDetails
	WHERE [Volume_Id] = @Idvol
END 








GO
/****** Object:  StoredProcedure [SchAffiliate].[GetLibraries]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetLibraries]
 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 
	SELECT  IdLibrary,[NameLibrary],[CodeIdLibrary] FROM [SchAffiliate].vLibrary
END 











GO
/****** Object:  StoredProcedure [SchAffiliate].[GetTarifByLibId]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Description:  Récupère le tarif d'une bibliothèque.
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetTarifByLibId]
@Id  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Id,[Library_Id],[Name],[Year], Duration,Fee,DailyPenalty FROM [SchAdmin].vTarif 
	WHERE Library_Id=@Id
END 


GO
/****** Object:  StoredProcedure [SchAffiliate].[GetTarifShortById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetTarifShortById]
@Id  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Duration,Fee,DailyPenalty FROM [SchAdmin].vTarif
	WHERE Id =@Id
END 



GO
/****** Object:  StoredProcedure [SchAffiliate].[GetVolumeById]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetVolumeById]
@Id INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Id,Isbn,Title,Cover FROM [SchAffiliate].vVolume
	WHERE Id=@Id
END 



GO
/****** Object:  StoredProcedure [SchAffiliate].[GetVolumeByIsbn]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetVolumeByIsbn]
@isbn  VARCHAR(13)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 
	SELECT Id,Isbn,Title,Cover FROM [SchAffiliate].vVolume
	WHERE Isbn=@isbn
END 








GO
/****** Object:  StoredProcedure [SchAffiliate].[GetVolumeByTitle]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Description:  
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetVolumeByTitle]
@title  VARCHAR(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SET @title = '%' + @title + '%'
	SELECT TOP 1 Id,Isbn,Title,Cover FROM [SchAffiliate].vVolume
	WHERE Title LIKE @title
	END 

GO
/****** Object:  StoredProcedure [SchAffiliate].[GetWishlist]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Description:  Renvoie la wishlist d'un affilié. 
-- =============================================
CREATE PROCEDURE [SchAffiliate].[GetWishlist]
@Id  INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

		SELECT [Id],[CardNum],[Volume_Id],[Isbn],[Cover] FROM [SchAffiliate].vWishlist
		WHERE CardNum=@Id 
END 


GO
/****** Object:  StoredProcedure [SchAffiliate].[InsertEmprunt]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Description:  Insère un emprunt. 
-- Deuxième version, la date d'insertion est crée ici.
-- =============================================
CREATE PROCEDURE [SchAffiliate].[InsertEmprunt]
@CardNum  INT,
@Item_Id INT,
@Tarif_Id int
--@StartDate date

AS
BEGIN
 	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 INSERT INTO [SchAffiliate].vEmpruntDetails([CardNum],Item_Id, [Tarif_Id], StartDate)  VALUES(@CardNum,@Item_Id,@Tarif_Id,CONVERT(date, getdate())); 
		
END 




GO
/****** Object:  StoredProcedure [SchAffiliate].[InsertWish]    Script Date: 30/08/2017 21:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Description:  Insert un volume dans la wishlist du lecteur.. 
-- =============================================
CREATE PROCEDURE [SchAffiliate].[InsertWish]
@CardNum  INT,
@Volume_Id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 INSERT INTO [SchAffiliate].vWishlist([CardNum],[Volume_Id])  VALUES(@CardNum,@Volume_Id); 
		
END 



GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[45] 4[21] 2[15] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -120
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Author"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 148
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Person"
            Begin Extent = 
               Top = 154
               Left = 48
               Bottom = 317
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'SchAdmin', @level1type=N'VIEW',@level1name=N'vAuthor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'SchAdmin', @level1type=N'VIEW',@level1name=N'vAuthor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[55] 4[20] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -240
      End
      Begin Tables = 
         Begin Table = "Emprunt"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Tarif"
            Begin Extent = 
               Top = 221
               Left = 272
               Bottom = 384
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Item"
            Begin Extent = 
               Top = 7
               Left = 457
               Bottom = 170
               Right = 651
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Volume"
            Begin Extent = 
               Top = 73
               Left = 718
               Bottom = 236
               Right = 912
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Library"
            Begin Extent = 
               Top = 239
               Left = 680
               Bottom = 380
               Right = 874
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
' , @level0type=N'SCHEMA',@level0name=N'SchAdmin', @level1type=N'VIEW',@level1name=N'vEmpruntDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'SchAdmin', @level1type=N'VIEW',@level1name=N'vEmpruntDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'SchAdmin', @level1type=N'VIEW',@level1name=N'vEmpruntDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Library_1"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 148
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'SchAdmin', @level1type=N'VIEW',@level1name=N'vLibrary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'SchAdmin', @level1type=N'VIEW',@level1name=N'vLibrary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Author"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 148
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Volume"
            Begin Extent = 
               Top = 154
               Left = 48
               Bottom = 317
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'SchAdmin', @level1type=N'VIEW',@level1name=N'vVolume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'SchAdmin', @level1type=N'VIEW',@level1name=N'vVolume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Author"
            Begin Extent = 
               Top = 13
               Left = 291
               Bottom = 154
               Right = 485
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Volume"
            Begin Extent = 
               Top = 21
               Left = 32
               Bottom = 184
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Person"
            Begin Extent = 
               Top = 7
               Left = 533
               Bottom = 170
               Right = 727
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'SchAffiliate', @level1type=N'VIEW',@level1name=N'vVolume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'SchAffiliate', @level1type=N'VIEW',@level1name=N'vVolume'
GO
USE [master]
GO
ALTER DATABASE [ExamSGBD2017] SET  READ_WRITE 
GO
