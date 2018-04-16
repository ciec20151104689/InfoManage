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
        {
            string name = inputName.Text;
            string gender = inputGender.Text;
            decimal age = inputAge.Value;
            string stunumb = inputStuNo.Text;
            string address = inputAddress.Text;
        }

        private void Frmupdate_Load(object sender, EventArgs e)
        {
            string name = dgvInfo.SelectedRows[0].Cells["ColName"].Value.ToString();
            inputName.Text = name;
        }
    }
}
