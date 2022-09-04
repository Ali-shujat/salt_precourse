

public class PersonTests
{
    [Fact]
    public void create_person_using_parameterless_constructor()
    {
        // act
        var p = new Person();

        // assert
        Assert.NotNull(p);
    }
    [Fact]
    public void create_person_using_constructor_with_name()
    {
        // act
        var p = new Person("Marcus");

        // assert
        Assert.NotNull(p);
        Assert.Equal("Marcus", p.Name);
    }
    [Fact]
    public void a_person_born_1972_is_50_2022()
    {
        // arrange
        var p = new Person();
        p.BirthYear = 1972;

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(50, age);
    }

    [Fact]
    public void an_employee_is_a_person()
    {
        // act
        var emp = new Employee();
        emp.LengthInMeters = 1.95;

        // assert
        Assert.IsType(typeof(Employee), emp);
        Assert.Equal(1.95, emp.LengthInMeters);
    }

    [Fact]
    public void a_person_has_an_address()
    {
        // arrange
        var p = new Person("Marcus");

        // act
        p.Address = new Address();
        p.Address.Street = "A Street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        // assert
        Assert.NotNull(p.Address);
        Assert.IsType(typeof(Address), p.Address);

        Assert.Equal("A Street", p.Address.Street);
        Assert.Equal(23, p.Address.StreetNo);
        Assert.Equal("Stockholm", p.Address.City);
    }

    public void Print(IPrintable printable)
    {
        var printString = printable.GetPrintString();
        Console.WriteLine(printString);
    }
    [Fact]
    public void can_print_printables()
    {
        // arrange
        var emp = new Employee("Ossian", "234-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "B Street";
        emp.Address.StreetNo = 22;
        emp.Address.City = "Malmö";

        var p = new Person("Marcus");
        p.Address = new Address();
        p.Address.Street = "A Street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        // act
        this.Print(p);
        this.Print(emp);
    }
}

