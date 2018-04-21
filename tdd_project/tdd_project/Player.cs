using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_project
{
    public class Player
    {
        private String name;
        private int points;
        public Player()
        {
            
        }
        public Player(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        public int getPoints()
        {
            return 0;
        }
    }
}
