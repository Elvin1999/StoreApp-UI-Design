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
    public partial class ProductUC : UserControl
    {
        public string Name
        {
            get => productName.Text; 
            set
            {
                productName.Text = value;
            }
        }

        public double Price
        {
            get => double.Parse(productPrice.Text);
            set
            {
                productPrice.Text = value.ToString();
            }
        }

       public Image ProductImage
        {
            get
            {
                return guna2CirclePictureBox1.Image;
            }
            set
            {
                guna2CirclePictureBox1.Image = value;
            }
        }

        public ProductUC()
        {
            InitializeComponent();
            
        }
    }
}
