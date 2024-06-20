using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class Curso
    {
        public int CursoId{get;set;}
        public string Titulo{get;set;}
        public string Descripcion{get;set;}
        public System.DateTime FechaPublicacion{get;set;}
        //Atraves de esta propiedad puedo intanciar valores de precio
        public Precio PrecioPromocion{get;set;}
        //Atraves de esta propiedad me permite almacenar la lista de comentario dentro de clase curso 
        public ICollection<Comentario> ComentarioLista {get;set;}
        public ICollection<CursoInstructor> InstructorLink {get;set;}
    }
}