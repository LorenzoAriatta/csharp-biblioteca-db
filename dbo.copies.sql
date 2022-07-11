CREATE TABLE [dbo].[copies]
(
	[Id] INT NOT NULL PRIMARY KEY,
    CONSTRAINT [FK_book_id] FOREIGN KEY ([id]) REFERENCES [books]([id]),
    CONSTRAINT [FK_condition_id] FOREIGN KEY ([id]) REFERENCES [conditions]([id]),
	[library_code] VARCHAR(10) NOT NULL,
	[publisher] VARCHAR(50) NOT NULL,
	[language] VARCHAR(3) NOT NULL,
	[isbn] VARCHAR(13) NOT NULL,
	[pages] INT NOT NULL
)
