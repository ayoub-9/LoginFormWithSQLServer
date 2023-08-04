namespace LoginForm
{
    partial class Login
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
            usernameText = new TextBox();
            passwordText = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // usernameText
            // 
            usernameText.Location = new Point(12, 12);
            usernameText.Name = "usernameText";
            usernameText.PlaceholderText = "USERNAME";
            usernameText.Size = new Size(293, 23);
            usernameText.TabIndex = 0;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(12, 41);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.PlaceholderText = "PASSWORD";
            passwordText.Size = new Size(293, 23);
            passwordText.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(60, 84);
            button1.Name = "button1";
            button1.Size = new Size(184, 27);
            button1.TabIndex = 2;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(318, 123);
            Controls.Add(button1);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.CodeDom.CodeTypeReference wilBitButton21;
        private TextBox usernameText;
        private TextBox passwordText;
        private Button button1;
    }
}