using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happyBirthday
{
    class HappyBirthday
    {
        //Place Vairables
        private string birthdayMessage;
        private decimal numberOfPresents;
        private bool havingParty;
       
        //  DEFAULT CONSTRUCTOR
        public HappyBirthday()
        {
            numberOfPresents = 0;
           // havingParty = false;
        }


        //METHOD
        private string getMessage(string givenName)
        {
            string theMessage;

            theMessage = "Happy Birthday " + givenName+ "! " + "\n";
            theMessage += "Number of presents = " + numberOfPresents.ToString() + "\n";
         

            if (havingParty == true)
            {
                theMessage += "You are having a party!";
            }
            else
            {
                theMessage += "You dont have a party...";
            }


            return theMessage;

        }

        //Read and write property
        public string myName
        {
            get { return birthdayMessage; }
            set { birthdayMessage = getMessage(value); }
        }

        //Write only property
        public decimal PresentCount
        {
            set { numberOfPresents = value; }
        }

        //Write only property
        public bool hasParty
        {
            set { havingParty = value; }
        }

         
    }
}
