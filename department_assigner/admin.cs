using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace department_assigner
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void start_MouseHover(object sender, EventArgs e)
        {
            start.BackColor = Color.Gold;
        }

        private void start_MouseLeave(object sender, EventArgs e)
        {
            start.BackColor = Color.Cyan;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            insta.BackColor = Color.Gold;

        }

        private void insta_MouseLeave(object sender, EventArgs e)
        {
            insta.BackColor = Color.Cyan;
        }

        //get start clck
        private void start_Click(object sender, EventArgs e)
        {
            assigner ass = new assigner();
            ass.Show();
        }

        //isntruction clicked 
        private void insta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        //help clicked 
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        //about clicked 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("intial contributer blackeagle team@msf dbu 2022\n fobybus and dagim emishaw");
        }

        //exit clicked 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
