using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class ChangeColorView : IView
    {
        private Country displayCountry;

        public Country DisplayCountry
        {
            get { return displayCountry; }
            set { displayCountry = value; }
        }  
            
        public ChangeColorView(Country _displayCountry)
        {
            displayCountry = _displayCountry;
        }

        public void Display()
        {
            IView view = new CountryView(displayCountry);
            List<ColorList> myList = new List<ColorList>();
            foreach(string color in displayCountry.Colors)
            {
                Enum.TryParse(color, out ColorList myColor);
                myList.Add(myColor);
            }
            
            if(myList.Count == 2)
            {
                Console.ForegroundColor = (ConsoleColor)myList[0];
                Console.BackgroundColor = (ConsoleColor)myList[1];
                view.Display();
            }
            else if (myList.Count == 3)
            {
                Console.BackgroundColor = (ConsoleColor)myList[0];
                Console.Write($"Name: { displayCountry.Name}\t");
                Console.BackgroundColor = (ConsoleColor)myList[1];
                Console.Write($"Continent: {displayCountry.Continent}\t");
                Console.BackgroundColor = (ConsoleColor)myList[2];
                Console.Write($"Colors: {string.Join(", ", displayCountry.Colors)}");
            }

            Console.ResetColor();
        }

    }
}
