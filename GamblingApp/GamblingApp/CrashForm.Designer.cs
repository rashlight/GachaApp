namespace GamblingApp
{
    partial class CrashForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.crashMultiplierTextBox = new System.Windows.Forms.TextBox();
            this.crashStatusTextBox = new System.Windows.Forms.TextBox();
            this.crashButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxMultiplierTextBox = new System.Windows.Forms.TextBox();
            this.betNumeric = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.crashChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.crashChart)).BeginInit();
            this.SuspendLayout();
            // 
            // crashMultiplierTextBox
            // 
            this.crashMultiplierTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.crashMultiplierTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crashMultiplierTextBox.Font = new System.Drawing.Font("Century Gothic", 31.8F);
            this.crashMultiplierTextBox.Location = new System.Drawing.Point(12, 52);
            this.crashMultiplierTextBox.Name = "crashMultiplierTextBox";
            this.crashMultiplierTextBox.Size = new System.Drawing.Size(603, 65);
            this.crashMultiplierTextBox.TabIndex = 0;
            this.crashMultiplierTextBox.Tag = "";
            this.crashMultiplierTextBox.Text = "0.00x";
            this.crashMultiplierTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // crashStatusTextBox
            // 
            this.crashStatusTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.crashStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crashStatusTextBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crashStatusTextBox.Location = new System.Drawing.Point(12, 123);
            this.crashStatusTextBox.Name = "crashStatusTextBox";
            this.crashStatusTextBox.Size = new System.Drawing.Size(603, 41);
            this.crashStatusTextBox.TabIndex = 1;
            this.crashStatusTextBox.Text = "Stopped at 0.00x";
            this.crashStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // crashButton
            // 
            this.crashButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crashButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crashButton.Location = new System.Drawing.Point(12, 446);
            this.crashButton.Name = "crashButton";
            this.crashButton.Size = new System.Drawing.Size(592, 50);
            this.crashButton.TabIndex = 21;
            this.crashButton.Text = "Start!";
            this.crashButton.UseVisualStyleBackColor = true;
            this.crashButton.Click += new System.EventHandler(this.crashButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Click \"Start!\" to play. Remember to click \"Stop!\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(7, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(404, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Max:";
            // 
            // maxMultiplierTextBox
            // 
            this.maxMultiplierTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maxMultiplierTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxMultiplierTextBox.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.maxMultiplierTextBox.Location = new System.Drawing.Point(454, 179);
            this.maxMultiplierTextBox.Name = "maxMultiplierTextBox";
            this.maxMultiplierTextBox.ReadOnly = true;
            this.maxMultiplierTextBox.Size = new System.Drawing.Size(150, 19);
            this.maxMultiplierTextBox.TabIndex = 28;
            this.maxMultiplierTextBox.Text = "0.00x";
            this.maxMultiplierTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // betNumeric
            // 
            this.betNumeric.Location = new System.Drawing.Point(95, 181);
            this.betNumeric.Name = "betNumeric";
            this.betNumeric.Size = new System.Drawing.Size(117, 22);
            this.betNumeric.TabIndex = 29;
            this.betNumeric.Text = "0";
            this.betNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.betNumeric.TextChanged += new System.EventHandler(this.betNumeric_TextChanged);
            // 
            // stopButton
            // 
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(12, 446);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(592, 50);
            this.stopButton.TabIndex = 30;
            this.stopButton.Text = "Stop!";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // crashChart
            // 
            chartArea1.Name = "ChartArea1";
            this.crashChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crashChart.Legends.Add(legend1);
            this.crashChart.Location = new System.Drawing.Point(11, 209);
            this.crashChart.Name = "crashChart";
            this.crashChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "CrashSeries";
            this.crashChart.Series.Add(series1);
            this.crashChart.Size = new System.Drawing.Size(593, 231);
            this.crashChart.TabIndex = 31;
            this.crashChart.Text = "chart1";
            // 
            // CrashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(622, 503);
            this.Controls.Add(this.crashChart);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.betNumeric);
            this.Controls.Add(this.maxMultiplierTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crashButton);
            this.Controls.Add(this.crashStatusTextBox);
            this.Controls.Add(this.crashMultiplierTextBox);
            this.Name = "CrashForm";
            this.Text = "Crash";
            ((System.ComponentModel.ISupportInitialize)(this.crashChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox crashMultiplierTextBox;
        private System.Windows.Forms.TextBox crashStatusTextBox;
        private System.Windows.Forms.Button crashButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxMultiplierTextBox;
        private System.Windows.Forms.TextBox betNumeric;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart crashChart;
    }
}