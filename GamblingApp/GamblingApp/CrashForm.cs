using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamblingApp
{
    public partial class CrashForm : Form
    {
        private const string START_AT_PREFIX = "Started at ";
        private const string STOP_AT_PREFIX = "Stopped at ";
        private const string CRASH_MULTIPIER_PREFIX = "x";
        private const int STATUS_NEUTRAL = 0;
        private const int STATUS_LOST_STOPPED = 1;
        private const int STATUS_PROFIT_STOPPED = 2;

        private MainForm mainForm = null;
        private float crashMultiplier = 0.00f;
        private float checkpointMultipier = 0.00f;
        private bool isPlaying = false;

        public CrashForm(Form callbackForm)
        {
            mainForm = callbackForm as MainForm;
            InitializeComponent();
        }

        private void AddRatioDataPoint(float toCompared)
        {
            crashChart.Series[0].Points.Add((int)Math.Round(checkpointMultipier / toCompared * 100));
        }

        private void ChangeCrashMultiplier(float value)
        {
            crashMultiplier = (float)Math.Round(value, 2);
            crashMultiplierTextBox.Text = value.ToString() + CRASH_MULTIPIER_PREFIX;
        }

        private void ChangeStatus()
        {
            int status = -1;

            if (checkpointMultipier > 1f) status = STATUS_PROFIT_STOPPED;
            if (checkpointMultipier == 1f) status = STATUS_NEUTRAL;
            if (0f < checkpointMultipier && checkpointMultipier < 1f) status = STATUS_LOST_STOPPED;

            switch (status)
            {
                case 0:
                {
                    crashStatusTextBox.ForeColor = Color.Gray;
                    crashStatusTextBox.Text = "Stayed!";
                    break;
                }
                case 1:
                {
                    crashStatusTextBox.ForeColor = Color.Tomato;
                    crashStatusTextBox.Text = "Stopped at " + checkpointMultipier + CRASH_MULTIPIER_PREFIX + "!";
                    break;
                }
                case 2:
                {
                    crashStatusTextBox.ForeColor = Color.SeaGreen;
                    crashStatusTextBox.Text = "Stopped at " + checkpointMultipier + CRASH_MULTIPIER_PREFIX;
                    break;
                }
                default:
                {
                    if (checkpointMultipier <= 0f)
                    {
                        crashStatusTextBox.ForeColor = Color.DarkRed;
                        crashStatusTextBox.Text = "Crashed!";
                    }
                    break;
                }
            }
        }

        private void UpdateMaxMultiplier()
        {
            if (!int.TryParse(betNumeric.Text, out int result)) return;
            if (result <= 0) maxMultiplierTextBox.Text = "0" + CRASH_MULTIPIER_PREFIX;
            else maxMultiplierTextBox.Text = (result / 10f + 9.9f) + CRASH_MULTIPIER_PREFIX;
        }

        private async void crashButton_Click(object sender, EventArgs e)
        {
            bool result = double.TryParse(maxMultiplierTextBox.Text.Replace(CRASH_MULTIPIER_PREFIX, string.Empty), out double mul);
            float predictedValue = Convert.ToSingle(Math.Round(GamblingClass.rand.NextDouble() * mul, 2));

            if (!result)
            {
                Console.WriteLine("Multiplier access violation");
                return;
            }           
            if (!int.TryParse(betNumeric.Text, out int outNum) || outNum <= 0)
            {
                MessageBox.Show("Enter a valid value.\n(Must be a natural number larger than 0)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MainForm.currentUser.Point - outNum < 0)
            {
                MessageBox.Show("You don't have enough point (" + MainForm.currentUser.Point + " vs " + outNum + ")", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainForm.currentUser.Point -= outNum;
            crashMultiplier = 0f;
            checkpointMultipier = 0f;
            crashMultiplierTextBox.ForeColor = Color.Black;
            crashMultiplierTextBox.Text = "0.00" + CRASH_MULTIPIER_PREFIX;
            crashStatusTextBox.ForeColor = Color.Black;
            crashStatusTextBox.Text = "Waiting for input...";
            crashButton.Enabled = false;
            crashButton.Visible = false;
            stopButton.Enabled = true;
            stopButton.Visible = true;

            mainForm.UpdateUserInfo();

            // Game behavior
            isPlaying = true;
            int quickTimer = 350;
            while (isPlaying)
            {
                await Task.Delay(quickTimer);
                if (quickTimer > 1) quickTimer--;
                ChangeCrashMultiplier(crashMultiplier + 0.01f);
                if (crashMultiplier >= predictedValue)
                {
                    isPlaying = false;
                    crashMultiplierTextBox.ForeColor = Color.Tomato;

                    ChangeStatus();
                    MainForm.currentUser.Point += (int)Math.Round(outNum * checkpointMultipier, 0);

                    crashButton.Enabled = true;
                    crashButton.Visible = true;
                    stopButton.Enabled = false;
                    stopButton.Visible = false;
                }                              
            }

            mainForm.UpdateUserInfo();
            AddRatioDataPoint(predictedValue);
        }

        private void betNumeric_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(betNumeric.Text, out int result))
            {
                maxMultiplierTextBox.Text = "???";
            }
            if (result <= 0) maxMultiplierTextBox.Text = "0" + CRASH_MULTIPIER_PREFIX;
            UpdateMaxMultiplier();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            crashButton.Enabled = false;
            crashButton.Visible = true;
            stopButton.Enabled = false;
            stopButton.Visible = false;
            checkpointMultipier = crashMultiplier;
            ChangeStatus();
        }
    }
}
