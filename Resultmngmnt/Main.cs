using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resultmngmnt
{
    public partial class Main : Form
    {
        // public int i;
        public Main(String User)
        {
            InitializeComponent();
            label1.Text = "User :" + User;

            if (User == "Student")
            {
                admin.Enabled = false;
                     
            }

        }
        private void button1_DragOver(object sender, DragEventArgs e)
        {
        
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reasult sr = new Reasult();
            sr.MdiParent = this;
            sr.Show();
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstuinfo sr = new frmstuinfo();
            sr.MdiParent = this;
            sr.Show();
        }

        private void subjectInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
             subinfo sr = new subinfo();
           // test1 sr = new test1();
            sr.MdiParent = this;
            sr.Show();
        }

        private void feedResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RsltFeed sr = new RsltFeed();
            sr.MdiParent = this;
            sr.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // if (i == 2)
            // {
            //     admin.Enabled = false;
            // }

         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
           
        }
    }
}