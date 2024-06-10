using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallSheet
{
    public partial class FormWin : Form
    {
        public FormWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go back to ProfileName
            
            ProfileName profileName = new ProfileName();
            this.Hide();
            profileName.ShowDialog();   


        }
    }
}
