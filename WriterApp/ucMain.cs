using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriterApp
{
    public partial class ucMain : UserControl
    {

        int login = 0;

        public ucMain()
        {
            InitializeComponent();
            loginText.Text = "Zalogowano jako:" + login;
        }

        public static object Instance { get; internal set; }

        private void listOnline_Click(object sender, EventArgs e)
        {
            frmSend frm = new frmSend();
            frm.Show();
        }
    }
}
