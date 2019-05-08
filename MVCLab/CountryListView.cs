using System;
using System.Collections.Generic;

namespace MVCLab
{
    class CountryListView : IView
    {
        private List<Country> countries;

        public List<Country> Countries
        {
            get { return countries; }
            set { countries = value; }
        }

        public CountryListView() { }

        public CountryListView(List<Country> _countries)
        {
            countries = _countries;
        }

        public void Display()
        {
            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine($"Index: {i}\tName: {countries[i].Name}");
            }
        }
    }
}
