﻿namespace InfoManage
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
            // inputGender
            // 
            this.inputGender.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.inputGender.Location = new System.Drawing.Point(867, 76);
            this.inputGender.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(296, 27);
            this.inputGender.TabIndex = 42;
            this.inputGender.SelectedIndexChanged += new System.EventHandler(this.inputGender_SelectedIndexChanged);
            // 
            // inputAddress
            // 
            this.inputAddress.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputAddress.Location = new System.Drawing.Point(327, 224);
            this.inputAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(836, 28);
            this.inputAddress.TabIndex = 41;
            this.inputAddress.TextChanged += new System.EventHandler(this.inputAddress_TextChanged);
            // 
            // inputStuNo
            // 
            this.inputStuNo.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputStuNo.Location = new System.Drawing.Point(867, 152);
            this.inputStuNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.inputStuNo.Name = "inputStuNo";
            this.inputStuNo.Size = new System.Drawing.Size(296, 28);
            this.inputStuNo.TabIndex = 40;
            this.inputStuNo.TextChanged += new System.EventHandler(this.inputStuNo_TextChanged);
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputName.Location = new System.Drawing.Point(327, 76);
            this.inputName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(296, 28);
            this.inputName.TabIndex = 38;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "籍贯";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // 密保问题
            // 
            this.密保问题.AutoSize = true;
            this.密保问题.Location = new System.Drawing.Point(733, 157);
            this.密保问题.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.密保问题.Name = "密保问题";
            this.密保问题.Size = new System.Drawing.Size(49, 19);
            this.密保问题.TabIndex = 36;
            this.密保问题.Text = "学号";
            this.密保问题.Click += new System.EventHandler(this.密保问题_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "年龄";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(733, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "性别";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "姓名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cancelsign
            // 
            this.cancelsign.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelsign.Location = new System.Drawing.Point(737, 398);
            this.cancelsign.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cancelsign.Name = "cancelsign";
            this.cancelsign.Size = new System.Drawing.Size(125, 36);
            this.cancelsign.TabIndex = 32;
            this.cancelsign.Text = "取消";
            this.cancelsign.UseVisualStyleBackColor = true;
            this.cancelsign.Click += new System.EventHandler(this.cancelsign_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(564, 398);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // inputAge
            // 
            this.inputAge.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputAge.Location = new System.Drawing.Point(327, 152);
            this.inputAge.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(200, 28);
            this.inputAge.TabIndex = 45;
            this.inputAge.ValueChanged += new System.EventHandler(this.inputAge_ValueChanged);
            // 
            // FrmEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelsign;
            this.ClientSize = new System.Drawing.Size(1203, 611);
            this.Controls.Add(this.inputAge);
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
            this.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmEdit";
            this.Text = "FrmEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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