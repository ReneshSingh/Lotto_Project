namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.displayMSG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.L_PB_Settings = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BallRang = new System.Windows.Forms.Label();
            this.maxPowerBall = new System.Windows.Forms.NumericUpDown();
            this.maxBalls = new System.Windows.Forms.NumericUpDown();
            this.numDraws = new System.Windows.Forms.NumericUpDown();
            this.minPowerBall = new System.Windows.Forms.NumericUpDown();
            this.minBalls = new System.Windows.Forms.NumericUpDown();
            this.ImportAndExportBox = new System.Windows.Forms.GroupBox();
            this.ExportData = new System.Windows.Forms.Button();
            this.PrintPowerBallStats = new System.Windows.Forms.RadioButton();
            this.PrintLotteryStats = new System.Windows.Forms.RadioButton();
            this.PrintPowerBallDraws = new System.Windows.Forms.RadioButton();
            this.PrintLottoDraws = new System.Windows.Forms.RadioButton();
            this.L_PB_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxPowerBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDraws)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPowerBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBalls)).BeginInit();
            this.ImportAndExportBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Lotto Numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayMSG
            // 
            this.displayMSG.AutoEllipsis = true;
            this.displayMSG.AutoSize = true;
            this.displayMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMSG.Location = new System.Drawing.Point(65, 70);
            this.displayMSG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayMSG.Name = "displayMSG";
            this.displayMSG.Size = new System.Drawing.Size(0, 25);
            this.displayMSG.TabIndex = 1;
            this.displayMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayMSG.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Olive;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Violet;
            this.label3.Location = new System.Drawing.Point(131, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 1;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 1;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.ForestGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 1;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Orchid;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 1;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Pink;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(39, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 1;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Power Ball Numbers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // L_PB_Settings
            // 
            this.L_PB_Settings.AccessibleName = "Lottery and PowerBall settings";
            this.L_PB_Settings.Controls.Add(this.label10);
            this.L_PB_Settings.Controls.Add(this.label8);
            this.L_PB_Settings.Controls.Add(this.label11);
            this.L_PB_Settings.Controls.Add(this.label9);
            this.L_PB_Settings.Controls.Add(this.BallRang);
            this.L_PB_Settings.Controls.Add(this.maxPowerBall);
            this.L_PB_Settings.Controls.Add(this.maxBalls);
            this.L_PB_Settings.Controls.Add(this.numDraws);
            this.L_PB_Settings.Controls.Add(this.minPowerBall);
            this.L_PB_Settings.Controls.Add(this.minBalls);
            this.L_PB_Settings.Location = new System.Drawing.Point(404, 15);
            this.L_PB_Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.L_PB_Settings.Name = "L_PB_Settings";
            this.L_PB_Settings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.L_PB_Settings.Size = new System.Drawing.Size(300, 150);
            this.L_PB_Settings.TabIndex = 3;
            this.L_PB_Settings.TabStop = false;
            this.L_PB_Settings.Text = "Lottery and PowerBall settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Number of draws: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "PowerBall Range:";
            // 
            // BallRang
            // 
            this.BallRang.AutoSize = true;
            this.BallRang.Location = new System.Drawing.Point(8, 26);
            this.BallRang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BallRang.Name = "BallRang";
            this.BallRang.Size = new System.Drawing.Size(81, 17);
            this.BallRang.TabIndex = 1;
            this.BallRang.Text = "Ball Range:";
            // 
            // maxPowerBall
            // 
            this.maxPowerBall.Location = new System.Drawing.Point(228, 64);
            this.maxPowerBall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxPowerBall.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.maxPowerBall.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxPowerBall.Name = "maxPowerBall";
            this.maxPowerBall.Size = new System.Drawing.Size(60, 22);
            this.maxPowerBall.TabIndex = 0;
            this.maxPowerBall.Tag = "Ball min value";
            this.maxPowerBall.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.maxPowerBall.ValueChanged += new System.EventHandler(this.maxBalls_ValueChanged);
            // 
            // maxBalls
            // 
            this.maxBalls.Location = new System.Drawing.Point(180, 26);
            this.maxBalls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxBalls.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.maxBalls.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.maxBalls.Name = "maxBalls";
            this.maxBalls.Size = new System.Drawing.Size(60, 22);
            this.maxBalls.TabIndex = 0;
            this.maxBalls.Tag = "Ball min value";
            this.maxBalls.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.maxBalls.ValueChanged += new System.EventHandler(this.maxBalls_ValueChanged);
            // 
            // numDraws
            // 
            this.numDraws.Location = new System.Drawing.Point(139, 100);
            this.numDraws.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numDraws.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numDraws.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDraws.Name = "numDraws";
            this.numDraws.Size = new System.Drawing.Size(101, 22);
            this.numDraws.TabIndex = 0;
            this.numDraws.Tag = "Ball min value";
            this.numDraws.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minPowerBall
            // 
            this.minPowerBall.Location = new System.Drawing.Point(139, 62);
            this.minPowerBall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minPowerBall.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.minPowerBall.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minPowerBall.Name = "minPowerBall";
            this.minPowerBall.Size = new System.Drawing.Size(60, 22);
            this.minPowerBall.TabIndex = 0;
            this.minPowerBall.Tag = "Ball min value";
            this.minPowerBall.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minBalls
            // 
            this.minBalls.Location = new System.Drawing.Point(91, 26);
            this.minBalls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minBalls.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.minBalls.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minBalls.Name = "minBalls";
            this.minBalls.Size = new System.Drawing.Size(60, 22);
            this.minBalls.TabIndex = 0;
            this.minBalls.Tag = "Ball min value";
            this.minBalls.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ImportAndExportBox
            // 
            this.ImportAndExportBox.Controls.Add(this.ExportData);
            this.ImportAndExportBox.Controls.Add(this.PrintPowerBallStats);
            this.ImportAndExportBox.Controls.Add(this.PrintLotteryStats);
            this.ImportAndExportBox.Controls.Add(this.PrintPowerBallDraws);
            this.ImportAndExportBox.Controls.Add(this.PrintLottoDraws);
            this.ImportAndExportBox.Location = new System.Drawing.Point(404, 172);
            this.ImportAndExportBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImportAndExportBox.Name = "ImportAndExportBox";
            this.ImportAndExportBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImportAndExportBox.Size = new System.Drawing.Size(300, 135);
            this.ImportAndExportBox.TabIndex = 4;
            this.ImportAndExportBox.TabStop = false;
            this.ImportAndExportBox.Text = "Import and Export";
            // 
            // ExportData
            // 
            this.ExportData.Location = new System.Drawing.Point(91, 90);
            this.ExportData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportData.Name = "ExportData";
            this.ExportData.Size = new System.Drawing.Size(100, 28);
            this.ExportData.TabIndex = 1;
            this.ExportData.Text = "&Export";
            this.ExportData.UseVisualStyleBackColor = true;
            this.ExportData.Click += new System.EventHandler(this.ExportData_Click);
            // 
            // PrintPowerBallStats
            // 
            this.PrintPowerBallStats.AutoSize = true;
            this.PrintPowerBallStats.Location = new System.Drawing.Point(139, 62);
            this.PrintPowerBallStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintPowerBallStats.Name = "PrintPowerBallStats";
            this.PrintPowerBallStats.Size = new System.Drawing.Size(125, 21);
            this.PrintPowerBallStats.TabIndex = 0;
            this.PrintPowerBallStats.TabStop = true;
            this.PrintPowerBallStats.Text = "PowerBall stats";
            this.PrintPowerBallStats.UseVisualStyleBackColor = true;
            // 
            // PrintLotteryStats
            // 
            this.PrintLotteryStats.AutoSize = true;
            this.PrintLotteryStats.Location = new System.Drawing.Point(12, 62);
            this.PrintLotteryStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintLotteryStats.Name = "PrintLotteryStats";
            this.PrintLotteryStats.Size = new System.Drawing.Size(107, 21);
            this.PrintLotteryStats.TabIndex = 0;
            this.PrintLotteryStats.TabStop = true;
            this.PrintLotteryStats.Text = "Lottery stats";
            this.PrintLotteryStats.UseVisualStyleBackColor = true;
            // 
            // PrintPowerBallDraws
            // 
            this.PrintPowerBallDraws.AutoSize = true;
            this.PrintPowerBallDraws.Location = new System.Drawing.Point(139, 33);
            this.PrintPowerBallDraws.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintPowerBallDraws.Name = "PrintPowerBallDraws";
            this.PrintPowerBallDraws.Size = new System.Drawing.Size(134, 21);
            this.PrintPowerBallDraws.TabIndex = 0;
            this.PrintPowerBallDraws.TabStop = true;
            this.PrintPowerBallDraws.Text = "PowerBall Draws";
            this.PrintPowerBallDraws.UseVisualStyleBackColor = true;
            // 
            // PrintLottoDraws
            // 
            this.PrintLottoDraws.AutoSize = true;
            this.PrintLottoDraws.Location = new System.Drawing.Point(12, 33);
            this.PrintLottoDraws.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintLottoDraws.Name = "PrintLottoDraws";
            this.PrintLottoDraws.Size = new System.Drawing.Size(104, 21);
            this.PrintLottoDraws.TabIndex = 0;
            this.PrintLottoDraws.TabStop = true;
            this.PrintLottoDraws.Text = "Lotto Draws";
            this.PrintLottoDraws.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 322);
            this.Controls.Add(this.ImportAndExportBox);
            this.Controls.Add(this.L_PB_Settings);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayMSG);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Lotto number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.L_PB_Settings.ResumeLayout(false);
            this.L_PB_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxPowerBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDraws)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPowerBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBalls)).EndInit();
            this.ImportAndExportBox.ResumeLayout(false);
            this.ImportAndExportBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label displayMSG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox L_PB_Settings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label BallRang;
        private System.Windows.Forms.NumericUpDown maxBalls;
        private System.Windows.Forms.NumericUpDown minBalls;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown maxPowerBall;
        private System.Windows.Forms.NumericUpDown minPowerBall;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numDraws;
        private System.Windows.Forms.GroupBox ImportAndExportBox;
        private System.Windows.Forms.RadioButton PrintLotteryStats;
        private System.Windows.Forms.RadioButton PrintPowerBallDraws;
        private System.Windows.Forms.RadioButton PrintLottoDraws;
        private System.Windows.Forms.Button ExportData;
        private System.Windows.Forms.RadioButton PrintPowerBallStats;
    }
}

