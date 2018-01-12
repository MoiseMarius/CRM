CREATE TABLE [dbo].[Login] (
	[ID] INT NOT NULL PRIMARY KEY
	,[PersonID] INT NOT NULL
	,FOREIGN KEY ([PersonID]) REFERENCES [Person]([ID])
	,[username] NVARCHAR(50) NULL
	,[password] NVARCHAR(MAX) NULL
	)
