namespace LibraryManagementSystem
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(84, 159);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(297, 27);
            textBoxUserName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(84, 268);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(297, 27);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(84, 115);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(84, 229);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaption;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonLogin.Location = new Point(144, 342);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(152, 45);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(466, 559);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormLogin";
            Text = "Library Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Button buttonLogin;
    }
}
