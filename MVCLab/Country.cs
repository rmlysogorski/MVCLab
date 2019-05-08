using System.Collections.Generic;

namespace MVCLab
{
    class Country
    {
        private string name;
        private string continent;
        private List<string> colors;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Continent
        {
            get { return continent; }
            set { continent = value; }
        }

        public List<string> Colors
        {
            get { return colors; }
            set { colors = value; }
        }

        public Country() { }

        public Country(string _name, string _continent, List<string> _colors)
        {
            name = _name;
            continent = _continent;
            colors = _colors;
        }
    }
}
