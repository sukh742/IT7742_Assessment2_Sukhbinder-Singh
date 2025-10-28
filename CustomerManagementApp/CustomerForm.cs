using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CustomerManagementApp.Model;
using CustomerManagementApp.Controller;
using System.Xml.Linq;

namespace CustomerManagementApp
{
    public partial class CustomerForm : Form
    {
        private CustomerController controller = new CustomerController();

        public CustomerForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        // Refresh the DataGridView
        private void RefreshGrid()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = controller.GetCustomers();
        }

        // Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.Trim();
                string name = txtName.Text.Trim();
                controller.AddCustomer(new Customer(id, name));
                RefreshGrid();
                MessageBox.Show("Customer added.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.Trim();
                string name = txtName.Text.Trim();
                controller.UpdateCustomer(id, name);
                RefreshGrid();
                MessageBox.Show("Customer updated.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.Trim();
                controller.DeleteCustomer(id);
                RefreshGrid();
                MessageBox.Show("Customer deleted.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Clear input boxes
        private void ClearFields()
        {
            txtID.Text = "";
            txtName.Text = "";
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
