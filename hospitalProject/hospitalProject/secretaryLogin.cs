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

namespace hospitalProject
{
    public partial class secretaryLogin : Form
    {
        public secretaryLogin()
        {
            InitializeComponent();
        }
        SqlConnect bgl=new SqlConnect();
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand komut1=new SqlCommand("select*from tbl_Secretaries where secretaryCitizNo=@p1 and secretaryPassword=@p2",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", mskCitizNo.Text);
            komut1.Parameters.AddWithValue("@p2",txtPassword.Text);
            SqlDataReader dr=komut1.ExecuteReader();
            if (dr.Read())
            {
                secretaryDetails sd=new secretaryDetails();
                sd.CitizNo = mskCitizNo.Text;
                sd.Show();
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
