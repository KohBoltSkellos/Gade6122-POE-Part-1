using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART_1_NEW
{
    public class Position
    {
        //Fields of position class for X and Y values
        private int x;//x interger field
        private int y;//y interger field

        //Constructor of position class accepting parameters
        public Position(int x, int y) 
        {
           this.x = x; 
           this.y = y;
        }
        //Properties of Position Class
        public int X 
        {
            get 
            { 
                return x;
            }
            set 
            {
                x = value;
            }

        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }

        }
    }
}
