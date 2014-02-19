using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace happyBirthday
{
    public partial class Form1 : Form
    {
        #region Variables
        int numPresents;
        string returnedMessage;
        #endregion

        public Form1()
        {
            InitializeComponent();
            yesRadioButton.Checked = true;
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //HappyBirthday birthdayMessage = new HappyBirthday();
            //MessageBox.Show(birthdayMessage.getMessage("Tyler"));

        }

        #region Buttonclick
        private void button2_Click(object sender, EventArgs e)
        {

            returnedMessage = "";
            
            HappyBirthday birthdayMessage = new HappyBirthday();
            BirthdayParty partyStatus = new BirthdayParty();

            //get name
            returnedMessage += birthdayMessage.getMessage(nameTextBox.Text) + "\n";

            //get party status
            returnedMessage += partyStatus.getParty(yesRadioButton.Checked) + "\n";


             
            //gets number of presents
            returnedMessage += birthdayMessage.getPresents(Convert.ToInt32(numericUpDown1.Value)) + "\n";

           
         
          
            
            MessageBox.Show(returnedMessage);

        }
        #endregion 

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        
    }
}
