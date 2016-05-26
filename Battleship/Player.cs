using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Battleship
{
    class Player 
    {
        private string name;


        ships[] ship;


        List<Point> new_point;
        List<Point> old_point;



        public Player(string name);

        public string Name
            {
              get { return name; }
              set { name = value; }
            }

        public ships[] Ship
            {
              get { return ship; }
              set { ship = value; }
            }
        public List<Point> New_point
            {
              get { return new_point; }
              set { new_point = value; }
            }
        public List<Point> Old_point
            {
              get { return old_point; }
              set { old_point = value; }
            }

        public void set_new_point(int x, int y)
        {
            for (int i = 0; i < y; i++)
            {

                for (int j = 0; j < x; j++)
                {
                    new_point.Add(new Point(j, i));
                }
            }
        }
    }
    
}
