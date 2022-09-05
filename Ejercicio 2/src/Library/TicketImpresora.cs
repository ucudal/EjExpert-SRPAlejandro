using System;
using System.Text;

namespace Library
{
    public class TicketImpresora
    {
        public static void Imprimir(string Txt)
        {

            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n"); 
            stringBuilder.Append(Txt);
            Console.WriteLine(stringBuilder.ToString());
          
            
        }

    }
}
