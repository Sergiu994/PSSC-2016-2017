create proc proc_materii
As
Begin
SELECT [PSSC].[dbo].[Materia].[Nume materie],[PSSC].[dbo].[Proffessor].Nume,Materia.[Numar credite],Materia.Proportia,Materia.[Tipul evaluarii]
FROM [PSSC].[dbo].[Materia]
INNER JOIN [PSSC].[dbo].[Proffessor]
ON [PSSC].[dbo].[Materia].IDProfesor=[PSSC].[dbo].[Proffessor].IDProfesor;
end