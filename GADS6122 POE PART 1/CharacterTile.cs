using GADE6122_POE_PART_1_NEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADS6122_POE_PART_1
{
    public abstract class CharacterTile : Tile
    {

        private Position PosCharT;
        private int hitPoints, MaxHP, attackPow;
        Tile[,] vis;

        //properties
        //constructor
        public CharacterTile(Position PosChar, int HP, int ATP) : base(PosChar)
        {
            this.PosCharT = PosChar;
            hitPoints = HP;
            MaxHP = HP;
            attackPow = ATP;
            vis = new Tile[4, 4];
        }



        //methods
        public override char Display
        {
            get { return 'x'; }
        }

        public void updateVis(Level l)
        {
            Tile[,] t = l.getTileArr();
            vis[0, 0] = t[PosCharT.X - 1, PosCharT.Y - 1];
            vis[0, 1] = t[PosCharT.X, PosCharT.Y + 1];
            vis[1, 0] = t[PosCharT.X, PosCharT.Y - 1];
            vis[1, 1] = t[PosCharT.X - 1, PosCharT.Y];
        }

        public void takeDamage (int dmg)
        {
            hitPoints = hitPoints - dmg;
        }

        public void attack (CharacterTile c)
        {
            c.takeDamage(attackPow);
        }

        public bool isDead()
        {
            bool dead = false;
            if (hitPoints > 0)
            {
                dead = false;
            }
            else if (hitPoints <= 0)
            {
                dead = true;
            }

            return dead;

        }



    }
}
