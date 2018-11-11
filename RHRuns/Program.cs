using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHRuns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int> { 1, 59, 12, 43, 4, 58, 5, 13, 46, 3, 6};
            var orderedValues = input.OrderBy(e => e).ToList();

            var listOfRuns = new List<Run>();
            var lastOne = orderedValues.First();
            var lastRun = new Run(lastOne);

            foreach (var currentValue in orderedValues)
            {
                if(lastOne + 1 == currentValue)
                {
                    Run newRun = Run.UpperBoundIncrease(lastRun, new Run(currentValue));
                    lastRun = newRun;
                }
                else
                {
                    lastRun = new Run(currentValue);
                    listOfRuns.Add(lastRun);
                }
                lastOne = currentValue;
            }

            Console.WriteLine("Runs:");
            foreach (var item in listOfRuns)
            {
                Console.Write("{");
                for (int i = 0; i < item.Runs.Count; i++)
                {
                    Console.Write(item.Runs[i]);
                    if (i< item.Runs.Count-1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("}");
                Console.WriteLine();
            }
        }
    }
}
