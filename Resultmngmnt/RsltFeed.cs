using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Resultmngmnt
{
    public partial class RsltFeed : Form
    {
        string str = @"Data Source=LAPTOP-2OU8NEFO\SQLEXPRESS;Initial Catalog=Result;Integrated Security=True;";

        int totthemax, totprexmax, totthmin, totprintmax;
        int tobt1, tobt2, tobt3, tobt4, tobt5, tobt6, tobt7;
        int pobt1, pobt2, pobt3, pobt4, pobt5, pobt6, pobt7;
        int tottobt, totpobt;



        int gtot, sess,sessobt, gp,gpobt, ie,ieobt;

        

        public RsltFeed()
        {
            InitializeComponent();
        }
        private void RollNo_DoubleClick(object sender, EventArgs e)
        {
            int i = 0;
            txtsroll.Text = RollNo.Text;
            txtsname.Text = Name.Text;

            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("select fname,dob from stinfo where Rollno = '" + txtsroll.Text + "' and Sname = '" + txtsname.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "stinfo");

            txtfn.Text = ds.Tables[0].Rows[i][0].ToString();
            dateTimePicker1.Value =Convert.ToDateTime( ds.Tables[0].Rows[i][0]);
            txtdob.Text = ds.Tables[0].Rows[i][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            totthemax = 0;
            totthmin = 0;
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
            sessobt = 0;
            gp = 0;
            gpobt = 0;
            ie = 0;
            ieobt = 0;
            //
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("Select Rollno,Sname from stinfo where Branch = '" + Cmbbrn.Text + "' and Semester = '" + CmbSem.Text + "' and Stutype = '" + CmbStutype.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "stinfo");
            RollNo.DataSource = ds.Tables[0];
            RollNo.DisplayMember = "Rollno";
            Name.DataSource = ds.Tables[0];

            Name.DisplayMember = "Sname";

            SqlDataAdapter da1 = new SqlDataAdapter("Select code,name,Th_max_m,Th_min_m,P_max_m,P_min_m from subjectinfo where Branch='" + Cmbbrn.Text + "' and Sem ='" + CmbSem.Text + "'", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "subjectinfo");
            if (CmbSem.SelectedItem.ToString() == "1")
            {
                txtsemax.Text = "320";
                sess = Convert.ToInt32(txtsemax.Text);
                txtsessMin.Text = Convert.ToString((sess) / 2);
                txtgpmx.Text = "25";
                gp = Convert.ToInt32(txtgpmx.Text);
                txtgpmin.Text = Convert.ToString((gp) / 2);
                txtiemx.Text = "25";
                ie = Convert.ToInt32(txtiemx.Text);
                txtiemn.Text = Convert.ToString((ie) / 2);


            }
            else if (CmbSem.SelectedItem.ToString() == "2")
            {
                txtsemax.Text = "320";
                sess = Convert.ToInt32(txtsemax.Text);
                txtsessMin.Text = Convert.ToString((sess) / 2);
                txtgpmx.Text = "25";
                gp = Convert.ToInt32(txtgpmx.Text);
                txtgpmin.Text = Convert.ToString((gp) / 2);
                txtiemx.Text = "25";
                ie = Convert.ToInt32(txtiemx.Text);
                txtiemn.Text = Convert.ToString((ie) / 2);
            }
            else if (CmbSem.SelectedItem.ToString() == "3")
            {
                txtsemax.Text = "220";
                sess = Convert.ToInt32(txtsemax.Text);
                txtsessMin.Text = Convert.ToString((sess) / 2);
                txtgpmx.Text = "25";
                gp = Convert.ToInt32(txtgpmx.Text);
                txtgpmin.Text = Convert.ToString((gp) / 2);
                txtiemx.Text = "25";
                ie = Convert.ToInt32(txtiemx.Text);
                txtiemn.Text = Convert.ToString((ie) / 2);
            }
            else if (CmbSem.SelectedItem.ToString() == "4")
            {
                txtsemax.Text = "220";
                sess = Convert.ToInt32(txtsemax.Text);
                txtsessMin.Text = Convert.ToString((sess) / 2);
                txtgpmx.Text = "25";
                gp = Convert.ToInt32(txtgpmx.Text);
                txtgpmin.Text = Convert.ToString((gp) / 2);
                txtiemx.Text = "25";
                ie = Convert.ToInt32(txtiemx.Text);
                txtiemn.Text = Convert.ToString((ie) / 2);
            }
            else if (CmbSem.SelectedItem.ToString() == "5")
            {
                txtsemax.Text = "220";
                sess = Convert.ToInt32(txtsemax.Text);
                txtsessMin.Text = Convert.ToString((sess) / 2);
                txtgpmx.Text = "25";
                gp = Convert.ToInt32(txtgpmx.Text);
                txtgpmin.Text = Convert.ToString((gp) / 2);
                txtiemx.Text = "25";
                ie = Convert.ToInt32(txtiemx.Text);
                txtiemn.Text = Convert.ToString((ie) / 2);
            }
            else if (CmbSem.SelectedItem.ToString() == "6")
            {
                txtsemax.Text = "220";
                sess = Convert.ToInt32(txtsemax.Text);
                txtsessMin.Text = Convert.ToString((sess) / 2);
                txtgpmx.Text = "25";
                gp = Convert.ToInt32(txtgpmx.Text);
                txtgpmin.Text = Convert.ToString((gp) / 2);
                txtiemx.Text = "25";
                ie = Convert.ToInt32(txtiemx.Text);
                txtiemn.Text = Convert.ToString((ie) / 2);
            }
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {

                    sthcode1.Text = ds1.Tables[0].Rows[i][0].ToString();
                    Sthname1.Text = ds1.Tables[0].Rows[i][1].ToString();
                    thmax1.Text = ds1.Tables[0].Rows[i][2].ToString();
                    thmin1.Text = ds1.Tables[0].Rows[i][3].ToString();
                    prsname1.Text = ds1.Tables[0].Rows[i][1].ToString();
                    Sprcode1.Text = ds1.Tables[0].Rows[i][0].ToString();
                    prmax1.Text = ds1.Tables[0].Rows[i][4].ToString();
                    prmin1.Text = ds1.Tables[0].Rows[i][5].ToString();
                    totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][2].ToString());
                    totthmin = totthmin + Convert.ToInt32(ds1.Tables[0].Rows[i][3].ToString());
               }

                else if (i==1)
                {
                    sthcode2.Text = ds1.Tables[0].Rows[i][0].ToString();
                    sthname2.Text = ds1.Tables[0].Rows[i][1].ToString();
                    thmax2.Text = ds1.Tables[0].Rows[i][2].ToString();
                    thmin2.Text = ds1.Tables[0].Rows[i][3].ToString();
                    prsname2.Text = ds1.Tables[0].Rows[i][1].ToString();
                    sprcode2.Text = ds1.Tables[0].Rows[i][0].ToString();
                    prmax2.Text = ds1.Tables[0].Rows[i][4].ToString();
                    prmin2.Text = ds1.Tables[0].Rows[i][5].ToString();
                    totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][2].ToString());
                    totthmin = totthmin + Convert.ToInt32(ds1.Tables[0].Rows[i][3].ToString());
                }
                else if (i == 2)
                {
                    sthcode3.Text = ds1.Tables[0].Rows[i][0].ToString();
                    sthname3.Text = ds1.Tables[0].Rows[i][1].ToString();
                    thmax3.Text = ds1.Tables[0].Rows[i][2].ToString();
                    thmin3.Text = ds1.Tables[0].Rows[i][3].ToString();
                    prsname3.Text = ds1.Tables[0].Rows[i][1].ToString();
                    sprcode3.Text = ds1.Tables[0].Rows[i][0].ToString();
                    prmax3.Text = ds1.Tables[0].Rows[i][4].ToString();
                    prmin3.Text = ds1.Tables[0].Rows[i][5].ToString();
                    totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][2].ToString());
                    totthmin = totthmin + Convert.ToInt32(ds1.Tables[0].Rows[i][3].ToString());

                }
                else if (i == 3)
                {
                    sthcode4.Text = ds1.Tables[0].Rows[i][0].ToString();
                    sthname4.Text = ds1.Tables[0].Rows[i][1].ToString();
                    thmax4.Text = ds1.Tables[0].Rows[i][2].ToString();
                    thmin4.Text = ds1.Tables[0].Rows[i][3].ToString();
                    prsname4.Text = ds1.Tables[0].Rows[i][1].ToString();
                    sprcode4.Text = ds1.Tables[0].Rows[i][0].ToString();
                    prmax4.Text = ds1.Tables[0].Rows[i][4].ToString();
                    prmin4.Text = ds1.Tables[0].Rows[i][5].ToString();
                    totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][2].ToString());
                    totthmin = totthmin + Convert.ToInt32(ds1.Tables[0].Rows[i][3].ToString());

                }
                else if (i == 4)
                {
                    sthcode5.Text = ds1.Tables[0].Rows[i][0].ToString();
                    sthname5.Text = ds1.Tables[0].Rows[i][1].ToString();
                    thmax5.Text = ds1.Tables[0].Rows[i][2].ToString();
                    thmin5.Text = ds1.Tables[0].Rows[i][3].ToString();
                    prsname5.Text = ds1.Tables[0].Rows[i][1].ToString();
                    sprcode5.Text = ds1.Tables[0].Rows[i][0].ToString();
                    prmax5.Text = ds1.Tables[0].Rows[i][4].ToString();
                    prmin5.Text = ds1.Tables[0].Rows[i][5].ToString();
                    totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][2].ToString());
                    totthmin = totthmin + Convert.ToInt32(ds1.Tables[0].Rows[i][3].ToString());

                }
                else if (i == 5)
                {
                    sthcode6.Text = ds1.Tables[0].Rows[i][0].ToString();
                    sthname6.Text = ds1.Tables[0].Rows[i][1].ToString();
                    thmax6.Text = ds1.Tables[0].Rows[i][2].ToString();
                    thmin6.Text = ds1.Tables[0].Rows[i][3].ToString();
                    prsname6.Text = ds1.Tables[0].Rows[i][1].ToString();
                    sprcode6.Text = ds1.Tables[0].Rows[i][0].ToString();
                    prmax6.Text = ds1.Tables[0].Rows[i][4].ToString();
                    prmin6.Text = ds1.Tables[0].Rows[i][5].ToString();
                    totthemax = totthemax + Convert.ToInt32(ds1.Tables[0].Rows[i][2].ToString());
                    totthmin = totthmin + Convert.ToInt32(ds1.Tables[0].Rows[i][3].ToString());

                }

            }
            thtotmax.Text = Convert.ToString(totthemax);
            tothemin.Text = Convert.ToString(totthmin);
            txtgndmax.Text = "1000";
            // txtsess.Text = Convert.ToString(totthintmax + totprintmax);

            //  prtotmax.Text = Convert.ToString(totprexmax);
            //    txtgtot.Text = Convert.ToString(totthintmax + totprintmax + totthemax + totprexmax + Convert.ToInt32(txtgp.Text) + Convert.ToInt32(txtie.Text));
            //     txtsessMin.Text = Convert.ToString((totthintmax + totprintmax) / 2);




        }

        private void thobt1_Leave(object sender, EventArgs e)
        {
            if (thobt1.Text != "")
            {
                tobt1 = Convert.ToInt32(thobt1.Text);
                tottobt = tobt1 + tobt2 + tobt3 + tobt4 + tobt5 + tobt6 + tobt7;
                if (tobt1 < Convert.ToInt32(thmin1.Text))
                {
                    thsta1.SelectedIndex = 0;
                    cmbrslt.SelectedIndex = 0;
                }
                else
                {
                    //thsta1.Text = "";
                    thsta1.SelectedIndex = 1;
                    

                }
                Thobtmax.Text = Convert.ToString(tottobt);
            }
        }

        

        private void thobt4_TextChanged(object sender, EventArgs e)
        {

        }
        private void thobt2_Leave(object sender, EventArgs e)
        {
            if (thobt2.Text != "")
            {
                tobt2 = Convert.ToInt32(thobt2.Text);
                tottobt = tobt1 + tobt2 + tobt3 + tobt4 + tobt5 + tobt6 + tobt7;
                if (tobt2 < Convert.ToInt32(thmin2.Text))
                {
                    thsta2.SelectedIndex = 0;
                    cmbrslt.SelectedIndex = 0;
                }
                else
                {
                    thsta2.SelectedIndex = 1;
                    
                }
           
                Thobtmax.Text = Convert.ToString(tottobt);
            }
        }

        private void thobt3_Leave(object sender, EventArgs e)
        {
            if (thobt3.Text != "")
            {
                tobt3 = Convert.ToInt32(thobt3.Text);
                tottobt = tobt1 + tobt2 + tobt3 + tobt4 + tobt5 + tobt6 + tobt7;
                if (tobt3 < Convert.ToInt32(thmin3.Text))
                {
                    thsta3.SelectedIndex = 0;
                    cmbrslt.SelectedIndex = 0;
                }
                else
                {
                    thsta3.SelectedIndex = 1;
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
                    thsta4.SelectedIndex = 0;
                    cmbrslt.SelectedIndex = 0;
                }
                else
                {
                    thsta4.SelectedIndex = 1;
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
                    thsta5.SelectedIndex = 0;
                    cmbrslt.SelectedIndex = 0;

                }
                else
                {
                    thsta5.SelectedIndex = 1;
                    
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
                    thsta6.SelectedIndex = 0;
                    cmbrslt.SelectedIndex = 0;
                }
                else
                {
                    thsta6.SelectedIndex = 1;
                }
                Thobtmax.Text = Convert.ToString(tottobt);
            }
        }

        private void probt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void probt1_Leave(object sender, EventArgs e)
        {
            if (probt1.Text != "")
            {
                pobt1 = Convert.ToInt32(probt1.Text);
                totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
                if (pobt1 < Convert.ToInt32(prmin1.Text))
                {
                    prsta1.SelectedIndex = 0;
                }
                else
                {
                    //prsta1.Text = "";
                    prsta1.SelectedIndex = 1;
                }
                probtmax.Text = Convert.ToString(totpobt);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void txtsessMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxtcode1_Leave(object sender, EventArgs e)
        {
            int i = 0;
          SqlConnection con = new SqlConnection(str);
          SqlCommand cmd = new SqlCommand();
          SqlDataAdapter da= new SqlDataAdapter("Select sem,Name,Th_max_m,Th_min_m from subjectinfo where Code = '" + btxtcode1.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "subjectinfo");
            btxtsem1.Text = ds.Tables[0].Rows[i][0].ToString();
            btxtsub1.Text = ds.Tables[0].Rows[i][1].ToString();
            btxtmm1.Text = ds.Tables[0].Rows[i][2].ToString();
            btxtmn1.Text = ds.Tables[0].Rows[i][3].ToString();

        }

        private void btxtcode2_Leave(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("Select sem,Name,Th_max_m,Th_min_m from subjectinfo where Code = '" + btxtcode2.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "subjectinfo");
            btxtsem2.Text = ds.Tables[0].Rows[i][0].ToString();
            btxtsub2.Text = ds.Tables[0].Rows[i][1].ToString();
            btxtmm2.Text = ds.Tables[0].Rows[i][2].ToString();
            btxtmn2.Text = ds.Tables[0].Rows[i][3].ToString();
        }

        private void btxtcode3_Leave(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("Select sem,Name,Th_max_m,Th_min_m from subjectinfo where Code = '" + btxtcode3.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "subjectinfo");
            btxtsem3.Text = ds.Tables[0].Rows[i][0].ToString();
            btxtsub3.Text = ds.Tables[0].Rows[i][1].ToString();
            btxtmm3.Text = ds.Tables[0].Rows[i][2].ToString();
            btxtmn3.Text = ds.Tables[0].Rows[i][3].ToString();
        }

        private void btxtcode4_Leave(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("Select sem,Name,Th_max_m,Th_min_m from subjectinfo where Code = '" + btxtcode4.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "subjectinfo");
            btxtsem4.Text = ds.Tables[0].Rows[i][0].ToString();
            btxtsub4.Text = ds.Tables[0].Rows[i][1].ToString();
            btxtmm4.Text = ds.Tables[0].Rows[i][2].ToString();
            btxtmn4.Text = ds.Tables[0].Rows[i][3].ToString();
        }

        private void btxtcode5_Leave(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("Select sem,Name,Th_max_m,Th_min_m from subjectinfo where Code = '" + btxtcode5.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "subjectinfo");
            btxtsem5.Text = ds.Tables[0].Rows[i][0].ToString();
            btxtsub5.Text = ds.Tables[0].Rows[i][1].ToString();
            btxtmm5.Text = ds.Tables[0].Rows[i][2].ToString();
            btxtmn5.Text = ds.Tables[0].Rows[i][3].ToString();
        }

        private void btxtcode6_Leave(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("Select sem,Name,Th_max_m,Th_min_m from subjectinfo where Code = '" + btxtcode6.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "subjectinfo");
            btxtsem6.Text = ds.Tables[0].Rows[i][0].ToString();
            btxtsub6.Text = ds.Tables[0].Rows[i][1].ToString();
            btxtmm6.Text = ds.Tables[0].Rows[i][2].ToString();
            btxtmn6.Text = ds.Tables[0].Rows[i][3].ToString();
        }
        private void btxtcode7_Leave(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("Select sem,Name,Th_max_m,Th_min_m from subjectinfo where Code = '" + btxtcode7.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "subjectinfo");
            btxtsem7.Text = ds.Tables[0].Rows[i][0].ToString();
            btxtsub7.Text = ds.Tables[0].Rows[i][1].ToString();
            btxtmm7.Text = ds.Tables[0].Rows[i][2].ToString();
            btxtmn7.Text = ds.Tables[0].Rows[i][3].ToString();
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {

            if (Convert.ToInt32(btxtobt1.Text) < Convert.ToInt32(btxtmn1.Text))
            {
                bcmbst1.SelectedIndex = 0;
                cmbrslt.SelectedIndex = 0;
            }
            else
            {
                bcmbst1.SelectedIndex = 1;
             
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btxtobt2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btxtobt2.Text) < Convert.ToInt32(btxtmn2.Text))
            {
                bcmbst2.SelectedIndex = 0;
                cmbrslt.SelectedIndex = 0;
            }
            else
            {
                bcmbst2.SelectedIndex = 1;
            }
        }

        private void btxtobt3_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btxtobt3.Text) < Convert.ToInt32(btxtmn3.Text))
            {
                bcmbst3.SelectedIndex = 0;
                cmbrslt.SelectedIndex = 0;
            }
            else
            {
                bcmbst3.SelectedIndex = 1;
            }
        }

        private void btxtobt4_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btxtobt4.Text) < Convert.ToInt32(btxtmn4.Text))
            {
                bcmbst4.SelectedIndex = 0;
                cmbrslt.SelectedIndex = 0;
            }
            else
            {
                bcmbst4.SelectedIndex = 1;
            }
        }

        private void btxtobt5_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btxtobt5.Text) < Convert.ToInt32(btxtmn5.Text))
            {
                bcmbst5.SelectedIndex = 0;
                cmbrslt.SelectedIndex = 0;
            }
            else
            {
                bcmbst5.SelectedIndex = 1;
            }
        }

        private void btxtobt6_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btxtobt6.Text) < Convert.ToInt32(btxtmn6.Text))
            {
                bcmbst6.SelectedIndex = 0;
                cmbrslt.SelectedIndex = 0;
            }
            else
            {
                bcmbst6.SelectedIndex = 1;
            }
        }

        private void btxtobt7_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btxtobt7.Text) < Convert.ToInt32(btxtmn7.Text))
            {
                bcmbst7.SelectedIndex = 0;
                cmbrslt.SelectedIndex = 0;
            }
            else
            {
                bcmbst7.SelectedIndex = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.ResetText();
            clear();

        }
        void clear()
        {
            label34.Text = "Cleared! Now,insert another result.♥♥♥ ";
            txtsroll.Clear();
            txtsname.Clear();
            txtfn.Clear();
            txtdob.Clear();
            //obtain
            thobt1.Clear();
            thobt2.Clear();
            thobt3.Clear();
            thobt4.Clear();
            thobt5.Clear();
            thobt6.Clear();
            //status

            //thsta1.ResetText();
            // thsta1.DataSource = null;
            thsta1.SelectedIndex = -1;
            thsta1.Items.Add("B");
            thsta1.Items.Add("P");
//            cmbrslt.Items.Add("PBP");
//            cmbrslt.Items.Add("PGP");
//            cmbrslt.Items.Add("FFF");



            thsta2.SelectedIndex = -1;
            thsta2.Items.Add("B");
            thsta2.Items.Add("P");
           // cmbrslt.Items.Add("PBP");
           // cmbrslt.Items.Add("PGP");
           // cmbrslt.Items.Add("FFF");

            thsta3.SelectedIndex = -1;
            thsta3.Items.Add("B");
            thsta3.Items.Add("P");
           // cmbrslt.Items.Add("PBP");
           // cmbrslt.Items.Add("PGP");
           // cmbrslt.Items.Add("FFF");

            thsta4.SelectedIndex = -1;
            thsta4.Items.Add("B");
            thsta4.Items.Add("P");
          //  cmbrslt.Items.Add("PBP");
          //  cmbrslt.Items.Add("PGP");
          //  cmbrslt.Items.Add("FFF");

            thsta5.SelectedIndex = -1;
            thsta5.Items.Add("B");
            thsta5.Items.Add("P");
           // cmbrslt.Items.Add("PBP");
           // cmbrslt.Items.Add("PGP");
           // cmbrslt.Items.Add("FFF");

            thsta6.SelectedIndex = -1;
            thsta6.Items.Add("B");
            thsta6.Items.Add("P");

            cmbrslt.Items.Add("PBP");
            cmbrslt.Items.Add("PGP");
            cmbrslt.Items.Add("FFF");


            Thobtmax.Clear();
            
            //practicals
           
            probt1.Clear();
            probt2.Clear();
            probt3.Clear();
            probt4.Clear();
            probt5.Clear();
            probt6.Clear();


            prsta1.ResetText();
            prsta1.Items.Add("B");
            prsta1.Items.Add("P");

            prsta2.ResetText();
            prsta2.Items.Add("B");
            prsta2.Items.Add("P");


            prsta3.ResetText();
            prsta3.Items.Add("B");
            prsta3.Items.Add("P");


            prsta4.ResetText();
            prsta4.Items.Add("B");
            prsta4.Items.Add("P");


            prsta5.ResetText();
            prsta5.Items.Add("B");
            prsta5.Items.Add("P");


            prsta6.ResetText();
            prsta6.Items.Add("B");
            prsta6.Items.Add("P");



            //sessional
            txtsess.Clear();
            txtgp.Clear();
            txtie.Clear();
            txtgndmax.Clear();
            txtgtot.Clear();
            cmbrslt.SelectedIndex = -1 ;

            //back
            btxtsem1.Clear();
            btxtsem2.Clear();
            btxtsem3.Clear();
            btxtsem4.Clear();
            btxtsem5.Clear();
            btxtsem6.Clear();

            btxtsem1.Clear();
            btxtsem2.Clear();
            btxtsem3.Clear();
            btxtsem4.Clear();
            btxtsem5.Clear();
            btxtsem6.Clear();

            btxtsub1.Clear();
            btxtsub2.Clear();
            btxtsub3.Clear();
            btxtsub4.Clear();
            btxtsub5.Clear();
            btxtsub6.Clear();

            btxtmm1.Clear();
            btxtmm2.Clear();
            btxtmm3.Clear();
            btxtmm4.Clear();
            btxtmm5.Clear();
            btxtmm6.Clear();

            btxtmn1.Clear();
            btxtmn2.Clear();
            btxtmn3.Clear();
            btxtmn4.Clear();
            btxtmn5.Clear();
            btxtmn6.Clear();

            btxtobt1.Clear();
            btxtobt2.Clear();
            btxtobt3.Clear();
            btxtobt4.Clear();
            btxtobt5.Clear();
            btxtobt6.Clear();

            bcmbst1.ResetText();
            bcmbst1.Items.Add("B");
            bcmbst1.Items.Add("P");

            bcmbst2.ResetText();
            bcmbst2.Items.Add("B");
            bcmbst2.Items.Add("P");

            bcmbst3.ResetText();
            bcmbst3.Items.Add("B");
            bcmbst3.Items.Add("P");

            bcmbst4.ResetText();
            bcmbst4.Items.Add("B");
            bcmbst4.Items.Add("P");

            bcmbst5.ResetText();
            bcmbst5.Items.Add("B");
            bcmbst5.Items.Add("P");

            bcmbst6.ResetText();
            bcmbst6.Items.Add("B");
            bcmbst6.Items.Add("P");




        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void probt2_Leave(object sender, EventArgs e)
        {
            if (probt2.Text != "")
            {
                pobt2 = Convert.ToInt32(probt2.Text);
                totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
                if (pobt2 < Convert.ToInt32(prmin2.Text))
                {
                    prsta2.SelectedIndex = 0;
                    cmbrslt.SelectedIndex = 0;

                }
                else
                {
                    prsta2.SelectedIndex = 1;
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
                    prsta3.SelectedIndex = 0;
                    cmbrslt.SelectedIndex = 0;

                }
                else
                {
                    prsta3.SelectedIndex = 1;
                }
                probtmax.Text = Convert.ToString(totpobt);
            }
        }

        private void CmbStutype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtfn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sprcode1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgpmx_TextChanged(object sender, EventArgs e)
        {

        }

        private void probt4_Leave(object sender, EventArgs e)
        {
            if (probt4.Text != "")
            {
                pobt4 = Convert.ToInt32(probt4.Text);
                totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
                if (pobt4 < Convert.ToInt32(prmin4.Text))

                {
                    prsta4.SelectedIndex = 0;

                    cmbrslt.SelectedIndex = 0;
                }
                else
                {
                    prsta4.SelectedIndex = 1;
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
                    prsta5.SelectedIndex = 0;

                    cmbrslt.SelectedIndex = 0;
                }
                else
                {
                    prsta5.SelectedIndex = 1;
                }
                probtmax.Text = Convert.ToString(totpobt);
            }

        }

        private void probt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void probt6_Leave(object sender, EventArgs e)
        {
            if (probt6.Text != "")
            {
                pobt6 = Convert.ToInt32(probt6.Text);
                totpobt = pobt1 + pobt2 + pobt3 + pobt4 + pobt5 + pobt6 + pobt7;
                if (pobt6 < Convert.ToInt32(prmin6.Text))
                {
                    prsta6.SelectedIndex = 0;
                    cmbrslt.SelectedIndex = 0;
                }
                else
                {
                    prsta6.SelectedIndex = 1;
                }
                probtmax.Text = Convert.ToString(totpobt);
            }


        }

        private void thtotmax_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsname_TextChanged(object sender, EventArgs e)
        {

        }

        private void RsltFeed_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sprcode7_TextChanged(object sender, EventArgs e)
        {

        }

        private void prsname7_TextChanged(object sender, EventArgs e)
        {

        }

        private void prmax7_TextChanged(object sender, EventArgs e)
        {

        }

        private void prmin7_TextChanged(object sender, EventArgs e)
        {

        }

        private void probt7_TextChanged(object sender, EventArgs e)
        {

        }

        private void prsta7_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void thmax1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Thobtmax_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtsess_Leave(object sender, EventArgs e)
        {
            sessobt = Convert.ToInt32(txtsess.Text);
            gtot = tottobt + totpobt + sessobt + gpobt + ieobt;
            txtgtot.Text = Convert.ToString(gtot);
        }
        private void txtgp_Leave(object sender, EventArgs e)
        {
            gpobt = Convert.ToInt32(txtgp.Text);
            gtot = tottobt + totpobt + sessobt + gpobt + ieobt;
            txtgtot.Text = Convert.ToString(gtot);

        }
        private void txtie_Leave(object sender, EventArgs e)
        {
            ieobt = Convert.ToInt32(txtie.Text);
            gtot = tottobt + totpobt + sessobt + gpobt + ieobt;
            txtgtot.Text = Convert.ToString(gtot);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
           SqlCommand cmd = new SqlCommand("insert into rslt(rollno,branch,sem,Theory,Practical,Sesional,GP,IE ,Total ,Result) values (@rollno, @branch,@sem,@Theory,@Practical,@Sesional,@GP,@IE,@Total,@Result)", con);
            cmd.Parameters.AddWithValue("@rollno", txtsroll.Text);
            cmd.Parameters.AddWithValue("@branch", Cmbbrn.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Sem", CmbSem.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Theory", Thobtmax.Text);
            cmd.Parameters.AddWithValue("@Practical", probtmax.Text);
            cmd.Parameters.AddWithValue("@Sesional", txtsess.Text);
            cmd.Parameters.AddWithValue("@GP", txtgp.Text);
            cmd.Parameters.AddWithValue("@IE", txtie.Text);
            cmd.Parameters.AddWithValue("@Total", txtgtot.Text);
            cmd.Parameters.AddWithValue("@Result", cmbrslt.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            label34.Text="One Result Added";
            MessageBox.Show("information Saved sucessfully");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("Update rslt set rollno = @rollno,branch = @branch, Sem = @Sem, Theory = @Theory,Practical=@Practical, Sesional = @Sesional, GP = @GP, IE = @IE, Total = @Total,Result=@Result where rollno = '" + txtsroll.Text + "'", con);
            cmd.Parameters.AddWithValue("@rollno", txtsroll.Text);
            cmd.Parameters.AddWithValue("@branch", Cmbbrn.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Sem", CmbSem.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Theory", Thobtmax.Text);
            cmd.Parameters.AddWithValue("@Practical", probtmax.Text);
            cmd.Parameters.AddWithValue("@Sesional", txtsess.Text);
            cmd.Parameters.AddWithValue("@GP", txtgp.Text);
            cmd.Parameters.AddWithValue("@IE", txtie.Text);
            cmd.Parameters.AddWithValue("@Total", txtgtot.Text);
            cmd.Parameters.AddWithValue("@Result", cmbrslt.Text); bcmbst1.Items.Clear();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            label34.Text = "One result is Updated";
            MessageBox.Show("information Updated sucessfully");
        }
    }
}
