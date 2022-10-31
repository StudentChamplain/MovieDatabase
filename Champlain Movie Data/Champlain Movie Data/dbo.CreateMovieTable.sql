CREATE TABLE [dbo].[Movie] (
    [MovieId]    INT           IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (50) NOT NULL,
    [Year]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([MovieId] ASC)
);

