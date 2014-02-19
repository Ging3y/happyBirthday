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
        #endregion

        #region Constructor Region
        public BirthdayParty()
            : base()
        {
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
   
        
        #endregion 
    }
}
