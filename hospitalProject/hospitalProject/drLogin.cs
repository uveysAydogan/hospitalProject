using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospitalProject
{
    public partial class drLogin : Form
    {
        public drLogin()
        {
            InitializeComponent();
        }
        SqlConnect bgl=new SqlConnect();
        private void drLogin_Load(object sender, EventArgs e)
        {
 
            bgl.baglanti().Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select*from tbl_Doctors where drCitizNo=@p1 and drPassword=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskCitizNo.Text);
            komut.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                doctorDetails dd = new doctorDetails();
                dd.CitizNo = mskCitizNo.Text;
                dd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Citizien Number or Password is incorrect! Please try again.");
            }
            bgl.baglanti().Close();
        }
    }
}
