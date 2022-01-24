using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    /* S — Single-responsibility principle
    ÖZET: Bir sınıf(nesne) yalnızca bir amaç uğruna değiştirilebilir, o da o sınıfa yüklenen sorumluluktur, 
    yani bir sınıfın(fonksiyona da indirgenebilir) yapması gereken yalnızca bir işi olması gerekir.
 
    O — Open-closed principle
    ÖZET: Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir.
    Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır.
 
    L — Liskov substitution principle
   ÖZET: Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, 
    türedikleri(üst) sınıfların yerine kullanabilmeliyiz.
 
    I — Interface segregation principle
    ÖZET: Sorumlulukların hepsini tek bir arayüze toplamak 
    yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız.
 
    D — Dependency Inversion Principle
    ÖZET: Sınıflar arası bağımlılıklar olabildiğince az olmalıdır 
    özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
