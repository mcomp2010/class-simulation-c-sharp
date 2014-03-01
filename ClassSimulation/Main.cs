using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1.org;

namespace ClassSimulation
{


    public partial class Main : Form
    {

        int intTimerCounter = 0;
        Button[] buttonArray = new Button[15];
        Student[] Students = new Student[15];
  
        Random Ran = new Random();

        public Main()
        {
            InitializeComponent();
            CreatingNewButtons();  //Call Create buttons

        }


        public void SetIconByArray()
        {
            for (int i = 0; i <= 14; i++)
            {
                Student Current = Students[i];

                if (Current.GetStrMood().Equals("Happy"))
                {
                    buttonArray[i].Image = Properties.Resources.happy;
                }
                else if (Current.GetStrMood().Equals("Bored"))
                {
                    buttonArray[i].Image = Properties.Resources.bored;
                }
                else if (Current.GetStrMood().Equals("Mad"))
                {
                    buttonArray[i].Image = Properties.Resources.angry;
                }
                else if (Current.GetStrMood().Equals("Content"))
                {
                    buttonArray[i].Image = Properties.Resources.content;
                }

            }

        }

        private void Main_Load(object sender, EventArgs e)
        {

            Students[0] = new Student("Teacher", 28);

            for (int i = 1; i <= 14; i++)
            {
                Students[i] = new Student("Student " + i, Ran.Next(18, 24));
            }

            SetIconByArray();
        }


        private void buttonArray_Click(object sender, EventArgs e)
        {
            Button who = (Button)sender;
            int CurrentIndex = int.Parse(who.Tag.ToString());

            //MessageBox.Show(CurrentIndex + ""); //used for debugging

            //MessageBox.Show("*"+Students[CurrentIndex].ToString()+"*");
          
            lblname.Text = Students[CurrentIndex].ToString();

        }


        /// ***********************************************************************************************
        /// method that Creates buttons
        /// ***********************************************************************************************
       
        private void CreatingNewButtons()
        {
            int horizontal = 30;
            int vertical = 100;

            buttonArray[0] = new Button();
            buttonArray[0].Size = new Size(77, 77);
            buttonArray[0].Image = Properties.Resources._base;
            buttonArray[0].Location = new Point(300, 10);
            buttonArray[0].Tag = 0;
            buttonArray[0].Click += new EventHandler(buttonArray_Click);
            this.Controls.Add(buttonArray[0]);


            for (int i = 1; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(77, 77);
                buttonArray[i].Image = Properties.Resources._base;
                buttonArray[i].Location = new Point(horizontal, vertical);
                buttonArray[i].Click += new EventHandler(buttonArray_Click);
                buttonArray[i].Tag=i;
                if ((i == 7))
                {
                    vertical += 90;
                    horizontal = 30;
                }
                else
                    
                horizontal = horizontal + 90;
                this.Controls.Add(buttonArray[i]);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (!cTemp.Text.Equals("") && !cSeason.Text.Equals("") && !cDay.Text.Equals(""))
            {
                //Show("*" + !cTemp.Text.Equals("") + "*");
                intTimerCounter = 0;
                TimerMain.Enabled = true;
            }
            else
            {
                MessageBox.Show("Need to fill in requirements");
            }

        }


        private void SimulateCycle()
        {
            for (int i = 0; i <= 14; i++)
            {
                Student Current = Students[i];

                Current.SetMood((Current.GetMood() + GetTempScaled(cTemp.Text) + GetDayScaled(cDay.Text)+GetSeasonScaled(cSeason.Text)) / 4);

                System.Console.WriteLine(Current.GetMood() + "-" + Current.GetStrMood());
            }

        }


        /// ////////////////////
        /// /// ////////////////////
        /// /// ////////////////////

        public int GetTempScaled(String Input)
        {
            int i = int.Parse(Input);

            if (i <= 65 || i >= 80)
            {

                return Ran.Next(7, 12);
            }
            else
            {
                return Ran.Next(1, 6);
            }  
        }

        public int GetDayScaled(String Input)
        {
            if (Input.Equals("Sun"))
            {
                return Ran.Next(7, 12);
            }
            else if (Input.Equals("Mon"))
            {
                return Ran.Next(7, 12);
            }
            else if (Input.Equals("Tue"))
            {
                return Ran.Next(1, 6);
            }
            else if (Input.Equals("Wed"))
            {
                return Ran.Next(1, 6);
            }
            else if (Input.Equals("Thr"))
            {
                return Ran.Next(1, 6);
            }
            else if (Input.Equals("Fri"))
            {
                return Ran.Next(1, 6);
            }
            else if (Input.Equals("Sat"))
            {
                return Ran.Next(1, 6);
            }
            else
            {
                return Ran.Next(1, 12);
            }
  
        }

        public int GetSeasonScaled(String Input)
        {
            if (Input.Equals("Winter"))
            {
                return Ran.Next(7, 12);
            }
            else if (Input.Equals("Fall"))
            {
                return Ran.Next(2, 10);
            }
            else if (Input.Equals("Summer"))
            {
                return Ran.Next(1, 9);
            }
            else if (Input.Equals("Spring"))
            {
                return Ran.Next(1, 9);
            }

            else
                return Ran.Next(1, 12);
            
       
        }

      
        /// ////////////////////
        /// ////////////////////
        /// ////////////////////
        /// ////////////////////

        
        private void TimerMain_Tick(object sender, EventArgs e)
        {
            intTimerCounter++;
            ///////////////////////
            lblCycle.Text = "Current Cycle= " + intTimerCounter;

            SimulateCycle();
            SetIconByArray();
            ////////////////////
            if (intTimerCounter >= 150)
            {
                TimerMain.Enabled = false;
            }



        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            TimerMain.Enabled = false;
        }

   
      


}



}

