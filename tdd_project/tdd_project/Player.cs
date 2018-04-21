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
            this.points = 0;
        }
        public Player(String name)
        {
            this.name = name;
            this.points = 0;
        }
        public String getName()
        {
            return name;
        }
        public int getPoints()
        {
            return points;
        }
        public void setPoints(int newPoints)
        {
            points = newPoints;
        }
    }
}
