using System;
using Core;

namespace ConsoleApp
{
    class Program
    {
        enum BeverageType
        {
            DarkRoast = 1,
            Decaf,
            Espresso,
            HouseBlend
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose a beverage:");
            Console.WriteLine("1. DarkRoast");
            Console.WriteLine("2. Decaf");
            Console.WriteLine("3. Espresso");
            Console.WriteLine("4. HouseBlend");

            bool validChoice = int.TryParse(Console.ReadLine(), out int choice);

            if (validChoice && Enum.IsDefined(typeof(BeverageType), choice))
            {
                BeverageType selected = (BeverageType)choice;

                Beverage selectedBeverage = null;
                switch (selected)
                {
                    case BeverageType.Espresso:
                        selectedBeverage = new Espresso();
                        break;
                    case BeverageType.DarkRoast:
                        selectedBeverage = new DarkRoast();
                        break;
                    case BeverageType.HouseBlend:
                        selectedBeverage = new HouseBlend();
                        break;
                    case BeverageType.Decaf:
                        selectedBeverage = new Decaf();
                        break;
                }

                if (selectedBeverage != null)
                {
                    bool toggleCondiments = true;
                    while (toggleCondiments)
                    {
                        Console.WriteLine("Choose a condiment (or 0 for none):");
                        Console.WriteLine("1. Mocha");
                        Console.WriteLine("2. Milk");
                        Console.WriteLine("0. None");

                        validChoice = int.TryParse(Console.ReadLine(), out int condimentChoice);

                        if (validChoice)
                        {
                            switch (condimentChoice)
                            {
                                case 1:
                                    selectedBeverage = new Mocha(selectedBeverage);
                                    break;
                                case 2:
                                    selectedBeverage = new Milk(selectedBeverage);
                                    break;
                                case 0:
                                    toggleCondiments = false;
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice. No condiment added.");
                                    break;
                            }

                            Console.WriteLine($"You selected: {selectedBeverage.GetDescription()}");
                            Console.WriteLine($"Total cost: ${selectedBeverage.Cost():0.00}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. No condiment added.");
                        }
                    }

                    Console.WriteLine(
                        $"Description {selectedBeverage.GetDescription()}: \n Price: {selectedBeverage.Cost()}");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid beverage number.");
                }
            }
        }
    }
}