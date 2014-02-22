USE [master]
GO
/****** Object:  Database [EnterpriseTraining]    Script Date: 2014-02-22 03:08:07 ******/
CREATE DATABASE [EnterpriseTraining]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EnterpriseTraining_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EnterpriseTraining.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EnterpriseTraining_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EnterpriseTraining.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EnterpriseTraining] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EnterpriseTraining].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EnterpriseTraining] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [EnterpriseTraining] SET ANSI_NULLS ON 
GO
ALTER DATABASE [EnterpriseTraining] SET ANSI_PADDING ON 
GO
ALTER DATABASE [EnterpriseTraining] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [EnterpriseTraining] SET ARITHABORT ON 
GO
ALTER DATABASE [EnterpriseTraining] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EnterpriseTraining] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EnterpriseTraining] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [EnterpriseTraining] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [EnterpriseTraining] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [EnterpriseTraining] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EnterpriseTraining] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EnterpriseTraining] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET RECOVERY FULL 
GO
ALTER DATABASE [EnterpriseTraining] SET  MULTI_USER 
GO
ALTER DATABASE [EnterpriseTraining] SET PAGE_VERIFY NONE  
GO
ALTER DATABASE [EnterpriseTraining] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EnterpriseTraining] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EnterpriseTraining] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [EnterpriseTraining]
GO
/****** Object:  Table [dbo].[Certificates]    Script Date: 2014-02-22 03:08:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Certificates](
	[CertificateId] [int] IDENTITY(0,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[ValidityYears] [int] NOT NULL,
 CONSTRAINT [PK__Certific__BBF8A7C1AB9ABF52] PRIMARY KEY CLUSTERED 
(
	[CertificateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[Trainees]    Script Date: 2014-02-22 03:08:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trainees](
	[UserId] [int] NOT NULL,
	[TrainingId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[TrainingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Trainers]    Script Date: 2014-02-22 03:08:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trainers](
	[UserId] [int] NOT NULL,
	[TrainingId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[TrainingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Trainings]    Script Date: 2014-02-22 03:08:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Trainings](
	[TrainingId] [int] IDENTITY(0,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[Cost] [money] NOT NULL,
	[CertificateId] [int] NULL,
	[RequiredPoints] [int] NOT NULL,
	[MaxPoints] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TrainingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[UserCertificates]    Script Date: 2014-02-22 03:08:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserCertificates](
	[UserId] [int] NOT NULL,
	[CertificateId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[CertificateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2014-02-22 03:08:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(0,1) NOT NULL,
	[FirstName] [varchar](63) NULL,
	[LastName] [varchar](63) NULL,
	[BirthDate] [date] NOT NULL,
	[EmailAddress] [varchar](255) NULL,
	[Country] [varchar](255) NULL,
	[City] [varchar](255) NULL,
	[Street] [varchar](255) NULL,
	[HouseNumber] [int] NULL,
	[FlatNumber] [int] NULL,
	[PostCode] [varchar](31) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
SET IDENTITY_INSERT [dbo].[Certificates] ON 

INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (4, N'Certificate in Advanced English', 3)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (5, N'First Certificate in English', 3)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (6, N'Certified C# Engineer', 5)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (7, N'Certified SQL Database Manager', 5)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (8, N'Microsoft Most Valuable Professional', 1)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (9, N'Certified C# Modeller', 5)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (10, N'Certified Access Database Manager', 5)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (11, N'Certified UML Modeller', 7)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (12, N'Certified Java EE Developer', 5)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (13, N'Certified Java SE Developer', 5)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (14, N'Certified Macromedia Flash Developer', 5)
INSERT [dbo].[Certificates] ([CertificateId], [Name], [ValidityYears]) VALUES (15, N'Certified SCRUM Manager', 5)
SET IDENTITY_INSERT [dbo].[Certificates] OFF
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (5, 2)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (5, 3)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (5, 4)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (5, 5)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (6, 2)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (6, 3)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (6, 4)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (7, 2)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (7, 3)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (7, 4)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (7, 5)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (8, 2)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (8, 4)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (8, 5)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (8, 7)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (9, 2)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (9, 3)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (9, 4)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (9, 5)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (9, 7)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (10, 2)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (11, 2)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (11, 3)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (12, 4)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (12, 5)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (13, 2)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (13, 3)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (13, 4)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (13, 5)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (14, 2)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (14, 5)
INSERT [dbo].[Trainees] ([UserId], [TrainingId]) VALUES (15, 2)
INSERT [dbo].[Trainers] ([UserId], [TrainingId]) VALUES (3, 2)
INSERT [dbo].[Trainers] ([UserId], [TrainingId]) VALUES (3, 5)
INSERT [dbo].[Trainers] ([UserId], [TrainingId]) VALUES (3, 6)
INSERT [dbo].[Trainers] ([UserId], [TrainingId]) VALUES (4, 2)
INSERT [dbo].[Trainers] ([UserId], [TrainingId]) VALUES (4, 3)
INSERT [dbo].[Trainers] ([UserId], [TrainingId]) VALUES (4, 4)
INSERT [dbo].[Trainers] ([UserId], [TrainingId]) VALUES (4, 7)
INSERT [dbo].[Trainers] ([UserId], [TrainingId]) VALUES (15, 3)
INSERT [dbo].[Trainers] ([UserId], [TrainingId]) VALUES (15, 5)
SET IDENTITY_INSERT [dbo].[Trainings] ON 

INSERT [dbo].[Trainings] ([TrainingId], [Name], [Description], [StartDate], [EndDate], [Cost], [CertificateId], [RequiredPoints], [MaxPoints]) VALUES (2, N'Large-scale C# designs', N'Excellent introduction to large-scale software modelling using C#', CAST(0x0000A2DA0148CFC8 AS DateTime), CAST(0x0000A2DB0148CFC8 AS DateTime), 300.0000, 9, 70, 100)
INSERT [dbo].[Trainings] ([TrainingId], [Name], [Description], [StartDate], [EndDate], [Cost], [CertificateId], [RequiredPoints], [MaxPoints]) VALUES (3, N'UML Modelling', N'Most important UML aspects', CAST(0x0000A2E0014C59A4 AS DateTime), CAST(0x0000A2E0014C59A4 AS DateTime), 50.0000, 11, 40, 100)
INSERT [dbo].[Trainings] ([TrainingId], [Name], [Description], [StartDate], [EndDate], [Cost], [CertificateId], [RequiredPoints], [MaxPoints]) VALUES (4, N'SCRUM', N'SCRUM Project Management', CAST(0x0000A2EE014E7E14 AS DateTime), CAST(0x0000A2D3014E7E14 AS DateTime), 300.0000, 15, 900, 1000)
INSERT [dbo].[Trainings] ([TrainingId], [Name], [Description], [StartDate], [EndDate], [Cost], [CertificateId], [RequiredPoints], [MaxPoints]) VALUES (5, N'Enterprise Java', N'Solid introduction to Java EE', CAST(0x0000A2F5014F373C AS DateTime), CAST(0x0000A2DB014F373C AS DateTime), 400.0000, 12, 65, 100)
INSERT [dbo].[Trainings] ([TrainingId], [Name], [Description], [StartDate], [EndDate], [Cost], [CertificateId], [RequiredPoints], [MaxPoints]) VALUES (6, N'Software Design Patterns', N'Introduction to software design patterns', CAST(0x0000A30F01501134 AS DateTime), CAST(0x0000A30F01501134 AS DateTime), 50.0000, NULL, 40, 100)
INSERT [dbo].[Trainings] ([TrainingId], [Name], [Description], [StartDate], [EndDate], [Cost], [CertificateId], [RequiredPoints], [MaxPoints]) VALUES (7, N'FCE English Course', N'FCE-level English course', CAST(0x0000A26900141504 AS DateTime), CAST(0x0000A2A500141504 AS DateTime), 1000.0000, 5, 70, 100)
SET IDENTITY_INSERT [dbo].[Trainings] OFF
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (3, 6)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (3, 8)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (3, 10)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (3, 11)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (3, 12)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (3, 14)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (3, 15)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (4, 6)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (4, 7)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (4, 8)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (4, 9)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (4, 11)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (4, 13)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (4, 15)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (5, 4)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (5, 6)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (6, 5)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (8, 5)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (9, 5)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (10, 10)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (10, 11)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (10, 13)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (12, 5)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (12, 14)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (13, 4)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (15, 4)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (15, 5)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (15, 6)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (15, 7)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (15, 11)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (15, 12)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (15, 13)
INSERT [dbo].[UserCertificates] ([UserId], [CertificateId]) VALUES (15, 15)
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (3, N'John', N'Tedding', CAST(0x4EFB0A00 AS Date), N'john.tedding@gmail.com', N'England', N'London', N'St. Peter''s', 5, NULL, N'430-1040')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (4, N'Martin', N'Mayer', CAST(0x00F10A00 AS Date), N'martin.mayer@gmail.com', N'United States', N'Los Angeles', N'Avenue 43', 13, 73, N'821-531A')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (5, N'Adam', N'Winiecki', CAST(0xBE130B00 AS Date), N'adam.winiecki@wp.pl', N'Poland', N'Warsaw', N'Piwnicka', 51, 7, N'42-512')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (6, N'Marcin', N'Skornicki', CAST(0x2BF90A00 AS Date), NULL, N'Poland', N'Gliwice', N'Bojkowska', 20, NULL, N'56-126')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (7, N'Agata', N'Biarnicka', CAST(0xBA180B00 AS Date), N'agata41@gmail.com', N'Poland', N'Katowice', N'Morcinka', 5, 8, N'40-086')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (8, N'Krzysztof', N'Morczak', CAST(0x5D0E0B00 AS Date), NULL, N'Poland', N'Czestochowa', N'Jasnogórska', 53, 5, N'51-316')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (9, N'Krzysztof', N'Damienowicz', CAST(0x2B110B00 AS Date), N'krzychu@hotmail.com', N'Poland', N'Gliwice', N'Dworcowa', 8, NULL, N'12-513')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (10, N'Marcin', N'Koblowicz', CAST(0x16080B00 AS Date), N'mkoblowicz@gmail.com', N'Poland', N'Warsaw', N'Wilczynska', 57, 42, N'51-251')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (11, N'Karol', N'Rogowicki', CAST(0x7B070B00 AS Date), N'karolrog@wp.pl', N'Poland', N'Siemianowice Slaskie', N'Kujawska', 12, 52, N'51-215')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (12, N'Hanna', N'Mielnicka', CAST(0xFE150B00 AS Date), N'hania40@gmail.com', N'Poland', N'Katowice', N'3-ego Maja', 51, 4, N'40-123')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (13, N'Robert', N'Rakowski', CAST(0xF8110B00 AS Date), N'rakowskir@gmail.com', N'Poland', N'Katowice', N'4231', 53, 4, N'53-513')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (14, N'Wojciech', N'Siwiec', CAST(0x63170B00 AS Date), N'siwy512@gazeta.pl', N'Poland', N'Chorzów', N'Katowicka', 45, 12, N'89-092')
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [BirthDate], [EmailAddress], [Country], [City], [Street], [HouseNumber], [FlatNumber], [PostCode]) VALUES (15, N'Tomasz', N'Nowak', CAST(0x570C0B00 AS Date), N'tomek.nowak@gmail.com', N'Germany', N'Berlin', N'Kugelstrasse', 54, NULL, N'A2-5123')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Trainees]  WITH CHECK ADD  CONSTRAINT [FK_Trainees_Trainings] FOREIGN KEY([TrainingId])
REFERENCES [dbo].[Trainings] ([TrainingId])
GO
ALTER TABLE [dbo].[Trainees] CHECK CONSTRAINT [FK_Trainees_Trainings]
GO
ALTER TABLE [dbo].[Trainees]  WITH CHECK ADD  CONSTRAINT [FK_Trainees_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Trainees] CHECK CONSTRAINT [FK_Trainees_Users]
GO
ALTER TABLE [dbo].[Trainers]  WITH CHECK ADD  CONSTRAINT [FK_Trainers_Trainings] FOREIGN KEY([TrainingId])
REFERENCES [dbo].[Trainings] ([TrainingId])
GO
ALTER TABLE [dbo].[Trainers] CHECK CONSTRAINT [FK_Trainers_Trainings]
GO
ALTER TABLE [dbo].[Trainers]  WITH CHECK ADD  CONSTRAINT [FK_Trainers_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Trainers] CHECK CONSTRAINT [FK_Trainers_Users]
GO
ALTER TABLE [dbo].[Trainings]  WITH CHECK ADD  CONSTRAINT [FK_Trainings_Certificates] FOREIGN KEY([CertificateId])
REFERENCES [dbo].[Certificates] ([CertificateId])
GO
ALTER TABLE [dbo].[Trainings] CHECK CONSTRAINT [FK_Trainings_Certificates]
GO
ALTER TABLE [dbo].[UserCertificates]  WITH CHECK ADD  CONSTRAINT [FK_UserCertificates_Certificates] FOREIGN KEY([CertificateId])
REFERENCES [dbo].[Certificates] ([CertificateId])
GO
ALTER TABLE [dbo].[UserCertificates] CHECK CONSTRAINT [FK_UserCertificates_Certificates]
GO
ALTER TABLE [dbo].[UserCertificates]  WITH CHECK ADD  CONSTRAINT [FK_UserCertificates_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UserCertificates] CHECK CONSTRAINT [FK_UserCertificates_Users]
GO
USE [master]
GO
ALTER DATABASE [EnterpriseTraining] SET  READ_WRITE 
GO
