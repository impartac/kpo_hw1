namespace PedalCarAccountingInformationSystem;
public class Customer
{
    public Car? Car { get; set; }
    public string Name { get; set; }

    public int FootPower { get; set; }
    public int HandPower { get; set; }

    public Customer(string name, int footPower, int handPower, Car? car = null)
    {
        Car = car;
        Name = name;
        FootPower = footPower;
        HandPower = handPower;
    }
    public override string ToString()
    {
        return $"Имя: {Name}, Номер машины: {Car?.Number ?? -1}, Сила ног: {FootPower}, Сила рук: {HandPower}";
    }
}