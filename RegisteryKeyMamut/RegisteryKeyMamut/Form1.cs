using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisteryKeyMamut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        //calls the function to create the key
        //exits the application when key is added and OK is pressed on the popup
        private void button1_Click(object sender, EventArgs e)
        {
            RegisteryKeyMamutClass rkm = new RegisteryKeyMamutClass();
            rkm.MakeRegisteryKey();


            MessageBox.Show("Da skal det være fikset! Programmet vil lukke seg når du trykker på \"OK\"");
            Application.Exit();
        }
    }
}
