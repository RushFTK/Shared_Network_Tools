using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Network_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ifpwhid_Click(object sender, EventArgs e)
        {
            if (wifi_password.UseSystemPasswordChar == false)
            {
                button_ifpwhid.Text = "隐";
                wifi_password.UseSystemPasswordChar = true;
                return;
            }
            if (wifi_password.UseSystemPasswordChar == true)
            {
                button_ifpwhid.Text = "显";
                wifi_password.UseSystemPasswordChar = false;
                return;
            }
        }
    }
}
