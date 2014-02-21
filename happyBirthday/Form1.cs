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

        #region Initializer
        public Form1()
        {
            InitializeComponent();
            yesRadioButton.Checked = true;
            
        }
        #endregion

        #region Buttonclick
        private void button2_Click(object sender, EventArgs e)
        {

            returnedMessage = "";
            
            BirthdayParty partyStatus = new BirthdayParty();
            MessageBox.Show(BirthdayParty.getNumberOfParties(), "Party Count: " + BirthdayParty.NumOfParties);

            //get name
            returnedMessage += partyStatus.getMessage(nameTextBox.Text) + "\n";

            //get party status
            returnedMessage += partyStatus.getParty(yesRadioButton.Checked) + "\n";

            //gets number of presents
            returnedMessage += partyStatus.getPresents(Convert.ToInt32(numericUpDown1.Value)) + "\n";
            returnedMessage += partyStatus.getParty(yesRadioButton.Checked, nameTextBox.Text);
            MessageBox.Show(returnedMessage);

        }
        #endregion 

       
        
    }
}
