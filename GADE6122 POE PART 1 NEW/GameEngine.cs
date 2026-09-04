using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART_1_NEW
{
    public class GameEngine
    {
        //fields
        private Level level;
        private int levelNums;
        private int Rand;

        const int MIN_SIZE = 10;
        const int MAX_SIZE = 20;

        //properties
        //constructor

        public GameEngine(int levelNums)
        {

            this.levelNums = levelNums;

            Random rand = new Random();

            int width = rand.Next(MIN_SIZE, MAX_SIZE + 1);
            int height = rand.Next(MIN_SIZE, MAX_SIZE + 1);

            level = new Level(width, height);

        }
        //methods
        public override string ToString()
        {
            return level.ToString();
        }
    }
}
