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
    
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
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
            product.location = txtLocation.Text;
            product.generic = txtGeneric.Text;
            product.expiryDate = ExpiryDate.Value;
            product.sale_rate = Convert.ToInt32(txtSaleRate.Text);
            product.purchase_rate = Convert.ToInt32(txtPurchaseRate.Text);
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
            // TODO: This line of code loads data into the 'pharmacyDatabaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.pharmacyDatabaseDataSet.Product);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
