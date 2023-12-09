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
    public partial class doctorDetails : Form
    {
        public doctorDetails()
        {
            InitializeComponent();
        }
        SqlConnect bgl=new SqlConnect();
        public string CitizNo;
        private void doctorDetails_Load(object sender, EventArgs e)
        {
            lblCitizNo.Text = CitizNo;

            //doctor name surname

            SqlCommand komut = new SqlCommand("select drName,drSurname from tbl_Doctors where drCitizNo=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblCitizNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblNmeSme.Text = dr[0]+" " + dr[1];
            }
            bgl.baglanti().Close();

            //Appointment
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_Appointments where appointmentDr='" + lblNmeSme.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            doctorEdit de=new doctorEdit();
            de.CitizNo = lblCitizNo.Text;
            de.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAncmnt_Click(object sender, EventArgs e)
        {
            Announcement a = new Announcement();
            a.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            rchComplaint.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }
    }
}
