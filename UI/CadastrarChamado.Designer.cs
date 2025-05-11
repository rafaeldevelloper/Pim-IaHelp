namespace UI
{
    partial class CadastrarChamado
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
            label1 = new Label();
            textBoxTituloChamado = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // textBoxTituloChamado
            // 
            textBoxTituloChamado.Location = new Point(181, 28);
            textBoxTituloChamado.Name = "textBoxTituloChamado";
            textBoxTituloChamado.Size = new Size(461, 27);
            textBoxTituloChamado.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 69);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(437, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 108);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 4;
            label3.Text = "Prioridade:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(437, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 140);
            label4.Name = "label4";
            label4.Size = new Size(205, 20);
            label4.TabIndex = 6;
            label4.Text = "Data da criação do chamado:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(124, 169);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // CadastrarChamado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 657);
            Controls.Add(monthCalendar1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBoxTituloChamado);
            Controls.Add(label1);
            Name = "CadastrarChamado";
            Text = "CadastrarChamado";
            Load += CadastrarChamado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTituloChamado;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private MonthCalendar monthCalendar1;
    }
}