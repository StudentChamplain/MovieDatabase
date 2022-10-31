CREATE TABLE [dbo].[Role] (
	[RoleId] INT IDENTITY (1, 1) NOT NULL, 
    [MovieId] INT NOT NULL, 
    [ActorId] INT NOT NULL, 
    CONSTRAINT [FK_Role_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movie]([MovieId]), 
    CONSTRAINT [FK_Role_ActorId] FOREIGN KEY ([ActorID]) REFERENCES [Actor]([ActorId]), 
    CONSTRAINT [PK_Role] PRIMARY KEY ([RoleId])
)