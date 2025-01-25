
namespace PedalCarAccountingInformationSystem;

public interface ICarFactory<TParams>
{
    public Car CreateCar(TParams car, int carNumber);
}
