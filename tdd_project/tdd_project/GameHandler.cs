using System;
using System.Collections.Generic;
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
        public GameHandler()
        {

        }
        public GameHandler(String name1, String name2)
        {
            player1 = new Player(name1);
            player2 = new Player(name2);
        }
        public String get_actualCity()
        {
            return actualCity;
        }
        public String get_newCity()
        {
            return newCity;
        }

    }
}
