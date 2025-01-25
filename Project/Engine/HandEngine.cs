
namespace PedalCarAccountingInformationSystem;
public class HandEngine : IEngine
{
    public HandEngine()
    {
    }

    public bool IsСompatibility(Customer customer)
    {
        return customer.HandPower > 5;
    }

    public override string ToString()
    {
        return GetType().Name;
    }
}
