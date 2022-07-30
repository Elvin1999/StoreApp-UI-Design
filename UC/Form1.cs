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
        HomeUC homeUC = new HomeUC();
        public Form1()
        {
            InitializeComponent();


            products.Add(new Product
            {
                Name = "Asus Rog Strix",
                Price = 1235.60,
                Image = Properties.Resources.asus
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
                Image = Properties.Resources.zenbook
            });

            products.Add(new Product
            {
                Name = "Samsung S21",
                Price = 3200.5,
                Image = Properties.Resources.samsung
            });


            productContainer.Controls.Add(homeUC);
            guna2PictureBox1.Click += homePanel_Click;
            homeLbl.Click += homePanel_Click;


            label1.Click += guna2GradientPanel2_Click;
            guna2PictureBox2.Click += guna2GradientPanel2_Click;





        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homePanel_Click(object sender, EventArgs e)
        {
            productContainer.Controls.Clear();
            productContainer.Controls.Add(homeUC);
        }

        private void guna2GradientPanel2_Click(object sender, EventArgs e)
        {
            productContainer.Controls.Clear();
            

            //var img=Properties.Resources.home;
            int x = 20;
            int y = 30;
            foreach (var item in products)
            {
                var productUC = new ProductUC();
                productUC.Location = new Point(x, y);
                y += 120;

                productUC.Name = item.Name;
                productUC.Price = item.Price;
                productUC.ProductImage = item.Image;

                productUC.DoubleClick += ProductUC_DoubleClick;

                productContainer.Controls.Add(productUC);
            }
        }

        private void ProductUC_DoubleClick(object sender, EventArgs e)
        {
            foreach (var item in productContainer.Controls)
            {
                if(item is ProductUC userControl)
                {
                    userControl.BackColor = Color.SpringGreen;
                }
            }

            var uc=sender as ProductUC;
            uc.BackColor= Color.FromArgb(60,255,255,255);
        }
    }
}
