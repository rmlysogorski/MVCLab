using System;

namespace MVCLab
{
    class Validator
    {
        public static int GetUserInt(int min, int max)
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.Write("Please enter the index of the country you wish to view: ");
                return GetUserInt(min, max);
            }
            else if (input < min || input > max)
            {
                Console.WriteLine($"Please enter a number between {min}-{max}");
                return GetUserInt(min, max);
            }
            else
            {
                return input;
            }
        }

        public static bool GetUserBool(string opt1, string opt2)
        {
            string input = Console.ReadLine();
            if (input == opt1)
            {
                return true;
            }
            else if (input == opt2)
            {
                return false;
            }
            else
            {
                Console.Write($"Please enter \"{opt1}\" for yes or \"{opt2}\" for no: ");
                return GetUserBool(opt1, opt2);
            }
        }
    }
}
