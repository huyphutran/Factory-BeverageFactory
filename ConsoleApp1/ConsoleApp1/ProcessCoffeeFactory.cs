using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        class ProcessCoffeeFactory : IMakingProcess
        {
            public void Process()
            {
                 Console.WriteLine("Grinding beans, pouring hot water, and serving in a cup.");
            }
        }
    }
}
