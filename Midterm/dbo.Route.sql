CREATE TABLE [dbo].[Route]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NULL, 
    [Map] IMAGE NULL, 
    [Description] NVARCHAR(1000) NULL, 
    [Price] DECIMAL NULL
)
