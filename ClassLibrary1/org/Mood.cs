using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.org
{
    class Mood
    {
        private int intCurrentMood;
        Random Ran2 = new Random();


        public void SetMood(int intCur)
        {
            intCurrentMood = intCur;
        }

        public int GetMood()
        {
 
            return intCurrentMood;
        }

        public Mood() 
        {
            
            this.intCurrentMood = Ran2.Next(1, 12);

           for (int i = 0; i <= 30000000; i++)
           {
            }

            System.Console.WriteLine(this.intCurrentMood);
        }

        private String FindStrMood(int intInput)
        {
            if (intInput == 1 || intInput == 2 || intInput == 3)
            {
                return "Happy";
            }
            else if (intInput == 4 || intInput == 5 || intInput == 6)
            {
                return "Content";
            }
            else if (intInput == 7 || intInput == 8 || intInput == 9)
            {
                return "Bored";
            }
            else if (intInput == 10 || intInput == 11 || intInput == 12)
            {
                return "Mad";
            }
            else
            {
            return "error";
            }

            
        }

        public String GetCurrentMood()
        {
            return FindStrMood(intCurrentMood);
        }

    }
}
