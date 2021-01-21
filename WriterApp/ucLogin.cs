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
            mainFile.Instance.Content.Controls.Add(new ucMain() { Dock = DockStyle.Fill });
            mainFile.Instance.Content.Controls[0].SendToBack();
        }
    }
}
