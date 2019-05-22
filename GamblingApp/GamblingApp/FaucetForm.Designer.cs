namespace GamblingApp
{
    partial class FaucetForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.faucetRollButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hundredThousandsPrefixTextBox = new System.Windows.Forms.TextBox();
            this.unitPrefixTextBox = new System.Windows.Forms.TextBox();
            this.tenPrefixTextBox = new System.Windows.Forms.TextBox();
            this.hundredPrefixTextBox = new System.Windows.Forms.TextBox();
            this.thousandPrefixTextBox = new System.Windows.Forms.TextBox();
            this.tenThousandsPrefixTextBox = new System.Windows.Forms.TextBox();
            this.plusRateButton = new System.Windows.Forms.Button();
            this.plusRateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.Items.AddRange(new object[] {
            "0 - 7500: 1gp",
            "7501 - 25000 : 2gp",
            "25001 - 60000: 3gp",
            "60001 - 100000: 4gp",
            "100001 - 300000: 7gp",
            "300000 - 550000: 10gp",
            "550001 - 725000: 15gp",
            "725001 - 800000: 17gp",
            "800001 - 900000: 20gp",
            "900001 - 950000: 25gp",
            "950001 - 975000: 30gp",
            "975001 - 985000: 35gp",
            "985001 - 990001: 45gp",
            "990001 - 999999: 50gp",
            "1000000: ???"});
            this.checkedListBox1.Location = new System.Drawing.Point(37, 63);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(450, 234);
            this.checkedListBox1.TabIndex = 21;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.UseCompatibleTextRendering = true;
            this.checkedListBox1.UseTabStops = false;
            // 
            // faucetRollButton
            // 
            this.faucetRollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.faucetRollButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faucetRollButton.Location = new System.Drawing.Point(113, 405);
            this.faucetRollButton.Name = "faucetRollButton";
            this.faucetRollButton.Size = new System.Drawing.Size(298, 50);
            this.faucetRollButton.TabIndex = 20;
            this.faucetRollButton.Text = "Roll!";
            this.faucetRollButton.UseVisualStyleBackColor = true;
            this.faucetRollButton.Click += new System.EventHandler(this.faucetRollButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Click \"Roll\" to play. Prices are defined below:";
            // 
            // hundredThousandsPrefixTextBox
            // 
            this.hundredThousandsPrefixTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hundredThousandsPrefixTextBox.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundredThousandsPrefixTextBox.Location = new System.Drawing.Point(37, 315);
            this.hundredThousandsPrefixTextBox.Name = "hundredThousandsPrefixTextBox";
            this.hundredThousandsPrefixTextBox.ReadOnly = true;
            this.hundredThousandsPrefixTextBox.Size = new System.Drawing.Size(70, 72);
            this.hundredThousandsPrefixTextBox.TabIndex = 18;
            this.hundredThousandsPrefixTextBox.Text = "0";
            this.hundredThousandsPrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitPrefixTextBox
            // 
            this.unitPrefixTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitPrefixTextBox.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrefixTextBox.Location = new System.Drawing.Point(417, 315);
            this.unitPrefixTextBox.Name = "unitPrefixTextBox";
            this.unitPrefixTextBox.ReadOnly = true;
            this.unitPrefixTextBox.Size = new System.Drawing.Size(70, 72);
            this.unitPrefixTextBox.TabIndex = 17;
            this.unitPrefixTextBox.Text = "0";
            this.unitPrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tenPrefixTextBox
            // 
            this.tenPrefixTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenPrefixTextBox.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenPrefixTextBox.Location = new System.Drawing.Point(341, 315);
            this.tenPrefixTextBox.Name = "tenPrefixTextBox";
            this.tenPrefixTextBox.ReadOnly = true;
            this.tenPrefixTextBox.Size = new System.Drawing.Size(70, 72);
            this.tenPrefixTextBox.TabIndex = 16;
            this.tenPrefixTextBox.Text = "0";
            this.tenPrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hundredPrefixTextBox
            // 
            this.hundredPrefixTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hundredPrefixTextBox.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundredPrefixTextBox.Location = new System.Drawing.Point(265, 315);
            this.hundredPrefixTextBox.Name = "hundredPrefixTextBox";
            this.hundredPrefixTextBox.ReadOnly = true;
            this.hundredPrefixTextBox.Size = new System.Drawing.Size(70, 72);
            this.hundredPrefixTextBox.TabIndex = 15;
            this.hundredPrefixTextBox.Text = "0";
            this.hundredPrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thousandPrefixTextBox
            // 
            this.thousandPrefixTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thousandPrefixTextBox.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thousandPrefixTextBox.Location = new System.Drawing.Point(189, 315);
            this.thousandPrefixTextBox.Name = "thousandPrefixTextBox";
            this.thousandPrefixTextBox.ReadOnly = true;
            this.thousandPrefixTextBox.Size = new System.Drawing.Size(70, 72);
            this.thousandPrefixTextBox.TabIndex = 14;
            this.thousandPrefixTextBox.Text = "0";
            this.thousandPrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tenThousandsPrefixTextBox
            // 
            this.tenThousandsPrefixTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenThousandsPrefixTextBox.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenThousandsPrefixTextBox.Location = new System.Drawing.Point(113, 315);
            this.tenThousandsPrefixTextBox.Name = "tenThousandsPrefixTextBox";
            this.tenThousandsPrefixTextBox.ReadOnly = true;
            this.tenThousandsPrefixTextBox.Size = new System.Drawing.Size(70, 72);
            this.tenThousandsPrefixTextBox.TabIndex = 13;
            this.tenThousandsPrefixTextBox.Text = "0";
            this.tenThousandsPrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plusRateButton
            // 
            this.plusRateButton.Location = new System.Drawing.Point(8, 405);
            this.plusRateButton.Name = "plusRateButton";
            this.plusRateButton.Size = new System.Drawing.Size(99, 27);
            this.plusRateButton.TabIndex = 23;
            this.plusRateButton.Text = "Plus Rate";
            this.plusRateButton.UseVisualStyleBackColor = true;
            this.plusRateButton.Click += new System.EventHandler(this.plusRateButton_Click);
            // 
            // plusRateTextBox
            // 
            this.plusRateTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plusRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plusRateTextBox.Font = new System.Drawing.Font("Roboto Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRateTextBox.Location = new System.Drawing.Point(8, 433);
            this.plusRateTextBox.Name = "plusRateTextBox";
            this.plusRateTextBox.ReadOnly = true;
            this.plusRateTextBox.Size = new System.Drawing.Size(99, 16);
            this.plusRateTextBox.TabIndex = 24;
            this.plusRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FaucetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(526, 477);
            this.Controls.Add(this.plusRateTextBox);
            this.Controls.Add(this.plusRateButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.faucetRollButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hundredThousandsPrefixTextBox);
            this.Controls.Add(this.unitPrefixTextBox);
            this.Controls.Add(this.tenPrefixTextBox);
            this.Controls.Add(this.hundredPrefixTextBox);
            this.Controls.Add(this.thousandPrefixTextBox);
            this.Controls.Add(this.tenThousandsPrefixTextBox);
            this.MaximizeBox = false;
            this.Name = "FaucetForm";
            this.Text = "Faucet game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaucetForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button faucetRollButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hundredThousandsPrefixTextBox;
        private System.Windows.Forms.TextBox unitPrefixTextBox;
        private System.Windows.Forms.TextBox tenPrefixTextBox;
        private System.Windows.Forms.TextBox hundredPrefixTextBox;
        private System.Windows.Forms.TextBox thousandPrefixTextBox;
        private System.Windows.Forms.TextBox tenThousandsPrefixTextBox;
        private System.Windows.Forms.Button plusRateButton;
        private System.Windows.Forms.TextBox plusRateTextBox;
    }
}