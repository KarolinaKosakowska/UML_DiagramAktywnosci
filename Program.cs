﻿using System;
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
            bool tryItAgain = true;
            while (tryItAgain)
            {
                Console.WriteLine("Wybierz klawisz 'S'");
                ConsoleKeyInfo start = Console.ReadKey(true);
                if (start.Key == ConsoleKey.S)
                {
                    Console.WriteLine("Kierownik rozpoczął pracę");

                    while (tryItAgain)
                    {
                        Console.WriteLine("Wybierz klawisz 'P',aby wydać polecenia pracownikom");
                        ConsoleKeyInfo command = Console.ReadKey(true);
                        if (command.Key == ConsoleKey.P)
                        {
                            Magazyn magazyn = new Magazyn();
                            Tasks tasks = new Tasks();
                            var taskList = new List<ITasks>();
                            taskList.Add(new Rozładunek());
                            taskList.Add(new Załadunek());
                            taskList.Add(new NoweZamówienie());

                            Console.WriteLine(tasks.DisplayTasks(taskList));

                            if (magazyn.pracownicy != null)
                            {
                                var a = tasks.DoTaskAsync(taskList);
                                Task.WaitAll(a);
                                Console.WriteLine(tasks.EndTasks(taskList));

                            }
                            else
                                Console.WriteLine("Brak pracowników w magazynie");
                            while (tryItAgain)
                            {
                                Console.WriteLine("Wybirz 'K', aby zakończyć");
                                ConsoleKeyInfo end = Console.ReadKey(true);
                                if (end.Key == ConsoleKey.K)
                                {
                                    Console.WriteLine("Zamknięcie magazynu");
                                    Console.Read();
                                }
                                else
                                    WrongKey("K");
                            }

                        }
                        else

                            WrongKey("P");
                        tryItAgain = true;

                    }
                }
                else

                    WrongKey("S");
                tryItAgain = true;

            }

        }

        private static void WrongKey(string key)
        {
            Console.WriteLine($"Wybrano błędny klawisz, wybierz:{key}");

        }
    }
}


