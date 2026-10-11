namespace PersonalInfoApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSureName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnSubmitName = new System.Windows.Forms.Button();
            this.btnSubmitSureName = new System.Windows.Forms.Button();
            this.btnSubmitUserName = new System.Windows.Forms.Button();
            this.btnSubmitPassword = new System.Windows.Forms.Button();
            this.btnSubmitEmail = new System.Windows.Forms.Button();
            this.btnSubmitAge = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDisplayUserName = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblDisplaySureName = new System.Windows.Forms.Label();
            this.lblDisplayPassword = new System.Windows.Forms.Label();
            this.lblDisplayEmail = new System.Windows.Forms.Label();
            this.lblDisplayAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SURNAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "USERNAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PASSWORD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "EMAİL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "AGE:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtSureName
            // 
            this.txtSureName.Location = new System.Drawing.Point(106, 43);
            this.txtSureName.Name = "txtSureName";
            this.txtSureName.Size = new System.Drawing.Size(100, 22);
            this.txtSureName.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(106, 71);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(106, 155);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 11;
            // 
            // btnSubmitName
            // 
            this.btnSubmitName.Location = new System.Drawing.Point(213, 16);
            this.btnSubmitName.Name = "btnSubmitName";
            this.btnSubmitName.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitName.TabIndex = 12;
            this.btnSubmitName.Text = "SUBMİT";
            this.btnSubmitName.UseVisualStyleBackColor = true;
            this.btnSubmitName.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubmitSureName
            // 
            this.btnSubmitSureName.Location = new System.Drawing.Point(213, 45);
            this.btnSubmitSureName.Name = "btnSubmitSureName";
            this.btnSubmitSureName.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitSureName.TabIndex = 13;
            this.btnSubmitSureName.Text = "SUBMİT";
            this.btnSubmitSureName.UseVisualStyleBackColor = true;
            this.btnSubmitSureName.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSubmitUserName
            // 
            this.btnSubmitUserName.Location = new System.Drawing.Point(213, 74);
            this.btnSubmitUserName.Name = "btnSubmitUserName";
            this.btnSubmitUserName.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitUserName.TabIndex = 14;
            this.btnSubmitUserName.Text = "SUBMİT";
            this.btnSubmitUserName.UseVisualStyleBackColor = true;
            this.btnSubmitUserName.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSubmitPassword
            // 
            this.btnSubmitPassword.Location = new System.Drawing.Point(212, 103);
            this.btnSubmitPassword.Name = "btnSubmitPassword";
            this.btnSubmitPassword.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitPassword.TabIndex = 15;
            this.btnSubmitPassword.Text = "SUBMİT";
            this.btnSubmitPassword.UseVisualStyleBackColor = true;
            this.btnSubmitPassword.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSubmitEmail
            // 
            this.btnSubmitEmail.Location = new System.Drawing.Point(212, 129);
            this.btnSubmitEmail.Name = "btnSubmitEmail";
            this.btnSubmitEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitEmail.TabIndex = 16;
            this.btnSubmitEmail.Text = "SUBMİT";
            this.btnSubmitEmail.UseVisualStyleBackColor = true;
            this.btnSubmitEmail.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSubmitAge
            // 
            this.btnSubmitAge.Location = new System.Drawing.Point(212, 158);
            this.btnSubmitAge.Name = "btnSubmitAge";
            this.btnSubmitAge.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAge.TabIndex = 17;
            this.btnSubmitAge.Text = "SUBMİT";
            this.btnSubmitAge.UseVisualStyleBackColor = true;
            this.btnSubmitAge.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "NAME:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "SURNAME:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "USERNAME:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "PASSWORD:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "EMAİL:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "AGE:";
            // 
            // lblDisplayUserName
            // 
            this.lblDisplayUserName.AutoSize = true;
            this.lblDisplayUserName.Location = new System.Drawing.Point(388, 74);
            this.lblDisplayUserName.Name = "lblDisplayUserName";
            this.lblDisplayUserName.Size = new System.Drawing.Size(51, 16);
            this.lblDisplayUserName.TabIndex = 24;
            this.lblDisplayUserName.Text = "label13";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(388, 23);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(51, 16);
            this.lblDisplayName.TabIndex = 25;
            this.lblDisplayName.Text = "label13";
            // 
            // lblDisplaySureName
            // 
            this.lblDisplaySureName.AutoSize = true;
            this.lblDisplaySureName.Location = new System.Drawing.Point(388, 46);
            this.lblDisplaySureName.Name = "lblDisplaySureName";
            this.lblDisplaySureName.Size = new System.Drawing.Size(51, 16);
            this.lblDisplaySureName.TabIndex = 26;
            this.lblDisplaySureName.Text = "label13";
            // 
            // lblDisplayPassword
            // 
            this.lblDisplayPassword.AutoSize = true;
            this.lblDisplayPassword.Location = new System.Drawing.Point(388, 104);
            this.lblDisplayPassword.Name = "lblDisplayPassword";
            this.lblDisplayPassword.Size = new System.Drawing.Size(51, 16);
            this.lblDisplayPassword.TabIndex = 27;
            this.lblDisplayPassword.Text = "label13";
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.Location = new System.Drawing.Point(388, 136);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(51, 16);
            this.lblDisplayEmail.TabIndex = 28;
            this.lblDisplayEmail.Text = "label13";
            // 
            // lblDisplayAge
            // 
            this.lblDisplayAge.AutoSize = true;
            this.lblDisplayAge.Location = new System.Drawing.Point(388, 165);
            this.lblDisplayAge.Name = "lblDisplayAge";
            this.lblDisplayAge.Size = new System.Drawing.Size(51, 16);
            this.lblDisplayAge.TabIndex = 29;
            this.lblDisplayAge.Text = "label13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.lblDisplayAge);
            this.Controls.Add(this.lblDisplayEmail);
            this.Controls.Add(this.lblDisplayPassword);
            this.Controls.Add(this.lblDisplaySureName);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblDisplayUserName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubmitAge);
            this.Controls.Add(this.btnSubmitEmail);
            this.Controls.Add(this.btnSubmitPassword);
            this.Controls.Add(this.btnSubmitUserName);
            this.Controls.Add(this.btnSubmitSureName);
            this.Controls.Add(this.btnSubmitName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtSureName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSureName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnSubmitName;
        private System.Windows.Forms.Button btnSubmitSureName;
        private System.Windows.Forms.Button btnSubmitUserName;
        private System.Windows.Forms.Button btnSubmitPassword;
        private System.Windows.Forms.Button btnSubmitEmail;
        private System.Windows.Forms.Button btnSubmitAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDisplayUserName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblDisplaySureName;
        private System.Windows.Forms.Label lblDisplayPassword;
        private System.Windows.Forms.Label lblDisplayEmail;
        private System.Windows.Forms.Label lblDisplayAge;
    }
}

