using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal partial class Program
    {
        class ProcessTeaFactory : IMakingProcess
        {
            public void Process()
            {
                Console.WriteLine("Dipping tea leaves, pouring hot water, and serving in a cup.");
            }
        }


        static void Main(string[] args)
        {
            IDrinkFactory factory = new DrinkFactory();
            ProcessCoffeeFactory coffeeFactory = new ProcessCoffeeFactory();
            ProcessTeaFactory teaFactory = new ProcessTeaFactory();
            IDrink coffee = factory.GetDrinkType("Coffee",coffeeFactory);
            coffee.GetDrink();
            IDrink tea = factory.GetDrinkType("Tea",teaFactory); 
            tea.GetDrink();
        }
    }
}
