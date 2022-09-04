public class Person : IPrintable
{
    public string? Name { get; private set; }
    public Address? Address { get; set; }
    public int BirthYear;
    public double LengthInMeters;
    public Person() { }
    public Person(string name) => this.Name = name;
    public Person(int birthYear) => this.BirthYear = birthYear;
    public Person(Address address) => this.Address = address;
public int GetAge(int currentYear)
    {
        var age = currentYear - this.BirthYear;
        if (age < 0)
        {
            throw new Exception("Not born yet");
        }
        return age;
    }
    public string GetPrintString()
{
  return @$"{this.Name}
{this.Address.Street} {this.Address.StreetNo}
{this.Address.City}";
}
}
