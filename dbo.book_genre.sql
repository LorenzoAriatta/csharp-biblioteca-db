CREATE TABLE [dbo].[book_genre]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[book_id] INT NOT NULL,
	[genre_id] INT NOT NULL,
	CONSTRAINT [FK_book_id] FOREIGN KEY (book_id) REFERENCES [dbo].[books] ([Id]),
	CONSTRAINT [FK_genre_id] FOREIGN KEY (genre_id) REFERENCES [dbo].[genres] ([Id])
)