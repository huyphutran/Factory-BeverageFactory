using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        class Tea : IDrink
        {
            public void GetDrink()
            {
                Console.WriteLine("Getting Tea!!");
            }
        }
    }
}
