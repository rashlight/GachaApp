using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GachaApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Contains game mode infos
        /// </summary>
        public struct GameModeInfo
        {
            public string GameMode { get; }
            public string RiskLevel { get; }
            public string EntryPrice { get; }
            public string Description { get; }

            public GameModeInfo(string _GameMode, string _RiskLevel, string _EntryPrice, string _Description)
            {
                GameMode = _GameMode;
                RiskLevel = _RiskLevel;
                EntryPrice = _EntryPrice;
                Description = _Description;
            }
        }
        /// <summary>
        /// Contains user info
        /// </summary>
        public struct UserInfo
        {
            public bool Activated { get; set; }
            public string UserName { get; set; }
            public BigInteger Point { get; set; }
            public DateTime TimePlayed { get; set; }         

            public UserInfo(bool _Activated, string _UserName, int _Point, DateTime _TimePlayed)
            {
                Activated = _Activated;
                UserName = _UserName;
                Point = _Point;
                TimePlayed = _TimePlayed;
            }

            public void SetDefault()
            {
                Activated = true;
                UserName = "Guest";
                Point = BigInteger.Zero;
                TimePlayed = DateTime.Now;
            }

            public void SetInfo(bool _Activated, string _UserName, int _Point, DateTime _TimePlayed)
            {
                Activated = _Activated;
                UserName = _UserName;
                Point = _Point;
                TimePlayed = _TimePlayed;
            }
        }

        public static readonly string TITLE_PREFIX = "GachaApp";
        public static readonly string USERNAME_PREFIX = "Username: ";
        public static readonly string Gacha_POINT_PREFIX = "Gacha Point: ";
        public static UserInfo currentUser = new UserInfo();

        private readonly List<GameModeInfo> gameModes = new List<GameModeInfo>();

        public static void CloseAllButMainForm()
        {
            while (Application.OpenForms.Count > 1)
            {
                Application.OpenForms[1].Close();
            }
        }
        public static Form GetSameFormInstance(Form form)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form checkingForm in fc)
            {
                if (form.GetType() == checkingForm.GetType())
                {
                    return checkingForm;
                }
            }

            return null;
        }
        public void OpenGameForm()
        {
            if (!currentUser.Activated || currentUser.Point < 0)
            {
                MessageBox.Show("User error! Please log in...", "No user logon.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (gameModeListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Choose any game first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            switch (gameModeListBox.SelectedIndex)
            {
                case 0:
                {
                    FaucetForm ff = new FaucetForm(this);
                    if (GetSameFormInstance(ff) != null)
                    {
                        GetSameFormInstance(ff).Focus();
                        ff.Dispose();
                    }
                    else
                    {
                        ff.Show();
                    }
                    break;
                }
                case 1:
                {
                    CrashForm cf = new CrashForm(this);
                    if (GetSameFormInstance(cf) != null)
                    {
                        GetSameFormInstance(cf).Focus();
                        cf.Dispose();
                    }
                    else
                    {
                        cf.Show();
                    }
                    break;
                }
                case 2:
                {
                    ColorPicker cp = new ColorPicker(this);
                    if (GetSameFormInstance(cp) != null)
                    {
                        GetSameFormInstance(cp).Focus();
                        cp = null;
                        cp.Dispose();
                    }
                    else
                    { 
                        cp.Show();
                    }
                    break;
                }
                default: throw new AccessViolationException("How's that possible?");
            }          
        }
        public void UpdateUserInfo()
        {
            userNameTextBox.Text = USERNAME_PREFIX + currentUser.UserName;
            GachaPointTextBox.Text = Gacha_POINT_PREFIX + currentUser.Point.ToString();

            if (currentUser.Activated)
            {
                userNameTextBox.ForeColor = Color.Black;
                GachaPointTextBox.ForeColor = Color.Black;
            }
            else
            {
                userNameTextBox.ForeColor = Color.Tomato;
                GachaPointTextBox.ForeColor = Color.Tomato;
            }
        }

        public MainForm()
        {
            InitializeComponent();         
        }  

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Game modes initialization

            gameModeListBox.Items.Clear();
            gameModes.Add(new GameModeInfo("Faucet", "0", "0", "Get free points here!"));
            gameModes.Add(new GameModeInfo("Crash", "3", "10", "The more you wait, more risk you bears."));
            gameModes.Add(new GameModeInfo("Color Picker", "2", "15", "Choose a color. Distance will be your might."));

            foreach (var _GameModeInfo in gameModes)
            {
                gameModeListBox.Items.Add(_GameModeInfo.GameMode);
            }

            #endregion
            #region User setup

            currentUser.SetDefault();

            #endregion
            #region UI Setup

            welcomeTextBox.Text = "Welcome back, " + Environment.UserName + "!";
            UpdateUserInfo();

            #endregion
        }
        private void playGameButton_Click(object sender, EventArgs e)
        {
            OpenGameForm();
        }
        private void gameModeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gameModeListBox.SelectedIndex < 0) return;
            descriptionTextBox.Text = gameModes[gameModeListBox.SelectedIndex].Description;
            riskLevelLabel.Text = gameModes[gameModeListBox.SelectedIndex].RiskLevel;
        }
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!currentUser.Activated)
            {
                userNameTextBox.ForeColor = Color.OrangeRed;
            }
            else
            {
                userNameTextBox.ForeColor = Color.Black;
            }
        }
        private void GachaPointTextBox_TextChanged(object sender, EventArgs e)
        {
            if (currentUser.Point < 0)
            {
                GachaPointTextBox.ForeColor = Color.OrangeRed;
            } 
            else userNameTextBox.ForeColor = Color.Black;
        }
        private void createsaveFileButton_Click(object sender, EventArgs e)
        {
            string userCrationPrefix = "Saved user: ";

            DialogResult dg = saveFileDialog.ShowDialog();
            if (dg == DialogResult.Cancel) return;

            if (!currentUser.Activated)
            {
                currentUser.UserName = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                currentUser.Point = 0;
                currentUser.Activated = true;
                currentUser.TimePlayed = DateTime.UtcNow;
                userCrationPrefix = "Created user: ";
            }

            try
            {
                CloseAllButMainForm();
                string encrypted = GachaApp.Encrypt.EncryptString(
                currentUser.Activated + "\r\n" + currentUser.UserName + "\r\n" + currentUser.Point + "\r\n" + currentUser.TimePlayed,
                GachaClass.THE_KEY);
                File.WriteAllText(saveFileDialog.FileName, encrypted.ToString(), Encoding.UTF8);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error! - " + exp);
                MessageBox.Show("User creation / saving failed. Reason: " + exp.Message, "Error! " + exp.HResult, MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentUser.SetDefault();
            }     
            finally
            {
                UpdateUserInfo();
            }
            Console.WriteLine(userCrationPrefix + currentUser.UserName);
        }
        private void openSaveFileButton_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            DialogResult dg = openFileDialog.ShowDialog();
            if (dg == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                CloseAllButMainForm();
                var stream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(stream))
                {
                    fileContent = GachaApp.Encrypt.DecryptString(reader.ReadToEnd(), GachaApp.GachaClass.THE_KEY);
                }
                string[] info = Regex.Split(fileContent, "\r\n");
                currentUser.Activated = Convert.ToBoolean(info[0]);
                currentUser.UserName = info[1];
                currentUser.Point = BigInteger.Parse(info[2]);
                currentUser.TimePlayed = Convert.ToDateTime(info[3]);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error! - " + exp);
                MessageBox.Show("User loading failed. Reason: " + exp.Message, "Error! " + exp.HResult, MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentUser.SetDefault();
                return;
            }
            Console.WriteLine("Loaded user: " + currentUser.UserName);
            UpdateUserInfo();
        }
        private void gameModeListBox_DoubleClick(object sender, EventArgs e)
        {
            OpenGameForm();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
        private void GachaAppFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createsaveFileButton_Click(null, new EventArgs());
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSaveFileButton_Click(null, new EventArgs());
        }
    }
}
