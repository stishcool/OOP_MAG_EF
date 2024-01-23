namespace OOP_MAG_EF
{
    partial class Admin
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            label5 = new Label();
            laptopDeleteChoice = new ComboBox();
            quantityDelete = new NumericUpDown();
            laptopDelete = new Button();
            searchProduct = new Button();
            productShow = new DataGridView();
            label3 = new Label();
            searchChoice = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            laptopChoice = new ComboBox();
            quantityProduct = new NumericUpDown();
            addProduct = new Button();
            tabPage2 = new TabPage();
            userIDChioce = new NumericUpDown();
            userSearch = new Button();
            userShow = new DataGridView();
            label6 = new Label();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityProduct).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userIDChioce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userShow).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(laptopDeleteChoice);
            tabPage1.Controls.Add(quantityDelete);
            tabPage1.Controls.Add(laptopDelete);
            tabPage1.Controls.Add(searchProduct);
            tabPage1.Controls.Add(productShow);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(searchChoice);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(laptopChoice);
            tabPage1.Controls.Add(quantityProduct);
            tabPage1.Controls.Add(addProduct);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Товары";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 86);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 13;
            label4.Text = "Кол-во товара";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 85);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 12;
            label5.Text = "Модель товара";
            // 
            // laptopDeleteChoice
            // 
            laptopDeleteChoice.FormattingEnabled = true;
            laptopDeleteChoice.Location = new Point(21, 103);
            laptopDeleteChoice.Name = "laptopDeleteChoice";
            laptopDeleteChoice.Size = new Size(196, 23);
            laptopDeleteChoice.TabIndex = 11;
            // 
            // quantityDelete
            // 
            quantityDelete.Location = new Point(258, 104);
            quantityDelete.Name = "quantityDelete";
            quantityDelete.Size = new Size(120, 23);
            quantityDelete.TabIndex = 10;
            // 
            // laptopDelete
            // 
            laptopDelete.Location = new Point(465, 104);
            laptopDelete.Name = "laptopDelete";
            laptopDelete.Size = new Size(75, 23);
            laptopDelete.TabIndex = 9;
            laptopDelete.Text = "Удалить";
            laptopDelete.UseVisualStyleBackColor = true;
            laptopDelete.Click += laptopDelete_Click;
            // 
            // searchProduct
            // 
            searchProduct.Location = new Point(65, 279);
            searchProduct.Name = "searchProduct";
            searchProduct.Size = new Size(75, 23);
            searchProduct.TabIndex = 8;
            searchProduct.Text = "Поиск";
            searchProduct.UseVisualStyleBackColor = true;
            searchProduct.Click += searchProduct_Click;
            // 
            // productShow
            // 
            productShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productShow.Location = new Point(208, 151);
            productShow.Name = "productShow";
            productShow.Size = new Size(554, 241);
            productShow.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 214);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 6;
            label3.Text = "Модель товара";
            // 
            // searchChoice
            // 
            searchChoice.FormattingEnabled = true;
            searchChoice.Location = new Point(6, 232);
            searchChoice.Name = "searchChoice";
            searchChoice.Size = new Size(196, 23);
            searchChoice.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 19);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Кол-во товара";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Модель товара";
            // 
            // laptopChoice
            // 
            laptopChoice.FormattingEnabled = true;
            laptopChoice.Location = new Point(21, 36);
            laptopChoice.Name = "laptopChoice";
            laptopChoice.Size = new Size(196, 23);
            laptopChoice.TabIndex = 2;
            // 
            // quantityProduct
            // 
            quantityProduct.Location = new Point(258, 37);
            quantityProduct.Name = "quantityProduct";
            quantityProduct.Size = new Size(120, 23);
            quantityProduct.TabIndex = 1;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(465, 37);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(75, 23);
            addProduct.TabIndex = 0;
            addProduct.Text = "Добавить";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(userIDChioce);
            tabPage2.Controls.Add(userSearch);
            tabPage2.Controls.Add(userShow);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пользователи";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // userIDChioce
            // 
            userIDChioce.Location = new Point(196, 30);
            userIDChioce.Name = "userIDChioce";
            userIDChioce.Size = new Size(235, 23);
            userIDChioce.TabIndex = 13;
            // 
            // userSearch
            // 
            userSearch.Location = new Point(472, 28);
            userSearch.Name = "userSearch";
            userSearch.Size = new Size(75, 23);
            userSearch.TabIndex = 12;
            userSearch.Text = "Поиск";
            userSearch.UseVisualStyleBackColor = true;
            userSearch.Click += userSearch_Click;
            // 
            // userShow
            // 
            userShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userShow.Location = new Point(6, 59);
            userShow.Name = "userShow";
            userShow.Size = new Size(756, 333);
            userShow.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 11);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 10;
            label6.Text = "ID пользователя";
            // 
            // button1
            // 
            button1.Location = new Point(687, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Admin";
            Text = "Admin";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)productShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityProduct).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userIDChioce).EndInit();
            ((System.ComponentModel.ISupportInitialize)userShow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox laptopChoice;
        private NumericUpDown quantityProduct;
        private Button addProduct;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private Button searchProduct;
        private DataGridView productShow;
        private Label label3;
        private ComboBox searchChoice;
        private Label label4;
        private Label label5;
        private ComboBox laptopDeleteChoice;
        private NumericUpDown quantityDelete;
        private Button laptopDelete;
        private NumericUpDown userIDChioce;
        private Button userSearch;
        private DataGridView userShow;
        private Label label6;
        private Button button1;
    }
}