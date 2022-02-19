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
    public partial class test1 : Form
    {
        string str = @"Data Source=LAPTOP-2OU8NEFO\SQLEXPRESS;Initial Catalog=Result;Integrated Security=True;";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        public test1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                cmd = new SqlCommand("insert into subjectinfo(Code, Name,Branch,Sem,Th_max_m,Th_min_m,P_max_m,P_min_m) values (@Code, @Name,@Branch,@Sem,@Th_max_m,@Th_min_m,@P_max_m,@P_min_m)", con);
                cmd.Parameters.AddWithValue("@Code", textBox1.Text);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Branch", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Sem", comboBox2.SelectedItem.ToString());

                if (checkBox1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Th_max_m", txtthmx.Text);
                    cmd.Parameters.AddWithValue("@Th_min_m", txtthmn.Text);

                }
                else if (checkBox2.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@P_max_m", txtpmx.Text);
                    cmd.Parameters.AddWithValue("@P_min_m", txtpmn.Text);
                }



                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("information Saved sucessfully");
                viewgrd();


            }
            catch (Exception es) { MessageBox.Show(es.Message); }

        }
        private void viewgrd()
        {

            con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("Select  * from subjectinfo ", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
