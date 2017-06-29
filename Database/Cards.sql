CREATE TABLE [dbo].[Cards]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NULL, 
    [Type] NCHAR(10) NULL, 
    [Strength] TINYINT NULL, 
    [Defense] TINYINT NULL, 
    [Mana Cost] TINYINT NULL, 
    [Artwork] NCHAR(10) NULL
)
