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
    public partial class patientDetail : Form
    {
        public patientDetail()
        {
            InitializeComponent();
        }
        public string CitizNo;
        SqlConnect bgl=new SqlConnect();
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientDetail_Load(object sender, EventArgs e)
        {
            //Ad Soyad Çekme
            lblCitizNo.Text = CitizNo;
            SqlCommand komut = new SqlCommand("select patientName,patientSurname from tbl_Patients where patientCitizNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblCitizNo.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                lblNmeSme.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            ////Randevu Geçmişi(datagrid farklılığı var)(Appointment History)
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Appointments where patientCitizNo="+CitizNo,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme(Take Branches)
            SqlCommand komut2=new SqlCommand(" select BrancheName from tbl_Branches",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbBranches.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktor Ekleme(Take Doctor)
            cmbDr.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select drName, drSurname from tbl_Doctors where drBranche=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBranches.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                cmbDr.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDr_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_Appointments where appointmentBranche='"+cmbBranches.Text+"'"+ " and appointmentDr='"+cmbDr.Text+"' and appointmentStatus=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource=dt;
        }

        private void lnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            patientEdit pe=new patientEdit();
            pe.CitizNo = lblCitizNo.Text;
            pe.Show();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand komutrandevu = new SqlCommand("update tbl_Appointments set appointmentStatus=1,patientCitizNo=@p1,patientComplaints=@p2 where appointmentID=@p3", bgl.baglanti());
            komutrandevu.Parameters.AddWithValue("@p1", lblCitizNo.Text);
            komutrandevu.Parameters.AddWithValue("@p2",rchComplaint.Text);
            komutrandevu.Parameters.AddWithValue("@p3",txtID.Text);

            komutrandevu.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Appointmet has been created!");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
