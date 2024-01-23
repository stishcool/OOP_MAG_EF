namespace OOP_MAG_EF
{
    partial class Login
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
            label2 = new Label();
            passwordInsert = new TextBox();
            label4 = new Label();
            emailInsert = new TextBox();
            loginButton = new Button();
            label8 = new Label();
            reg = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 185);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 15;
            label2.Text = "Пароль";
            // 
            // passwordInsert
            // 
            passwordInsert.Location = new Point(413, 203);
            passwordInsert.Name = "passwordInsert";
            passwordInsert.Size = new Size(153, 23);
            passwordInsert.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 185);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 13;
            label4.Text = "Почта";
            // 
            // emailInsert
            // 
            emailInsert.Location = new Point(193, 203);
            emailInsert.Name = "emailInsert";
            emailInsert.Size = new Size(153, 23);
            emailInsert.TabIndex = 12;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Bottom;
            loginButton.Location = new Point(300, 322);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(153, 36);
            loginButton.TabIndex = 16;
            loginButton.Text = "Вход";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(321, 30);
            label8.Name = "label8";
            label8.Size = new Size(102, 50);
            label8.TabIndex = 17;
            label8.Text = "Вход";
            // 
            // reg
            // 
            reg.Anchor = AnchorStyles.Bottom;
            reg.Location = new Point(300, 380);
            reg.Name = "reg";
            reg.Size = new Size(153, 36);
            reg.TabIndex = 18;
            reg.Text = "Регистрация";
            reg.UseVisualStyleBackColor = true;
            reg.Click += reg_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(reg);
            Controls.Add(label8);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(passwordInsert);
            Controls.Add(label4);
            Controls.Add(emailInsert);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox passwordInsert;
        private Label label4;
        private TextBox emailInsert;
        private Button loginButton;
        private Label label8;
        private Button reg;
        private Button button1;
    }
}