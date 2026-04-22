using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TicketApplicationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string selectedCategory = cboCategory.SelectedItem.ToString();
            double ratePerKm = GetRatePerKm(selectedCategory);
            double distance = double.Parse(txtDistance.Text);
            int age = int.Parse(txtAge.Text);
            double basePrice = ratePerKm * distance;
            double finalPrice;
            string discountMessage;

            if (age < 12)
            {
                finalPrice = 0;
                discountMessage = "FREE ticket (Age < 12)";
            }
            else if (rbtnFemale.Checked)
            {
                finalPrice = basePrice * 0.5;
                discountMessage = "50% Female discount applied";
            }
            else
            {
                finalPrice = basePrice;
                discountMessage = "No discount";
            }

            string gender = rbtnMale.Checked ? "MALE" : "FEMALE";
            string summary = $"TICKET SUMMARY\n--------------------------------\n" +
                              $"Passenger Name : {txtName.Text.Trim()}\n" +
                              $"Gender         : {gender}\n" +
                              $"Age               : {age}\n" +
                              $"Category       : {selectedCategory}\n" +
                              $"Distance       : {distance} km\n" +
                              $"--------------------------------\n" +
                              $"Base Price     : R {basePrice:F2}\n" +
                              $"Discount       : {discountMessage}\n" +
                              $"FINAL PRICE  : R {finalPrice:F2}\n" +
                              $"--------------------------------";

            MessageBox.Show(summary, "Ticket Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double GetRatePerKm(string category)
        {
            switch (category)
            {
                case "Category One": return 20;
                case "Category Two": return 35;
                case "Category Three": return 50;
                default: return 0;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter passenger name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!rbtnMale.Checked && !rbtnFemale.Checked)
            {
                MessageBox.Show("Please select gender (MALE or FEMALE).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0 || age > 120)
            {
                MessageBox.Show("Please enter a valid age (1-120).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Clear();
                txtAge.Focus();
                return false;
            }

            if (!double.TryParse(txtDistance.Text, out double distance) || distance <= 0)
            {
                MessageBox.Show("Please enter a valid distance (> 0 km).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistance.Clear();
                txtDistance.Focus();
                return false;
            }

            if (cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a travel category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategory.Focus();
                return false;
            }

            return true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            txtAge.Clear();
            cboCategory.SelectedIndex = -1;
            txtDistance.Clear();
            txtName.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}