using System;
using api.Models;
using Microsoft.EntityFrameworkCore;

/*
    Desde aquí gestionamos lo que son las entidades de la base de datos. Al añadir un DbSet lo que hacemos es crear
    la entidad en base al modelo que le pasemos. En este caso tengo dos modelos: Comment y Stock. con esto bastará para usar
    el comando:
        dotnet migrations add init
    Y debería empezar a hacer las migraciones.

    En caso de lanzar un error de dotnet use:
        dotnet tool install dotnet-ef
*/
namespace api.Data
{
    /* Este es el contextualizador de nuestra app para la conexión con la base de datos. */
    public class AplicationDBContext : DbContext
    {
        // Constructor
        public AplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Comment> Comments {get; set;}
        public DbSet<Stock> Stocks{get; set;}
        
    }
}