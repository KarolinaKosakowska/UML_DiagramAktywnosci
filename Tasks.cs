using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZadanieDiagramAktywnosci
{
    public class Tasks
    {

        public string DisplayTasks(List<ITasks> taskList)
        {
            string result = "Lista zadań do wykonania: ";
            taskList.ForEach(t => result += $"{t.Do()}, ");
            return result;
        }

        public void DoTask(List<ITasks> taskList)
        {
            foreach (var t in taskList)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"{t.Do()}");
            }

        }
        public string EndTasks(List<ITasks> taskList)
        {
            string result = "Pracownicy wykonali: ";
            taskList.ForEach(t => result += $"{t.Do()}; ");
            return result;
        }


        public async Task DoTaskAsync(List<ITasks> taskList)
        {
            await Task.Run(() => DoTask(taskList));
        }


    }
}
