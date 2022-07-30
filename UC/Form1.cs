using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC
{
   
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            products.Add(new Product
            {
                Name = "Asus Rog Strix",
                Price = 1235.60,
                Image=Properties.Resources.asus
            });
            products.Add(new Product
            {
                Name = "Iphone 11 Pro max",
                Price = 950.99,
                Image = Properties.Resources.iphone11
            });
            products.Add(new Product
            {
                Name = "Zenbook Pro Slim",
                Price = 3200.5,
                Image= Properties.Resources.zenbook
            });

            products.Add(new Product
            {
                Name = "Samsung S21",
                Price = 3200.5,
                Image= Properties.Resources.samsung
            });

            //var img=Properties.Resources.home;
            int x = 20;
            int y = 30;
            foreach (var item in products)
            {
                var productUC=new ProductUC();
                productUC.Location = new Point(x, y);
                y += 120;

                productUC.Name = item.Name;
                productUC.Price = item.Price;
                productUC.ProductImage= item.Image;

                productContainer.Controls.Add(productUC);
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
