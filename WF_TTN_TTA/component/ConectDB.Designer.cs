namespace WF_TTN_TTA.component
{
    partial class ConectDB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbDBName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btTestConect = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbAuthentication = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 546);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btTestConect);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(264, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 529);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbbDBName);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(4, 445);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(695, 81);
            this.panel7.TabIndex = 0;
            // 
            // cbbDBName
            // 
            this.cbbDBName.FormattingEnabled = true;
            this.cbbDBName.Location = new System.Drawing.Point(237, 21);
            this.cbbDBName.Name = "cbbDBName";
            this.cbbDBName.Size = new System.Drawing.Size(420, 33);
            this.cbbDBName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(4, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "DB Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btTestConect
            // 
            this.btTestConect.Location = new System.Drawing.Point(471, 354);
            this.btTestConect.Name = "btTestConect";
            this.btTestConect.Size = new System.Drawing.Size(176, 59);
            this.btTestConect.TabIndex = 1;
            this.btTestConect.Text = "Test Conect";
            this.btTestConect.UseVisualStyleBackColor = true;
            this.btTestConect.Click += new System.EventHandler(this.btTestConect_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbUserName);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(695, 81);
            this.panel5.TabIndex = 0;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(238, 24);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(424, 31);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbAuthentication);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(695, 81);
            this.panel4.TabIndex = 0;
            // 
            // cbbAuthentication
            // 
            this.cbbAuthentication.FormattingEnabled = true;
            this.cbbAuthentication.Items.AddRange(new object[] {
            "dadasdsa"});
            this.cbbAuthentication.Location = new System.Drawing.Point(239, 18);
            this.cbbAuthentication.Name = "cbbAuthentication";
            this.cbbAuthentication.Size = new System.Drawing.Size(424, 33);
            this.cbbAuthentication.TabIndex = 1;
            this.cbbAuthentication.SelectedIndexChanged += new System.EventHandler(this.cbbAuthentication_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Authentication:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbServerName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(4, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 81);
            this.panel3.TabIndex = 0;
            // 
            // txbServerName
            // 
            this.txbServerName.Location = new System.Drawing.Point(237, 24);
            this.txbServerName.Name = "txbServerName";
            this.txbServerName.Size = new System.Drawing.Size(425, 31);
            this.txbServerName.TabIndex = 1;
            this.txbServerName.Text = "Tên server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Server :";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbPassword);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(263, 274);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(695, 81);
            this.panel6.TabIndex = 0;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(238, 24);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(424, 31);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // ConectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 548);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ConectDB";
            this.Text = "Kết Nối Data Base";
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btTestConect;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDBName;
        private System.Windows.Forms.ComboBox cbbAuthentication;
    }
}