

using System.Collections.Generic;

namespace MVCLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countryDb = FileIO.GetDataFile();
            CountryController controller = new CountryController(countryDb);
            controller.WelcomeAction();
        }
    }
}
