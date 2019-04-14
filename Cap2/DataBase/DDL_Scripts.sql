EXEC usp_GetAll 'AERO%'
go

CREATE PROCEDURE usp_GetAll
(
	@filterByName NVARCHAR(100)
)
AS
	BEGIN

		SELECT * FROM Artist
		WHERE NAME like @filterByName
	END
GO

