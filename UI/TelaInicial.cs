using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

            btnCadastrarChamado.Click += btnCadastrarChamado_Click;
        }

        private void btnCadastrarChamado_Click(object sender, EventArgs e)
        {
            CadastrarChamado telaCadastrarChamado = new CadastrarChamado();
            telaCadastrarChamado.ShowDialog();
            this.Hide();
        }
    }
}
