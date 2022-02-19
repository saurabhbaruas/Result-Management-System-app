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

namespace Resultmngmnt
{
    public partial class subinfo : Form
    {
        string str = @"Data Source=LAPTOP-2OU8NEFO\SQLEXPRESS;Initial Catalog=Result;Integrated Security=True;";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        public subinfo()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            cmd = new SqlCommand("Update subjectinfo set Code=@Code, Name = @Name, Branch = @Branch, Sem= @Sem,Th_max_m = @Th_max_m ,Th_min_m = @Th_min_m ,P_max_m = @P_max_m , P_min_m = @P_min_m where Code = " + textBox1.Text + "", con);
             cmd.Parameters.AddWithValue("@Code", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Branch", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Sem", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Th_max_m", txtthmx.Text);
            cmd.Parameters.AddWithValue("@Th_min_m", txtthmn.Text);
            cmd.Parameters.AddWithValue("@P_max_m", txtpmx.Text);
            cmd.Parameters.AddWithValue("@P_min_m", txtpmn.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save information");
            viewgrd();
        }
        private void subinfo_Load(object sender, EventArgs e)
        {
            viewgrd();
        }
        private void viewgrd()
        {

            con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("Select  * from subjectinfo ", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
