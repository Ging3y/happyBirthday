using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happyBirthday
{
    class BirthdayParty : HappyBirthday
    {
        #region Fields Region
        static int numOfParties = 0;
        #endregion

        #region Properties
        public static int NumOfParties
        {
            get { return numOfParties; }
        }
        #endregion

        #region Constructor Region
        public BirthdayParty()
            : base()
        {
            //every time we call constructor, we add one to our party count
            numOfParties += 1;
        }

        #endregion

        #region Methods
        public string getParty(bool haveParty)
        {
            if (haveParty == true)
            {
                return "Enjoy your party!";
            }
            else
            {
                return "Sorry - No party for you!";
            }
        }
        public string getParty(bool haveParty, string Name)
        {
            if (haveParty == true)
            {
                return "Enjoy your party! " + Name + "!";
            }
            else
            {
                return "Sorry - No party for you, " + Name + "!";
            }
        }
        //Part 2
        public static string getNumberOfParties()
        {
            return "There are a total of " + numOfParties.ToString() + " parties.";
        }

  
   
        
        #endregion 
    }
}
