CREATE VIEW [dbo].[Clasament]
AS
SELECT TOP (3) [Titlu]
	,[Nume]
	,[Prenume]
	,[Ocupatie]
	,[NumeActivitate]
	,[ScorActivitate] * (
		SELECT [Multiplicator]
		FROM [dbo].[TipuriDeActivitati]
		WHERE [ID] = a.CategorieActivitate
		) AS Punctaj
FROM [dbo].[Person] p
INNER JOIN [dbo].[Activitati] a ON p.ID = a.PersonID
GROUP BY [CategorieActivitate]
	,[Titlu]
	,[Nume]
	,[Prenume]
	,[Ocupatie]
	,[ScorActivitate]
	,[NumeActivitate]
ORDER BY Punctaj DESC
