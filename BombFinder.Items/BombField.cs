using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BombFinder.Items
{
    public class BombField
    {
        public Space[,] Array { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Bombs { get; set; }
        public int BombsLeft { get; set; }
        public int SafeSpacesLeft { get; set; }
        public string Difficulty { get; set; }
        public bool FirstPressSafe { get; set; }
        public Label BombsLeftLabel { get; set; }

        public BombField(int height, int width, int bombs, string difficulty, bool firstPressSafe)
        {
            Height = height;
            Width = width;
            Bombs = bombs;
            Difficulty = difficulty;
            FirstPressSafe = firstPressSafe;
            BombsLeft = bombs;
            SafeSpacesLeft = (height * width) - bombs;
            Array = new Space[height, width];
        }

        public void LoadBombs()
        {
            bool underloaded = (Height * Width > Bombs * 2) ? true : false;

            if (!underloaded)
            {
                for(int h = 0; h < Height; h++)
                {
                    for(int w = 0; w < Width; w++)
                    {
                        Array[h, w].IsBomb = true;
                    }
                }
            }

            int bs = underloaded ? Bombs : Height * Width - Bombs;
            for (int b = 0; b < bs; b++)
            {
                Random rand = new Random();

                int rHeight = rand.Next(Height);
                int rWidth = rand.Next(Width);

                if (!(Array[rHeight, rWidth].IsBomb == underloaded))
                {
                    Array[rHeight, rWidth].IsBomb = underloaded;
                }
                else { b--; }
            }
        }

        public void AddBombs(int x, int y, int bombs)
        {
            for (int b = 0; b < bombs; b++)
            {
                Random rand = new Random();

                int rHeight = rand.Next(Height);
                int rWidth = rand.Next(Width);

                Space space = Array[rHeight, rWidth];
                if ((space.IsBomb == false) 
                    && (!(rHeight == y || rHeight == y - 1 || rHeight == y + 1)
                    && !(rWidth == x || rWidth == x - 1 || rWidth == x + 1 )))
                {
                    space.IsBomb = true;
                }
                else { b--; }
            }
        }

        public void IncrementBomb()
        {
            BombsLeftLabel.Text = (++BombsLeft).ToString();
        }

        public void DecrementBomb()
        {
            BombsLeftLabel.Text = (--BombsLeft).ToString();
        }

        public void IncrementSafeSpace()
        {
            SafeSpacesLeft++;
        }

        public bool DecrementSafeSpace()
        {
            if (--SafeSpacesLeft <= 0)
            {
                return true;
            }
            return false;
        }

        public void Explode(bool win)
        {
            foreach (Space s in Array)
            {
                if (s.IsBomb)
                {
                    s.ChangeSpaceText("X", Color.Red);
                }
            }
        }

        public int ClearNearbyBombs(int X, int Y)
        {
            int bombs = 0;

            if (Height * Width - Bombs < 10)
            {
                Array[Y, X].IsBomb = false;
                DecrementBomb();
                IncrementSafeSpace();
                return 0;
            }

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    int xValue = X + x;
                    int yValue = Y + y;
                    if (((xValue) >= 0 && (xValue) < Array.GetLength(1))
                        && ((yValue) >= 0 && (yValue) < Array.GetLength(0)))
                    {
                        Space space = Array[yValue, xValue];
                        if (!(space.Status == SpaceStatus.Pressed) && space.IsBomb)
                        {
                            space.IsBomb = false;
                            bombs++;
                        }
                    }
                }
            }
            return bombs;
        }

        public void PressAllNearbyEmptySpaces(int X, int Y)
        {
            int loop = 1;
            for (int x = -loop; x <= loop; x++)
            {
                for (int y = -loop; y <= loop; y++)
                {
                    int xValue = X + x;
                    int yValue = Y + y;
                    if (((xValue) >= 0 && (xValue) < Array.GetLength(1))
                        && ((yValue) >= 0 && (yValue) < Array.GetLength(0)))
                    {
                        Space space = Array[yValue, xValue];
                        if (!(space.Status == SpaceStatus.Pressed))
                        {
                            space.Press(this);
                        }
                    }
                }
            }
        }
    }
}
