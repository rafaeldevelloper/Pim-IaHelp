namespace UI
{
    partial class TelaInicial
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnCadastrarChamado = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Pim_IaHelp;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 103);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 1;
            label1.Text = "Bem-vindo(a) à IA Help";
            // 
            // btnCadastrarChamado
            // 
            btnCadastrarChamado.ForeColor = SystemColors.Desktop;
            btnCadastrarChamado.Location = new Point(273, 157);
            btnCadastrarChamado.Name = "btnCadastrarChamado";
            btnCadastrarChamado.Size = new Size(153, 29);
            btnCadastrarChamado.TabIndex = 2;
            btnCadastrarChamado.Text = "Cadastrar chamado";
            btnCadastrarChamado.UseVisualStyleBackColor = true;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarChamado);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.HighlightText;
            Name = "TelaInicial";
            Text = "CadastrarChamado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnCadastrarChamado;
    }
}