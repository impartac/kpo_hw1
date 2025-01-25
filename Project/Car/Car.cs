using System;

namespace PedalCarAccountingInformationSystem;
public class Car
{
    private static readonly Random _random = new();
    public IEngine Engine { get; private set; }
    public int Number { get; private set; }

    public Car()
    {
        Engine = new PedalEngine(_random.Next(1, 100));
    }
    public Car(int number)
    {
        Engine = new PedalEngine(_random.Next(1, 100));
        Number = number;
    }
    public Car(IEngine engine, int carNumber)
    {
        Engine = engine;
        Number = carNumber;
    }
    public override string ToString()
    {
        return $"Номер: {Number}, Размер педалей: {Engine}";
    }

    public bool Compatibility(Customer customer)
    {
        return Engine.IsСompatibility(customer);
    }
}