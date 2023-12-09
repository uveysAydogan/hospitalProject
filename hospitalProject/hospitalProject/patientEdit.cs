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
    public partial class patientEdit : Form
    {
        public patientEdit()
        {
            InitializeComponent();
        }

        public string CitizNo;
        SqlConnect bgl=new SqlConnect();
        private void patientEdit_Load(object sender, EventArgs e)
        {
            mskCitizNo.Text = CitizNo;
            SqlCommand komut = new SqlCommand("select*from tbl_Patients where patientCitizNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskCitizNo.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                mskPhone.Text = dr[4].ToString();
                txtPassword.Text = dr[5].ToString();
                cmbGender.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_Patients set patientName=@p1, patientSurname=@p2,patientPhone=@p3,patientPassword=@p4,patientSex=@p5 where patientCitizNo=@p6",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",txtName.Text);
            komut2.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut2.Parameters.AddWithValue("@p3", mskPhone.Text);
            komut2.Parameters.AddWithValue("@p4", txtPassword.Text);
            komut2.Parameters.AddWithValue("@p5", cmbGender.Text);
            komut2.Parameters.AddWithValue("@p6", mskCitizNo.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Information has been updated!","Information",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
