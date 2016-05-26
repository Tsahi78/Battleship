using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Battleship
{
    class Ships
    {
       private string name;
       private int size;
       private Boolean sink =false;
       private Boolean horizontal = false;
       private Point[] point;


       public Ships(string name, int size, Boolean horizontal, Point[] point)
        {
            this.name = name;
            this.size = size;
            this.horizontal = horizontal;
            this.point = point;
        }

        public Ships()
        {

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Boolean Sink
        {
            get { return sink; }
            set { sink = value; }
        }

        public Boolean Horizontal
        {
            get { return horizontal; }
            set { horizontal = value; }
        }

        public Point[] Point
        {
            get { return point; }
            set { point = value; }
        }


    }
}
