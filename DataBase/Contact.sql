CREATE TABLE [dbo].[Contact]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Adresa] NVARCHAR(MAX) NULL, 
    [Emailuri] NVARCHAR(MAX) NULL, 
    [TelefonAcasa] NCHAR(10) NULL, 
    [TelefonMobil] NCHAR(10) NULL
)
