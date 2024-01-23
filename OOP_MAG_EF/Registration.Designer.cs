namespace OOP_MAG_EF
{
    partial class Registration
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
            registerButton = new Button();
            nameInsert = new TextBox();
            label1 = new Label();
            label2 = new Label();
            surnameInsert = new TextBox();
            label3 = new Label();
            patronymicInsert = new TextBox();
            label4 = new Label();
            emailInsert = new TextBox();
            label9 = new Label();
            passwordInsert = new TextBox();
            label6 = new Label();
            phoneInsert = new TextBox();
            label7 = new Label();
            addressInsert = new TextBox();
            label8 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.Bottom;
            registerButton.Location = new Point(307, 361);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(153, 36);
            registerButton.TabIndex = 0;
            registerButton.Text = "Регистрация";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // nameInsert
            // 
            nameInsert.Location = new Point(100, 132);
            nameInsert.Name = "nameInsert";
            nameInsert.Size = new Size(153, 23);
            nameInsert.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 114);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 114);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            // 
            // surnameInsert
            // 
            surnameInsert.Location = new Point(307, 132);
            surnameInsert.Name = "surnameInsert";
            surnameInsert.Size = new Size(153, 23);
            surnameInsert.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 114);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Отчество";
            // 
            // patronymicInsert
            // 
            patronymicInsert.Location = new Point(511, 132);
            patronymicInsert.Name = "patronymicInsert";
            patronymicInsert.Size = new Size(153, 23);
            patronymicInsert.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 198);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 9;
            label4.Text = "Почта";
            // 
            // emailInsert
            // 
            emailInsert.Location = new Point(100, 216);
            emailInsert.Name = "emailInsert";
            emailInsert.Size = new Size(153, 23);
            emailInsert.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(307, 198);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 11;
            label9.Text = "Пароль";
            // 
            // passwordInsert
            // 
            passwordInsert.Location = new Point(307, 216);
            passwordInsert.Name = "passwordInsert";
            passwordInsert.Size = new Size(153, 23);
            passwordInsert.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 198);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 13;
            label6.Text = "Телефон";
            // 
            // phoneInsert
            // 
            phoneInsert.Location = new Point(511, 216);
            phoneInsert.Name = "phoneInsert";
            phoneInsert.Size = new Size(153, 23);
            phoneInsert.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(217, 267);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 15;
            label7.Text = "Адрес";
            // 
            // addressInsert
            // 
            addressInsert.Location = new Point(217, 285);
            addressInsert.Name = "addressInsert";
            addressInsert.Size = new Size(351, 23);
            addressInsert.TabIndex = 14;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(265, 9);
            label8.Name = "label8";
            label8.Size = new Size(234, 50);
            label8.TabIndex = 16;
            label8.Text = "Регистрация";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(480, 216);
            label5.Name = "label5";
            label5.Size = new Size(30, 23);
            label5.TabIndex = 17;
            label5.Text = "+7";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(addressInsert);
            Controls.Add(label6);
            Controls.Add(phoneInsert);
            Controls.Add(label9);
            Controls.Add(passwordInsert);
            Controls.Add(label4);
            Controls.Add(emailInsert);
            Controls.Add(label3);
            Controls.Add(patronymicInsert);
            Controls.Add(label2);
            Controls.Add(surnameInsert);
            Controls.Add(label1);
            Controls.Add(nameInsert);
            Controls.Add(registerButton);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private TextBox nameInsert;
        private Label label1;
        private Label label2;
        private TextBox surnameInsert;
        private Label label3;
        private TextBox patronymicInsert;
        private Label label4;
        private TextBox emailInsert;
        private Label label9;
        private TextBox passwordInsert;
        private Label label6;
        private TextBox phoneInsert;
        private Label label7;
        private TextBox addressInsert;
        private Label label8;
        private Label label5;
    }
}