CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Age] INT NULL, 
    [Sex] VARCHAR(50) NULL, 
    [Purpose] VARCHAR(100) NULL, 
    [Doctor] VARCHAR(50) NULL, 
    [Date] TIMESTAMP NULL, 
    [Time] VARCHAR(50) NULL, 
    [Status] VARCHAR(50) NULL
)
