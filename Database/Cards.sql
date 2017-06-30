CREATE TABLE [dbo].[Cards]
(
    [Name] NCHAR(10) NOT NULL, 
    [Type] NCHAR(10) NULL, 
    [Strength] INT NULL, 
    [Defense] INT NULL, 
    [Mana Cost] INT NULL, 
    [Artwork] NCHAR(10) NULL, 
    PRIMARY KEY ([Name])
)
