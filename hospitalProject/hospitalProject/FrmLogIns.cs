using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalProject
{
    public partial class FrmLogIns : Form
    {
        public FrmLogIns()
        {
            InitializeComponent();
        }

        private void btnPatLogin_Click(object sender, EventArgs e)
        {
            patientLogin pl=new patientLogin();
            pl.Show();
            this.Hide();
        }

        private void btnDrLogin_Click(object sender, EventArgs e)
        {
            drLogin dl=new drLogin();
            dl.Show();
            this.Hide();
        }

        private void btnSecLogin_Click(object sender, EventArgs e)
        {
            secretaryLogin sl=new secretaryLogin();
            sl.Show();
            this.Hide();
        }
    }
}
