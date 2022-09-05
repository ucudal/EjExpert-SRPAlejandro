using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            
        }
    }
}
