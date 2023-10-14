namespace ConsoleApp1
{
    internal partial class Program
    {
        interface IDrinkFactory {

            IDrink GetDrinkType(string drinkType, IMakingProcess makingProcess);
        }
    }
}
