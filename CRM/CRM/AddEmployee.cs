using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class AddEmployee : Form
    {
        private Employee Employee;

        public AddEmployee()
        {
            InitializeComponent();
        }

        public AddEmployee(Employee employee)
        {
            this.Employee = employee;
            InitializeComponent();
            this.Text = "Update an employee";
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            if (this.Employee == null)
            {
                return;
            }

            // Set employee names
            bsnInput.Text = this.Employee.Bsn.ToString();
            bsnInput.Enabled = false;
            nameInput.Text = this.Employee.Name;
            surnameInput.Text = this.Employee.Surname;
            
            // Addresses
            foreach (Address address in this.Employee.Addresses())
            {
                ListViewItem item = new ListViewItem(new string[] {
                    address.Pivot["residence"],
                    address.PostalCode,
                    address.Addition,
                    address.Number.ToString(),
                    address.Street.Name,
                    address.Street.City.Name,
                    address.Street.City.Province.Name,
                    address.Street.City.Province.Country.Name
                });

                addressesList.Items.Add(item);
            }

            // Degrees
            foreach (Degree degree in this.Employee.Degrees())
            {
                ListViewItem item = new ListViewItem(new string[] {
                    degree.School.Name,
                    degree.Level.Name,
                    degree.Course.Name
                });

                degreesList.Items.Add(item);
            }

            // Positions
            foreach (Position position in this.Employee.Positions())
            {
                ListViewItem item = new ListViewItem(new string[] {
                    position.Name,
                    position.Description,
                    position.HourFee.ToString()
                });

                positionsList.Items.Add(item);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var employee = new Employee();
            if (this.Employee != null)
            {
                employee = this.Employee;
            }

            employee.Bsn = Convert.ToInt32(bsnInput.Text);
            employee.Name = nameInput.Text;
            employee.Surname = surnameInput.Text;

            employee.Save();

            this.Close();
        }

        private void bsnInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addAddress_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] {
                residenceCheckbox.Checked.ToString(),
                postalCodeInput.Text,
                additionInput.Text,
                numberInput.Text,
                streetInput.Text,
                cityInput.Text,
                provinceInput.Text,
                countryInput.Text
            });

            addressesList.Items.Add(item);
        }

        private void UpdateAddressActionButtons()
        {
            bool selected = addressesList.SelectedItems.Count > 0;

            removeAddressButton.Enabled = selected;
        }

        private void UpdateDegreeActionButtons()
        {
            bool selected = degreesList.SelectedItems.Count > 0;

            removeDegreeButton.Enabled = selected;
        }

        private void UpdatePositionActionButtons()
        {
            bool selected = positionsList.SelectedItems.Count > 0;

            removePositionButton.Enabled = selected;
        }

        private void addressesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateAddressActionButtons();
        }

        private void addDegree_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] {
                schoolInput.Text,
                levelInput.Text,
                courseInput.Text
            });

            degreesList.Items.Add(item);
        }

        private void removeDegreeButton_Click(object sender, EventArgs e)
        {

        }

        private void degreesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateDegreeActionButtons();
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] {
                positionInput.Text,
                descriptionInput.Text,
                hourFeeInput.Text
            });

            positionsList.Items.Add(item);
        }

        private void positionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdatePositionActionButtons();
        }
    }
}
