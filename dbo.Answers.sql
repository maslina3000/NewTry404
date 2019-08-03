CREATE TABLE [dbo].[Answers] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NOT NULL,
    [Age]           INT            NOT NULL,
    [Gender]        NVARCHAR (MAX) NOT NULL,
    [BirthDate]     DATETIME2 (7)  NOT NULL,
    [MaritalStatus] NVARCHAR (MAX) NOT NULL,
    [Programming]   NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Answers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

