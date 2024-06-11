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
    public partial class PVP_select : Form
    {
        public PVP_select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //func to open host form
            Host host = new Host();
            host.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //func to open client form
            Client client = new Client();
            client.Show();
            this.Hide();
        }
    }
}
