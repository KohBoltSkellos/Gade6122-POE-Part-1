using GADS6122_POE_PART_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART_1_NEW
{
    public class Level
    {
        //fields
        private int width = 0;
        private int height = 0;
        Position Pos;
        Tile[,] Tiles;
        public Tile[,] eTile;
        private HeroTile hero;


        //properties
        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }



        //constructor
        public Level(int width, int height, HeroTile h = null)
        {
            this.width = width;
            this.height = height;
           

            Tiles = new Tile[width, height];
            InitialiseTiles();
            Position rpos = GetRandomEmptyPosition();

            if (h == null)
            {
                h = new HeroTile(rpos);
            }
            else if (h != null)
            {
                h.X = rpos.X;
                h.Y = rpos.Y;
                Tiles[rpos.X, rpos.Y] = h;
            }
            hero = h;
        }
        public Level()
        {

        }

        public HeroTile getHeroTile()
        {
            return hero;
        }


        public enum TileType
        {
            Empty,
            Wall,
            Hero,
        }

        

        //methods
        private static Tile CreateTile(TileType tileType, Position pos)
        {
            Tile t = null;

            switch (tileType)
            {
                case TileType.Wall:

                    t = new WallTile(pos);
                    
                    break;

                case TileType.Empty:

                    
                    t = new EmptyTile(pos);

                    break;

                case TileType.Hero:
                    t = new HeroTile(pos);
                        break;

                default:
                    break;
            }

            return t;

        }

        public Tile [,] getTileArr ()
        {
            
            for (int j = 0; j < Tiles.Length; j++)
            {
                eTile[j,j] = Tiles[j, j];
            }

            return eTile;
            
            
        }

        public void InitialiseTiles()
        {
            for (int i = 0; i < Tiles.Length; i++)
            {
                String t = Tiles[i, i].getTileType();
                if (t == nameof(TileType.Empty))
                {
                    Position pos = new Position(i, i);
                    CreateTile(TileType.Empty, pos);
                    Tiles[i, i] = CreateTile(TileType.Wall, pos);
                }
                else if (t == nameof(TileType.Wall))
                {
                    Position pos = new Position (i, i);
                    Tiles[i, i] = CreateTile(TileType.Wall, pos);
                }
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }

        public Position GetRandomEmptyPosition()
        {
            Position p = null;
            for (int z = 0; z < Tiles.Length; z++)
            {
                String t = Tiles[z, z].getTileType();
                
                if (t == nameof (TileType.Empty))
                { 
                   p = new Position (Tiles[z,z].X, Tiles[z, z].Y);
                }

            }

            return p;

        }

        public void SwapTiles (Tile t1, Tile t2)
        {
            Tile temp;
            temp = t2;
            Tiles[t2.X, t2 .Y] = t1;
            Tiles[t1.X, t1.Y] = temp;

            t2.X = t1.X;
            t2.Y = t1.Y;
            t1.X = temp.X;
            t1.Y = temp.Y;

        }

        public enum Direction
        {
            UP = 0,
            Right = 1,
            Down = 2,
            Left = 3,
            None = 4,
        }

    }
}
