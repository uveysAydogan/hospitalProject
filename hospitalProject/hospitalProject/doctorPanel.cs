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
    public partial class doctorPanel : Form
    {
        public doctorPanel()
        {
            InitializeComponent();
        }
        SqlConnect bgl=new SqlConnect();
        private void doctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select*from tbl_Doctors",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Brance
            SqlCommand komut4= new SqlCommand("select*from tbl_Branches",bgl.baglanti());
            SqlDataReader dr4=komut4.ExecuteReader();
            while(dr4.Read())
            {
                cmbBranche.Items.Add(dr4[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand komutsave= new SqlCommand("insert into tbl_Doctors (DrName,DrSurname,DrBranche,DrCitizNo,DrPassword) values(@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komutsave.Parameters.AddWithValue("@p1",txtName.Text);
            komutsave.Parameters.AddWithValue("@p2",txtSurname.Text);
            komutsave.Parameters.AddWithValue("@p3",cmbBranche.Text);
            komutsave.Parameters.AddWithValue("@p4",mskCitzNo.Text);
            komutsave.Parameters.AddWithValue("@p5",txtPassword.Text);
            komutsave.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor has been inserted!","Informations",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            cmbBranche.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            mskCitzNo.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlCommand komutdelete=new SqlCommand("delete from tbl_Doctors where DrCitizNo=@p1",bgl.baglanti());
            komutdelete.Parameters.AddWithValue("@p1",mskCitzNo.Text);
            komutdelete.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor has been deleted!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komutupdate = new SqlCommand("update tbl_Doctors set DrName=@p1,DrSurname=@p2,DrBranche=@p3,DrPassword=@p5 where DrCitizNo=@p4", bgl.baglanti());
            komutupdate.Parameters.AddWithValue("@p1", txtName.Text);
            komutupdate.Parameters.AddWithValue("@p2", txtSurname.Text);
            komutupdate.Parameters.AddWithValue("@p3", cmbBranche.Text);
            komutupdate.Parameters.AddWithValue("@p4", mskCitzNo.Text);
            komutupdate.Parameters.AddWithValue("@p5", txtPassword.Text);
            komutupdate.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor has been updated!", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
