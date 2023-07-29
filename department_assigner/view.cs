using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace department_assigner
{
    public partial class view : Form
    {
        public view(DataTable dt,SqlDataAdapter ad)
        {
            InitializeComponent();
            this.Show();
            ad.Fill(dt);
            this.dataGridView1.DataSource = dt;
          
        }
    }
}
