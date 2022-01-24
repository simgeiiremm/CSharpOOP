using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPerson person = new IPerson(); //instance oluşturulmaz
            #region Interface Customer PersonManager Ornegi
            //PersonManager manager = new PersonManager();
            //Customer customer = new Customer
            //{
            //    Id=1,
            //    FirstName = "Engin",
            //    LastName = "Demiroğ",
            //    Address = "Ankara"
            //};

            //Student student = new Student()
            //{
            //    Id=1,
            //    FirstName="Derin",
            //    LastName= "Demiroğ",
            //    Department = "Computer Sciences"
            //};
            //manager.Add(student); //PersonManager'da interface olarak parametre gönderdigimiz için kullanabiliriz
            //manager.Add(customer);

            ////manager.Add(new Customer
            ////{
            ////    Id=1,
            ////    FirstName = "Engin",
            ////    LastName = "Demiroğ",
            ////    Address = "Ankara"
            ////});
            #endregion

            #region ICustomerDal Kullanımı
            /*
             CustomerManager customerManager = new CustomerManager();
             customerManager.Add(new OracleCustomerDal()); //uygulamanın bağımlılıklarını sıfıra(miniminize etmek) indirmek
            */
            #endregion

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };
            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }
    }
    //Temel nesne oluşturup bütün nesneleri implemente etmektir
    interface IPerson //soyut nesne tek başına bir şey ifade etmez
                      //Burada tanımlanan her şeyi classlarda çağırabiliriz
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person) //nesneyi parametre yaptık
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
