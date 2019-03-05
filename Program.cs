using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDiagramAktywnosci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz klawisz 'S'");
            ConsoleKeyInfo start = Console.ReadKey(true);
            if (start.Key == ConsoleKey.S)
            {
                Console.WriteLine("Kierownik rozpoczął pracę");
            }
            Console.WriteLine("Wybierz klawisz 'P' aby wydać polecenia pracownikom");
            ConsoleKeyInfo command = Console.ReadKey(true);
            if (start.Key == ConsoleKey.P)
            {
                Magazyn magazyn = new Magazyn();
                if (magazyn.pracownicy != null)
                {
                    var task = new Tasks();
                    var tasks = new List<ITasks>();
                    tasks.Add(new Rozładunki());
                    tasks.Add(new Załadunki());
                    tasks.Add(new NoweZamówienia());
                    Console.WriteLine(task.DoTask(tasks));
                }
                else

                    Console.WriteLine("Brak pracowników w magazynie");
                Console.WriteLine("Wybierz klawisz 'K' aby zakończyć");
                ConsoleKeyInfo end = Console.ReadKey(true);
                if (start.Key == ConsoleKey.K)
                {
                    Console.WriteLine("Zamknięcie magazynu");
                }



            }

        }
    }
}
