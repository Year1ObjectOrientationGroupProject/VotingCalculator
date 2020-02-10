using System;


namespace VotingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create array of country objects:
            Country[] countries = initialCountryArray();

            bool programActive = true;

            while (programActive == true) {
                // User Interface:
                falloutTextPrint("Welcome to the voting calculator");
                Console.ReadLine();
            }


        }

        static void falloutTextPrint(string text) {
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i <= text.Length - 1; i++) {
                Console.Write(text[i]);
                System.Threading.Thread.Sleep(10);
            }
        }
        static Country[] initialCountryArray() {
            Country[] countries = new Country[26];
            countries[0] = new Country("Austria", 1.98f);
            countries[1] = new Country("Belgium", 2.56f);
            countries[2] = new Country("Bulgaria", 1.56f);
            countries[3] = new Country("Croatia", 0.91f);
            countries[4] = new Country("Cyprus", 0.2f);
            countries[5] = new Country("Czech Republic", 2.35f);
            countries[6] = new Country("Denmark", 1.3f);
            countries[7] = new Country("Estonia", 0.3f);
            countries[8] = new Country("Finland", 1.23f);
            countries[9] = new Country("Germany", 18.54f);
            countries[10] = new Country("Greece", 2.4f);
            countries[11] = new Country("Hungary", 2.18f);
            countries[12] = new Country("Ireland", 1.1f);
            countries[13] = new Country("Italy", 13.65f);
            countries[14] = new Country("Latvia", 0.43f);
            countries[15] = new Country("Lithuania", 0.62f);
            countries[16] = new Country("Luxembourg", 0.14f);
            countries[17] = new Country("Malta", 0.11f);
            countries[18] = new Country("Netherlands", 3.89f);
            countries[19] = new Country("Poland", 8.49f);
            countries[20] = new Country("Portugal", 8.49f);
            countries[21] = new Country("Romania", 4.34f);
            countries[22] = new Country("Slovakia", 1.22f);
            countries[23] = new Country("Slovenia", 0.47f);
            countries[24] = new Country("Spain", 10.49f);
            countries[25] = new Country("Sweden", 2.29f);
            return countries;
        }
        
    }
}

