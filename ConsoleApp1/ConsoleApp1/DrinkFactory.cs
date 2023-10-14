namespace ConsoleApp1
{
    internal partial class Program
    {
        class DrinkFactory : IDrinkFactory
        {
            public IDrink GetDrinkType(string drinkType, IMakingProcess makingProcess)
            {
                    if (drinkType.Equals("Coffee"))
                    {
                    makingProcess.Process();
                        return new Coffee();
                    }
                    else if (drinkType.Equals("Tea"))
                    {
                        makingProcess.Process();
                        return new Tea();
                    }
                    else
                {
                    return null;
                }
            }
        }
    }
}
