using TrainingGround;

public class ConditionalTests
{

    [Fact]
    public void should_be_kid_when_younger_than_18()
    {
        // arrange
        var p = new Person(2005);

        // act
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Kid, category);
    }
    [Fact]
    public void should_be_adult_when_older_than_18()
    {
        // arrange
        var p = new Person(2002);

        // act
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Adult, category);
    }
    [Fact]
    public void when_50_then_prime_Age()
    {
        // arrange
        var p = new Person(1972);

        // act
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Prime, category);
    }
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-4, -6, -10)]
    [InlineData(-2, 2, 0)]
    [InlineData(int.MinValue, -1, int.MaxValue)]
    public void CanAddTheory(int value1, int value2, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(value1, value2);

        Assert.Equal(expected, result);
    }
}
