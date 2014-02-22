CREATE TABLE [dbo].[Certificates]
(
	[CertificateId] INT NOT NULL PRIMARY KEY IDENTITY(0, 1), 
    [Name] VARCHAR(255) NOT NULL, 
    [ValidityYears] INT NOT NULL
)
