namespace UI
{
    partial class FormCadastro
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
            labelNomeCompleto = new Label();
            textBoxNomeCompleto = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            label1 = new Label();
            textBoxSenha = new TextBox();
            labelConfirmarSenha = new Label();
            textBoxConfirmarSenha = new TextBox();
            label2 = new Label();
            monthCalendarDataNascimento = new MonthCalendar();
            btnEfetuarCadastro = new Button();
            btnVoltarParaTelaDeLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelNomeCompleto
            // 
            labelNomeCompleto.AutoSize = true;
            labelNomeCompleto.Location = new Point(142, 32);
            labelNomeCompleto.Name = "labelNomeCompleto";
            labelNomeCompleto.Size = new Size(121, 20);
            labelNomeCompleto.TabIndex = 0;
            labelNomeCompleto.Text = "Nome completo:";
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Location = new Point(269, 25);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.Size = new Size(309, 27);
            textBoxNomeCompleto.TabIndex = 1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(142, 71);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(55, 20);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "E-mail:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(203, 64);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(375, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 110);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(200, 103);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(378, 27);
            textBoxSenha.TabIndex = 5;
            // 
            // labelConfirmarSenha
            // 
            labelConfirmarSenha.AutoSize = true;
            labelConfirmarSenha.Location = new Point(143, 147);
            labelConfirmarSenha.Name = "labelConfirmarSenha";
            labelConfirmarSenha.Size = new Size(120, 20);
            labelConfirmarSenha.TabIndex = 6;
            labelConfirmarSenha.Text = "Confirmar senha:";
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Location = new Point(269, 140);
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.Size = new Size(309, 27);
            textBoxConfirmarSenha.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 187);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 8;
            label2.Text = "Data de nascimento";
            // 
            // monthCalendarDataNascimento
            // 
            monthCalendarDataNascimento.Location = new Point(142, 216);
            monthCalendarDataNascimento.Name = "monthCalendarDataNascimento";
            monthCalendarDataNascimento.TabIndex = 9;
            // 
            // btnEfetuarCadastro
            // 
            btnEfetuarCadastro.Location = new Point(269, 467);
            btnEfetuarCadastro.Name = "btnEfetuarCadastro";
            btnEfetuarCadastro.Size = new Size(105, 35);
            btnEfetuarCadastro.TabIndex = 10;
            btnEfetuarCadastro.Text = "Cadastrar";
            btnEfetuarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnVoltarParaTelaDeLogin
            // 
            btnVoltarParaTelaDeLogin.Location = new Point(256, 554);
            btnVoltarParaTelaDeLogin.Name = "btnVoltarParaTelaDeLogin";
            btnVoltarParaTelaDeLogin.Size = new Size(118, 30);
            btnVoltarParaTelaDeLogin.TabIndex = 11;
            btnVoltarParaTelaDeLogin.Text = "Logar";
            btnVoltarParaTelaDeLogin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 522);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 12;
            label3.Text = "Já tem uma conta ?";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 629);
            Controls.Add(label3);
            Controls.Add(btnVoltarParaTelaDeLogin);
            Controls.Add(btnEfetuarCadastro);
            Controls.Add(monthCalendarDataNascimento);
            Controls.Add(label2);
            Controls.Add(textBoxConfirmarSenha);
            Controls.Add(labelConfirmarSenha);
            Controls.Add(textBoxSenha);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxNomeCompleto);
            Controls.Add(labelNomeCompleto);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomeCompleto;
        private TextBox textBoxNomeCompleto;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label label1;
        private TextBox textBoxSenha;
        private Label labelConfirmarSenha;
        private TextBox textBoxConfirmarSenha;
        private Label label2;
        private MonthCalendar monthCalendarDataNascimento;
        private Button btnEfetuarCadastro;
        private Button btnVoltarParaTelaDeLogin;
        private Label label3;
    }
}