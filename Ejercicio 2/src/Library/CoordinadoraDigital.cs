using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        
        public static void CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            Usuario us1=new Usuario(name,id,phoneNumber);
            string paraImprimir=Verificadora.Verificar(name,id,phoneNumber,date,appoinmentPlace,doctorName);
            TicketImpresora.Imprimir(paraImprimir);

           
           
        }

    }
}
