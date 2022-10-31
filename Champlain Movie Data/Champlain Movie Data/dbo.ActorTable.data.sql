﻿CREATE TABLE [dbo].[Actor] (
    [ActorId]   INT          IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50) NOT NULL,
    [BirthYear] VARCHAR (4)         NOT NULL,
    [DeathYear] VARCHAR (4)         NULL,
    PRIMARY KEY CLUSTERED ([ActorId] ASC)
);



