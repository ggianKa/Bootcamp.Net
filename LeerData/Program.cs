using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Creo mi instancia de mi clase AppVentaCursosContext */
            // using(var db = new AppVentaCursosContext()){
            //     /*
            //     Esta variable cursos almacenara toda la data del sql
            //     con AsNoTracking pido la data y me lo entrega inmediatamente
            //     */
            //     var cursos = db.Curso.AsNoTracking(); //arreglo IQueryable 
            //     foreach(var curso in cursos){
            //         Console.WriteLine(curso.Titulo + "----" + curso.Descripcion);
            //     }

            //Query que me permite devolver datos de estas dos entidades
            // using(var db = new AppVentaCursosContext()){
            //     var cursos = db.Curso.Include(p => p.PrecioPromocion).AsNoTracking(); //AsNoTracking para que no almacene nada en caché   
            //     foreach(var curso in cursos){
            //         Console.WriteLine(curso.Titulo + "--------" + curso.PrecioPromocion.PrecioActual);
            //     }

            // }

            // Utilizamos 'using' para asegurarnos de que el contexto de la base de datos se elimine correctamente después de su uso.
            using (var db = new AppVentaCursosContext())
            {
                // Consultamos la base de datos para obtener todos los cursos, incluyendo la lista de comentarios relacionados.
                var cursos = db.Curso.Include(c => c.ComentarioLista).AsNoTracking();

                // Iteramos a través de cada curso obtenido de la base de datos.
                foreach (var curso in cursos)
                {
                    // Mostramos el título del curso en la consola.
                    Console.WriteLine(curso.Titulo);

                    // Iteramos a través de la lista de comentarios asociados a este curso.
                    foreach (var comentario in curso.ComentarioLista)
                    {
                        // Mostramos cada comentario precedido por un separador.
                        Console.WriteLine("**************" + comentario.ComentarioTexto);
                    }
                }
            }

        }
    }
}