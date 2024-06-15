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
        //Poner como entidad a la clase curso y precio 
        public DbSet<Curso> Curso{get;set;}
        public DbSet<Precio> Precio{get;set;}
        public DbSet<Comentario> Comentario{get;set;}
    }
}