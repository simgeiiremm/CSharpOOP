using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    /*CLASSES
En temel unsur 
Yapmak istediğimiz işlemleri gruplara ayırmak ve rahatlıkla bu gruba ulaşmak için kullanabiliriz
Class içerisine methodlar yazılır ex. public void Add();
Main'de class'ı her zaman new'le kullan!! ex. pascalcase = CustomerManager camelcase = customerManager
ex. CustomerManager customerManager = new CustomerManager();
Class'ları başka bir dosya olarak çalıştırabiliriz
Bir diğer özellikleri de property olarak tutmak

*/
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();   
            productManager.Add();   
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.City = "Ankara";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Derin", LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName); //Derin



            Console.ReadLine();
        }
    }
 
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!!");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated");
        }

    }
}
