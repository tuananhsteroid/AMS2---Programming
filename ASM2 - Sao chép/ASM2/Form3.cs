using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            string name = txbusename.Text;
            string pass = txbpassword.Text;



            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter your password", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                Form1 form1 = new Form1();
                
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
        
        }

        private void btnext_Click_1(object sender, EventArgs e)
        {
            DialogResult check_Exit = MessageBox.Show("Do you want to exit?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check_Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
