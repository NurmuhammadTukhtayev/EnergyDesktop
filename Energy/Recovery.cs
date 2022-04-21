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
    public partial class Sun : Form
    {
        TypeOfEnergy typeOfEnergy;
        public Sun(TypeOfEnergy t)
        {
            typeOfEnergy = t;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            typeOfEnergy.Visible = true;
        }

        private void Recovery_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.VER_POSITIVE);
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            TheSun theSun = new TheSun(this);
            theSun.Show();
            this.Visible = false;
        }

        private void Wind_Click(object sender, EventArgs e)
        {
            Wind wind = new Wind(this);
            wind.Show();
            this.Visible = false;
        }

        private void geotemal_Click(object sender, EventArgs e)
        {
            Geotermal geotermal = new Geotermal(this);
            geotermal.Show();
            this.Visible = false;
        }

        private void Water_Click(object sender, EventArgs e)
        {
            Water water = new Water(this);
            water.Show();
            this.Visible = false;
        }

        private void Land_Click(object sender, EventArgs e)
        {
            Land land = new Land(this);
            land.Show();
            this.Visible = false;
        }

        private void Biogas_Click(object sender, EventArgs e)
        {
            Biogas biogas = new Biogas(this);
            biogas.Show();
            this.Visible = false;
        }

        private void Sea_Click(object sender, EventArgs e)
        {
            Sea sea = new Sea(this);
            sea.Show();
            this.Visible=false;
        }

        private void ocean_Click(object sender, EventArgs e)
        {
            Ocean ocean = new Ocean(this);
            ocean.Show();
            this.Visible = false;
        }

        private void degree_Click(object sender, EventArgs e)
        {
            Degree degree = new Degree(this);
            degree.Show();
            this.Visible = false;
        }

        private void Hidro_Click(object sender, EventArgs e)
        {
            Hidro hidro = new Hidro(this);
            hidro.Show();
            this.Visible= false;
        }
    }
}
