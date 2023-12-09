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
    public partial class branchePanel : Form
    {
        public branchePanel()
        {
            InitializeComponent();
        }
        SqlConnect bgl=new SqlConnect();
        private void branchePanel_Load(object sender, EventArgs e)
        {
            DataTable dt= new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select*from tbl_Branches",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand komutsave=new SqlCommand("insert into tbl_Branches (BrancheName) values (@p1)",bgl.baglanti());
            komutsave.Parameters.AddWithValue("@p1",txtName.Text);
            komutsave.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branche has been inserted!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text=dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlCommand komutdelete = new SqlCommand("delete from tbl_Branches where brancheID=@p1", bgl.baglanti());
            komutdelete.Parameters.AddWithValue("@p1",txtID.Text);
            komutdelete.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branche was deleted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komutupdate = new SqlCommand("update tbl_Branches set brancheName=@p1 where brancheID=@p2", bgl.baglanti());
            komutupdate.Parameters.AddWithValue("@p1", txtName.Text);
            komutupdate.Parameters.AddWithValue("@p2", txtID.Text);
            komutupdate.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branche has been updated!");
        }
    }
}
