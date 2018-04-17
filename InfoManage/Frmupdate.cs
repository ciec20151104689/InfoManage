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
    public partial class Frmupdate : Form
    {
        DataGridView dgvInfo;
        public Frmupdate()
        {
            InitializeComponent();
        }
        public Frmupdate(DataGridView _dgvInfo)
        {
            dgvInfo = _dgvInfo;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {//1获取数据
            string name = inputName.Text;
            string gender = inputGender.Text;
            decimal age = inputAge.Value;
            string stunumb = inputStuNo.Text;
            string address = inputAddress.Text;
            //FrmMain.dt.Rows.RemoveAt(FrmMain.index);
            
            //2获取选中行索引

            int index = dgvInfo.SelectedRows[0].Index;

            //3修改ddatatable数据

            FrmMain.dt.Rows[index]["colname"] = name;
            FrmMain.dt.Rows[index]["colgen"] = gender;
            FrmMain.dt.Rows[index]["colage"] = age;
            FrmMain.dt.Rows[index]["colnum"] = stunumb;
            FrmMain.dt.Rows[index]["coladd"] = address;
            dgvInfo.DataSource = FrmMain.dt;

        }

        private void Frmupdate_Load(object sender, EventArgs e)
        {
            string name = dgvInfo.SelectedRows[0].Cells["ColName"].Value.ToString();
            string gender = dgvInfo.SelectedRows[0].Cells["ColGender"].Value.ToString();
            decimal age = Convert.ToDecimal(dgvInfo.SelectedRows[0].Cells["ColAge"].Value);
            string stunumb = dgvInfo.SelectedRows[0].Cells["ColStuNum"].Value.ToString();
            string address = dgvInfo.SelectedRows[0].Cells["ColAddress"].Value.ToString();
            inputName.Text = name;
            inputGender.Text = gender;
            inputAge.Value = age;
            inputStuNo.Text = stunumb;
            inputAddress.Text = address;
        }
    }
}
