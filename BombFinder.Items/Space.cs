using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BombFinder.Items
{
    public enum SpaceStatus { Empty, Flagged, Questioned, Pressed }

    public class Space : Button
    {
        public int X { get; set; }
        public int Y { get; set; }
        public SpaceStatus Status { get; set; }
        public bool IsBomb { get; set; }

        public Space(int x, int y) : base()
        {
            X = x;
            Y = y;
            Status = SpaceStatus.Empty;
            IsBomb = false;
        }

        public bool CheckIfFirstPressIsSafe(BombField bombField)
        {
            if (!bombField.FirstPressSafe)
            {
                return false;
            }

            int bombs = bombField.ClearNearbyBombs(X,Y);
            bombField.AddBombs(X, Y, bombs);
            bombField.FirstPressSafe = false;

            return true;
        }

        public bool Press(BombField bombField)
        {
            if(Status == SpaceStatus.Pressed)
            {
                return false;
            }

            if (IsBomb)
            {
                bombField.Explode(false);
                return true;
            }
            else
            {
                if(Status == SpaceStatus.Flagged)
                {
                    bombField.IncrementBomb();
                }

                Status = SpaceStatus.Pressed;

                if (CheckForNearbyBombs(bombField) == 0)
                {
                    bombField.PressAllNearbyEmptySpaces(X,Y);
                }
                bombField.DecrementSafeSpace();
                return false;
            }
        }

        public SpaceStatus RightClick(BombField bombField)
        {
            switch (Status)
            {
                case SpaceStatus.Empty:
                    Status = SpaceStatus.Flagged;
                    bombField.DecrementBomb();
                    ChangeSpaceText("F", Color.Green);
                    break;
                case SpaceStatus.Flagged:
                    Status = SpaceStatus.Questioned;
                    bombField.IncrementBomb();
                    ChangeSpaceText("?", Color.Blue);
                    break;
                case SpaceStatus.Questioned:
                    Status = SpaceStatus.Empty;
                    ChangeSpaceText("", Color.Black);
                    break;
                default:
                    Status = SpaceStatus.Empty;
                    ChangeSpaceText("", Color.Black);
                    break;
            }
            return Status;
        }

        public void ChangeSpaceText(string text, Color color)
        {
            Text = text;
            ForeColor = color;
        }

        public int CheckForNearbyBombs(BombField bombField)
        {
            int bombCount = 0;
            for(int x = -1; x <= 1; x++)
            {
                for(int y = -1; y <= 1; y++)
                {
                    if(((X + x) >= 0 && (X + x) < bombField.Array.GetLength(1))
                        && ((Y + y) >= 0 && (Y + y) < bombField.Array.GetLength(0)))
                    {
                        if (bombField.Array[Y + y, X + x].IsBomb)
                        {
                            bombCount++;
                        }
                    }
                }
            }
            if (bombCount == 0)
            {
                BackColor = Color.DarkGray;
            }
            else
            {
                Text = bombCount.ToString();
            }
            return bombCount;
        }
    }
}
