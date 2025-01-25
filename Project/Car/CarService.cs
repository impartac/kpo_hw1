using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccountingInformationSystem;

public class CarService : ICarProvider
{
    List<Car> cars;

    public CarService()
    {
        cars = new List<Car>();
    }

    public Car? FindCar(Customer customer)
    {
        Car? result = cars.FirstOrDefault(car => car.Compatibility(customer));
        if (result != null)
        {
            cars.Remove(result);
        }
        return result;
    }

    public void AddCar<TParams>(ICarFactory<TParams> carFactory, TParams tparams)
    {
        int carNumber = cars.Count + 1;

        cars.Add(carFactory.CreateCar(tparams, carNumber));
    }
}
