using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoManage
{
    
    public partial class FrmMain : Form
    {
        public static DataTable dt = new DataTable();
        public FrmMain()
        {
            //DataColumn dc1 = new DataColumn("");
            DataColumn dc1 = new DataColumn("colname");
            DataColumn dc2 = new DataColumn("colgen");
            DataColumn dc3 = new DataColumn("colage");
            DataColumn dc4 = new DataColumn("colnum");
            DataColumn dc5 = new DataColumn("coladd");
            DataColumn dc6 = new DataColumn("colhob");

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            InitializeComponent();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmEdit(dgvInfo);
            frm.Show();
            //this.Hide();
        }
    }
}
