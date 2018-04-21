using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tdd_project
{
    public class GameHandler
    {
        public Player player1, player2;
        private String actualCity;
        private String newCity;
        private List<String> oldCities, newCities;
        public bool numberOfPlayer;
        public GameHandler()
        {

        }
        public GameHandler(String name1, String name2)
        {
            player1 = new Player(name1);
            player2 = new Player(name2);
            newCities = new List<string>();
            oldCities = new List<string>();
            numberOfPlayer = true;
        }
        public void loadGame()
        {
            setNewCitiesListFromCSV("cities.csv");
            startActualCity();
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
            if (lastLetter == 'ь')
                lastLetter = cityName[cityName.Length - 2];
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
            foreach (var city in newCities)
            {
                if (city.ToLower() == newCity.ToLower())
                {
                    newCities.Remove(city);
                    return true;
                }
            }
            return false;
        }
        public void startActualCity()
        {
            Random random = new Random();
            int num = random.Next(0, newCities.Count);
            actualCity = newCities[num];
            newCities.Remove(actualCity);
        }
        public void enterCity(String nCity)
        {
            set_newCity(nCity);
            if (ifNewCitySuitableInLetters(get_actualCity(), get_newCity()))
            {
                if (ifNewCityFromNewCitiesList(get_newCity()))
                {
                    if (numberOfPlayer)
                        player1.setPoints(player1.getPoints() + newCity.Length);
                    else
                        player2.setPoints(player2.getPoints() + newCity.Length);

                    numberOfPlayer = !numberOfPlayer;
                    actualCity = newCity;
                }
                else
                {
                    MessageBox.Show("Данный город либо уже был, либо его нет в базе.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Первая и последняя буквы не совпали.");
                return;
            }
        }

    }
}
