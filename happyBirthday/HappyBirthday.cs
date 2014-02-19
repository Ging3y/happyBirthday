using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happyBirthday
{
    class HappyBirthday
    {
        #region Private  Fields
        private string birthdayMessage;
        private string presentString;
        #endregion 

        #region Constructor 
        public HappyBirthday()
        {
            presentString = "Number of presents: ";
            birthdayMessage = "Happy Birthday ";
        }
        #endregion

        #region Methods Region
        public string getMessage(string givenName)
        {
            return birthdayMessage + givenName;
        }

        public string getPresents(int numPresents)
        {
            presentString = presentString + numPresents.ToString();
            return presentString;
        }

        #endregion
    }
}
