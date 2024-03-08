using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFile
{
    internal static class PrintMessage
    {
        public static void Print(string message, DataFromConfiguration data)
        {
            FileChange file = new FileChange();
            while (true)
            {
                if (!file.IsChanged)
                {
                Thread.Sleep(1000 * data.IntervalInSeconds);
                Console.WriteLine($"{message} data {data.dateFormat} interval {data.IntervalInSeconds}");
            }
        }
    }
}
}
