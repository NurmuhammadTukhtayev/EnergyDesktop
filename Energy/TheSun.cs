using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Energy
{
    public partial class TheSun : Form
    {
        Sun recovery;
        public TheSun(Sun s)
        {
            recovery = s;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            recovery.Visible = true;
        }

        private void TheSun_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.HOR_Positive);
        }

    }
}
