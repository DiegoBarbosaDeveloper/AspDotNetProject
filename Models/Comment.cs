using System;

/*
    Modelo simple para una tabla en una base de datos, se crean los atributos y sus getters and setters 
    respectivos.
*/
namespace api.Models{

    public class Comment
    {   
        public int Id { get; set; }
        public int? StockId { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        //La diferencia entre estos dos strings es que uno no quedará nulo mientras
        //el otro sí, el primero simplemente quedará como "" y el otro sí será nulo (eso creo xd)
        public string Title { get; set; } = string.Empty;
        public string? Massage { get; set; } 

    }

}