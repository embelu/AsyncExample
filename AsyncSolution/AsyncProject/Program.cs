using System;
using System.Threading;

namespace AsyncProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début du programme");
            AppelTache1();
            AppelTache2();

            Console.WriteLine("Fin du programme");
            Console.ReadKey();
        }


        public static void AppelTache1()
        {
            AppelMethode1();
            Console.WriteLine("  FIN DE LA TACHE 1");
        }

        public static void AppelTache2()
        {
            AppelMethode2();
            Console.WriteLine("  FIN DE LA TACHE 2");
        }

        public static void AppelMethode1()
        {
            Thread.Sleep(6000);
        }

        public static void AppelMethode2()
        {
            Thread.Sleep(4000);
        }
    }
}
