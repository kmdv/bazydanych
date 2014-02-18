CREATE TABLE [dbo].[Users]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY(0, 1), 
    [FirstName] VARCHAR(63) NULL, 
    [LastName] VARCHAR(63) NULL, 
    [BirthDate] DATE NOT NULL, 
    [EmailAddress] VARCHAR(255) NULL, 
    [Country] VARCHAR(255) NULL, 
    [City] VARCHAR(255) NULL, 
    [Street] VARCHAR(255) NULL, 
    [HouseNumber] INT NULL, 
    [FlatNumber] INT NULL, 
    [PostCode] VARCHAR(31) NULL
)
