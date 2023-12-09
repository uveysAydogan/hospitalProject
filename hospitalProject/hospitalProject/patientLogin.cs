using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace hospitalProject
{
    public partial class patientLogin : Form
    {
        public patientLogin()
        {
            InitializeComponent();
        }

        SqlConnect bgl = new SqlConnect(); 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            patientSignin ps=new patientSignin();
            ps.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand komut1=new SqlCommand("Select*from tbl_patients where patientCitizNo=@p1 and patientPassword=@p2",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",mskCitizNo.Text);
            komut1.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr=komut1.ExecuteReader();
            if (dr.Read())
            {
                patientDetail pd = new patientDetail();
                pd.CitizNo = mskCitizNo.Text;
                pd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Citizien Number or Password!");  
            }

            bgl.baglanti().Close();
        }
    }
}
