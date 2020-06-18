namespace PVLB_Buoi4_BT_AppSmart
{
    partial class Form1
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
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.btnDK = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(178, 39);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(186, 20);
            this.txtTK.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(178, 92);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(186, 20);
            this.txtMK.TabIndex = 1;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Location = new System.Drawing.Point(52, 42);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(56, 13);
            this.lbTK.TabIndex = 2;
            this.lbTK.Text = "Tai Khoan";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Location = new System.Drawing.Point(52, 95);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(53, 13);
            this.lbMK.TabIndex = 3;
            this.lbMK.Text = "Mat Khau";
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(287, 148);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(114, 40);
            this.btnDK.TabIndex = 4;
            this.btnDK.Text = "Chon Server";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(139, 148);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(114, 40);
            this.btnDN.TabIndex = 5;
            this.btnDN.Text = "Dang Nhap";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 273);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Button btnDN;
    }
}

