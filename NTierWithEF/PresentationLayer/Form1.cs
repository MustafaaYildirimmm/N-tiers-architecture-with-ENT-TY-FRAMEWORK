using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerRepository cr = new CustomerRepository();
            List<Customer> CustList = cr.GetAll();
            foreach (Customer item in CustList)
            {
                cmbCustomer.Items.Add(item);
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Customer Cust =(Customer)cmbCustomer.SelectedItem;
            List<Order_Detail> OrderDetails = OrderDetailsRepository.GetOrderDetailByCustomerId(Cust.CustomerID);

            foreach (Order_Detail item in OrderDetails)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.OrderID.ToString();
                li.SubItems.Add(item.Product.ProductName);
                li.SubItems.Add(item.UnitPrice.ToString());
                li.SubItems.Add(item.Discount.ToString());
                li.SubItems.Add(item.Quantity.ToString());
                listView1.Items.Add(li);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EkleFrm frm = new EkleFrm();
            frm.ShowDialog();
        }
    }
}
