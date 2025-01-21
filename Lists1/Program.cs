using System;
using System.Collections.Generic;

namespace PatikaPlusGala
{
    class Program
    {
        static void Main(string[] args)
        {
            // Davetli listesi oluşturma (List kullanımı daha esnektir)
            List<string> davetliler = new List<string>()
            {
                "Bülent Ersoy",
                "Ajda Pekkan",
                "Ebru Gündeş",
                "Hadise",
                "Hande Yener",
                "Tarkan",
                "Funda Arar",
                "Demet Akalın"
            };

            // Foreach döngüsü ile listedeki tüm davetlileri ekrana yazdırma
            Console.WriteLine("Patika Plus Gala Gecesi Davetlileri:");
            foreach (string davetli in davetliler)
            {
                Console.WriteLine(davetli);
            }
        }
    }
}