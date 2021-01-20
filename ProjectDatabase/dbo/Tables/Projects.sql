CREATE TABLE [dbo].[Projects]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Namn] VARCHAR(MAX) NOT NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [InitialDate] DATE NOT NULL, 
    [LastUpdatedDate] DATE NOT NULL, 
    [Language] VARCHAR(MAX) NULL
)
