using System;
using System.Collections.Generic;

namespace MVCLab
{
    class CountryController
    {
        private List<Country> countryDb;

        public List<Country> CountryDb
        {
            get { return countryDb; }
            set { countryDb = value; }
        }

        public CountryController() { }

        public CountryController(List<Country> _countryDb)
        {
            countryDb = _countryDb;
        }

        public void CountryAction(Country c)
        {
            IView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            bool viewAnother = true;

            while (viewAnother)
            {
                IView view = new CountryListView(countryDb);
                
                Console.Clear();
                Console.WriteLine("Hello, welcome to the country app.\nPlease select a country from the following list:");
                view.Display();
                Console.Write("Enter your choice: ");
                int input = Validator.GetUserInt(0, countryDb.Count);
                Console.WriteLine();
                IView colorView = new ChangeColorView(countryDb[input]);
                colorView.Display();
                Console.Write("\n\nWould you like to view another country? (y/n): ");
                viewAnother = Validator.GetUserBool("y", "n");
            }

        }
    }
}
