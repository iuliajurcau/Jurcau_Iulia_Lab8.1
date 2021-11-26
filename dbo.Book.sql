CREATE TABLE [dbo].[Book] (
    [ID]     INT             IDENTITY (1, 1) NOT NULL,
    [Title]  NVARCHAR (MAX)  NULL,
    [Author] NVARCHAR (MAX)  NULL,
    [Price]  DECIMAL (18, 2) NOT NULL,
	[PublishingDate] DECIMAL (6, 2) NOT NULL,
	
    CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED ([ID] ASC)
);

