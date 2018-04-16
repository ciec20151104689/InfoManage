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
            // DataColumn dc6 = new DataColumn("colhob");

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            //dt.Columns.Add(dc6);
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

        private void tsbtndel_Click(object sender, EventArgs e)
        {
            //弹出提示框，如果 选择 是
            //MessageBox.Show("删除");
            //获取当前选中行
            /*int index = dgvInfo.CurrentRow.Index;    //取得选中行的索引  
            txt_ProductId.Text = dgvInfo.Rows[index].Cells["Id"].Value;   //获取单元格列名为‘Id’的值  */
            /* DialogResult RSS = MessageBox.Show(this, "确定要删除选中行数据码？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             switch (RSS)
             {
                 case DialogResult.Yes:
                     for (int i = this.dgvInfo.SelectedRows.Count; i > 0; i--)
                     {
                         int ID = Convert.ToInt32(dgvInfo.SelectedRows[i - 1].Cells[0].Value);
                         dgvInfo.Rows.RemoveAt(dgvInfo.SelectedRows[i - 1].Index);

                         //从datatable查找要删除行，并删除
                         //重新绑定datagridview
                     }
                     break;
             }*/
            //dgvInfo.Rows.Remove(dgvInfo.SelectedRows[0]);

            DialogResult rs =MessageBox.Show(this, "确定要删除选中行数据码？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                //dgvInfo.Rows.Remove(dgvInfo.SelectedRows[0]);
                int index = dgvInfo.SelectedRows[0].Index;
                FrmMain.dt.Rows.RemoveAt(index);
                dgvInfo.DataSource = FrmMain.dt;
            }
        }

        private void tsbtnedt_Click(object sender, EventArgs e)
        {
            Form fu = new Frmupdate(dgvInfo);
            fu.Show();
        }
    }
}
