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
    public partial class Gas : Form
    {
        Unrecovery unrecovery;
        public Gas(Unrecovery u)
        {
            InitializeComponent();
            unrecovery = u;
        }

        private void Gas_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.VER_POSITIVE);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            unrecovery.Visible = true;
        }
    }
}
