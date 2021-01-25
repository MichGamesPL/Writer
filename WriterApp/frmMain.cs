using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriterApp
{
    public partial class frmMain : MaterialForm
    {

        private static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }
        public frmMain()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.Blue100, TextShade.WHITE);
            _instance = this;
            MainContainer.Controls.Add(new ucLogin() { Dock = DockStyle.Fill });
        }

        public Panel Content
        {
            get { return MainContainer; }
            set { MainContainer = value; }
        }
    }
}
