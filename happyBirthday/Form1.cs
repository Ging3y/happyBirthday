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
       

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer music = new SoundPlayer("
            HappyBirthday birthdayMessage = new HappyBirthday();
            string returnedMessage;

            if (yesRadioButton.Checked)
            {
                birthdayMessage.hasParty = true;
            }
            if (noRadioButton.Checked)
            {
                birthdayMessage.hasParty = false;
            }

            birthdayMessage.PresentCount = numericUpDown1.Value;
            birthdayMessage.myName = nameTextBox.Text;
          
            
            returnedMessage = birthdayMessage.myName; 

            MessageBox.Show(returnedMessage);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        
    }
}
