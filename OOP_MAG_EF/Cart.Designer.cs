namespace OOP_MAG_EF
{
    partial class Cart
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
            cartShow = new DataGridView();
            totalAmountLabel = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)cartShow).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cartShow
            // 
            cartShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartShow.Location = new Point(22, 175);
            cartShow.Name = "cartShow";
            cartShow.Size = new Size(520, 263);
            cartShow.TabIndex = 0;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            totalAmountLabel.Location = new Point(572, 417);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(40, 21);
            totalAmountLabel.TabIndex = 1;
            totalAmountLabel.Text = "sum";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 123);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(22, 32);
            button1.Name = "button1";
            button1.Size = new Size(120, 45);
            button1.TabIndex = 1;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(300, 32);
            label1.Name = "label1";
            label1.Size = new Size(156, 47);
            label1.TabIndex = 0;
            label1.Text = "Корзина";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(totalAmountLabel);
            Controls.Add(cartShow);
            Name = "Cart";
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)cartShow).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cartShow;
        private Label totalAmountLabel;
        private Panel panel2;
        private Button button1;
        private Label label1;
    }
}