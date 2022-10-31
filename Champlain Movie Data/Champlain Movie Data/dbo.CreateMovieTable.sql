CREATE TABLE [dbo].[MovieTable] (
    [MovieId]    INT           IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (50) NOT NULL,
    [Year]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

