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
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class EkleFrm : Form
    {
        public EkleFrm()
        {
            InitializeComponent();
        }

        Category secilenKategori = null;
        private void EkleFrm_Load(object sender, EventArgs e)
        {

            foreach (Category item in CategoryRepository.GetAllCategory())
            {
                cmbCategory.Items.Add(item);
            }

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKategori =(Category)cmbCategory.SelectedItem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = txtName.Text;
            p.UnitsInStock = Convert.ToInt16(txtStock.Text);
            p.UnitPrice = Convert.ToDecimal(txtPrice.Text);

            if (secilenKategori != null)
            {
                p.CategoryID = secilenKategori.CategoryID;
            }

            bool sonuc = ProductProcess.controlToSaveProduct(p);
            if(sonuc)
                MessageBox.Show("Basarili");
            else
                MessageBox.Show("islem Basarisiz");


        }
    }
}
