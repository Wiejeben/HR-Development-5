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
        private List<Pivot> ToBeRemoved = new List<Pivot>();
        private List<Pivot> ToBeAdded = new List<Pivot>();
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
                var pivot = (AddressEmployee) address.Pivot;

                ListViewItem item = new ListViewItem(new string[] {
                    pivot.Residence.ToString(),
                    address.PostalCode,
                    address.Addition,
                    address.Number.ToString(),
                    address.Street.Name,
                    address.Street.City.Name,
                    address.Street.City.Province.Name,
                    address.Street.City.Province.Country.Name
                });
                item.Tag = address.Pivot;

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
                item.Tag = degree.Pivot;

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
                item.Tag = position.Pivot;

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
            
            // Remove awaiting pivot tables
            foreach (Pivot model in this.ToBeRemoved)
            {
                model.Delete();
            }

            // Add awaiting pivot tables
            foreach (Pivot model in this.ToBeAdded)
            {
                model.AssignLeft(employee.Bsn);
                model.Save();
            }

            this.Close();
        }

        private void bsnInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addAddress_Click(object sender, EventArgs e)
        {
            var country = new Country { Name = countryInput.Text };
            int countryId = country.FindOrInsert(new Dictionary<string, string> { { "name", country.Name } });

            var province = new Province { Name = provinceInput.Text, CountryId = countryId };
            int provinceId = province.FindOrInsert(new Dictionary<string, string> { { "name", province.Name }, { "country_id", province.CountryId.ToString() } });

            var city = new City { Name = cityInput.Text, ProvinceId = provinceId };
            int cityId = city.FindOrInsert(new Dictionary<string, string> { { "name", city.Name }, { "province_id", city.ProvinceId.ToString() } });

            var street = new Street { Name = streetInput.Text, CityId = cityId };
            int streetId = street.FindOrInsert(new Dictionary<string, string> { { "name", street.Name }, { "city_id", street.CityId.ToString() } });

            var address = new Address();

            address.Addition = additionInput.Text;
            address.Number = Convert.ToInt32(numberInput.Text);
            address.PostalCode = postalCodeInput.Text;
            address.StreetId = streetId;

            address.Save();

            var pivot = new AddressEmployee();
            pivot.AddressId = address.LastAutoIncrement;
            pivot.Residence = residenceCheckbox.Checked;

            ListViewItem item = new ListViewItem(new string[] {
                residenceCheckbox.Checked.ToString(),
                country.Name,
                additionInput.Text,
                numberInput.Text,
                street.Name,
                city.Name,
                province.Name,
                country.Name
            });
            item.Tag = pivot;

            addressesList.Items.Add(item);
            this.ToBeAdded.Add(pivot);
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

        private ListViewItem GetCurrentListViewItem(ListView list)
        {
            // No items selected
            if (list.SelectedItems.Count <= 0)
            {
                return null;
            }

            return list.SelectedItems[0];
        }

        private void removeDegreeButton_Click(object sender, EventArgs e)
        {
            var item = this.GetCurrentListViewItem(degreesList);

            if (item == null)
            {
                return;
            }

            this.ToBeRemoved.Add((Pivot) item.Tag);

            item.Remove();
        }

        private void removePositionButton_Click(object sender, EventArgs e)
        {
            var item = this.GetCurrentListViewItem(positionsList);

            if (item == null)
            {
                return;
            }

            this.ToBeRemoved.Add((Pivot) item.Tag);

            item.Remove();
        }

        private void removeAddressButton_Click(object sender, EventArgs e)
        {
            var item = this.GetCurrentListViewItem(addressesList);

            if (item == null)
            {
                return;
            }

            this.ToBeRemoved.Add((Pivot) item.Tag);

            item.Remove();
        }
    }
}
