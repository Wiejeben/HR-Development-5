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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void UpdateEmployeeActionButtons()
        {
            bool selected = employeesList.SelectedItems.Count > 0;

            modifyButton.Enabled = selected;
            deleteButton.Enabled = selected;
        }

        private void LoadEmployeeListView()
        {
            // Empty list
            employeesList.Items.Clear();

            // Load employees
            new Employee().All().ForEach((Employee employee) =>
            {
                ListViewItem item = new ListViewItem(new string[] {
                    employee.Bsn.ToString(),
                    employee.Name,
                    employee.Surname
                });
                item.Tag = employee;

                employeesList.Items.Add(item);
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadEmployeeListView();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            this.LoadEmployeeListView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var form = new AddEmployee();
            form.Show();
        }

        private void employeesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateEmployeeActionButtons();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            var employee = this.GetCurrentEmployee();

            if (employee == null)
            {
                return;
            }

            new AddEmployee(employee).Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private Employee GetCurrentEmployee()
        {
            // No items selected
            if (employeesList.SelectedItems.Count <= 0)
            {
                return null;
            }

            var item = employeesList.SelectedItems[0];

            return (Employee) item.Tag;
        }
    }
}
