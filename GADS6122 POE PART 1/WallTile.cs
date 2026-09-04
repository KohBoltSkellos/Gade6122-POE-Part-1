using GADE6122_POE_PART_1_NEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADS6122_POE_PART_1
{
    internal class WallTile : Tile
    {
        private Position PosWallT;

        //properties
        //constructor
        public WallTile(Position PosWall) : base(PosWall)
        {
            this.PosWallT = PosWall;
        }

        //methods
        public override char Display
        {
            get { return '|'; }
        }
    }
}
