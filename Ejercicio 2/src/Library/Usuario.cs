using System;
using System.Text;

namespace Library
{
    public class Usuario
    {
        private string name;
        private string id;
        private string phoneNumber;
        public Usuario(string Name, string Id,string PhoneNumber)
        {
            this.name=Name;
            this.id=Id;
            this.phoneNumber=PhoneNumber;

        }

    }
}
