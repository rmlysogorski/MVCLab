using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class FileIO
    {
        public static List<Country> GetDataFile()
        {
            List<Country> countryDb = new List<Country>();
            
            string fileName = "\\countryDb.txt";
            string binaryPath = @"" + Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + fileName;
            
            StreamReader myFile = new StreamReader(binaryPath);
            try
            {
                string line; //stores the file data for one line

                while ((line = myFile.ReadLine()) != null) //while line exists
                {
                    Country countryToAdd = new Country(); //Create a dummy Country 
                    countryToAdd.Name = line.Split(',')[0]; //Add the country name
                    countryToAdd.Continent = line.Split(',')[1]; //Add the country continent
                    countryToAdd.Colors = line.Split(',')[2].Split('|').ToList(); //Add the colors as a list
                    countryDb.Add(countryToAdd); //Put the Country in the list 
                }
            }
            finally
            {
                myFile.Close();
            }
            
            return countryDb;
        }
    }
}
