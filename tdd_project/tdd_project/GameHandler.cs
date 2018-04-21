using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_project
{
    public class GameHandler
    {
        private Player player1, player2;
        private String actualCity;
        private String newCity;
        private List<String> oldCities, newCities;
        public GameHandler()
        {

        }
        public GameHandler(String name1, String name2)
        {
            player1 = new Player(name1);
            player2 = new Player(name2);
            newCities = new List<string>();
            oldCities = new List<string>();
        }
        public void loadGame()
        {
            setNewCitiesListFromCSV("cities.csv");
        }
        public String get_actualCity()
        {
            return actualCity;
        }
        public String get_newCity()
        {
            return newCity;
        }
        public void set_actualCity(String actCity)
        {
            this.actualCity = actCity;
        }
        public void set_newCity(String newCity)
        {
            this.newCity = newCity;
        }
        public List<String> get_oldCities()
        {
            return oldCities;
        }
        public List<String> get_newCities()
        {
            return newCities;
        }
        public void setNewCitiesListFromCSV(String filename)
        {
            using (var reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    newCities.Add(line);
                }
            }
        }
        public string getFirstLetter(String cityName)
        {
            var firstLetter = cityName[0];
            return firstLetter.ToString();
        }
        public string getLastLetter(String cityName)
        {
            var lastLetter = cityName[cityName.Length - 1];
            return lastLetter.ToString();
        }
        public bool ifNewCitySuitableInLetters(String oldCity, String newCity)
        {
            if (getLastLetter(oldCity).ToLower() == getFirstLetter(newCity).ToLower())
                return true;
            else
                return false;
        }
        public bool ifNewCityFromNewCitiesList(String newCity)
        {
            return true;
        }
    }
}
