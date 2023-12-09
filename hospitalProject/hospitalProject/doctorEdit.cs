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
    public partial class doctorEdit : Form
    {
        public doctorEdit()
        {
            InitializeComponent();
        }
        SqlConnect bgl=new SqlConnect();
        public string CitizNo;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("update tbl_Doctors set drName=@p1,drSurname=@p2,drBranche=@p3,drPassword=@p4 where drCitizNo=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut.Parameters.AddWithValue("@p3", txtBranche.Text);
            komut.Parameters.AddWithValue("@p4", txtPassword.Text);
            komut.Parameters.AddWithValue("@p5", mskCitizNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi!");

        }

        private void doctorEdit_Load(object sender, EventArgs e)
        {
            mskCitizNo.Text=CitizNo;
            SqlCommand komut1 = new SqlCommand("select*from tbl_Doctors where drCitizNo=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", mskCitizNo.Text);
            SqlDataReader dr= komut1.ExecuteReader();
            while(dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                txtBranche.Text = dr[3].ToString();
                txtPassword.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
