using ProojektClassObjectct_Kristiqn;
using System.Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {
        Carinfo car1 = new Carinfo("BMW", 2020);
        Carinfo car2 = new Carinfo("Mercedes", 2021);
        Carinfo car3 = new Carinfo("Audi", 2022);
        Carinfo car4 = new Carinfo("Toyota", 2023);
        Carinfo car5 = new Carinfo("Ford");

        Console.WriteLine("Choose a car:");
        Console.WriteLine("1. BMW");
        Console.WriteLine("2. Mercedes");
        Console.WriteLine("3. Audi");
        Console.WriteLine("4. Toyota");
        Console.WriteLine("5. Ford");

        Console.Write("Enter number: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            car1.ShowInfo();

            Console.Write("Enter new year: ");
            int newYear = Convert.ToInt32(Console.ReadLine());

            car1.ChangeYear(newYear);
            car1.ShowInfo();
        }
        else if (choice == 2)
        {
            car2.ShowInfo();

            Console.Write("Enter new year: ");
            int newYear = Convert.ToInt32(Console.ReadLine());

            car2.ChangeYear(newYear);
            car2.ShowInfo();
        }
        else if (choice == 3)
        {
            car3.ShowInfo();

            Console.Write("Enter new year: ");
            int newYear = Convert.ToInt32(Console.ReadLine());

            car3.ChangeYear(newYear);
            car3.ShowInfo();
        }
        else if (choice == 4)
        {
            car4.ShowInfo();

            Console.Write("Enter new year: ");
            int newYear = Convert.ToInt32(Console.ReadLine());

            car4.ChangeYear(newYear);
            car4.ShowInfo();
        }
        else if (choice == 5)
        {
            car5.ShowInfo();

            Console.Write("Enter new year: ");
            int newYear = Convert.ToInt32(Console.ReadLine());

            car5.ChangeYear(newYear);
            car5.ShowInfo();
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }

        Console.ReadKey();
    }
}