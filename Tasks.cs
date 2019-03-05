using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDiagramAktywnosci
{
    public class Tasks
    {
        public string DoTask(List<ITasks> tasks)
        {
            string result = "Pracowncy wykonali:";
            tasks.ForEach(t => result += $"{t.Do()}");
            return result;
        }
    }
}
