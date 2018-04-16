namespace InfoManage
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnedt = new System.Windows.Forms.ToolStripButton();
            this.tsbtndel = new System.Windows.Forms.ToolStripButton();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStuNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbtnedt,
            this.tsbtndel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "添加";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtnedt
            // 
            this.tsbtnedt.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnedt.Image")));
            this.tsbtnedt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnedt.Name = "tsbtnedt";
            this.tsbtnedt.Size = new System.Drawing.Size(52, 22);
            this.tsbtnedt.Text = "修改";
            this.tsbtnedt.Click += new System.EventHandler(this.tsbtnedt_Click);
            // 
            // tsbtndel
            // 
            this.tsbtndel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtndel.Image")));
            this.tsbtndel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtndel.Name = "tsbtndel";
            this.tsbtndel.Size = new System.Drawing.Size(52, 22);
            this.tsbtndel.Text = "删除";
            this.tsbtndel.Click += new System.EventHandler(this.tsbtndel_Click);
            // 
            // ColAddress
            // 
            this.ColAddress.DataPropertyName = "coladd";
            this.ColAddress.HeaderText = "籍贯";
            this.ColAddress.Name = "ColAddress";
            // 
            // ColStuNum
            // 
            this.ColStuNum.DataPropertyName = "colnum";
            this.ColStuNum.HeaderText = "学号";
            this.ColStuNum.Name = "ColStuNum";
            // 
            // ColAge
            // 
            this.ColAge.DataPropertyName = "colage";
            this.ColAge.HeaderText = "年龄";
            this.ColAge.Name = "ColAge";
            // 
            // ColGender
            // 
            this.ColGender.DataPropertyName = "colgen";
            this.ColGender.HeaderText = "性别";
            this.ColGender.Name = "ColGender";
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "colname";
            this.ColName.HeaderText = "姓名";
            this.ColName.Name = "ColName";
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColGender,
            this.ColAge,
            this.ColStuNum,
            this.ColAddress});
            this.dgvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfo.Location = new System.Drawing.Point(0, 25);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(800, 425);
            this.dgvInfo.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbtnedt;
        private System.Windows.Forms.ToolStripButton tsbtndel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStuNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridView dgvInfo;
    }
}