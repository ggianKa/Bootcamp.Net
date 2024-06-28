using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentaCursosContext : DbContext    
    {
        private const string connectionString = @"Data Source=PC-SI-TIC-001\SQLEXPRESS; Initial Catalog=CursosOnline; Integrated Security=True; TrustServerCertificate=True";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        /*
        Protegido: solamente clase que hereden van obtner acceso
        Override: Estamos sobreescribiendo un metodo que previamente fue declarado por una clase padre DbContext
        */
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.CursoId, ci.InstructorId});
        }

        //Poner como entidad a la clase curso y precio 
        public DbSet<Curso> Curso {get;set;}
        public DbSet<Precio> Precio {get;set;}
        public DbSet<Comentario> Comentario {get;set;}
        public DbSet<Instructor> Instructor {get;set;}
        public DbSet<CursoInstructor> CursoInstructor {get;set;}
    }
}