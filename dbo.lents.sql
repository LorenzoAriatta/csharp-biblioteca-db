CREATE TABLE [dbo].[lents]
(
	[Id] INT NOT NULL PRIMARY KEY,
    CONSTRAINT [FK_copy_id] FOREIGN KEY ([id]) REFERENCES [copies]([id]), 
    CONSTRAINT [FK_user_id] FOREIGN KEY ([id]) REFERENCES [users]([id]), 
	[start] DATE NOT NULL,
	[end] DATE NOT NULL,
)
