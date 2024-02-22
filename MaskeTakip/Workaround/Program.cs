using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string mesaj = "Merhaba";
            //double tutar = 10000;
            //int sayi = 100;
            //bool girisYapmisMi = false;

            //string ad = "Ömer";
            //string soyad = "Güç";
            //int dogumYili = 1985;
            //long tcNo = 32495386;


            //Console.WriteLine(tutar * 1.85);

            //Console.WriteLine("Hello World!");

            //Vatandas vatandas1 = new Vatandas();

            selamVer("ömer");
            selamVer();

            int sonuc = Topla(3,5);

            string ogrenci1 = "Ömer";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Engin";

            string[] ogrenciler = new string[3];
            
            ogrenciler[0] = "Ömer";
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Kerem";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] {"Ankara","İstanbul","İzmir"};
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };


            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Engin";

            Person person2 = new Person();
            person2.FirstName = "Ömer Faruk";
            person2.LastName = "Güç";
            person2.DateOfBirthYear = 2000;
            person2.NationalIdentity = 35289566484;


            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> {"Ankara 1", "İstanbul 1","İzmir 1"};
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person2);

            Console.ReadLine();
        }

        static void selamVer(string isim="noname")
        {
            Console.WriteLine("Merhaba" + isim);
        }
        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine( "Toplam : " + sonuc.ToString());
            return sonuc;
        }


    }
    //public class Vatandas
    //{
    //    public string ad = "Ömer";
    //    public string soyad = "Güç";
    //    public int dogumYili = 1985;
    //    public long tcNo = 32495386;

    //}


}
