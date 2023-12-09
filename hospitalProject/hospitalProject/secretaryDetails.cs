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
    public partial class secretaryDetails : Form
    {
        public secretaryDetails()
        {
            InitializeComponent();
        }
        public string CitizNo;
        SqlConnect bgl=new SqlConnect();
        private void button1_Click(object sender, EventArgs e)
        {
            doctorPanel dp = new doctorPanel();
            dp.Show();
        }

        private void secretaryDetails_Load(object sender, EventArgs e)
        {
            lblCitizNo.Text = CitizNo;

            //Name Surname
            SqlCommand komut = new SqlCommand("select secretaryNmeSme from tbl_Secretaries where secretaryCitizNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblCitizNo.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                lblNmeSme.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branche and dataGrid
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select*from tbl_Branches",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doctors and DataGrid
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (drName+' '+drSurname) as 'Doctors', drBranche from tbl_Doctors", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branche-->Cmbobox
            SqlCommand komut2 = new SqlCommand("select BrancheName from tbl_Branches", bgl.baglanti());
            SqlDataReader dr2 =komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbBranche.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand komutsave = new SqlCommand("insert into tbl_Appointments (appointmentDate,appointmentTime,appointmentBranche,appointmentDr) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutsave.Parameters.AddWithValue("@r1", mskDate.Text);
            komutsave.Parameters.AddWithValue("@r2",mskTime.Text);
            komutsave.Parameters.AddWithValue("@r3", cmbBranche.Text);
            komutsave.Parameters.AddWithValue("@r4",cmbDr.Text);
            komutsave.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Appointment has been created!");
        }

        private void cmbBranche_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doctors-->combobox
            //cmbDr.Items.Clear();
            cmbDr.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DrName,drSurname from tbl_Doctors where drBranche=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBranche.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDr.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            SqlCommand komutpublish = new SqlCommand("insert into tbl_Announces (announce) values(@a1)", bgl.baglanti());
            komutpublish.Parameters.AddWithValue("@a1",rchAnnounce.Text);
            komutpublish.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Announcement has been created!");
        }

        private void btnBranchPnl_Click(object sender, EventArgs e)
        {
            branchePanel bp= new branchePanel();
            bp.Show();
        }

        private void btnApmtList_Click(object sender, EventArgs e)
        {
            appointmentList al= new appointmentList();
            al.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Announcement a=new Announcement();
            a.Show();
        }
    }
}
