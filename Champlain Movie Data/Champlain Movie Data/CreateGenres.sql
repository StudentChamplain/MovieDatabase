CREATE TABLE [dbo].[Genre] (
    [GenreId] INT           IDENTITY (1, 1) NOT NULL,
    [Genre]   NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([GenreId] ASC)
);

