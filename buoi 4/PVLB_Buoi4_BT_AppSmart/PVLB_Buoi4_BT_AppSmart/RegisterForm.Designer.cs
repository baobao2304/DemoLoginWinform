namespace PVLB_Buoi4_BT_AppSmart
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.cboServerName = new System.Windows.Forms.ComboBox();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pass Word :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(149, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(231, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(149, 129);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(231, 20);
            this.txtPassWord.TabIndex = 5;
            // 
            // cboServerName
            // 
            this.cboServerName.FormattingEnabled = true;
            this.cboServerName.Location = new System.Drawing.Point(149, 40);
            this.cboServerName.Name = "cboServerName";
            this.cboServerName.Size = new System.Drawing.Size(231, 21);
            this.cboServerName.TabIndex = 6;
            this.cboServerName.DropDown += new System.EventHandler(this.cboServerName_SelectedIndexChanged);
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(149, 179);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(231, 21);
            this.cboDatabase.TabIndex = 7;
            this.cboDatabase.DropDown += new System.EventHandler(this.cboDatabase_DropDown);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(56, 233);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(126, 52);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Luu Lai";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(234, 233);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(126, 52);
            this.btnHuyBo.TabIndex = 9;
            this.btnHuyBo.Text = "Huy Bo";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.cboServerName);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.ComboBox cboServerName;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
    }
}