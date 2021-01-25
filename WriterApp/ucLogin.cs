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
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void btnSignln_Click(object sender, EventArgs e)
        {
            frmMain.Instance.Content.Controls.Add(new ucMain() { Dock = DockStyle.Fill });
            frmMain.Instance.Content.Controls[0].SendToBack();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
