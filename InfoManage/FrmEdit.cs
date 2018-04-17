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
    public partial class FrmEdit : Form
    {
        DataGridView dgvInfo;
        
        public FrmEdit()
        {
            InitializeComponent();
        }
        public FrmEdit(DataGridView _dgvInfo)
        {
            dgvInfo = _dgvInfo ;
            InitializeComponent();

        }

        private void FrmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //1获取数据
            string name = inputName.Text;
            string gender = inputGender.Text;
            decimal age = inputAge.Value;
            string stunumb = inputStuNo.Text;
            string address = inputAddress.Text;
            //string interest = inputInteres.CheckedItems;
            /*string interest = "";


            for (int i = 0; i < inputInteres.CheckedItems.Count; i++)
            {
                interest += inputInteres.CheckedItems[i].ToString()+",";
            }*/


            //MessageBox.Show(name + "  " + gender + "  " + age + "  " + stunumb + "  "+ address +"  "+ interest,"输入的是");


            //2绑定数据 DATATABLE
            //DataTable dt = new DataTable();

            

            DataRow dr = FrmMain.dt.NewRow();
            dr["colname"] = name;
            dr["colgen"] = gender;
            dr["colage"] = age;
            dr["colnum"] = stunumb;
            dr["coladd"] = address;
            //dr["colhob"] = interest;

            FrmMain.dt.Rows.Add(dr);

            dgvInfo.DataSource = FrmMain.dt;
            this.Hide();
        }

        private void cancelsign_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {

        }

        private void inputGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputStuNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void 密保问题_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputAge_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
