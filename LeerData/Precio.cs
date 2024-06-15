using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class Precio
    {
        public int PrecioId{get;set;}
        public decimal PrecioActual{get;set;}
        public decimal Promocion{get;set;}
        public int CursoId{get;set;}
        //Para enlazarlo a nivel de objetos creamos una referencia del objecto de la clase curso
        public Curso Curso{get;set;}

    }
}