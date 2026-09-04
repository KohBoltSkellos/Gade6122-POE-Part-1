using GADE6122_POE_PART_1_NEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADS6122_POE_PART_1
{
    internal class HeroTile : CharacterTile

    {

        private Position PosCharH;
        private int hitPoints, MaxHP, attackPow;
        Tile[,] vis;

        //properties
        //constructor
        public HeroTile(Position PosHer) : base(PosHer, 40, 5)
        {
            this.PosCharH = PosHer;

            hitPoints = 40;
            MaxHP = 40;
            attackPow = 5;
            vis = new Tile[4, 4];
        }



        //methods
        public override char Display
        {
            get { return 'x'; }
        }

       

        

        

       
    }
}
