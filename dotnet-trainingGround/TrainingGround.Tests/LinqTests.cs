
public class LinqTests
{

    [Fact]
    public void loop_to_filer_numbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var numbersLargerThan15 = new List<int>();
        foreach (var number in numbers)
        {
            if (number > 15)
            {
                numbersLargerThan15.Add(number);
                continue;
            }
        }

        // assert
        Assert.Equal(4, numbersLargerThan15.Count);
    }
    [Fact]
    public void linq_to_filer_numbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var numbersLargerThan15 = numbers.FindAll(number => number > 15);

        // assert
        Assert.Equal(4, numbersLargerThan15.Count);
    }
    [Fact]
    public void linq_to_find_first()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var firstNumberLargerThan15 = numbers.Find(number => number > 15);

        // assert
        Assert.Equal(53, firstNumberLargerThan15);
    }
    [Fact]
    public void linq_to_check_if_any_matches()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var anyNumberGreater = numbers.Any(number => number > 115);

        // assert
        Assert.False(anyNumberGreater);
    }
    [Fact]
    public void filter_people_by_age()
    {
        // arrange
        var people = new List<Person> {
                new Person("Shujat"),
                new Person("Sara"),
                new Person("Ali"),
                new Person("Rabbiya"),
                new Person("Talha"),
                new Person("AAli")
                                    };
        // act
        var allWithLongNames = people.Where(p => p.Name.Length > 4).ToList();
        // assert
        Assert.Equal(3, allWithLongNames.Count);
        Assert.Equal("Shujat", allWithLongNames[0].Name);
    }
    [Fact]
    public void select_people_by_age()
    {
        // arrange
        var people = new List<Person> {
                new Person("Shujat"),
                new Person("Sara"),
                new Person("Ali"),
                new Person("Rabbiya"),
                new Person("Talha"),
                new Person("AAli")
                                    };
        // act
        var allWithLongNames = people
        .Where(p => p.Name.Length > 4)
        .Select(p => p.Name)
        .ToList();
        // assert
        Assert.Equal(3, allWithLongNames.Count);
        Assert.Equal("Shujat", allWithLongNames[0]);
        Assert.Equal("Talha", allWithLongNames[2]);
    }
    [Fact]
    public void filter_people_by_age_names_age()
    {
        // arrange
        var a = new Person("Shujat");
        a.LengthInMeters = 1.96;
        var people = new List<Person> {
                                        a,
                                        new Person("Bea"),
                                        new Person("Ceasar"),
                                        new Person("Dave"),
                                    };

        // act
        var namesAndAges = people
          .Where(p => p.Name.Length > 4)
          .Select(p => new { Name = p.Name, Height = p.LengthInMeters })
          .ToList();

        // assert
        Assert.Equal(2, namesAndAges.Count);
        Assert.Equal("Shujat", namesAndAges[0].Name);
        Assert.Equal(1.96, namesAndAges[0].Height);
    }
}