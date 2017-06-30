CREATE TABLE [dbo].[Cards] (
    [Name]      NCHAR (10) NOT NULL,
    [Type]      NCHAR (10) NULL,
    [Strength]  TINYINT    NULL,
    [Defense]   TINYINT    NULL,
    [Mana Cost] TINYINT    NULL,
    [Artwork]   NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

