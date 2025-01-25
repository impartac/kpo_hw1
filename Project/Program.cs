using PedalCarAccountingInformationSystem;
using System.Xml.Linq;

namespace PedalCarAccauntingInformationSystem;

internal class Program
{
    static void Main(string[] args)
    {
        var carService = new CarService();
        var customerStorage = new CustomerStorage();
        var hseCarService = new HseCarService(carService, customerStorage);
        var pedalCarFactory = new PedalCarFactory();
        var handCarFactory = new HandCarFactory();

        customerStorage.AddCustomer(new Customer("Ann", 6, 4));
        customerStorage.AddCustomer(new Customer("Bob", 4, 6));
        customerStorage.AddCustomer(new Customer("Clark", 6, 6));
        customerStorage.AddCustomer(new Customer("Denis", 4, 4));

        carService.AddCar(pedalCarFactory, new PedalEngineParams(4));
        carService.AddCar(pedalCarFactory, new PedalEngineParams(4));
        carService.AddCar(handCarFactory, new EmptyEngineParams());
        carService.AddCar(handCarFactory, new EmptyEngineParams());

        foreach (var customer in customerStorage.GetCustomerList())
        {
            Console.WriteLine(customer);
        }

        hseCarService.SellCars();

        foreach (var customer in customerStorage.GetCustomerList())
        {
            Console.WriteLine(customer);
        }
    }
}