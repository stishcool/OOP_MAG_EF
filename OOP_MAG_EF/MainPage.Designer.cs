namespace OOP_MAG_EF
{
    partial class MainPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            cart = new Button();
            label1 = new Label();
            firstProduct = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            secondProductText = new Label();
            costFirstProduct = new Label();
            descriptionFirstProduct = new Label();
            quantityFirstProduct = new Label();
            quantitySecondProduct = new Label();
            descriptionSecondProduct = new Label();
            costSecondProduct = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 450);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 96);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 2;
            label6.Text = "• ПК";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 1;
            label3.Text = "• Ноутбуки";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 0;
            label2.Text = "Каталог";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(cart);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(150, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 123);
            panel2.TabIndex = 1;
            // 
            // cart
            // 
            cart.Location = new Point(508, 32);
            cart.Name = "cart";
            cart.Size = new Size(120, 45);
            cart.TabIndex = 1;
            cart.Text = "Корзина";
            cart.UseVisualStyleBackColor = true;
            cart.Click += cart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(236, 32);
            label1.Name = "label1";
            label1.Size = new Size(156, 47);
            label1.TabIndex = 0;
            label1.Text = "Магазин";
            // 
            // firstProduct
            // 
            firstProduct.AutoSize = true;
            firstProduct.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            firstProduct.Location = new Point(317, 141);
            firstProduct.Name = "firstProduct";
            firstProduct.Size = new Size(277, 37);
            firstProduct.TabIndex = 2;
            firstProduct.Text = "Ноутбук Lenovo L485";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lenovo;
            pictureBox1.Location = new Point(171, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PC1;
            pictureBox2.Location = new Point(171, 302);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // secondProductText
            // 
            secondProductText.AutoSize = true;
            secondProductText.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            secondProductText.Location = new Point(317, 302);
            secondProductText.Name = "secondProductText";
            secondProductText.Size = new Size(405, 37);
            secondProductText.TabIndex = 4;
            secondProductText.Text = "Персональный компьютер PC1";
            // 
            // costFirstProduct
            // 
            costFirstProduct.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            costFirstProduct.Location = new Point(612, 218);
            costFirstProduct.Name = "costFirstProduct";
            costFirstProduct.Size = new Size(176, 37);
            costFirstProduct.TabIndex = 6;
            costFirstProduct.Text = "cost";
            // 
            // descriptionFirstProduct
            // 
            descriptionFirstProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionFirstProduct.Location = new Point(317, 187);
            descriptionFirstProduct.Name = "descriptionFirstProduct";
            descriptionFirstProduct.Size = new Size(277, 94);
            descriptionFirstProduct.TabIndex = 7;
            descriptionFirstProduct.Text = "description";
            // 
            // quantityFirstProduct
            // 
            quantityFirstProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            quantityFirstProduct.Location = new Point(624, 255);
            quantityFirstProduct.Name = "quantityFirstProduct";
            quantityFirstProduct.Size = new Size(154, 26);
            quantityFirstProduct.TabIndex = 8;
            quantityFirstProduct.Text = "quantity";
            // 
            // quantitySecondProduct
            // 
            quantitySecondProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            quantitySecondProduct.Location = new Point(624, 416);
            quantitySecondProduct.Name = "quantitySecondProduct";
            quantitySecondProduct.Size = new Size(154, 26);
            quantitySecondProduct.TabIndex = 11;
            quantitySecondProduct.Text = "quantity";
            // 
            // descriptionSecondProduct
            // 
            descriptionSecondProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionSecondProduct.Location = new Point(317, 348);
            descriptionSecondProduct.Name = "descriptionSecondProduct";
            descriptionSecondProduct.Size = new Size(277, 94);
            descriptionSecondProduct.TabIndex = 10;
            descriptionSecondProduct.Text = "description";
            // 
            // costSecondProduct
            // 
            costSecondProduct.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            costSecondProduct.Location = new Point(612, 379);
            costSecondProduct.Name = "costSecondProduct";
            costSecondProduct.Size = new Size(176, 37);
            costSecondProduct.TabIndex = 9;
            costSecondProduct.Text = "cost";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(quantitySecondProduct);
            Controls.Add(descriptionSecondProduct);
            Controls.Add(costSecondProduct);
            Controls.Add(quantityFirstProduct);
            Controls.Add(descriptionFirstProduct);
            Controls.Add(costFirstProduct);
            Controls.Add(pictureBox2);
            Controls.Add(secondProductText);
            Controls.Add(pictureBox1);
            Controls.Add(firstProduct);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainPage";
            Text = "MainPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label firstProduct;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox2;
        private Label secondProductText;
        private Label costFirstProduct;
        private Label descriptionFirstProduct;
        private Label quantityFirstProduct;
        private Label quantitySecondProduct;
        private Label descriptionSecondProduct;
        private Label costSecondProduct;
        private Button cart;
    }
}