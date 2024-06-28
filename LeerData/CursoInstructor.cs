using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class CursoInstructor
    {
        public int InstructorId{get;set;}
        public int CursoId{get;set;}
        //Ancla que va enlazar la clase CursoInstructor con Curso
        public Curso Curso{get;set;}
        public Instructor Instructor {get;set;}
    }
}