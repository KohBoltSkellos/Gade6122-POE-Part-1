using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART_1_NEW
{
    public abstract class Tile
    {
        //Fields of Tile class
        private Position Pos;
        private int x, y;
        private String type;

        //constructor 
        public Tile(Position posTile)
        {
            this.Pos = posTile;
            x = Pos.X; y = Pos.Y;
        }

        //properties exposing values
        public int X 
        {
            get { return x; }

            set { x = value; }

        }

        public int Y 
        {
            get { return y; }

            set {  y = value; }

        }

        public String getTileType ()
        {
             return type;

            
        }

        public void setTileType(String t)
        {
            type = t;
        }
        

        public abstract char Display 
        {
            get;
        }
    }
}
