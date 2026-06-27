using System;
using System.ComponentModel.DataAnnotations.Schema;


/*
    Modelo simple para una tabla en una base de datos, se crean los atributos y sus getters and setters 
    respectivos.
*/
namespace api.Models
{
    public class Stock
    {
        // Se crean los atributos de la clase
        public int Id {get; set;}
        public string Symbol {get;set;} = string.Empty;
        public string Company {get; set;} = string.Empty;
        
        [Column(TypeName ="decimal(18,2)")]
        public decimal Purchase {get; set;}
        [Column(TypeName ="decimal(18,2)")]
        public decimal LastDiv {get; set;}
        public string? Industry { get; set; }
        public long MarketCap { get; set; }

        /* Relación de uno a muchos

            Stock 1 - N Comentrios
        */
        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}