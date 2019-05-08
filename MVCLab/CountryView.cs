using System;

namespace MVCLab
{
    class CountryView : IView
    {
        private Country displayCountry;

        public Country DisplayCountry
        {
            get { return displayCountry; }
            set { displayCountry = value; }
        }

        public CountryView() { }

        public CountryView(Country _displayCountry)
        {
            displayCountry = _displayCountry;
        }

        public void Display()
        {
            Console.Write($"Name: {displayCountry.Name}\t" +
                $"Continent: {displayCountry.Continent}\t" +
                $"Colors: {string.Join(", ", displayCountry.Colors)}");
        }
    }
}
