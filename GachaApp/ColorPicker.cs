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

namespace GachaApp
{
    public partial class ColorPicker : Form
    {
        public static readonly string COLOR_ACCURACY_PREFIX = "∓";
        public static readonly string MULTIPLIER_PREFIX = "x";

        public float maxMultiplier = 1f;
        public bool isPlaying;
        public bool isColorPicked;
        public bool isPlayerColorSpecial;
        private float betMultiplier = 1f;
        private MainForm mainForm;

        public ColorPicker(Form callbackForm)
        {
            mainForm = callbackForm as MainForm;
            InitializeComponent();
        }
        private void ApplyMultiplier()
        {
            betMultiplier = (float)Math.Round((decimal)maxMultiplier / (multiplierNumeric.Value / 255m) / 1.5m, 2);
            rollColorButton.Text = "Roll! (" + betMultiplier + "x)";
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
                if (playerColorBox.BackColor == color)
                {
                    if (!isPlayerColorSpecial)
                    {
                        maxMultiplier *= 1.5f;
                        isPlayerColorSpecial = !isPlayerColorSpecial;
                    }
                    return;
                }
            }
            
            if (isPlayerColorSpecial)
            {
                maxMultiplier /= 1.5f;
                isPlayerColorSpecial = !isPlayerColorSpecial;
            } 
        }
        private void ChooseRedColor()
        {
            int redColor = GachaClass.Random(0, 0, 255);

            redChosenColorBox.BackColor = Color.FromArgb(redColor, 100, 100);
            redChosenColorBox.Text = redColor.ToString();
            redAccuracyTextBox.Text = (redPlayerColorBox.BackColor.R - redColor).ToString();

            colorAccuracyTextBox.Text = GachaClass.Random(0, 0, 255).ToString();
        }
        private void ChooseGreenColor()
        {
            int greenColor = GachaClass.Random(0, 0, 255);

            greenChosenColorBox.BackColor = Color.FromArgb(100, 100, greenColor);
            greenChosenColorBox.Text = greenColor.ToString();
            greenAccuracyTextBox.Text = (greenPlayerColorBox.BackColor.R - greenColor).ToString();

            colorAccuracyTextBox.Text = GachaClass.Random(0, 0, 255).ToString();
        }
        private void ChooseBlueColor()
        {
            int blueColor = GachaClass.Random(0, 0, 255);

            blueChosenColorBox.BackColor = Color.FromArgb(blueColor, 100, 100);
            blueChosenColorBox.Text = blueColor.ToString();
            blueAccuracyTextBox.Text = (bluePlayerColorBox.BackColor.B - blueColor).ToString();

            colorAccuracyTextBox.Text = GachaClass.Random(0, 0, 255).ToString();
        }      
        private void FinalizeColor()
        {
            int redChosenColor = int.Parse(redChosenColorBox.Text);
            int greenChosenColor = int.Parse(greenChosenColorBox.Text);
            int blueChosenColor = int.Parse(blueChosenColorBox.Text);

            colorAccuracyTextBox.Text = Math.Round((
                Math.Abs(Convert.ToInt32(redAccuracyTextBox.Text)) 
                + Math.Abs(Convert.ToInt32(greenAccuracyTextBox.Text)) 
                + Math.Abs(Convert.ToInt32(blueAccuracyTextBox.Text))) / 3d, 0).ToString();

            chosenColorBox.BackColor = Color.FromArgb(255, redChosenColor, greenChosenColor, blueChosenColor);
        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {
            Color color = Color.Empty;

            for (int i = 27; i <= 167; i++) //27 = Transparent, 167 = YellowGreen, taken from KnownColor enum.
            {
                color = Color.FromKnownColor((KnownColor) i);
                if (color.A != 255) continue;
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
            ApplyMultiplier();
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
                for (int i = 0; i <= GachaClass.Random(0, 50, 100); i++)
                {
                    ChooseRedColor();
                    await Task.Delay(5).ConfigureAwait(true);
                }
                for (int i = 0; i <= GachaClass.Random(0, 60, 120); i++)
                {
                    ChooseGreenColor();
                    await Task.Delay(5).ConfigureAwait(true);
                }
                for (int i = 0; i <= GachaClass.Random(0, 70, 140); i++)
                {
                    ChooseBlueColor();
                    await Task.Delay(5).ConfigureAwait(true);
                }
                FinalizeColor();
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
            ApplyMultiplier();
        }
        private void ColorPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isPlaying)
            {
                DialogResult dg = MessageBox.Show("If you close this game, all of your points will be lost.\nContinue?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dg != DialogResult.OK)
                {
                    e.Cancel = true;

                }
            }
        }
        private void bonusColorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isColorPicked = true;

            int plusNum = 27;
            while (Color.FromKnownColor((KnownColor)bonusColorListBox.SelectedIndex + 1 + plusNum).A != 255)
            {
                plusNum++;
            }
            playerColorBox.BackColor = Color.FromKnownColor((KnownColor)bonusColorListBox.SelectedIndex + 1 + plusNum);

            redPlayerColorBox.BackColor = Color.FromArgb(255, playerColorBox.BackColor.R, 100, 100);
            redPlayerColorBox.Text = playerColorBox.BackColor.R.ToString();

            greenPlayerColorBox.BackColor = Color.FromArgb(255, 100, playerColorBox.BackColor.G, 100);
            greenPlayerColorBox.Text = playerColorBox.BackColor.G.ToString();

            bluePlayerColorBox.BackColor = Color.FromArgb(255, 100, 100, playerColorBox.BackColor.B);
            bluePlayerColorBox.Text = playerColorBox.BackColor.B.ToString();

            CheckColorMultiplier();
            ApplyMultiplier();
            ChangeDefaultPlayerBackColor();
        }
    }
}
