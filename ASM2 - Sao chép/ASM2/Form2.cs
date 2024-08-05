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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Phương thức để cập nhật thông tin hóa đơn
        public void UpdateBillInfo(string name, string phone, string paymentObject, string peopleFamily, double lastMonthIndex, 
            double thisMonthIndex, double pretaxCost, double envTax, double vat, double totalPayment, double waterUsed)
        {
            lblName.Text = name;
            lblPhone.Text = phone;
            lblPaymentObject.Text = paymentObject;
            lblLastMonthIndex.Text = lastMonthIndex.ToString();
            lblThisMonthIndex.Text = thisMonthIndex.ToString();
            lblWaterUsed.Text = waterUsed.ToString();
            lblPretaxCost.Text = pretaxCost.ToString("C");
            lblEnvTax.Text = envTax.ToString("C");
            lblVAT.Text = vat.ToString("C");
            lblTotalPayment.Text = totalPayment.ToString("C");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult check_Exit = MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check_Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
