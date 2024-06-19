-- Este comando ALTER TABLE agrega una restricci�n de clave externa a la tabla CursoInstructor.
ALTER TABLE CursoInstructor
    -- Aqu� se nombra la restricci�n como FK_CURSO_INSTRUCTOR_INSTRUCTOR_ID    
    ADD CONSTRAINT FK_CURSO_INSTRUCTOR_INSTRUCTOR_ID
    -- Esta l�nea especifica que la columna InstructorId en la tabla CursoInstructor       
    -- va a hacer referencia a la columna InstructorId en la tabla Instructor     
    FOREIGN KEY(InstructorId) REFERENCES Instructor(InstructorId);
