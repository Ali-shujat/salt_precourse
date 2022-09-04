namespace TrainingGround;

public class AgeCalculator
{
    // public int GetAge(int birthYear, int currentYear)
    // {
    //     return currentYear - birthYear;
    // }

    public static AgeCategory GetAgeCategory(Person person, int currentYear)
    {
        var test = person.GetAge(currentYear);
        if ( test > 18)
        {
            if (test >= 50){ return AgeCategory.Prime; }

            return AgeCategory.Adult;
        }

        return AgeCategory.Kid;

    }
    public static int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }
}


