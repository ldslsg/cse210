public class Address
{
    private string Street;
    private string City;
    private string State;
    private string ZipCode;

    public Address(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public string GetAddress()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}
