
namespace PedalCarAccountingInformationSystem;
public class PedalEngine : IEngine
{
    public int PedalSize { get; set; }

    public PedalEngine(int pedalSize)
    {
        PedalSize = pedalSize;
    }

    public bool IsСompatibility(Customer customer)
    {
        return customer.FootPower > 5;
    }

    public override string ToString()
    {
        return GetType().Name;
    }
}
