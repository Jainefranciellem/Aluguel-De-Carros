using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    //10 - Crie o construtor de `Rent` seguindo as regras de negócio
    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        Person = person;
        DaysRented = daysRented;
        Vehicle = vehicle;

        if(person is PhysicalPerson physicalPerson)
        {
            Price = vehicle.PricePerDay * daysRented;
        }
        else if(person is LegalPerson legalPerson)
        {
            Price = vehicle.PricePerDay * daysRented * 0.9;
        }
        Person.Debit += Price;
        vehicle.IsRented = true;
        Status = RentStatus.Confirmed;
    }
    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Cancel()
    {
        throw new NotImplementedException();
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Finish()
    {
        throw new NotImplementedException();
    }
}