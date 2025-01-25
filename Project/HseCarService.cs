
namespace PedalCarAccountingInformationSystem;

public class HseCarService
{
    ICarProvider carProvider;
    ICustomerProvider customerProvider;

    public HseCarService(ICarProvider carProvider, ICustomerProvider customerProvider)
    {
        this.carProvider = carProvider;
        this.customerProvider = customerProvider;
    }

    public void SellCars() 
    {
        List<Customer> customers = customerProvider.GetCustomerList();
        foreach (Customer customer in customers)
        {
            if (customer.Car == null) 
            {
                customer.Car = carProvider.FindCar(customer);
            }
        }
    }
}
