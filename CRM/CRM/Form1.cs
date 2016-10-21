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

        private void employeesList_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
