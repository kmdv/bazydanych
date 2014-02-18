CREATE TABLE [dbo].[Trainings]
(
	[TrainingId] INT NOT NULL PRIMARY KEY IDENTITY(0, 1), 
    [Name] VARCHAR(255) NOT NULL, 
    [Description] VARCHAR(MAX) NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL, 
    [Cost] MONEY NOT NULL, 
    [CertificateId] INT NOT NULL, 
    [RequiredPoints] INT NOT NULL, 
    [MaxPoints] INT NOT NULL, 
    CONSTRAINT [FK_Trainings_Certificates] FOREIGN KEY ([CertificateId]) REFERENCES [Certificates]([CertificateId])
)
