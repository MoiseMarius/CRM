CREATE TABLE [dbo].[Contact] (
	[ID] INT IDENTITY(1, 1) PRIMARY KEY
	,[PersonID] INT NOT NULL
	,FOREIGN KEY ([PersonID]) REFERENCES [Person]([ID])
	,[Adresa] NVARCHAR(MAX) NULL
	,[Emailuri] NVARCHAR(MAX) NULL
	,[TelefonAcasa] NVARCHAR(MAX) NULL
	,[TelefonMobil] NVARCHAR(MAX) NULL
	)
