using System;


namespace VotingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Country myCountry = new Country("France", 5.09f);
            Console.WriteLine(myCountry.getName());
            Console.WriteLine(myCountry.getPercentageOfPop());
        }
    }
}
