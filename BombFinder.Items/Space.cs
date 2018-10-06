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

        public SpaceStatus RightClick()
        {
            switch (Status)
            {
                case SpaceStatus.Empty:
                    Status = SpaceStatus.Flagged;
                    ChangeSpaceText("F", Color.Green);
                    break;
                case SpaceStatus.Flagged:
                    Status = SpaceStatus.Questioned;
                    ChangeSpaceText("?", Color.Blue);
                    break;
                case SpaceStatus.Questioned:
                    Status = SpaceStatus.Empty;
                    ChangeSpaceText("", Color.Black);
                    break;
                case SpaceStatus.Pressed:
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
    }
}