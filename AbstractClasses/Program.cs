using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{

    //Interface ve virtual methodların birleşimi gibi düşünebiliriz
    //Tamamen inheritance amacıyla kullanılır
    //abstract dedğimiz şey içi dolu olmayan virtual methoddur
    //interface'ler gibi abstract classlarda new'lenemez
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new OracleServer();
            database.Add();
            database.Delete();

            Database database1 = new SqlServer();    
            database1.Add();    
            database1.Delete();

            Console.ReadLine();
        }
    }
    abstract class Database
    {
        public void Add() //ekleme işlemi her yerde aynı
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete(); //silme işlemi bütün veri tabanlarında farklı
        
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }
    class OracleServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
