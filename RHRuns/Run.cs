using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHRuns
{
    class Run
    {
        public List<int> Runs { get; set; }

        public Run(int maal)
        {
            Runs = new List<int>(maal);
        }
        public Run()
        {

        }

        public static Run UpperBoundIncrease(Run lastRun, Run newRun)
        {
            lastRun.Runs.AddRange(newRun.Runs);
            return lastRun;
        }

    }
}
