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
    public partial class o : Form
    {
        string str = @"Data Source=LAPTOP-2OU8NEFO\SQLEXPRESS;Initial Catalog=Result;Integrated Security=True;";
        SqlConnection con;
        SqlCommand cmd;
        int totthemax, totprexmax, totthintmax, totprintmax;
        int tobt1, tobt2, tobt3, tobt4, tobt5, tobt6, tobt7;
        int pobt1, pobt2, pobt3, pobt4, pobt5, pobt6, pobt7;
        int tottobt, totpobt;
        int gtot, sess, gp, ie;

        public o()
        {
            InitializeComponent();
        }

        private void o_Load(object sender, EventArgs e)
        {
           con = new SqlConnection(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   Con = new SqlConnection("string str = @"Data Source = LAPTOP - 2OU8NEFO\SQLEXPRESS; Initial Catalog = Result; Integrated Security = True";
            //");
            // cmd = new SqlCommand("select Rollno, Sname,Fname,dob from stinfo");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            totprexmax = 0;
            totprintmax = 0;
            tobt1 = 0;
            tobt2 = 0;
            tobt3 = 0;
            tobt4 = 0;
            tobt5 = 0;
            tobt6 = 0;
            tobt7 = 0;
            gtot = 0;
            sess = 0;
            gp = 0;
            ie = 0;
            int i;
            totthemax = 0;
         //
            //  SqlDataAdapter da = new SqlDataAdapter("select * from stinfo where Branch = '" + Cmbbrn.Text + "' and Semester = " + CmbSem.Text + " and Stutype = '" + CmbStutype.Text + "'", con);
            //  DataSet ds = new DataSet();
            //  da.Fill(ds);
            SqlConnection con = new SqlConnection(str);
           //  con.Open();
            SqlCommand cmd = new SqlCommand("Select Rollno,sname from stinfo where Branch='" +Cmbbrn.Text + "' and Semester ='" + CmbSem.Text +"' and Stutype='"+CmbStutype+ "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "stinfo");
            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "Rollno";
            listBox2.DataSource = ds.Tables[0];
            listBox2.DisplayMember = "sname";

            

            // SqlDataAdapter da1 = new SqlDataAdapter("select * from subjectinfo where Branch = '" + Cmbbrn.Text + "' and sem = " + CmbSem.Text + " ", con);
            // DataSet ds1 = new DataSet();
            // da1.Fill(ds1);
            SqlConnection sr = new SqlConnection(str);
            sr.Open();
            SqlCommand cm = new SqlCommand("Select * from subjectinfo where Branch='" + Cmbbrn.Text + "' and sem='" + CmbSem.Text + "'", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            for (i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    ////th///
                    if (ds1.Tables[0].Rows[i][4].ToString() == "1")
                    {
                        sthcode1.Text = ds1.Tables[0].Rows[i][0].ToString();
                        Sthname1.Text = ds1.Tables[0].Rows[i][1].ToString();
                        thmax1.Text = ds1.Tables[0].Rows[i][7].ToString();
                        totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][7].ToString());
                        totthintmax = totthintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][6].ToString());
                        thmin1.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][7].ToString()) * 0.33));
    
                    }
                    else
                    {
                        sthcode1.Visible = false;
                        Sthname1.Visible = false;
                        thmax1.Visible = false;
                        thmin1.Visible = false;
                        thobt1.Visible = false;
                        thsta1.Visible = false;
                    }
                    //pr//
                    if (ds1.Tables[0].Rows[i][5].ToString() == "1")
                    {
                        Sprcode1.Text = ds1.Tables[0].Rows[i][0].ToString();
                        prsname1.Text = ds1.Tables[0].Rows[i][1].ToString();
                        prmax1.Text = ds1.Tables[0].Rows[i][9].ToString();
                        totprexmax = totprexmax + Convert.ToInt32(ds1.Tables[0].Rows[i][9].ToString());
                        totprintmax = totprintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][8].ToString());
                        prmin1.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][9].ToString()) * 0.33));
                    }
                    else
                    {
                        Sprcode1.Visible = false;
                        prsname1.Visible = false;
                        prmax1.Visible = false;
                        prmin1.Visible = false;
                        probt1.Visible = false;
                        prsta1.Visible = false;
    
                    }
                }
                else if (i == 1)
                {
                    //th//
                    if (ds1.Tables[0].Rows[i][4].ToString() == "1")
                    {
                        sthcode2.Text = ds1.Tables[0].Rows[i][0].ToString();
                        sthname2.Text = ds1.Tables[0].Rows[i][1].ToString();
                        thmax2.Text = ds1.Tables[0].Rows[i][7].ToString();
                        totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][7].ToString());
                        totthintmax = totthintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][6].ToString());
                        thmin2.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][7].ToString()) * 0.33));
                    }
                    else
                    {
                        sthcode2.Visible = false;
                        sthname2.Visible = false;
                        thmax2.Visible = false;
                        thmin2.Visible = false;
                        thobt2.Visible = false;
                        thsta2.Visible = false;
                    }
                    //pr//
                    if (ds1.Tables[0].Rows[i][5].ToString() == "1")
                    {
                        sprcode2.Text = ds1.Tables[0].Rows[i][0].ToString();
                        prsname2.Text = ds1.Tables[0].Rows[i][1].ToString();
                        prmax2.Text = ds1.Tables[0].Rows[i][9].ToString();
                        totprexmax = totprexmax + Convert.ToInt32(ds1.Tables[0].Rows[i][9].ToString());
                        totprintmax = totprintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][8].ToString());
                        prmin2.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][9].ToString()) * 0.33));
                    }
                    else
                    {
                        sprcode2.Visible = false;
                        prsname2.Visible = false;
                        prmax2.Visible = false;
                        prmin2.Visible = false;
                        probt2.Visible = false;
                        prsta2.Visible = false;
    
                    }
    
                }
                else if (i == 2)
                {
                    ////th////
                    if (ds1.Tables[0].Rows[i][4].ToString() == "1")
                    {
                        sthcode3.Text = ds1.Tables[0].Rows[i][0].ToString();
                        sthname3.Text = ds1.Tables[0].Rows[i][1].ToString();
                        thmax3.Text = ds1.Tables[0].Rows[i][7].ToString();
                        totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][7].ToString());
                        totthintmax = totthintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][6].ToString());
                        thmin3.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][7].ToString()) * 0.33));
                    }
                    else
                    {
                        sthcode3.Visible = false;
                        sthname3.Visible = false;
                        thmax3.Visible = false;
                        thmin3.Visible = false;
                        thobt3.Visible = false;
                        thsta3.Visible = false;
                    }
                    //pr//
    
                    if (ds1.Tables[0].Rows[i][5].ToString() == "1")
                    {
                        sprcode3.Text = ds1.Tables[0].Rows[i][0].ToString();
                        prsname3.Text = ds1.Tables[0].Rows[i][1].ToString();
                        prmax3.Text = ds1.Tables[0].Rows[i][9].ToString();
                        totprexmax = totprexmax + Convert.ToInt32(ds1.Tables[0].Rows[i][9].ToString());
                        totprintmax = totprintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][8].ToString());
                        Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][9].ToString()) * 0.33));
                    }
                    else
                    {
                        sprcode3.Visible = false;
                        prsname3.Visible = false;
                        prmax3.Visible = false;
                        prmin3.Visible = false;
                        probt3.Visible = false;
                        prsta3.Visible = false;
                    }
                }
                else if (i == 3)
                {
                    //th///
                    if (ds1.Tables[0].Rows[i][4].ToString() == "1")
                    {
                        sthcode4.Text = ds1.Tables[0].Rows[i][0].ToString();
                        sthname4.Text = ds1.Tables[0].Rows[i][1].ToString();
                        thmax4.Text = ds1.Tables[0].Rows[i][7].ToString();
                        totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][7].ToString());
                        totthintmax = totthintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][6].ToString());
                        thmin4.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][7].ToString()) * 0.33));
    
                    }
                    else
                    {
                        sthcode4.Visible = false;
                        sthname4.Visible = false;
                        thmax4.Visible = false;
                        thmin4.Visible = false;
                        thobt4.Visible = false;
                        thsta4.Visible = false;
                    }
                    //pr//
                    if (ds1.Tables[0].Rows[i][5].ToString() == "1")
                    {
                        sprcode4.Text = ds1.Tables[0].Rows[i][0].ToString();
                        prsname4.Text = ds1.Tables[0].Rows[i][1].ToString();
                        prmax4.Text = ds1.Tables[0].Rows[i][9].ToString();
                        totprexmax = totprexmax + Convert.ToInt32(ds1.Tables[0].Rows[i][9].ToString());
                        totprintmax = totprintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][8].ToString());
                        prmin4.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][9].ToString()) * 0.33));
    
                    }
                    else
                    {
                        sprcode4.Visible = false;
                        prsname4.Visible = false;
                        prmax4.Visible = false;
                        prmin4.Visible = false;
                        probt4.Visible = false;
                        prsta4.Visible = false;
                    }
                }
                else if (i == 4)
                {
                    if (ds1.Tables[0].Rows[i][4].ToString() == "1")
                    {
                        sthcode5.Text = ds1.Tables[0].Rows[i][0].ToString();
                        sthname5.Text = ds1.Tables[0].Rows[i][1].ToString();
                        thmax5.Text = ds1.Tables[0].Rows[i][7].ToString();
                        totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][7].ToString());
                        totthintmax = totthintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][6].ToString());
                        thmin5.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][7].ToString()) * 0.33));
    
                    }
                    else
                    {
                        sthcode5.Visible = false;
                        sthname5.Visible = false;
                        thmax5.Visible = false;
                        thmin5.Visible = false;
                        thobt5.Visible = false;
                        thsta5.Visible = false;
                    }
                    //pr//
                    if (ds1.Tables[0].Rows[i][5].ToString() == "1")
                    {
                        sprcode5.Text = ds1.Tables[0].Rows[i][0].ToString();
                        prsname5.Text = ds1.Tables[0].Rows[i][1].ToString();
                        prmax5.Text = ds1.Tables[0].Rows[i][9].ToString();
                        totprexmax = totprexmax + Convert.ToInt32(ds1.Tables[0].Rows[i][9].ToString());
                        totprintmax = totprintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][8].ToString());
                        prmin5.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][9].ToString()) * 0.33));
    
                    }
                    else
                    {
                        sprcode5.Visible = false;
                        prsname5.Visible = false;
                        prmax5.Visible = false;
                        prmin5.Visible = false;
                        probt5.Visible = false;
                        prsta5.Visible = false;
                    }
                }
                else if (i == 5)
                {
                    if (ds1.Tables[0].Rows[i][4].ToString() == "1")
                    {
                        sthcode6.Text = ds1.Tables[0].Rows[i][0].ToString();
                        sthname6.Text = ds1.Tables[0].Rows[i][1].ToString();
                        thmax6.Text = ds1.Tables[0].Rows[i][7].ToString();
                        totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][7].ToString());
                        totthintmax = totthintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][6].ToString());
                        thmin6.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][7].ToString()) * 0.33));
    
                    }
                    else
                    {
                        sthcode6.Visible = false;
                        sthname6.Visible = false;
                        thmax6.Visible = false;
                        thmin6.Visible = false;
                        thobt6.Visible = false;
                        thsta6.Visible = false;
                    }
                    //pr//
                    if (ds1.Tables[0].Rows[i][5].ToString() == "1")
                    {
                        sprcode6.Text = ds1.Tables[0].Rows[i][0].ToString();
                        prsname6.Text = ds1.Tables[0].Rows[i][1].ToString();
                        prmax6.Text = ds1.Tables[0].Rows[i][9].ToString();
                        totprexmax = totprexmax + Convert.ToInt32(ds1.Tables[0].Rows[i][9].ToString());
                        totprintmax = totprintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][8].ToString());
                        prmin6.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][9].ToString()) * 0.33));
    
                    }
                    else
                    {
                        sprcode6.Visible = false;
                        prsname6.Visible = false;
                        prmax6.Visible = false;
                        prmin6.Visible = false;
                        probt6.Visible = false;
                        prsta5.Visible = false;
                    }
                }
                else if (i == 6)
                {
                    if (ds1.Tables[0].Rows[i][4].ToString() == "1")
                    {
                        sthcode7.Text = ds1.Tables[0].Rows[i][0].ToString();
                        sthname7.Text = ds1.Tables[0].Rows[i][1].ToString();
                        thmax7.Text = ds1.Tables[0].Rows[i][7].ToString();
                        totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][7].ToString());
                        totthintmax = totthintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][6].ToString());
                        thmin7.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][7].ToString()) * 0.33));
    
                    }
                    else
                    {
                        sthcode7.Visible = false;
                        sthname7.Visible = false;
                        thmax7.Visible = false;
                        thmin7.Visible = false;
                        thobt7.Visible = false;
                        thsta7.Visible = false;
                    }
                    //pr//
                    if (ds1.Tables[0].Rows[i][5].ToString() == "1")
                    {
                        sprcode7.Text = ds1.Tables[0].Rows[i][0].ToString();
                        prsname7.Text = ds1.Tables[0].Rows[i][1].ToString();
                        prmax7.Text = ds1.Tables[0].Rows[i][9].ToString();
                        totprexmax = totprexmax + Convert.ToInt32(ds1.Tables[0].Rows[i][9].ToString());
                        totprintmax = totprintmax + Convert.ToInt32(ds1.Tables[0].Rows[i][8].ToString());
                        prmin7.Text = Convert.ToString(Math.Round(Convert.ToSingle(ds1.Tables[0].Rows[i][9].ToString()) * 0.33));
    
                    }
                    else
                    {
                        sprcode7.Visible = false;
                        prsname7.Visible = false;
                        prmax7.Visible = false;
                        prmin7.Visible = false;
                        probt7.Visible = false;
                        prsta7.Visible = false;
                    }
                }
            }
    
            for (int j = i; j <= 7; j++)
            {
                if (j == 0)
                {
                    sthcode1.Visible = false;
                    Sthname1.Visible = false;
                    thmax1.Visible = false;
                    thmin1.Visible = false;
    
                    Sprcode1.Visible = false;
                    prsname1.Visible = false;
                    prmax1.Visible = false;
                    probt1.Visible = false;
                    prsta1.Visible = false;
                }
                else if (j == 1)
                {
                    sthcode2.Visible = false;
                    sthname2.Visible = false;
                    thmax2.Visible = false;
                    thmin2.Visible = false;
    
                    sprcode2.Visible = false;
                    prsname2.Visible = false;
                    prmax2.Visible = false;
                    probt2.Visible = false;
                    prsta2.Visible = false;
                }
                else if (j == 2)
                {
                    sthcode3.Visible = false;
                    sthname3.Visible = false;
                    thmax3.Visible = false;
                    thmin3.Visible = false;
    
                    sprcode3.Visible = false;
                    prsname3.Visible = false;
                    prmax3.Visible = false;
                    probt3.Visible = false;
                    prsta3.Visible = false;
                }
                else if (j == 3)
                {
                    sthcode4.Visible = false;
                    sthname4.Visible = false;
                    thmax4.Visible = false;
                    thmin4.Visible = false;
    
                    sprcode4.Visible = false;
                    prsname4.Visible = false;
                    prmax4.Visible = false;
                    probt4.Visible = false;
                    prsta4.Visible = false;
                }
                else if (j == 4)
                {
                    sthcode5.Visible = false;
                    sthname5.Visible = false;
                    thmax5.Visible = false;
                    thmin5.Visible = false;
    
                    sprcode5.Visible = false;
                    prsname5.Visible = false;
                    prmax5.Visible = false;
                    probt5.Visible = false;
                    prsta5.Visible = false;
                }
                else if (j == 5)
                {
                    sthcode6.Visible = false;
                    sthname6.Visible = false;
                    thmax6.Visible = false;
                    thmin6.Visible = false;
    
                    sprcode6.Visible = false;
                    prsname6.Visible = false;
                    prmax6.Visible = false;
                    probt6.Visible = false;
                    prsta6.Visible = false;
                }
                else if (j == 6)
                {
                    sthcode7.Visible = false;
                    sthname7.Visible = false;
                    thmax7.Visible = false;
                    thmin7.Visible = false;
    
                    sprcode7.Visible = false;
                    prsname7.Visible = false;
                    prmax7.Visible = false;
                    probt7.Visible = false;
                    prsta7.Visible = false;
                }
            }
            txtsess.Text = Convert.ToString(totthintmax + totprintmax);
            thtotmax.Text = Convert.ToString(totthemax);
            prtotmax.Text = Convert.ToString(totprexmax);
            txtgtot.Text = Convert.ToString(totthintmax + totprintmax + totthemax + totprexmax + Convert.ToInt32(txtgp.Text) + Convert.ToInt32(txtie.Text));
            txtsessMin.Text = Convert.ToString((totthintmax + totprintmax) / 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
            {

            }
        private void thobt1_Leave(object sender, EventArgs e)
        {
           if (thobt1.Text != "")
           {
               tobt1 = Convert.ToInt32(thobt1.Text);
               tottobt = tobt1 + tobt2 + tobt3 + tobt4 + tobt5 + tobt6 + tobt7;
               if (tobt1 < Convert.ToInt32(thmin1.Text))
               {
                   thsta1.SelectedIndex = 1;
               }
               else
               {
                   thsta1.Text = "";
               }
               Thobtmax.Text = Convert.ToString(tottobt);
           }
        }

        private void thobt2_Leave(object sender, EventArgs e)
        {
            if (thobt2.Text != "")
            {
                tobt2 = Convert.ToInt32(thobt2.Text);
                tottobt = tobt1 + tobt2 + tobt3 + tobt4 + tobt5 + tobt6 + tobt7;
                if (tobt2 < Convert.ToInt32(thmin2.Text))
                {
                    thsta2.SelectedIndex = 1;
                }
                else
                {
                    thsta2.Text = "";
                }
                Thobtmax.Text = Convert.ToString(tottobt);
            }
        }

        private void thtotmax_TextChanged(object sender, EventArgs e)
        {

        }

        private void thobt3_Leave(object sender, EventArgs e)
        {
           if (thobt1.Text != "")
           {
               tobt3 = Convert.ToInt32(thobt3.Text);
               tottobt = tobt1 + tobt2 + tobt3 + tobt4 + tobt5 + tobt6 + tobt7;
               if (tobt3 < Convert.ToInt32(thmin3.Text))
               {
                   thsta3.SelectedIndex = 1;
               }
               else
               {
                   thsta3.Text = "";
               }
               Thobtmax.Text = Convert.ToString(tottobt);
           }
        }
   
        private void thobt4_Leave(object sender, EventArgs e)
        {
            if (thobt4.Text != "")
            {
                tobt4 = Convert.ToInt32(thobt4.Text);
                tottobt = tobt1 + tobt2 + tobt3 + tobt4 + tobt5 + tobt6 + tobt7;
                if (tobt4 < Convert.ToInt32(thmin4.Text))
                {
                    thsta4.SelectedIndex = 1;
                }
                else
                {
                    thsta4.Text = "";
                }
                Thobtmax.Text = Convert.ToString(tottobt);
            }
        }
   
        private void thobt5_Leave(object sender, EventArgs e)
        {
            if (thobt1.Text != "")
            {
                tobt5 = Convert.ToInt32(thobt5.Text);
                tottobt = tobt1 + tobt2 + tobt3 + tobt4 + tobt5 + tobt6 + tobt7;
                if (tobt5 < Convert.ToInt32(thmin5.Text))
                {
                    thsta5.SelectedIndex = 1;
                }
                else
                {
                    thsta5.Text = "";
                }
                Thobtmax.Text = Convert.ToString(tottobt);
            }
        }
   
        private void thobt6_Leave(object sender, EventArgs e)
        {
            if (thobt6.Text != "")
            {
                tobt6 = Convert.ToInt32(thobt6.Text);
                tottobt = tobt1 + tobt2 + tobt3 + tobt4 + tobt5 + tobt6 + tobt7;
                if (tobt6 < Convert.ToInt32(thmin6.Text))
                {
                    thsta6.SelectedIndex = 1;
                }
                else
                {
                    thsta6.Text = "";
                }
                Thobtmax.Text = Convert.ToString(tottobt);
            }
        }
   
        private void thobt7_Leave(object sender, EventArgs e)
        {
           if (thobt1.Text != "")
           {
               tobt7 = Convert.ToInt32(thobt7.Text);
               tottobt = tobt1 + tobt2 + tobt3 + tobt4 + tobt5 + tobt6 + tobt7;
               if (tobt7 < Convert.ToInt32(thmin7.Text))
               {
                   thsta1.SelectedIndex = 1;
               }
               else
               {
                   thsta7.Text = "";
               }
               Thobtmax.Text = Convert.ToString(tottobt);
           }
        }
   
        private void probt1_Leave(object sender, EventArgs e)
        {
            if (probt1.Text != "")
            {
                pobt1 = Convert.ToInt32(probt1.Text);
                totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
                if (pobt1 < Convert.ToInt32(prmin1.Text))
                {
                    prsta1.SelectedIndex = 1;
                }
                else
                {
                    prsta1.Text = "";
                }
                probtmax.Text = Convert.ToString(totpobt);
            }
        }
   
        private void probt2_Leave(object sender, EventArgs e)
        {
           if (probt2.Text != "")
           {
               pobt2 = Convert.ToInt32(probt2.Text);
               totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
               if (pobt2 < Convert.ToInt32(prmin2.Text))
               {
                   prsta2.SelectedIndex = 1;
               }
               else
               {
                   prsta2.Text = "";
               }
               probtmax.Text = Convert.ToString(totpobt);
           }
  
        }
   
        private void probt3_Leave(object sender, EventArgs e)
        {
            if (probt3.Text != "")
            {
                pobt3 = Convert.ToInt32(probt3.Text);
                totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
                if (pobt3 < Convert.ToInt32(prmin3.Text))
                {
                    prsta3.SelectedIndex = 1;
                }
                else
                {
                    prsta3.Text = "";
                }
                probtmax.Text = Convert.ToString(totpobt);
            }
   
        }
   
        private void probt4_Leave(object sender, EventArgs e)
        {
            if (probt4.Text != "")
            {
                pobt4 = Convert.ToInt32(probt4.Text);
                totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
                if (pobt4 < Convert.ToInt32(prmin4.Text))
                {
                    prsta4.SelectedIndex = 1;
                }
                else
                {
                    prsta4.Text = "";
                }
                probtmax.Text = Convert.ToString(totpobt);
            }
   
        }
   
        private void probt5_Leave(object sender, EventArgs e)
        {
         if (probt5.Text != "")
         {
             pobt5 = Convert.ToInt32(probt5.Text);
             totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
             if (pobt5 < Convert.ToInt32(prmin5.Text))
             {
                 prsta5.SelectedIndex = 1;
             }
             else
             {
                 prsta5.Text = "";
             }
             probtmax.Text = Convert.ToString(totpobt);
         }
   
        }
   
        private void probt6_Leave(object sender, EventArgs e)
        {
            if (probt6.Text != "")
            {
                pobt6 = Convert.ToInt32(probt6.Text);
                totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
                if (pobt6 < Convert.ToInt32(prmin6.Text))
                {
                    prsta6.SelectedIndex = 1;
                }
                else
                {
                    prsta6.Text = "";
                }
                probtmax.Text = Convert.ToString(totpobt);
            }
   
        }
   
        private void probt7_Leave(object sender, EventArgs e)
        {
           if (probt7.Text != "")
           {
               pobt7 = Convert.ToInt32(probt7.Text);
               totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
               if (pobt7 < Convert.ToInt32(prmin7.Text))
               {
                   prsta7.SelectedIndex = 1;
               }
               else
               {
                   prsta7.Text = "";
               }
               probtmax.Text = Convert.ToString(totpobt);
           }
   
        }
   
        private void txtsessobt_Leave(object sender, EventArgs e)
        {
   
        }
   
        private void txtsess_Leave(object sender, EventArgs e)
        {
           if (txtsess.Text != "")
           {
               sess = Convert.ToInt32(txtsess.Text);
               gtot = tottobt + totpobt + sess + gp + ie;
               txtgtot.Text = Convert.ToString(gtot);
           }
        }
   
        private void txtgp_Leave(object sender, EventArgs e)
        {
            if (txtgp.Text != "")
            {
                gp = Convert.ToInt32(txtgp.Text);
                gtot = tottobt + totpobt + sess + gp + ie;
                txtgtot.Text = Convert.ToString(gtot);
            }
        }
   
        private void txtie_Leave(object sender, EventArgs e)
        {
           if (txtie.Text != "") 
           {
               gp = Convert.ToInt32(txtie.Text);
               gtot = tottobt + totpobt + sess + gp + ie;
               txtgtot.Text = Convert.ToString(gtot);
           }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Thobtmax_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
