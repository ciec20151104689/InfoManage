namespace InfoManage
{
    partial class FrmEdit
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
            this.inputInteres = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputGender = new System.Windows.Forms.ComboBox();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.inputStuNo = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.密保问题 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelsign = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.inputAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inputAge)).BeginInit();
            this.SuspendLayout();
            // 
            // inputInteres
            // 
            this.inputInteres.FormattingEnabled = true;
            this.inputInteres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputInteres.Items.AddRange(new object[] {
            "爬树",
            "游泳",
            "吃饭"});
            this.inputInteres.Location = new System.Drawing.Point(196, 197);
            this.inputInteres.MultiColumn = true;
            this.inputInteres.Name = "inputInteres";
            this.inputInteres.Size = new System.Drawing.Size(120, 84);
            this.inputInteres.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 43;
            this.label4.Text = "兴趣";
            // 
            // inputGender
            // 
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.inputGender.Location = new System.Drawing.Point(520, 48);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(179, 20);
            this.inputGender.TabIndex = 42;
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(196, 142);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(503, 21);
            this.inputAddress.TabIndex = 41;
            // 
            // inputStuNo
            // 
            this.inputStuNo.Location = new System.Drawing.Point(520, 96);
            this.inputStuNo.Name = "inputStuNo";
            this.inputStuNo.Size = new System.Drawing.Size(179, 21);
            this.inputStuNo.TabIndex = 40;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(196, 48);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(179, 21);
            this.inputName.TabIndex = 38;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "籍贯";
            // 
            // 密保问题
            // 
            this.密保问题.AutoSize = true;
            this.密保问题.Location = new System.Drawing.Point(440, 99);
            this.密保问题.Name = "密保问题";
            this.密保问题.Size = new System.Drawing.Size(29, 12);
            this.密保问题.TabIndex = 36;
            this.密保问题.Text = "学号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "年龄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "性别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "姓名";
            // 
            // cancelsign
            // 
            this.cancelsign.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelsign.Location = new System.Drawing.Point(546, 379);
            this.cancelsign.Name = "cancelsign";
            this.cancelsign.Size = new System.Drawing.Size(75, 23);
            this.cancelsign.TabIndex = 32;
            this.cancelsign.Text = "取消";
            this.cancelsign.UseVisualStyleBackColor = true;
            this.cancelsign.Click += new System.EventHandler(this.cancelsign_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(442, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(196, 96);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(120, 21);
            this.inputAge.TabIndex = 45;
            // 
            // FrmEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelsign;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.inputInteres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.inputStuNo);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.密保问题);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelsign);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmEdit";
            this.Text = "FrmEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEdit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.inputAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox inputInteres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputGender;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.TextBox inputStuNo;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label 密保问题;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelsign;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown inputAge;
    }
}