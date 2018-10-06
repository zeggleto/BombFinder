using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BombFinder.Items;

namespace BombFinder
{
    public partial class BombFinder : Form
    {
        public BombFinder()
        {
            InitializeComponent();
        }

        private void customRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (customRadio.Checked)
                customRulesGroupBox.Visible = true;
            else
                customRulesGroupBox.Visible = false;
        }

        private void heightTrackBar_Scroll(object sender, EventArgs e)
        {
            heightLabel.Text = heightTrackBar.Value.ToString();
            bombsTrackBar.Maximum = (heightTrackBar.Value * widthTrackBar.Value) - 1;
        }

        private void widthTrackBar_Scroll(object sender, EventArgs e)
        {
            widthLabel.Text = widthTrackBar.Value.ToString();
            bombsTrackBar.Maximum = (heightTrackBar.Value * widthTrackBar.Value) - 1;
        }

        private void bombsTrackBar_Scroll(object sender, EventArgs e)
        {
            bombsLabel.Text = bombsTrackBar.Value.ToString();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (easyRadio.Checked)
                CreateBombField(8, 8, 10, "Easy", true);
            else if (moderateRadio.Checked)
                CreateBombField(16, 16, 40, "Moderate", true);
            else if (hardRadio.Checked)
                CreateBombField(30, 16, 100, "Hard", true);
            else if (slightlyHarderRadio.Checked)
                CreateBombField(30, 30, 899, "Slightly Harder", false);
            else if (customRadio.Checked)
                CreateBombField(heightTrackBar.Value, widthTrackBar.Value, bombsTrackBar.Value,
                    "Custom", safeCheckBox.Checked);
            ToggleMenuVisibility(false);
        }

        private void spaceBtn_Click(object sender, MouseEventArgs e)
        {
            Space space = sender as Space;
            BombField bf = Global.MainBombField;
            if (space.Status == SpaceStatus.Pressed)
            {
                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                if (space.Status == SpaceStatus.Empty && bf.BombsLeft <= 0)
                {
                    Global.GameStatusLabel.Text = "Out of Flags";
                }
                else
                {
                    SpaceStatus rc = space.RightClick();
                    if (rc == SpaceStatus.Flagged)
                    {
                        bf.DecrementBomb();
                    }
                    else if (rc == SpaceStatus.Questioned)
                    {
                        bf.IncrementBomb();
                    }
                }

                return;
            }

            if (bf.FirstPressSafe)
            {
                int bombs = bf.ClearNearbyBombs(space.X, space.Y);
                bf.AddBombs(space.X, space.Y, bombs);
                bf.FirstPressSafe = false;
            }


            if (bf.Press(space))
            {
                Global.GameStatusLabel.Text = "BOOM!";
                foreach (Space s in bf.Array)
                {
                    s.MouseUp -= spaceBtn_Click;
                }
            }
            else if (bf.SafeSpacesLeft == 0)
            {
                Global.GameStatusLabel.Text = "Nice!";
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetBombFields();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls.OfType<Control>())
            {
                item.Visible = false;
            }
            ToggleMenuVisibility(true);
        }

        private void ResetBombFields()
        {
            Global.GameStatusLabel.Text = "";

            BombField bf = Global.MainBombField;
            bf.BombsLeft = bf.Bombs;
            bf.SafeSpacesLeft = (bf.Height * bf.Width) - bf.Bombs;
            bf.BombsLeftLabel.Text = bf.BombsLeft.ToString();
            bf.FirstPressSafe =
                (bf.Difficulty == "Slightly Harder" || (!safeCheckBox.Checked && bf.Difficulty == "Custom"))
                ? false : true;

            foreach (Space s in bf.Array)
            {
                s.Status = SpaceStatus.Empty;
                s.BackColor = Color.Gainsboro;
                s.ChangeSpaceText(String.Empty, Color.Black);
                s.MouseUp -= spaceBtn_Click;
                s.MouseUp += spaceBtn_Click;
                s.IsBomb = false;
            }
            bf.LoadBombs();
        }

        private void ToggleMenuVisibility(bool visible)
        {
            if (visible)
                Size = new Size(390, 313);

            startBtn.Visible = visible;
            difficultyGroupBox.Visible = visible;
            customRulesGroupBox.Visible = (customRadio.Checked) ? visible : false;
            gameLogo.Visible = visible;
        }

        private void CreateBombField(int height, int width, int bombs, string difficulty, bool firstPressSafe)
        {
            Global.MainBombField = new BombField(height, width, bombs, difficulty, firstPressSafe);
            Size = new Size(width * 18 + 150, height * 18 + 120);
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    Space button = new Space(w, h);

                    button.Size = new Size(20, 20);
                    button.Location = new Point(w * 18 + 20, h * 18 + 20);
                    button.Font = new Font(button.Font, FontStyle.Bold);
                    button.MouseUp += new MouseEventHandler(spaceBtn_Click);
                    Global.MainBombField.LoadSpace(button, h, w);

                    Controls.Add(button);
                }
            }
            Label bombsLeftTextLabel = new Label();
            Label numberOfBombsLeftLabel = new Label();

            bombsLeftTextLabel.Location = new Point(width * 18 + 50, 20);
            numberOfBombsLeftLabel.Location = new Point(width * 18 + 70, 45);

            bombsLeftTextLabel.Text = "Bombs Left: ";
            numberOfBombsLeftLabel.Text = bombs.ToString();

            Global.GameStatusLabel = new Label();
            Global.GameStatusLabel.Location = new Point(width * 18 + 50, height * 18);

            Button resetBtn = new Button();
            Button quitBtn = new Button();

            resetBtn.Click += new EventHandler(resetBtn_Click);
            quitBtn.Click += new EventHandler(quitBtn_Click);

            resetBtn.Text = "Reset";
            quitBtn.Text = "Quit";
            resetBtn.Location = new Point(20, height * 18 + 50);
            quitBtn.Location = new Point(100, height * 18 + 50);

            Controls.Add(bombsLeftTextLabel);
            Controls.Add(numberOfBombsLeftLabel);
            Controls.Add(resetBtn);
            Controls.Add(quitBtn);
            Controls.Add(Global.GameStatusLabel);

            Global.MainBombField.BombsLeft = bombs;
            Global.MainBombField.BombsLeftLabel = numberOfBombsLeftLabel;

            Global.MainBombField.LoadBombs();
        }
    }
}
