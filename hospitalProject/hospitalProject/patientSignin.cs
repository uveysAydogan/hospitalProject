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

namespace hospitalProject
{
    public partial class patientSignin : Form
    {
        public patientSignin()
        {
            InitializeComponent();
        }

        SqlConnect bgl=new SqlConnect();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into tbl_Patients (patientName,patientSurname,patientCitizNo,patientPhone,patientPassword,patientSex) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",txtName.Text);
            komut1.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut1.Parameters.AddWithValue("@p3", mskCitizNo.Text);
            komut1.Parameters.AddWithValue("@p4", mskPhone.Text);
            komut1.Parameters.AddWithValue("@p5", txtPassword.Text);
            komut1.Parameters.AddWithValue("@p6", cmbGender.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Registration Successful! Your Password is "+txtPassword.Text,"Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
