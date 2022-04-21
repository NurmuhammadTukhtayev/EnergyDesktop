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
    public partial class Unrecovery : Form
    {
        TypeOfEnergy typeOfEnergy;
        public Unrecovery(TypeOfEnergy t)
        {
            typeOfEnergy = t;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            typeOfEnergy.Visible = true;
        }

        private void Unrecovery_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.VER_NEGATIVE);
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            Oil oil = new Oil(this);
            oil.Show();
            this.Visible = false;   
        }

        private void btnCoal_Click(object sender, EventArgs e)
        {
            Coal coal = new Coal(this);
            coal.Show();
            this.Visible=false;
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            Gas gas = new Gas(this);
            gas.Show();
            this.Visible = false;
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            AES aes = new AES(this);
            aes.Show();
            this.Visible = false;
        }
    }
}
