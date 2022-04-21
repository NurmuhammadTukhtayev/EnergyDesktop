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
    public partial class TypeOfEnergy : Form
    {
        Form1 Form1;
        public TypeOfEnergy(Form1 form1)
        {
            Form1 = form1;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Visible = true;
        }

        private void TypeOfEnergy_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.HOR_NEGATIVE);
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            Sun recovery = new Sun(this);
            recovery.Show();
            this.Visible = false;
        }

        private void btnUnrecovery_Click(object sender, EventArgs e)
        {
            Unrecovery unrecovery = new Unrecovery(this);
            unrecovery.Show();
            this.Visible = false;
        }
    }
}
