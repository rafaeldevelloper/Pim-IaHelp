namespace UI
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
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelSenha = new Label();
            textBoxSenha = new TextBox();
            checkBoxMostrarSenha = new CheckBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(178, 37);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(55, 20);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "E-mail:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(239, 30);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(293, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(178, 77);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(52, 20);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(236, 70);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(296, 27);
            textBoxSenha.TabIndex = 3;
            // 
            // checkBoxMostrarSenha
            // 
            checkBoxMostrarSenha.AutoSize = true;
            checkBoxMostrarSenha.Location = new Point(178, 117);
            checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            checkBoxMostrarSenha.Size = new Size(124, 24);
            checkBoxMostrarSenha.TabIndex = 4;
            checkBoxMostrarSenha.Text = "Mostrar senha";
            checkBoxMostrarSenha.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(280, 169);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(98, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(checkBoxMostrarSenha);
            Controls.Add(textBoxSenha);
            Controls.Add(labelSenha);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormLogin";
            Text = "Formulário de login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelSenha;
        private TextBox textBoxSenha;
        private CheckBox checkBoxMostrarSenha;
        private Button btnLogin;
    }
}
