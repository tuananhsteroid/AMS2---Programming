namespace ASM2
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnext = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.txbusename = new System.Windows.Forms.TextBox();
            this.lbusename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnext);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.txbpassword);
            this.groupBox1.Controls.Add(this.lbpassword);
            this.groupBox1.Controls.Add(this.txbusename);
            this.groupBox1.Controls.Add(this.lbusename);
            this.groupBox1.Location = new System.Drawing.Point(175, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(291, 280);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(97, 46);
            this.btnext.TabIndex = 12;
            this.btnext.Text = "Exit";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click_1);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(93, 280);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(104, 47);
            this.btnlogin.TabIndex = 11;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txbpassword
            // 
            this.txbpassword.Location = new System.Drawing.Point(168, 184);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.PasswordChar = '*';
            this.txbpassword.Size = new System.Drawing.Size(178, 22);
            this.txbpassword.TabIndex = 10;
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Location = new System.Drawing.Point(53, 190);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(67, 16);
            this.lbpassword.TabIndex = 9;
            this.lbpassword.Text = "Password";
            // 
            // txbusename
            // 
            this.txbusename.Location = new System.Drawing.Point(168, 102);
            this.txbusename.Name = "txbusename";
            this.txbusename.Size = new System.Drawing.Size(178, 22);
            this.txbusename.TabIndex = 8;
            // 
            // lbusename
            // 
            this.lbusename.AutoSize = true;
            this.lbusename.Location = new System.Drawing.Point(54, 108);
            this.lbusename.Name = "lbusename";
            this.lbusename.Size = new System.Drawing.Size(66, 16);
            this.lbusename.TabIndex = 7;
            this.lbusename.Text = "Usename";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(242, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome to water bill service";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 504);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox txbusename;
        private System.Windows.Forms.Label lbusename;
        private System.Windows.Forms.Label label1;
    }
}