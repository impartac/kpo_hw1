using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccountingInformationSystem;

public class HandCarFactory : ICarFactory<EmptyEngineParams>
{
    public Car CreateCar(EmptyEngineParams engineParams, int carNumber)
    {
        return new Car(new HandEngine(), carNumber);
    }
}
