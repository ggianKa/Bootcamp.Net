using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class Comentario
    {
        public int ComentarioId {get;set;}
        public string Alumno {get;set;}
        public int Puntaje {get;set;}
        public string ComentarioTexto {get;set;}
        public int CursoId{get;set;}
        //Ancla para que esten relacionado entre si 
        public Curso Curso {get;set;}
    }
}