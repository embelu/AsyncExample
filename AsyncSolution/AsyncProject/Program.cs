using System;
using System.Threading;
using System.Threading.Tasks;

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


        public static async void AppelTache1()
        {
            await Task.Run(() => AppelMethode1());
            Console.WriteLine("  FIN DE LA TACHE 1 (6 sec)");
        }

        public static async void AppelTache2()
        {
            await Task.Run(() => AppelMethode2());
            Console.WriteLine("  FIN DE LA TACHE 2 (4 sec)");
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
