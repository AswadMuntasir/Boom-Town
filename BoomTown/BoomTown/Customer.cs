using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoomTown.Entities;
using BoomTown.Framework;
using BoomTown.Repo;

namespace BoomTown
{
    public partial class Customer : MetroFramework.Forms.MetroForm
    {
        CustomerRepo cmrRepo = new CustomerRepo();
        List<Custo> currentData = new List<Custo>();
        Custo cu = new Custo();
        HomePage hp;

        public Customer(HomePage hp)
        {
            InitializeComponent();
            this.hp = hp;
            this.PopulateGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            hp.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string customer_no = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                Custo cmr = currentData.FirstOrDefault(cm => cm.customer_no.ToString() == customer_no);
                if (cmr != null)
                {
                    this.txtCustomerId.Text = cmr.customer_no.ToString();
                    this.txtCustomerName.Text = cmr.customer_Name;
                    this.txtCustomerContactNo.Text = cmr.customer_contact_no;
                    this.txtCustomerEmail.Text = cmr.customer_email;
                    this.txtCustomerAddress.Text = cmr.customer_address;
                }
            }
        }
        private void PopulateGridView()
        {
            var result = cmrRepo.GetAllCustomer();
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.DataSource = result.Data.ToList();
            currentData = result.Data.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmrRepo.SaveCustomer(cu);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string val = this.dgvCustomer.CurrentRow.Cells["customer_id"].Value.ToString();
            cmrRepo.DeleteCustomer(cu, val);
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            var result = cmrRepo.GetDataSearch(metroTextBox1.Text);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.DataSource = result.Data.ToList();
            currentData = result.Data.ToList();
        }
    }
}
