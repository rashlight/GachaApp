using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamblingApp
{
    public partial class ColorPicker : Form
    {
        public static readonly string COLOR_ACCURACY_PREFIX = "∓";
        public const string MULTIPLIER_PREFIX = "x";

        public float betMultiplier = 1f;
        public bool isColorPicked;
        public bool isPlaying;
        private bool isPlayerColorSpecial;
        private MainForm mainForm = null;

        public ColorPicker(Form callbackForm)
        {
            mainForm = callbackForm as MainForm;
            InitializeComponent();
            multiplierNumeric.Value = 0m;
        }

        private void ChangeDefaultPlayerBackColor()
        {
            redPlayerColorBox.ForeColor = Color.AntiqueWhite;
            greenPlayerColorBox.ForeColor = Color.AntiqueWhite;
            bluePlayerColorBox.ForeColor = Color.AntiqueWhite;
        }

        private void ChangeDefaultChosenBackColor()
        {
            redChosenColorBox.ForeColor = Color.AntiqueWhite;
            greenChosenColorBox.ForeColor = Color.AntiqueWhite;
            blueChosenColorBox.ForeColor = Color.AntiqueWhite;
        }

        private void CheckColorMultiplier()
        {
            Color color = Color.Empty;

            for (int i = 27; i <= 167; i++) //27 = Transparent, 167 = YellowGreen, taken from KnownColor enum.
            {
                color = Color.FromKnownColor((KnownColor)i);
                if (playerColorBox.BackColor == color && !isPlayerColorSpecial)
                {
                    betMultiplier += 1f;
                    isPlayerColorSpecial = !isPlayerColorSpecial;
                    rollColorButton.Text = "Roll! (" + betMultiplier + "x)";
                    return;
                }                
            }
            
            if (isPlayerColorSpecial)
            {
                betMultiplier -= 1f;
                isPlayerColorSpecial = !isPlayerColorSpecial;
                rollColorButton.Text = "Roll! (" + betMultiplier + "x)";
            } 
        }

        private void ChooseColor()
        {
            Color color = Color.FromArgb(GamblingClass.Random(0, 0, 255), GamblingClass.Random(0, 0, 255), GamblingClass.Random(0, 0, 255));

            chosenColorBox.BackColor = color;

            colorAccuracyTextBox.Text = Math.Round((Math.Abs(colorDialog.Color.R - color.R) + Math.Abs(colorDialog.Color.G - color.G) + Math.Abs(colorDialog.Color.B - color.B)) / 3d, 0).ToString();

            redChosenColorBox.BackColor = Color.FromArgb(color.R, 100, 100);
            greenChosenColorBox.BackColor = Color.FromArgb(100, color.G, 100);
            blueChosenColorBox.BackColor = Color.FromArgb(100, 100, color.B);

            redChosenColorBox.Text = color.R.ToString();
            greenChosenColorBox.Text = color.G.ToString();
            blueChosenColorBox.Text = color.B.ToString();

            redAccuracyTextBox.Text = (redPlayerColorBox.BackColor.R - redChosenColorBox.BackColor.R).ToString();
            greenAccuracyTextBox.Text = (greenPlayerColorBox.BackColor.G - greenChosenColorBox.BackColor.G).ToString();
            blueAccuracyTextBox.Text = (bluePlayerColorBox.BackColor.B - blueChosenColorBox.BackColor.B).ToString();

        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {
            Color color = Color.Empty;

            for (int i = 27; i <= 167; i++) //27 = Transparent, 167 = YellowGreen, taken from KnownColor enum.
            {
                color = Color.FromKnownColor((KnownColor) i);
                bonusColorListBox.Items.Add(color.Name + ": (" + color.R + ", " + color.G + ", " + color.B + ")");
            }
        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            isColorPicked = true;
            playerColorBox.BackColor = colorDialog.Color;
            redPlayerColorBox.Text = colorDialog.Color.R.ToString();
            redPlayerColorBox.BackColor = Color.FromArgb(colorDialog.Color.R, 100, 100);
            greenPlayerColorBox.Text = colorDialog.Color.G.ToString();
            greenPlayerColorBox.BackColor = Color.FromArgb(100, colorDialog.Color.G, 100);
            bluePlayerColorBox.Text = colorDialog.Color.B.ToString();
            bluePlayerColorBox.BackColor = Color.FromArgb(100, 100, colorDialog.Color.B);

            ChangeDefaultPlayerBackColor();
            CheckColorMultiplier();
        }

        private async void rollColorButton_Click(object sender, EventArgs e)
        {
            if (!isColorPicked)
            {
                MessageBox.Show("Choose a color to continue...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!int.TryParse(betAmount.Text, out int outNum) || outNum <= 0)
            {
                MessageBox.Show("Enter a valid value.\n(Must be a natural number larger than 0)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MainForm.currentUser.Point - outNum < 0)
            {
                MessageBox.Show("You don't have enough point (" + MainForm.currentUser.Point + " vs " + outNum + ")", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            rollColorButton.Enabled = false;
            pickColorButton.Enabled = false;
            betAmount.Enabled = false;

            MainForm.currentUser.Point -= outNum;
            mainForm.UpdateUserInfo();

            ChangeDefaultChosenBackColor();
            isPlaying = true;
            while (isPlaying)
            {               
                for (int i = 0; i <= GamblingClass.Random(0, 100, 200); i++)
                {
                    ChooseColor();
                    await Task.Delay(5).ConfigureAwait(true);
                }
                isPlaying = false;
            }

            if (int.Parse(colorAccuracyTextBox.Text) <= multiplierNumeric.Value)
            {
                colorAccuracyTextBox.ForeColor = Color.SeaGreen;
                MainForm.currentUser.Point += (int)(outNum * betMultiplier);
            }
            else
            {
                colorAccuracyTextBox.ForeColor = Color.Tomato;
            }

            mainForm.UpdateUserInfo();

            betAmount.Enabled = true;
            rollColorButton.Enabled = true;
            pickColorButton.Enabled = true;
        }

        private void multiplierNumeric_ValueChanged(object sender, EventArgs e)
        {
            betMultiplier = (float)Math.Round(1.0m + (1.0m - multiplierNumeric.Value / 255m), 2);
            if (isPlayerColorSpecial) betMultiplier += 1f;
            rollColorButton.Text = "Roll! (" + betMultiplier + "x)";
        }

        private void ColorPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isPlaying)
            {
                DialogResult dg = MessageBox.Show("If you close this game, all of your points will be lost.\nContinue?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dg != DialogResult.OK) e.Cancel = true;
            }
        }
    }
}
