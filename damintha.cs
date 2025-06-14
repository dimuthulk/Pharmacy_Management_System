using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    
    public partial class damintha : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public damintha()
        {
            InitializeComponent();
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Product product = new Product();
            product.pname = txtProductName.Text;
            product.packSize = txtPackSize.Text;
            product.location = txtCompany.Text;
            product.generic = txtGeneric.Text;
            product.expiryDate = ExpiryDate.Value;
            product.sale_rate = Convert.ToInt32(txtSaleRate.Text);
            product.purchase_rate = Convert.ToInt32(txtPurchaseRate.Text);
            product.quantity = Convert.ToInt32(txtQuantity.Text);
            product.batchNo= txtBatchNo.Text;
            product.company = txtCompany.Text;
            product.ptype = cmbType.Text;

            db.Products.InsertOnSubmit(product);
            db.SubmitChanges();
            MessageBox.Show("Data Successfully Inserted");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDatabaseDataSet3.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter2.Fill(this.pharmacyDatabaseDataSet3.Product);
            // TODO: This line of code loads data into the 'pharmacyDatabaseDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.pharmacyDatabaseDataSet2.Product);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPurchaseRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
