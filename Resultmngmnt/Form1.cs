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
    public partial class Form1 : Form
    {
        string str = @"Data Source=LAPTOP-2OU8NEFO\SQLEXPRESS;Initial Catalog = Result; Integrated Security = True;";
        int a, x;
       
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // SqlConnection con = new SqlConnection(str);
            // SqlDataAdapter da = new SqlDataAdapter("Select Count(*) from Signin where Unamen = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "' and type ='"+ cmbtype.Text +"'", con);

            //Method 1

            //    DataSet ds = new DataSet();
            //    da.Fill(ds,"LogIn");
            //   if(ds.Tables[0].Rows.Count == 0)
            //    {
            //       a = 1;
            //        // x = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            //       timer1.Enabled = true;
            //
            //
            //    }
            //    else
            //    {
            //        //con.Close();
            //        MessageBox.Show("Wrong user id or password");
            //    }


            // Method 2
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("Select Count(*) from Signin where Unamen = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "' and type ='" + cmbtype.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") 
            {
                 a = 1;
                timer1.Enabled = true;
                cpy.Text = "Copyright ©2017 Saurabh Singh Rawat's & Group All Rights Reserved.";
            }
            else
            {
                MessageBox.Show("Wrong Userid or Password");
                textBox1.Clear();
                textBox2.Clear();
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (a <= 50)
           {
              progressBar1.Value = a;
              a++;
           }
            else
            {
                //     Main fm = new Main();
                //     fm.i=x;
                //     fm.Show();
                //     timer1.Enabled = false;
                //     this.Hide();
                // 

                SqlConnection con1 = new SqlConnection(str);
                SqlDataAdapter da1 = new SqlDataAdapter("Select type from Signin where Unamen = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "'", con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                if (dt1.Rows[0][0].ToString() == "SERVER")
                {

                    
                    Main mn = new Main(textBox1.Text);
                    mn.Show();
                    timer1.Enabled = false;
                    this.Hide();
                }
                if (dt1.Rows[0][0].ToString() == "CLIENT")
                {
                    this.Hide();
                    Main mn = new Main(textBox1.Text);
                    mn.Show();
                    timer1.Enabled = false;
                }

            }
        }
    }
}
