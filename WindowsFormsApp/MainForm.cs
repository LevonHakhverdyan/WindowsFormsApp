using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Persons;
using WindowsFormsApp.Service;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            _customerService = new Service.CustomerService();
            InitializeComponent();
        }
        private readonly CustomerService _customerService;

        private void SaveBtn_Click(Object sender, EventArgs e)
        {
            string message = string.Empty;
            if (string.IsNullOrEmpty(firstNametxt.Text) || string.IsNullOrEmpty(lastNametxt.Text) || string.IsNullOrEmpty(agetxt.Text))
            {
                message = "Please fill in all fields";
                MessageBox.Show(message);
            }
            else
            {
                _customerService.Add(new Customer { FirstName = firstNametxt.Text, LastName = lastNametxt.Text, Age = Int32.Parse(agetxt.Text) });
                UpdateDataDataSource(customerGridView);

            }
            firstNametxt.Clear();
            lastNametxt.Clear();
            agetxt.Clear();
        }
        private void UpdateBtn_Click(Object sender, EventArgs e)
        {
            Guid id = (Guid)customerGridView.CurrentRow.Cells[0].Value;
            _customerService.Update(new Customer(id) { FirstName = firstNametxt.Text, LastName = lastNametxt.Text, Age = Int32.Parse(agetxt.Text) });
            UpdateDataDataSource(customerGridView);
            firstNametxt.Clear();
            lastNametxt.Clear();
            agetxt.Clear();

        }
        private void DeleteBtn_Click(Object sender, EventArgs e)
        {
            Guid id = (Guid)customerGridView.CurrentRow.Cells[0].Value;
            _customerService.Delete(_customerService.Get(id));
            UpdateDataDataSource(customerGridView);
            firstNametxt.Clear();
            lastNametxt.Clear();
            agetxt.Clear();
        }
        private void UpdateDataDataSource(DataGridView dataGridView)
        {
            List<Customer> customers = _customerService.GetAll();
            customerGridView.DataSource = null;
            customerGridView.DataSource = customers;

        }
        private void CustomerGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNametxt.Text) || string.IsNullOrEmpty(lastNametxt.Text) || string.IsNullOrEmpty(agetxt.Text))
            {
                firstNametxt.Text =null ;
                lastNametxt.Text =null ;
                agetxt.Text = null;
            }
            else
            {
                firstNametxt.Text = customerGridView.CurrentRow.Cells[2].Value.ToString();
                lastNametxt.Text = customerGridView.CurrentRow.Cells[3].Value.ToString();
                agetxt.Text = customerGridView.CurrentRow.Cells[1].Value.ToString();
            }
            
        }
    }
}
