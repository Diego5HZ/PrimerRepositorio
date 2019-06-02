alter procedure usp_Insert_Alumnos
(
	@Nombres NVARCHAR(50),
	@Apellidos NVARCHAR(50),
	@Direccion NVARCHAR (100),
	@Sexo		NCHAR(1),
	@FechaNacimiento datetime
)
AS
	BEGIN

	INSERT  INTO Alumno (Nombres,Apellidos,Direccion,Sexo,FechaNacimiento)
	VALUES	(@Nombres,@Apellidos,@Direccion,@Sexo,@FechaNacimiento)
	SELECT SCOPE_IDENTITY()

	END
GO

CREATE PROCEDURE usp_GetAll_Alumnos
(
	@filterByName NVARCHAR(100)
)
AS
	BEGIN

		SELECT * FROM Alumno
		WHERE NOMBRES like @filterByName
	END
GO


create procedure usp_Insert_Notas
(
	@AlumnoId Int,
	@CursoId Int,
	@Nota	Int
)
AS
	BEGIN

	INSERT INTO Notas(AlumnoID,CursoID,Nota)
	VALUES (@AlumnoId,@CursoId,@Nota)
	SELECT SCOPE_IDENTITY()

	END
GO

Alter PROCEDURE usp_Insert_Notas
(
	@pAlumnoId	INT,
	@pCursoId INT,
	@pNota INT
)
AS
	BEGIN
		INSERT INTO Notas(AlumnoID, CursoID, Nota)
		VALUES (@pAlumnoId, @pCursoId,@pNota)
		SELECT SCOPE_IDENTITY()
	END
GO

alter PROCEDURE usp_GetNotasAlumnos
(
	@pCurso NVARCHAR(100),
	@pGrado NVARCHAR(10)
)
AS BEGIN
SELECT      B.Nombre, 
			A.Nivel,
			D.AlumnoID, 
			D.Nombres, 
			D.Apellidos,  
			C.Nota
			
FROM            dbo.Grado AS A INNER JOIN
                dbo.Curso AS B ON A.GradoID = B.GradoID INNER JOIN
                dbo.Notas AS C ON B.CursoID = C.CursoID INNER JOIN
                dbo.Alumno AS D ON C.AlumnoID = D.AlumnoID
WHERE	B.Nombre LIKE @pCurso AND
		A.Nivel LIKE @pGrado
ORDER BY B.Nombre,
		 A.Nivel
END

GO



