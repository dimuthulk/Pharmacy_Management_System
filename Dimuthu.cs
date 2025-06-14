using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Management_System.PharmacyDatabaseDataSetTableAdapters;

namespace Pharmacy_Management_System
{
    
    public partial class Dimuthu : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public Dimuthu()
        {
            InitializeComponent();
        }
        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            customer newCustomer = new customer
            {
                cname = txtCName.Text,
                phoneNo = txtCPhone.Text,
                address = txtCAddress.Text
            };
        }
    }
}
