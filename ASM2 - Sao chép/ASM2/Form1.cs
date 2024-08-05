using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace ASM2
{
    public partial class Form1 : Form
    {
        private string name;
        private string phone;
        private string menu;
        private string peopleText;
        private double lastMonth;
        private double thisMonth;
        private double waterUsed;
        private double pretaxCost;
        private double environmentalTax;
        private double VAT;
        private double grandTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Chế độ view để hiển thị trên listview
            lsvBill.View = View.Details;

            lsvBill.Columns.Add("Name", 150);
            lsvBill.Columns.Add("Phone", 100);
            lsvBill.Columns.Add("Payment object", 120);
            lsvBill.Columns.Add("People Family", 80);
            lsvBill.Columns.Add("Water index last month", 120);
            lsvBill.Columns.Add("Water index this month", 120);
            lsvBill.Columns.Add("Pretax cost", 80);
            lsvBill.Columns.Add("Environmental tax amount", 140);
            lsvBill.Columns.Add("VAT amount", 80);
            lsvBill.Columns.Add("Total payment after tax", 150);

            // Đăng ký sự kiện cho combobox
            cobMenu.SelectedIndexChanged += cobMenu_SelectedIndexChanged;
        }

        private void cobMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            menu = GetMenuSelection();
            if (menu == "1. Household customer")
            {
                tbpeople.Enabled = true;  // Cho phép nhập số người
            }
            else
            {
                tbpeople.Enabled = false; // Không cho phép nhập số người
                tbpeople.Clear(); // Xóa giá trị nếu đối tượng không phải hộ gia đình
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            phone = tbPhone.Text;
            string lastMonthText = tblast.Text;
            string thisMonthText = tbthis.Text;
            peopleText = tbpeople.Text;

            


            menu = GetMenuSelection();
            if (menu == null)
            {
                MessageBox.Show("Please select a payment object.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryParseInput(lastMonthText, out lastMonth) || !TryParseInput(thisMonthText, out thisMonth))
                return;

            if (lastMonth > thisMonth)
            {
                MessageBox.Show("Last month's index cannot be greater than this month's index, Please try again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbthis.Focus();
                return;
            }

            double waterUsed = thisMonth - lastMonth;
            if (menu == "1. Household customer" && !string.IsNullOrWhiteSpace(peopleText) && !TryParseInput(peopleText, out double people))
            {
                tbpeople.Focus();
                return;
            }

            CalculateCosts(menu, waterUsed, peopleText, out pretaxCost, out environmentalTax, out VAT, out grandTotal);

            AddListViewItem(name, phone, menu, peopleText, lastMonth, thisMonth, pretaxCost, environmentalTax, VAT, grandTotal, waterUsed);

            ClearInputFields();
        }

        private string GetMenuSelection()
        {
            switch (cobMenu.SelectedIndex)
            {
                case 0: return "1. Household customer";
                case 1: return "2. Administrative agency, public services";
                case 2: return "3. Production units";
                case 3: return "4. Business services";
                default: return null;
            }
        }

        private bool TryParseInput(string input, out double value)
        {
            input = input.Trim().Replace(",", "");
            if (!double.TryParse(input, out value))
            {
                MessageBox.Show("Please enter a valid number.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void CalculateCosts(string menu, double waterUsed, string peopleText, out double pretaxCost, 
            out double environmentalTax, out double VAT, out double grandTotal)
        {
            double totalAmount = 0;
            pretaxCost = environmentalTax = VAT = grandTotal = 0;

            switch (menu)
            {
                case "1. Household customer":
                    if (!TryParseInput(peopleText, out double people))
                    {
                        tbpeople.Focus();
                        return;
                    }
                    double cubicMetersPerPerson = waterUsed / people;
                    double[] waterPrices = { 5.973, 7.052, 8.699, 15.929 };
                    totalAmount = CalculateHouseholdCost(cubicMetersPerPerson, waterPrices);
                    pretaxCost = totalAmount * people;
                    break;

                case "2. Administrative agency, public services":
                case "3. Production units":
                case "4. Business services":
                    totalAmount = waterUsed * GetPriceForMenu(menu);
                    pretaxCost = totalAmount;
                    break;
            }

            environmentalTax = pretaxCost / 10;
            VAT = (pretaxCost + environmentalTax) / 10;
            grandTotal = VAT + environmentalTax + pretaxCost;
        }

        private double CalculateHouseholdCost(double cubicMetersPerPerson, double[] waterPrices)
        {
            double totalAmount = 0;
            for (int i = 0; i < 3 && cubicMetersPerPerson > 0; i++)
            {
                double currentCubicMeters = Math.Min(10, cubicMetersPerPerson);
                totalAmount += currentCubicMeters * waterPrices[i];
                cubicMetersPerPerson -= currentCubicMeters;
            }

            if (cubicMetersPerPerson > 0)
            {
                totalAmount += cubicMetersPerPerson * waterPrices[3];
            }

            return totalAmount;
        }

        private double GetPriceForMenu(string menu)
        {
            switch (menu)
            {
                case "2. Administrative agency, public services": return 9.955;
                case "3. Production units": return 11.615;
                case "4. Business services": return 22.068;
                default: return 0;
            }
        }

        private void AddListViewItem(string name, string phone, string menu, string people, double lastMonth, 
            double thisMonth, double pretaxCost, double environmentalTax, double VAT, double grandTotal, double waterUsed)
        {
            ListViewItem item = new ListViewItem
            {
                Text = name,
                SubItems = {
                phone,
                menu,
                people,
                lastMonth.ToString(),
                thisMonth.ToString(),
                pretaxCost.ToString("0.000"),
                environmentalTax.ToString("0.000"),
                VAT.ToString("0.000"),
                grandTotal.ToString("#,#.000"),
                waterUsed.ToString("0.00") // Thêm chỉ số nước đã sử dụng
            }
            };

            lsvBill.Items.Add(item);
        }

        private void ClearInputFields()
        {
            tbName.Clear();
            tbPhone.Clear();
            cobMenu.SelectedIndex = -1;
            tbpeople.Clear();
            tblast.Clear();
            tbthis.Clear();
        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvBill.SelectedItems[0];
                tbName.Text = selectedItem.Text;
                tbPhone.Text = selectedItem.SubItems[1].Text;
                cobMenu.SelectedIndex = GetMenuIndex(selectedItem.SubItems[2].Text);
                tbpeople.Text = selectedItem.SubItems[3].Text;
                tblast.Text = selectedItem.SubItems[4].Text;
                tbthis.Text = selectedItem.SubItems[5].Text;
            }
        }

        private int GetMenuIndex(string menuText)
        {
            switch (menuText)
            {
                case "1. Household customer": return 0;
                case "2. Administrative agency, public services": return 1;
                case "3. Production units": return 2;
                case "4. Business services": return 3;
                default: return -1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvBill.SelectedItems[0];

                name = tbName.Text;
                phone = tbPhone.Text;
                string lastMonthText = tblast.Text;
                string thisMonthText = tbthis.Text;
                peopleText = tbpeople.Text;

                menu = GetMenuSelection();
                if (menu == null)
                {
                    MessageBox.Show("Please select a payment object.", "Notice", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!TryParseInput(lastMonthText, out lastMonth) || !TryParseInput(thisMonthText, out thisMonth))
                    return;

                if (lastMonth > thisMonth)
                {
                    MessageBox.Show("Last month's index cannot be greater than this month's index, Please try again.", "Notice", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbthis.Focus();
                    return;
                }

                double waterUsed = thisMonth - lastMonth;
                if (menu == "1. Household customer" && !string.IsNullOrWhiteSpace(peopleText) && !TryParseInput(peopleText, out double people))
                {
                    tbpeople.Focus();
                    return;
                }

                CalculateCosts(menu, waterUsed, peopleText, out pretaxCost, out environmentalTax, out VAT, out grandTotal);

                UpdateListViewItem(selectedItem, name, phone, menu, peopleText, lastMonth, thisMonth, pretaxCost, environmentalTax, VAT, grandTotal, waterUsed);
            }
        }
        private void UpdateListViewItem(ListViewItem item, string name, string phone, string menu, string people,
            double lastMonth, double thisMonth, double pretaxCost, double environmentalTax, double VAT, double grandTotal, double waterUsed)
        {
            item.Text = name;
            item.SubItems[1].Text = phone;
            item.SubItems[2].Text = menu;
            item.SubItems[3].Text = people;
            item.SubItems[4].Text = lastMonth.ToString();
            item.SubItems[5].Text = thisMonth.ToString();
            item.SubItems[6].Text = pretaxCost.ToString("0.000");
            item.SubItems[7].Text = environmentalTax.ToString("0.000");
            item.SubItems[8].Text = VAT.ToString("0.000");
            item.SubItems[9].Text = grandTotal.ToString("#,#.000");
            item.SubItems[10].Text = waterUsed.ToString("0.00"); // Cập nhật chỉ số nước đã sử dụng
        }


        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                // Lấy thông tin từ ListViewItem đã chọn
                ListViewItem selectedItem = lsvBill.SelectedItems[0];

                name = selectedItem.Text;
                phone = selectedItem.SubItems[1].Text;
                menu = selectedItem.SubItems[2].Text;
                peopleText = selectedItem.SubItems[3].Text;
                lastMonth = double.Parse(selectedItem.SubItems[4].Text);
                thisMonth = double.Parse(selectedItem.SubItems[5].Text);
                waterUsed = double.Parse(selectedItem.SubItems[10].Text); // Đảm bảo cột nước đã sử dụng có tồn tại
                pretaxCost = double.Parse(selectedItem.SubItems[6].Text);
                environmentalTax = double.Parse(selectedItem.SubItems[7].Text);
                VAT = double.Parse(selectedItem.SubItems[8].Text);
                grandTotal = double.Parse(selectedItem.SubItems[9].Text);

                // Tạo và hiển thị Form2
                Form2 form2 = new Form2();
                form2.UpdateBillInfo(name, phone, menu, peopleText, lastMonth, thisMonth, pretaxCost, environmentalTax, VAT, grandTotal, waterUsed); // Thêm waterUsed
                
                this.Hide();
                form2.ShowDialog();

                this.Close();


            }
            else
            {
                MessageBox.Show("Please select an item from the list to print.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult check_Exit = MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check_Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Placeholder for unused event handlers
        private void lbThismonth_Click(object sender, EventArgs e) { }
        private void tblast_TextChanged(object sender, EventArgs e) { }
    }
}
