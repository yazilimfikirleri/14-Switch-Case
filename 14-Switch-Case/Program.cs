using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch Case
            /*
             çok sayıda koşul kontrolü barındıran işlemlerde  if-else yapısı ile kod akışı izlenmesi zorlaşabilir. Bu tip durumlarda switch-case yapısı ile verilen değeri yapı içerisinde işaretleyerek gelen değere göre doğrudan yönlendirme yaptırabiliriz.
             */

            //Örn.
            //dışarıdan gelen sayıya göre o sayıyı temsil eden ay'ı console ekranında gösterin.
            //1=> Ocak
            //2=> Şubat
            //3=> Mart
            //4=> Nisan
            //5=> Mayıs
            //6=> Haziran
            //7=> Temmuz
            //8=> Ağustos
            //9=> Eylül
            //10=> Ekim
            //11=> Kasım
            //12=< Aralık

            //string gelenDeger;
            //Console.WriteLine("Ay no girin...");
            //gelenDeger = Console.ReadLine();

            //switch (gelenDeger)//1
            //{
            //    case "1":
            //        Console.WriteLine("Ocak");
            //        break;
            //    case "2":
            //        Console.WriteLine("Şubat");
            //        break;
            //    case "3":
            //        Console.WriteLine("Mart");
            //        break;
            //    case "4":
            //        Console.WriteLine("Nisan");
            //        break;
            //    case "5":
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case "6":
            //        Console.WriteLine("Haziran");
            //        break;
            //    case "7":
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case "8":
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case "9":
            //        Console.WriteLine("Eylül");
            //        break;
            //    case "10":
            //        Console.WriteLine("Ekim");
            //        break;
            //    case "11":
            //        Console.WriteLine("Kasım");
            //        break;
            //    case "12":
            //        Console.WriteLine("Aralık");
            //        break;
            //}
            //Console.Read();

            //Örn.; 
            //giriş yapan kullanıcının rolü admin ise; "yönetim sayfasına yönlendiriliyorsunuz",
            //kullanıcı ise "kullanıcı paneline yönlendiriliyorsunuz",
            //tedarikci ise "tedarikci sayfasına yönlendiriliyorsunuz",
            //nakliyeci ise "nakliyeci sayfasına yönlendiriliyorsunuz"
            //uyarısını console ekranında gösteren uygulama.

            string login;
            Console.WriteLine("Kullanıcı rolü girin...");
            login = Console.ReadLine();

            switch (login.ToLower())//admin
            {
                case "admin":
                    Console.WriteLine("yönetim sayfasına yönlendiriliyorsunuz");
                    break;
                case "kullanıcı":
                    Console.WriteLine("kullanıcı paneline yönlendiriliyorsunuz");
                    break;
                case "tedarikci":
                    Console.WriteLine("tedarikci sayfasına yönlendiriliyorsunuz");
                    break;
                case "nakiyeci":
                    Console.WriteLine("nakliyeci sayfasına yönlendiriliyorsunuz");
                    break;
                default:
                    Console.WriteLine("böyle bir kullanıcı rolü bulunmamaktadır.");
                    break;

            }
            Console.Read();
        }
    }
}
