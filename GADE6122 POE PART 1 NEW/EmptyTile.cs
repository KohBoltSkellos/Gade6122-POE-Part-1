using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART_1_NEW
{
    public class EmptyTile : Tile
    {
        //fields
        private Position PosEmptyT;

        //properties
        //constructor
        public EmptyTile(Position PosEmpty) : base(PosEmpty)
        {
            this.PosEmptyT = PosEmpty;
        }

        //methods
        public override char Display
        {
            get { return '.'; }
        }
    }
}
