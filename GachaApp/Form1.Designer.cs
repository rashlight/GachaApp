namespace GachaApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GachaAppFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.openSaveFileButton = new System.Windows.Forms.Button();
            this.createsaveFileButton = new System.Windows.Forms.Button();
            this.GachaPointTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.gameModeListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.playGameButton = new System.Windows.Forms.Button();
            this.riskLevelLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.welcomeTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(622, 26);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GachaAppFileToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // GachaAppFileToolStripMenuItem
            // 
            this.GachaAppFileToolStripMenuItem.Name = "GachaAppFileToolStripMenuItem";
            this.GachaAppFileToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.GachaAppFileToolStripMenuItem.Text = "GachaApp File...";
            this.GachaAppFileToolStripMenuItem.Click += new System.EventHandler(this.GachaAppFileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.exitToolStripMenuItem.Text = "Exit...";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizerToolStripMenuItem,
            this.colorTemplateToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // randomizerToolStripMenuItem
            // 
            this.randomizerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordinaryToolStripMenuItem});
            this.randomizerToolStripMenuItem.Name = "randomizerToolStripMenuItem";
            this.randomizerToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.randomizerToolStripMenuItem.Text = "Randomizer";
            // 
            // ordinaryToolStripMenuItem
            // 
            this.ordinaryToolStripMenuItem.Name = "ordinaryToolStripMenuItem";
            this.ordinaryToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.ordinaryToolStripMenuItem.Text = "Ordinary...";
            // 
            // colorTemplateToolStripMenuItem
            // 
            this.colorTemplateToolStripMenuItem.Name = "colorTemplateToolStripMenuItem";
            this.colorTemplateToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.colorTemplateToolStripMenuItem.Text = "Color Template...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Open a save file to continue. Or create new one!";
            // 
            // openSaveFileButton
            // 
            this.openSaveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSaveFileButton.Location = new System.Drawing.Point(74, 113);
            this.openSaveFileButton.Name = "openSaveFileButton";
            this.openSaveFileButton.Size = new System.Drawing.Size(184, 53);
            this.openSaveFileButton.TabIndex = 13;
            this.openSaveFileButton.Text = "Open";
            this.openSaveFileButton.UseVisualStyleBackColor = true;
            this.openSaveFileButton.Click += new System.EventHandler(this.openSaveFileButton_Click);
            // 
            // createsaveFileButton
            // 
            this.createsaveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createsaveFileButton.Location = new System.Drawing.Point(298, 113);
            this.createsaveFileButton.Name = "createsaveFileButton";
            this.createsaveFileButton.Size = new System.Drawing.Size(266, 53);
            this.createsaveFileButton.TabIndex = 17;
            this.createsaveFileButton.Text = "Create / Save";
            this.createsaveFileButton.UseVisualStyleBackColor = true;
            this.createsaveFileButton.Click += new System.EventHandler(this.createsaveFileButton_Click);
            // 
            // GachaPointTextBox
            // 
            this.GachaPointTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GachaPointTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GachaPointTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GachaPointTextBox.Location = new System.Drawing.Point(12, 203);
            this.GachaPointTextBox.Name = "GachaPointTextBox";
            this.GachaPointTextBox.Size = new System.Drawing.Size(598, 20);
            this.GachaPointTextBox.TabIndex = 15;
            this.GachaPointTextBox.Text = "Gacha Point:";
            this.GachaPointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GachaPointTextBox.TextChanged += new System.EventHandler(this.GachaPointTextBox_TextChanged);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(12, 182);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(598, 20);
            this.userNameTextBox.TabIndex = 14;
            this.userNameTextBox.Text = "Username:";
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // gameModeListBox
            // 
            this.gameModeListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gameModeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameModeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameModeListBox.FormattingEnabled = true;
            this.gameModeListBox.ItemHeight = 22;
            this.gameModeListBox.Location = new System.Drawing.Point(12, 241);
            this.gameModeListBox.Name = "gameModeListBox";
            this.gameModeListBox.ScrollAlwaysVisible = true;
            this.gameModeListBox.Size = new System.Drawing.Size(295, 176);
            this.gameModeListBox.TabIndex = 18;
            this.gameModeListBox.SelectedIndexChanged += new System.EventHandler(this.gameModeListBox_SelectedIndexChanged);
            this.gameModeListBox.DoubleClick += new System.EventHandler(this.gameModeListBox_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(313, 261);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(309, 95);
            this.descriptionTextBox.TabIndex = 20;
            this.descriptionTextBox.Text = "Choose a gamemode...";
            // 
            // playGameButton
            // 
            this.playGameButton.Location = new System.Drawing.Point(317, 385);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(298, 35);
            this.playGameButton.TabIndex = 21;
            this.playGameButton.Text = "Play";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // riskLevelLabel
            // 
            this.riskLevelLabel.AutoSize = true;
            this.riskLevelLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.riskLevelLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riskLevelLabel.Location = new System.Drawing.Point(393, 359);
            this.riskLevelLabel.Name = "riskLevelLabel";
            this.riskLevelLabel.Size = new System.Drawing.Size(149, 18);
            this.riskLevelLabel.TabIndex = 22;
            this.riskLevelLabel.Text = "Choose a gamemode...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Risk Level:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "gaf";
            this.openFileDialog.Filter = "GachaApp file|*.gaf|All files|*.*";
            this.openFileDialog.ReadOnlyChecked = true;
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.ShowHelp = true;
            this.openFileDialog.ShowReadOnly = true;
            this.openFileDialog.SupportMultiDottedExtensions = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CreatePrompt = true;
            this.saveFileDialog.DefaultExt = "gaf";
            this.saveFileDialog.Filter = "GachaApp file|*.gaf";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.ShowHelp = true;
            this.saveFileDialog.SupportMultiDottedExtensions = true;
            // 
            // welcomeTextBox
            // 
            this.welcomeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.welcomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTextBox.Location = new System.Drawing.Point(10, 37);
            this.welcomeTextBox.Name = "welcomeTextBox";
            this.welcomeTextBox.Size = new System.Drawing.Size(598, 34);
            this.welcomeTextBox.TabIndex = 24;
            this.welcomeTextBox.Text = "Welcome back!";
            this.welcomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.welcomeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.riskLevelLabel);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gameModeListBox);
            this.Controls.Add(this.createsaveFileButton);
            this.Controls.Add(this.GachaPointTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.openSaveFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gacha App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openSaveFileButton;
        private System.Windows.Forms.Button createsaveFileButton;
        private System.Windows.Forms.ListBox gameModeListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Label riskLevelLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem GachaAppFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorTemplateToolStripMenuItem;
        public System.Windows.Forms.TextBox GachaPointTextBox;
        public System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.ToolStripMenuItem ordinaryToolStripMenuItem;
        private System.Windows.Forms.TextBox welcomeTextBox;
    }
}

