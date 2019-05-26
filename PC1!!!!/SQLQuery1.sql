create procedure usp_Insert_Alumnos
(
	@Nombre NVARCHAR(50),
	@Apellido NVARCHAR(50),
	@Direccion NVARCHAR (100),
	@Sexo		NCHAR(1),
	@FechaNacimiento datetime
)
AS
	BEGIN

	INSERT  Alumno (Nombres,Apellidos,Direccion,Sexo,FechaNacimiento)
	VALUES	(@Nombre,@Apellido,@Direccion,@Sexo,@FechaNacimiento)
	SELECT SCOPE_IDENTITY()

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