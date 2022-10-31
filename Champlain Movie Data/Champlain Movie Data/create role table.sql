CREATE TABLE [dbo].[Role]
(
	[RoleId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MovieId] INT NOT NULL, 
    [ActorId] INT NOT NULL, 
    CONSTRAINT [FK_Role_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movie]([MovieId]), 
    CONSTRAINT [FK_Role_ActorId] FOREIGN KEY ([ActorID]) REFERENCES [Actor]([ActorId])
)