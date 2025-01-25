using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccountingInformationSystem;

public class PedalCarFactory : ICarFactory<PedalEngineParams>
{
    public Car CreateCar(PedalEngineParams engineParams, int carNumber)
    {
        return new Car(new PedalEngine(engineParams.PedalSize), carNumber);
    }
}
