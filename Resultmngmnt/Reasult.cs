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
    public partial class Reasult : Form
    {
        string str = @"Data Source=LAPTOP-2OU8NEFO\SQLEXPRESS;Initial Catalog = Result; Integrated Security = True;";
        public Reasult()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
           SqlDataAdapter da = new SqlDataAdapter("Select Sname,fname,dob,Stutype from stinfo where Rollno ='" + textBox1.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "stinfo");

            txtname.Text = ds.Tables[0].Rows[i][0].ToString();
            txtfnm.Text = ds.Tables[0].Rows[i][1].ToString();
            txtdob.Text = ds.Tables[0].Rows[i][2].ToString();
            txttyp.Text = ds.Tables[0].Rows[i][3].ToString();
            viewgrd();

        }
        private void viewgrd()
        {

            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("Select rollno,branch,sem as Semester,Theory as Theory_Total,Practical as Practical_Total,Sesional,GP as General_Proficiency,IE as Industrial_Exposure ,Total ,Result from rslt where rollno = '" + textBox1.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void Reasult_Load(object sender, EventArgs e)
        {

        }
    }
}
