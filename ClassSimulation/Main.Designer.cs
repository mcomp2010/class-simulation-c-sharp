namespace ClassSimulation
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCycle = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cSeason = new System.Windows.Forms.ComboBox();
            this.cDay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cTemp = new System.Windows.Forms.ComboBox();
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(28, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(25, 35);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 39);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name:\r\nAge:\r\nMood:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCycle);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.cSeason);
            this.groupBox2.Controls.Add(this.cDay);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cTemp);
            this.groupBox2.Location = new System.Drawing.Point(713, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Environment";
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Location = new System.Drawing.Point(18, 230);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(69, 13);
            this.lblCycle.TabIndex = 8;
            this.lblCycle.Text = "Cycle : 1-150";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(61, 151);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(61, 122);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cSeason
            // 
            this.cSeason.AutoCompleteCustomSource.AddRange(new string[] {
            "Fall",
            "Summer",
            "Spring",
            "Winter"});
            this.cSeason.FormattingEnabled = true;
            this.cSeason.Items.AddRange(new object[] {
            "Spring",
            "Winter",
            "Summer",
            "Fall"});
            this.cSeason.Location = new System.Drawing.Point(105, 81);
            this.cSeason.Name = "cSeason";
            this.cSeason.Size = new System.Drawing.Size(121, 21);
            this.cSeason.TabIndex = 5;
            // 
            // cDay
            // 
            this.cDay.AutoCompleteCustomSource.AddRange(new string[] {
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat"});
            this.cDay.FormattingEnabled = true;
            this.cDay.Items.AddRange(new object[] {
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thur",
            "Fri",
            "Sat"});
            this.cDay.Location = new System.Drawing.Point(105, 51);
            this.cDay.Name = "cDay";
            this.cDay.Size = new System.Drawing.Size(121, 21);
            this.cDay.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Season";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature";
            // 
            // cTemp
            // 
            this.cTemp.FormattingEnabled = true;
            this.cTemp.Items.AddRange(new object[] {
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90"});
            this.cTemp.Location = new System.Drawing.Point(105, 18);
            this.cTemp.Name = "cTemp";
            this.cTemp.Size = new System.Drawing.Size(121, 21);
            this.cTemp.TabIndex = 0;
            // 
            // TimerMain
            // 
            this.TimerMain.Interval = 600;
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Class Simulator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cTemp;
        private System.Windows.Forms.ComboBox cDay;
        private System.Windows.Forms.ComboBox cSeason;
        private System.Windows.Forms.Timer TimerMain;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;


    }
}

