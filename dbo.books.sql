CREATE TABLE [dbo].[books]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[title] VARCHAR(100) NOT NULL,
	[author] VARCHAR(60) NOT NULL,
	[year] INT NOT NULL,
	[plot] TEXT NOT NULL,
	[age_range] INT NOT NULL
)
