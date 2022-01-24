using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Customer
    {
        //Bir müşterinin özelliklerini, bilgilerini tutmak için kullanılır

        //Property 
        public int Id { get; set; }
        private string _firstname;
        public string FirstName
        {
            //bir field üzerinde ekleme yapmak istersek bunu kullanabiliriz
            //Çok fazla kullanılan bir şey değildir
            get { return "Mrs." + _firstname; }
            set { _firstname = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }

        //Field
        //public string FirstName;  
    }
}
