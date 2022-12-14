public class TypesTests
{
    [Fact]
    public void reference_types_can_be_changed_via_reference()
    {
        // arrange
        Person a = new Person("Person A");
        a.LengthInMeters = 1.95;
        Person b = a;

        // act
        b.LengthInMeters = 1.96;

        // assert
        Assert.Equal(1.96, b.LengthInMeters);
        Assert.Equal(1.96, a.LengthInMeters);
    }
    [Fact]
    public void value_types_cannot_be_changed_via_reference()
    {
        // arrange
        double aLengthInMeters = 1.95;
        double bLengthInMeters = aLengthInMeters;

        // act
        bLengthInMeters = 1.96;

        // assert
        Assert.Equal(1.96, bLengthInMeters);
        Assert.Equal(1.95, aLengthInMeters);
    }
    [Fact]
    public void getting_age_from_person()
    {
        // arrange
        var p = new Person(1972);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(50, age);
        Assert.IsType(typeof(Person), p);
        Assert.IsType(typeof(int), age);
    }

    [Fact]
    public void an_employee_gets_a_nice_printed_address()
    {
        // arrange
        var emp = new Employee("Marcus", "234-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "A Street";
        emp.Address.StreetNo = 23;
        emp.Address.City = "Stockholm";

        // act
        var printString = emp.GetPrintString();

      
  // assert
  Assert.Equal(@"Marcus (234-BDAS)
A Street 23
Stockholm", printString);
    }
}
