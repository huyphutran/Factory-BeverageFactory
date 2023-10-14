using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        class Coffee : IDrink
        {
            public void GetDrink()
            {
                Console.WriteLine("Getting Coffee!!");
            }
        }
    }
}
