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

namespace Resultmngmnt
{
    public partial class frmstuinfo : Form
    {
        string str = @"Data Source=LAPTOP-2OU8NEFO\SQLEXPRESS;Initial Catalog=Result;Integrated Security=True;";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        public frmstuinfo()
        {
            InitializeComponent();
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                cmd = new SqlCommand("insert into stinfo(Rollno, Sname,fname,dob,Branch,Semester,Stutype) values (@Rollno, @Sname, @fname, @dob,@Branch,@Semester, @Stutype)", con);
                cmd.Parameters. AddWithValue("@Rollno", textBox1.Text);
                cmd.Parameters.AddWithValue("@Sname", textBox2.Text);
                cmd.Parameters.AddWithValue("@fname", textBox3.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Branch", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Semester", comboBox2.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Stutype", comboBox3.SelectedItem.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save information");
                viewgrd();
            }
            catch(Exception es){ MessageBox.Show(es.Message);}
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            cmd = new SqlCommand("Update stinfo set Sname=@Sname, fname = @fname, dob = @dob, Branch = @Branch, Semester = @Semester, Stutype= @Stutype where Rollno = " + textBox1.Text + "", con);
           // cmd.Parameters.AddWithValue("@Rollno", textBox1.Text);
            cmd.Parameters.AddWithValue("@Sname", textBox2.Text);
            cmd.Parameters.AddWithValue("@fname", textBox3.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Branch", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Semester", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Stutype", comboBox3.SelectedItem.ToString());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save information");
            viewgrd();

        }
        private void frmstuinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resultDataSet1.stinfo' table. You can move, or remove it, as needed.
            //this.stinfoTableAdapter.Fill(this.resultDataSet1.stinfo);
            viewgrd();
        }
        private void viewgrd()
        {
            con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("Select * from stinfo", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.DataMember = "stinfo";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete from stinfo where Rollno = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            viewgrd();
            MessageBox.Show("One record Deleted!");
        }
    }
}
