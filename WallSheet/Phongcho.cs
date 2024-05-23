<<<<<<< HEAD
﻿using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class Phongcho : Form
    {
        public Phongcho()
        {
            InitializeComponent();
        }
        public string Username;

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
       

        private void Phongcho_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
=======
﻿using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class Phongcho : Form
    {
        public Phongcho()
        {
            InitializeComponent();
        }
        public string Username;

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
       

        private void Phongcho_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }
    }
}
>>>>>>> 05345d035aa0462a5948a3565b2f98cb7ffa07f6
