-- Este comando ALTER TABLE agrega una restricción de clave externa a la tabla CursoInstructor.
ALTER TABLE CursoInstructor
--Aqui se nombra el nombre de la llave foranea 
	ADD CONSTRAINT FK_CURSO_INSTRUCTOR_CURSOID
	--Esta linea especifica que la columna CursoId de la tabla CursoInstructor va hacer referencia 
	--a la columba CursoId de la tabla Curso.
		FOREIGN KEY(CursoId) REFERENCES dbo.Curso(CursoId) 