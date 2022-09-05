using System;
using System.Collections.Generic;
namespace SRP
{
    public class Bookstore
    {
    
        public string Name;
        public Dictionary<Tuple<string, string>, List<Book>> Dicc;
        
        
        
        public Bookstore(string name)
        {
            
            this.Name=name;
            
            var dicLibros = new Dictionary<Tuple<string, string>, List<Book>>();  //crea el diccionario donde se almacena los libros
            this.Dicc=dicLibros;
            

        }
        
        public void ShelveBook(Book book2store,String sector, String shelve)
        {
                 
            var ubicacion = Tuple.Create(sector,shelve);
            try
            {
                this.Dicc[ubicacion].Add(book2store);    //Lo añade a una ubicacion existente
            }
            catch{
                this.Dicc.Add(ubicacion,new List<Book>{book2store});  //lo añade a una nueva ubicacion
            }
                                              
        }
    }
}
