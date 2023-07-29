namespace department_assigner
{
    partial class assigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assigner));
            this.label1 = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.caplabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cap = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.screen_sadd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_s = new System.Windows.Forms.Button();
            this.selec_b = new System.Windows.Forms.Button();
            this.choice_l = new System.Windows.Forms.ComboBox();
            this.nth_l = new System.Windows.Forms.ComboBox();
            this.textBox_ave = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assign_b = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "insert departments";
            // 
            // dname
            // 
            this.dname.Location = new System.Drawing.Point(30, 310);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(178, 20);
            this.dname.TabIndex = 1;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(30, 346);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(124, 55);
            this.add.TabIndex = 2;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(124, 154);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // caplabel
            // 
            this.caplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caplabel.Location = new System.Drawing.Point(257, 283);
            this.caplabel.Name = "caplabel";
            this.caplabel.Size = new System.Drawing.Size(84, 21);
            this.caplabel.TabIndex = 4;
            this.caplabel.Text = "capacity";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "department name";
            // 
            // cap
            // 
            this.cap.Location = new System.Drawing.Point(251, 310);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(90, 20);
            this.cap.TabIndex = 6;
            // 
            // next
            // 
            this.next.Enabled = false;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(194, 345);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(132, 56);
            this.next.TabIndex = 8;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dname);
            this.panel1.Controls.Add(this.cap);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.caplabel);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 440);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.screen_sadd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.add_s);
            this.groupBox1.Controls.Add(this.selec_b);
            this.groupBox1.Controls.Add(this.choice_l);
            this.groupBox1.Controls.Add(this.nth_l);
            this.groupBox1.Controls.Add(this.textBox_ave);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(392, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 255);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "student choice";
            // 
            // screen_sadd
            // 
            this.screen_sadd.Location = new System.Drawing.Point(243, 179);
            this.screen_sadd.Name = "screen_sadd";
            this.screen_sadd.Size = new System.Drawing.Size(89, 29);
            this.screen_sadd.TabIndex = 10;
            this.screen_sadd.Text = "0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(199, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "added:";
            // 
            // add_s
            // 
            this.add_s.Enabled = false;
            this.add_s.Location = new System.Drawing.Point(76, 179);
            this.add_s.Name = "add_s";
            this.add_s.Size = new System.Drawing.Size(93, 34);
            this.add_s.TabIndex = 8;
            this.add_s.Text = "add student";
            this.add_s.UseVisualStyleBackColor = true;
            this.add_s.Click += new System.EventHandler(this.add_s_Click);
            // 
            // selec_b
            // 
            this.selec_b.Location = new System.Drawing.Point(319, 128);
            this.selec_b.Name = "selec_b";
            this.selec_b.Size = new System.Drawing.Size(57, 32);
            this.selec_b.TabIndex = 7;
            this.selec_b.Text = "select";
            this.selec_b.UseVisualStyleBackColor = true;
            this.selec_b.Click += new System.EventHandler(this.selec_b_Click);
            // 
            // choice_l
            // 
            this.choice_l.FormattingEnabled = true;
            this.choice_l.Location = new System.Drawing.Point(177, 128);
            this.choice_l.Name = "choice_l";
            this.choice_l.Size = new System.Drawing.Size(121, 21);
            this.choice_l.TabIndex = 6;
            // 
            // nth_l
            // 
            this.nth_l.FormattingEnabled = true;
            this.nth_l.Location = new System.Drawing.Point(18, 128);
            this.nth_l.Name = "nth_l";
            this.nth_l.Size = new System.Drawing.Size(121, 21);
            this.nth_l.TabIndex = 5;
            // 
            // textBox_ave
            // 
            this.textBox_ave.Location = new System.Drawing.Point(110, 75);
            this.textBox_ave.Name = "textBox_ave";
            this.textBox_ave.Size = new System.Drawing.Size(121, 20);
            this.textBox_ave.TabIndex = 4;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(110, 36);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(178, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "average_point";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "full name";
            // 
            // assign_b
            // 
            this.assign_b.BackColor = System.Drawing.SystemColors.Highlight;
            this.assign_b.BackgroundImage = global::department_assigner.Properties.Resources.edu_cape;
            this.assign_b.Enabled = false;
            this.assign_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assign_b.Location = new System.Drawing.Point(502, 349);
            this.assign_b.Name = "assign_b";
            this.assign_b.Size = new System.Drawing.Size(165, 70);
            this.assign_b.TabIndex = 11;
            this.assign_b.Text = "assign";
            this.assign_b.UseVisualStyleBackColor = false;
            this.assign_b.Click += new System.EventHandler(this.assign_b_Click);
            // 
            // assigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::department_assigner.Properties.Resources.it_guys1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 522);
            this.Controls.Add(this.assign_b);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "assigner";
            this.Text = "assigner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dname;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label caplabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cap;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ave;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_s;
        private System.Windows.Forms.Button selec_b;
        private System.Windows.Forms.ComboBox choice_l;
        private System.Windows.Forms.ComboBox nth_l;
        private System.Windows.Forms.Button assign_b;
        private System.Windows.Forms.Label screen_sadd;
        private System.Windows.Forms.Label label4;
    }
}