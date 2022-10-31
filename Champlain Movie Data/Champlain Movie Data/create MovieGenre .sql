CREATE TABLE [dbo].[MovieGenre] (
	[MovieGenreId] INT IDENTITY (1, 1) NOT NULL, 
    [MovieId] INT NOT NULL, 
    [GenreId] INT NOT NULL, 
    CONSTRAINT [FK_Genre_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movie]([MovieId]), 
    CONSTRAINT [FK_Genre_GenreId] FOREIGN KEY ([GenreID]) REFERENCES [Genre]([GenreId])
)
