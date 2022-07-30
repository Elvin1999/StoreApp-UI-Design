namespace UC
{
    partial class ProductUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productName = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productName.ForeColor = System.Drawing.Color.White;
            this.productName.Location = new System.Drawing.Point(137, 31);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(74, 30);
            this.productName.TabIndex = 1;
            this.productName.Text = "label1";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPrice.ForeColor = System.Drawing.Color.White;
            this.productPrice.Location = new System.Drawing.Point(333, 25);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(93, 38);
            this.productPrice.TabIndex = 2;
            this.productPrice.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(432, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "$";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::UC.Properties.Resources.iphone11;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(86, 85);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(491, 91);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label label1;
    }
}
