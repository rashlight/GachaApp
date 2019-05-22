namespace GamblingApp
{
    partial class ColorPicker
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pickColorButton = new System.Windows.Forms.Button();
            this.bonusColorListBox = new System.Windows.Forms.ListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.rollColorButton = new System.Windows.Forms.Button();
            this.redPlayerColorBox = new System.Windows.Forms.TextBox();
            this.greenPlayerColorBox = new System.Windows.Forms.TextBox();
            this.bluePlayerColorBox = new System.Windows.Forms.TextBox();
            this.blueChosenColorBox = new System.Windows.Forms.TextBox();
            this.greenChosenColorBox = new System.Windows.Forms.TextBox();
            this.redChosenColorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.playerColorBox = new System.Windows.Forms.RichTextBox();
            this.chosenColorBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.redAccuracyTextBox = new System.Windows.Forms.TextBox();
            this.greenAccuracyTextBox = new System.Windows.Forms.TextBox();
            this.blueAccuracyTextBox = new System.Windows.Forms.TextBox();
            this.colorAccuracyTextBox = new System.Windows.Forms.TextBox();
            this.multiplierNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.multiplierNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose colors, get smaller (or equal) accuracy to win!";
            // 
            // pickColorButton
            // 
            this.pickColorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickColorButton.Location = new System.Drawing.Point(10, 452);
            this.pickColorButton.Name = "pickColorButton";
            this.pickColorButton.Size = new System.Drawing.Size(268, 40);
            this.pickColorButton.TabIndex = 7;
            this.pickColorButton.Text = "Pick a color!";
            this.pickColorButton.UseVisualStyleBackColor = true;
            this.pickColorButton.Click += new System.EventHandler(this.pickColorButton_Click);
            // 
            // bonusColorListBox
            // 
            this.bonusColorListBox.FormattingEnabled = true;
            this.bonusColorListBox.ItemHeight = 16;
            this.bonusColorListBox.Location = new System.Drawing.Point(12, 77);
            this.bonusColorListBox.Name = "bonusColorListBox";
            this.bonusColorListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.bonusColorListBox.Size = new System.Drawing.Size(266, 164);
            this.bonusColorListBox.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(12, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(544, 25);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "Bet on these colors to get maximum 2x multiplier!";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rollColorButton
            // 
            this.rollColorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollColorButton.Location = new System.Drawing.Point(284, 452);
            this.rollColorButton.Name = "rollColorButton";
            this.rollColorButton.Size = new System.Drawing.Size(272, 40);
            this.rollColorButton.TabIndex = 26;
            this.rollColorButton.Text = "Roll! (2x)";
            this.rollColorButton.UseVisualStyleBackColor = true;
            this.rollColorButton.Click += new System.EventHandler(this.rollColorButton_Click);
            // 
            // redPlayerColorBox
            // 
            this.redPlayerColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redPlayerColorBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redPlayerColorBox.Location = new System.Drawing.Point(93, 283);
            this.redPlayerColorBox.Name = "redPlayerColorBox";
            this.redPlayerColorBox.ReadOnly = true;
            this.redPlayerColorBox.Size = new System.Drawing.Size(86, 48);
            this.redPlayerColorBox.TabIndex = 27;
            this.redPlayerColorBox.Text = "?";
            this.redPlayerColorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // greenPlayerColorBox
            // 
            this.greenPlayerColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenPlayerColorBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenPlayerColorBox.Location = new System.Drawing.Point(93, 337);
            this.greenPlayerColorBox.Name = "greenPlayerColorBox";
            this.greenPlayerColorBox.ReadOnly = true;
            this.greenPlayerColorBox.Size = new System.Drawing.Size(86, 48);
            this.greenPlayerColorBox.TabIndex = 28;
            this.greenPlayerColorBox.Text = "?";
            this.greenPlayerColorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bluePlayerColorBox
            // 
            this.bluePlayerColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bluePlayerColorBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePlayerColorBox.Location = new System.Drawing.Point(93, 391);
            this.bluePlayerColorBox.Name = "bluePlayerColorBox";
            this.bluePlayerColorBox.ReadOnly = true;
            this.bluePlayerColorBox.Size = new System.Drawing.Size(86, 48);
            this.bluePlayerColorBox.TabIndex = 29;
            this.bluePlayerColorBox.Text = "?";
            this.bluePlayerColorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // blueChosenColorBox
            // 
            this.blueChosenColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueChosenColorBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueChosenColorBox.Location = new System.Drawing.Point(382, 391);
            this.blueChosenColorBox.Name = "blueChosenColorBox";
            this.blueChosenColorBox.ReadOnly = true;
            this.blueChosenColorBox.Size = new System.Drawing.Size(86, 48);
            this.blueChosenColorBox.TabIndex = 32;
            this.blueChosenColorBox.Text = "?";
            this.blueChosenColorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // greenChosenColorBox
            // 
            this.greenChosenColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenChosenColorBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenChosenColorBox.Location = new System.Drawing.Point(382, 337);
            this.greenChosenColorBox.Name = "greenChosenColorBox";
            this.greenChosenColorBox.ReadOnly = true;
            this.greenChosenColorBox.Size = new System.Drawing.Size(86, 48);
            this.greenChosenColorBox.TabIndex = 31;
            this.greenChosenColorBox.Text = "?";
            this.greenChosenColorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // redChosenColorBox
            // 
            this.redChosenColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redChosenColorBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redChosenColorBox.Location = new System.Drawing.Point(382, 283);
            this.redChosenColorBox.Name = "redChosenColorBox";
            this.redChosenColorBox.ReadOnly = true;
            this.redChosenColorBox.Size = new System.Drawing.Size(86, 48);
            this.redChosenColorBox.TabIndex = 30;
            this.redChosenColorBox.Text = "?";
            this.redChosenColorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.label2.Location = new System.Drawing.Point(40, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 40);
            this.label2.TabIndex = 33;
            this.label2.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.label3.Location = new System.Drawing.Point(31, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 40);
            this.label3.TabIndex = 34;
            this.label3.Text = "G:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.label4.Location = new System.Drawing.Point(40, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 40);
            this.label4.TabIndex = 35;
            this.label4.Text = "B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.label5.Location = new System.Drawing.Point(474, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 40);
            this.label5.TabIndex = 36;
            this.label5.Text = ":R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.label6.Location = new System.Drawing.Point(474, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 40);
            this.label6.TabIndex = 37;
            this.label6.Text = ":G";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F);
            this.label7.Location = new System.Drawing.Point(474, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 40);
            this.label7.TabIndex = 38;
            this.label7.Text = ":B";
            // 
            // playerColorBox
            // 
            this.playerColorBox.Location = new System.Drawing.Point(10, 283);
            this.playerColorBox.MaxLength = 0;
            this.playerColorBox.Multiline = false;
            this.playerColorBox.Name = "playerColorBox";
            this.playerColorBox.ReadOnly = true;
            this.playerColorBox.Size = new System.Drawing.Size(24, 156);
            this.playerColorBox.TabIndex = 39;
            this.playerColorBox.Text = "";
            this.playerColorBox.WordWrap = false;
            // 
            // chosenColorBox
            // 
            this.chosenColorBox.Location = new System.Drawing.Point(530, 283);
            this.chosenColorBox.MaxLength = 0;
            this.chosenColorBox.Multiline = false;
            this.chosenColorBox.Name = "chosenColorBox";
            this.chosenColorBox.ReadOnly = true;
            this.chosenColorBox.Size = new System.Drawing.Size(24, 156);
            this.chosenColorBox.TabIndex = 40;
            this.chosenColorBox.Text = "";
            this.chosenColorBox.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "Amount:";
            // 
            // betAmount
            // 
            this.betAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.betAmount.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.betAmount.Location = new System.Drawing.Point(109, 247);
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(139, 30);
            this.betAmount.TabIndex = 42;
            this.betAmount.Text = "0";
            this.betAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(348, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "Accuracy:";
            // 
            // redAccuracyTextBox
            // 
            this.redAccuracyTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.redAccuracyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redAccuracyTextBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redAccuracyTextBox.Location = new System.Drawing.Point(186, 286);
            this.redAccuracyTextBox.Name = "redAccuracyTextBox";
            this.redAccuracyTextBox.ReadOnly = true;
            this.redAccuracyTextBox.Size = new System.Drawing.Size(191, 41);
            this.redAccuracyTextBox.TabIndex = 45;
            this.redAccuracyTextBox.Text = "∓0";
            this.redAccuracyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // greenAccuracyTextBox
            // 
            this.greenAccuracyTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.greenAccuracyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.greenAccuracyTextBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenAccuracyTextBox.Location = new System.Drawing.Point(186, 340);
            this.greenAccuracyTextBox.Name = "greenAccuracyTextBox";
            this.greenAccuracyTextBox.ReadOnly = true;
            this.greenAccuracyTextBox.Size = new System.Drawing.Size(191, 41);
            this.greenAccuracyTextBox.TabIndex = 46;
            this.greenAccuracyTextBox.Text = "∓0";
            this.greenAccuracyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // blueAccuracyTextBox
            // 
            this.blueAccuracyTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.blueAccuracyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blueAccuracyTextBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueAccuracyTextBox.Location = new System.Drawing.Point(186, 394);
            this.blueAccuracyTextBox.Name = "blueAccuracyTextBox";
            this.blueAccuracyTextBox.ReadOnly = true;
            this.blueAccuracyTextBox.Size = new System.Drawing.Size(191, 41);
            this.blueAccuracyTextBox.TabIndex = 47;
            this.blueAccuracyTextBox.Text = "∓0";
            this.blueAccuracyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorAccuracyTextBox
            // 
            this.colorAccuracyTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colorAccuracyTextBox.Font = new System.Drawing.Font("Century Gothic", 76.5F);
            this.colorAccuracyTextBox.Location = new System.Drawing.Point(284, 77);
            this.colorAccuracyTextBox.Name = "colorAccuracyTextBox";
            this.colorAccuracyTextBox.ReadOnly = true;
            this.colorAccuracyTextBox.Size = new System.Drawing.Size(272, 164);
            this.colorAccuracyTextBox.TabIndex = 48;
            this.colorAccuracyTextBox.Text = "∓0";
            this.colorAccuracyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // multiplierNumeric
            // 
            this.multiplierNumeric.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.multiplierNumeric.Location = new System.Drawing.Point(465, 246);
            this.multiplierNumeric.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.multiplierNumeric.Name = "multiplierNumeric";
            this.multiplierNumeric.ReadOnly = true;
            this.multiplierNumeric.Size = new System.Drawing.Size(89, 32);
            this.multiplierNumeric.TabIndex = 49;
            this.multiplierNumeric.ValueChanged += new System.EventHandler(this.multiplierNumeric_ValueChanged);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(568, 503);
            this.Controls.Add(this.multiplierNumeric);
            this.Controls.Add(this.colorAccuracyTextBox);
            this.Controls.Add(this.blueAccuracyTextBox);
            this.Controls.Add(this.greenAccuracyTextBox);
            this.Controls.Add(this.redAccuracyTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chosenColorBox);
            this.Controls.Add(this.playerColorBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blueChosenColorBox);
            this.Controls.Add(this.greenChosenColorBox);
            this.Controls.Add(this.redChosenColorBox);
            this.Controls.Add(this.bluePlayerColorBox);
            this.Controls.Add(this.greenPlayerColorBox);
            this.Controls.Add(this.redPlayerColorBox);
            this.Controls.Add(this.rollColorButton);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.bonusColorListBox);
            this.Controls.Add(this.pickColorButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ColorPicker";
            this.Text = "Color picker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorPicker_FormClosing);
            this.Load += new System.EventHandler(this.ColorPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.multiplierNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pickColorButton;
        private System.Windows.Forms.ListBox bonusColorListBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button rollColorButton;
        private System.Windows.Forms.TextBox redPlayerColorBox;
        private System.Windows.Forms.TextBox greenPlayerColorBox;
        private System.Windows.Forms.TextBox bluePlayerColorBox;
        private System.Windows.Forms.TextBox blueChosenColorBox;
        private System.Windows.Forms.TextBox greenChosenColorBox;
        private System.Windows.Forms.TextBox redChosenColorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox playerColorBox;
        private System.Windows.Forms.RichTextBox chosenColorBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox betAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox redAccuracyTextBox;
        private System.Windows.Forms.TextBox greenAccuracyTextBox;
        private System.Windows.Forms.TextBox blueAccuracyTextBox;
        private System.Windows.Forms.TextBox colorAccuracyTextBox;
        private System.Windows.Forms.NumericUpDown multiplierNumeric;
    }
}