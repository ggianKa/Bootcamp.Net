-- Este comando ALTER TABLE agrega una restricción de clave externa a la tabla CursoInstructor.
ALTER TABLE CursoInstructor
    -- Aquí se nombra la restricción como FK_CURSO_INSTRUCTOR_INSTRUCTOR_ID    
    ADD CONSTRAINT FK_CURSO_INSTRUCTOR_INSTRUCTOR_ID
    -- Esta línea especifica que la columna InstructorId en la tabla CursoInstructor       
    -- va a hacer referencia a la columna InstructorId en la tabla Instructor     
    FOREIGN KEY(InstructorId) REFERENCES Instructor(InstructorId);
