using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.org
{
    public class Student
    {
        public String strName;
        public int intAge;
        private String StrMood;
        
        Mood CurrentMood = new Mood();


        public String GetStrMood()
        {
            return CurrentMood.GetCurrentMood();
        }

            
        public void SetMood(int intCur)
        {
            CurrentMood.SetMood(intCur);
        }

        public int GetMood()
        {
            return CurrentMood.GetMood();
        }

        public Student(String instrName, int inintAge)
        {
            this.strName = instrName;
            this.intAge = inintAge;
            this.StrMood = CurrentMood.GetCurrentMood()+"";
        }

        public override String ToString()
        {
            return "Name:" + strName + "\n" + "Age:" + intAge + "\n" + "Mood:" + CurrentMood.GetCurrentMood();
        }


    }
}
