CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(100) NOT NULL,
	[LastName] VARCHAR(100) not null,
	[Birthdate] DATE NOT NULL, 
    [IsAsian] BIT NOT NULL
)
