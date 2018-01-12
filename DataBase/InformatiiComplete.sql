CREATE VIEW [dbo].[InformatiiComplete]
AS
SELECT p.ID
	,p.Titlu
	,p.Nume
	,p.Prenume
	,c.Adresa
	,p.DataNasterii
	,p.Sex
	,p.Ocupatie
	,c.Emailuri
	,c.TelefonMobil
	,c.TelefonAcasa
FROM [Person] p
INNER JOIN [Contact] c ON p.ID = c.ID
