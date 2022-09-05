using System;
using System.Collections.Generic;
using SRP;

public class Program
{
	public static void Main()
	{
        Bookstore Central = new Bookstore("central");//crea un lugar de almacen de libros
		Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");//crea el libro1
        Book book2 = new Book("Pro C#","Troelsen","001-035");//crea el libro2
        Central.ShelveBook(book1,"A","7");//guarda libro1
        Central.ShelveBook(book2,"B","3");//guarda libro2     
	}
}
           
            


