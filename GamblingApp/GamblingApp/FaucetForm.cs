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
    public partial class FaucetForm : Form
    {
        struct PriceDictionary
        {
            public int Lowest { get; set; }
            public int Highest { get; set; }
            public int Price { get; set; }

            public PriceDictionary(int _Lowest, int _Highest, int _Price)
            {
                Lowest = _Lowest;
                Highest = _Highest;
                Price = _Price;
            }
        }

        private const float DEFAULT_RATE = 20f;

        private float rate = DEFAULT_RATE;
        private MainForm mainForm = null;
        private List<PriceDictionary> priceLookup = new List<PriceDictionary>();
        public int plusPrice = 1;
        public bool isPlaying = false;
        public bool isLarger = false;     

        public FaucetForm(Form callbackForm)
        {
            mainForm = callbackForm as MainForm;
            InitializeComponent();
            #region Add price lookup
            priceLookup.Add(new PriceDictionary(0, 7500, 1));
            priceLookup.Add(new PriceDictionary(7501, 25000, 2));
            priceLookup.Add(new PriceDictionary(25001, 60000, 3));
            priceLookup.Add(new PriceDictionary(60001, 100001, 4));
            priceLookup.Add(new PriceDictionary(100001, 350000, 7));
            priceLookup.Add(new PriceDictionary(350000, 550000, 10));
            priceLookup.Add(new PriceDictionary(500001, 725000, 15));
            priceLookup.Add(new PriceDictionary(725001, 800000, 17));
            priceLookup.Add(new PriceDictionary(800001, 900000, 20));
            priceLookup.Add(new PriceDictionary(900001, 950000, 25));
            priceLookup.Add(new PriceDictionary(950001, 975000, 30));
            priceLookup.Add(new PriceDictionary(975001, 985000, 35));
            priceLookup.Add(new PriceDictionary(985001, 990000, 45));
            priceLookup.Add(new PriceDictionary(990000, 999999, 50));
            priceLookup.Add(new PriceDictionary(999999, int.MaxValue, 50));
            #endregion
            PlusRateUpdateUI();
        }

        private void FaucetUpdateUI(int number)
        {
            string strNumber = string.Empty;

            if (number > 999999)
            {
                FaucetUpdateUI(999999);
                return;
            }
            for (int i = 1; i <= 5; i++)
            {
                if (number < Math.Pow(10, i))
                {
                    strNumber += "0";
                }
            }
            strNumber += number.ToString();
            unitPrefixTextBox.Text = strNumber[5].ToString();
            tenPrefixTextBox.Text = strNumber[4].ToString();
            hundredPrefixTextBox.Text = strNumber[3].ToString();
            thousandPrefixTextBox.Text = strNumber[2].ToString();
            tenThousandsPrefixTextBox.Text = strNumber[1].ToString();
            hundredThousandsPrefixTextBox.Text = strNumber[0].ToString();         
        }

        private void PlusRateUpdateUI()
        {
            plusRateTextBox.Text = plusPrice + " / ~" + rate;
        }

        private async void faucetRollButton_Click(object sender, EventArgs e)
        {
            unitPrefixTextBox.Text = "0";
            tenPrefixTextBox.Text = "0";
            hundredPrefixTextBox.Text = "0";
            thousandPrefixTextBox.Text = "0";
            tenThousandsPrefixTextBox.Text = "0";
            hundredThousandsPrefixTextBox.Text = "0";

            int chosenNumber = 0;
            faucetRollButton.Enabled = false;
            plusRateButton.Enabled = false;
            isPlaying = true;
            while (isPlaying)
            {
                chosenNumber += GamblingClass.Random(0, 250, 750);
                FaucetUpdateUI(chosenNumber);
                await Task.Delay(25);
                if (GamblingClass.Random(0, 1, 999999) > (999999 - chosenNumber / rate) || chosenNumber > 999999) isPlaying = false;
            }
            plusPrice = 1;
            rate = DEFAULT_RATE;
            PlusRateUpdateUI();
            foreach (var price in priceLookup)
            {
                if (chosenNumber > price.Lowest && chosenNumber < price.Highest) MainForm.currentUser.Point += price.Price;
            }
            mainForm.UpdateUserInfo();
            faucetRollButton.Enabled = true;
            plusRateButton.Enabled = true;
        }

        private void plusRateButton_Click(object sender, EventArgs e)
        {
            if (MainForm.currentUser.Point - plusPrice < 0)
            {
                MessageBox.Show("You don't have enough point (" + MainForm.currentUser.Point + " vs " + plusPrice + ")", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainForm.currentUser.Point -= plusPrice;
            float price = rate;
            for (int i = 1; i <= plusPrice; i++)
            {
                price /= 1.5f;
            }

            plusPrice += 1;
            rate += price;
            PlusRateUpdateUI();
            mainForm.UpdateUserInfo();
        }
    }
}
