namespace Resultmngmnt
{
    partial class Reasult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reasult));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Button();
            this.RollNo = new System.Windows.Forms.Label();
            this.txttyp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfnm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdob = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(124, 45);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(75, 28);
            this.Result.TabIndex = 3;
            this.Result.Text = "Result";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // RollNo
            // 
            this.RollNo.AutoSize = true;
            this.RollNo.Location = new System.Drawing.Point(12, 22);
            this.RollNo.Name = "RollNo";
            this.RollNo.Size = new System.Drawing.Size(45, 13);
            this.RollNo.TabIndex = 4;
            this.RollNo.Text = "Roll No.";
            // 
            // txttyp
            // 
            this.txttyp.Location = new System.Drawing.Point(739, 81);
            this.txttyp.Name = "txttyp";
            this.txttyp.Size = new System.Drawing.Size(151, 20);
            this.txttyp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            // 
            // txtfnm
            // 
            this.txtfnm.Location = new System.Drawing.Point(739, 36);
            this.txtfnm.Name = "txtfnm";
            this.txtfnm.Size = new System.Drawing.Size(151, 20);
            this.txtfnm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Father\'s Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(407, 40);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(154, 20);
            this.txtname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Birth";
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(407, 80);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(154, 20);
            this.txtdob.TabIndex = 2;
            // 
            // Reasult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1061, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RollNo);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtfnm);
            this.Controls.Add(this.txttyp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reasult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reasult";
            this.Load += new System.EventHandler(this.Reasult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label RollNo;
        private System.Windows.Forms.TextBox txttyp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfnm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdob;
    }
}