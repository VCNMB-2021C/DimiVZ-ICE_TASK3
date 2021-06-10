using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjIceTask3
{
    public partial class Form1 : Form
    {
        private static string PATH = System.IO.Path.GetFullPath(@"..\..\..\") + "ProductList.txt";

        string[] ProductList;

        string strName;
        string DELIMITER = ",";
        
        public Form1()
        {
            InitializeComponent();
        }
        public void RunDelimiter ()
        {
           
            strName = txtName.Text;
            
            ProductList = strName.Split(DELIMITER);
            
            foreach (var Product in ProductList)
            {
                lstProducts.Items.Add(Product);
            }
            txtName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                RunDelimiter();
            }
            else
            {
                MessageBox.Show("Please enter in values");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstProducts.Items.Clear();
        }
    }
}
