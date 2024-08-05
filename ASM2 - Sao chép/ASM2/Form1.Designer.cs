namespace ASM2
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
            this.tbthis = new System.Windows.Forms.TextBox();
            this.tblast = new System.Windows.Forms.TextBox();
            this.lbThismonth = new System.Windows.Forms.Label();
            this.lbLastmonth = new System.Windows.Forms.Label();
            this.cobMenu = new System.Windows.Forms.ComboBox();
            this.lbMenu = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBillWater = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.lbpeople = new System.Windows.Forms.Label();
            this.tbpeople = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbthis
            // 
            this.tbthis.Location = new System.Drawing.Point(814, 360);
            this.tbthis.Name = "tbthis";
            this.tbthis.Size = new System.Drawing.Size(91, 22);
            this.tbthis.TabIndex = 22;
            this.tbthis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tblast
            // 
            this.tblast.Location = new System.Drawing.Point(814, 298);
            this.tblast.Name = "tblast";
            this.tblast.Size = new System.Drawing.Size(91, 22);
            this.tblast.TabIndex = 21;
            this.tblast.Text = " ";
            this.tblast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tblast.TextChanged += new System.EventHandler(this.tblast_TextChanged);
            // 
            // lbThismonth
            // 
            this.lbThismonth.AutoSize = true;
            this.lbThismonth.Location = new System.Drawing.Point(553, 366);
            this.lbThismonth.Name = "lbThismonth";
            this.lbThismonth.Size = new System.Drawing.Size(232, 16);
            this.lbThismonth.TabIndex = 20;
            this.lbThismonth.Text = "This month\'s water meter reading(m3):";
            this.lbThismonth.Click += new System.EventHandler(this.lbThismonth_Click);
            // 
            // lbLastmonth
            // 
            this.lbLastmonth.AutoSize = true;
            this.lbLastmonth.Location = new System.Drawing.Point(553, 298);
            this.lbLastmonth.Name = "lbLastmonth";
            this.lbLastmonth.Size = new System.Drawing.Size(231, 16);
            this.lbLastmonth.TabIndex = 19;
            this.lbLastmonth.Text = "Last month\'s water meter reading(m3):";
            // 
            // cobMenu
            // 
            this.cobMenu.FormattingEnabled = true;
            this.cobMenu.Items.AddRange(new object[] {
            "1. Household customer",
            "2. Administrative agency, public services",
            "3. Production units",
            "4. Business services",
            "            "});
            this.cobMenu.Location = new System.Drawing.Point(591, 134);
            this.cobMenu.Name = "cobMenu";
            this.cobMenu.Size = new System.Drawing.Size(337, 24);
            this.cobMenu.TabIndex = 18;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Location = new System.Drawing.Point(725, 99);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(40, 16);
            this.lbMenu.TabIndex = 17;
            this.lbMenu.Text = "Menu";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(154, 190);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(260, 22);
            this.tbPhone.TabIndex = 16;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(61, 190);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(49, 16);
            this.lbPhone.TabIndex = 15;
            this.lbPhone.Text = "Phone ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(154, 131);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 22);
            this.tbName.TabIndex = 14;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(61, 134);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Name";
            // 
            // lbBillWater
            // 
            this.lbBillWater.AutoSize = true;
            this.lbBillWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBillWater.Location = new System.Drawing.Point(572, 35);
            this.lbBillWater.Name = "lbBillWater";
            this.lbBillWater.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbBillWater.Size = new System.Drawing.Size(117, 22);
            this.lbBillWater.TabIndex = 12;
            this.lbBillWater.Text = "WATER BILL";
            this.lbBillWater.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(47, 298);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(112, 43);
            this.btnTotal.TabIndex = 23;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lsvBill
            // 
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(12, 490);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(1502, 237);
            this.lsvBill.TabIndex = 24;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // lbpeople
            // 
            this.lbpeople.AutoSize = true;
            this.lbpeople.Location = new System.Drawing.Point(553, 196);
            this.lbpeople.Name = "lbpeople";
            this.lbpeople.Size = new System.Drawing.Size(413, 16);
            this.lbpeople.TabIndex = 25;
            this.lbpeople.Text = "If it is a family, please fill in the specific number of people in the family.";
            // 
            // tbpeople
            // 
            this.tbpeople.Location = new System.Drawing.Point(693, 234);
            this.tbpeople.Name = "tbpeople";
            this.tbpeople.Size = new System.Drawing.Size(100, 22);
            this.tbpeople.TabIndex = 26;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(302, 298);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 43);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Location = new System.Drawing.Point(47, 382);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(107, 45);
            this.btnPrintBill.TabIndex = 28;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(302, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 43);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 727);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbpeople);
            this.Controls.Add(this.lbpeople);
            this.Controls.Add(this.lsvBill);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.tbthis);
            this.Controls.Add(this.tblast);
            this.Controls.Add(this.lbThismonth);
            this.Controls.Add(this.lbLastmonth);
            this.Controls.Add(this.cobMenu);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbBillWater);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbthis;
        private System.Windows.Forms.TextBox tblast;
        private System.Windows.Forms.Label lbThismonth;
        private System.Windows.Forms.Label lbLastmonth;
        private System.Windows.Forms.ComboBox cobMenu;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbBillWater;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Label lbpeople;
        private System.Windows.Forms.TextBox tbpeople;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnExit;
    }
}

