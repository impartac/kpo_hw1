using PedalCarAccountingInformationSystem;
using System.Xml.Linq;

namespace PedalCarAccauntingInformationSystem;

internal class Program
{
    static void Main(string[] args)
    {
        var customers = new List<Customer>
        {
            new Customer("Me"),
            new Customer("CR7"),
            new Customer("Matvej"),
            new Customer("Starij Bog"),
            new Customer("ALoha")
        };

        var factory = new FactoryAF(customers);

        for (int i = 0; i < 5; i++)
        {
            factory.AddCar();
        }

        Console.WriteLine("Was");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

        factory.SaleCar();

        Console.WriteLine("Now");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));
    }
}