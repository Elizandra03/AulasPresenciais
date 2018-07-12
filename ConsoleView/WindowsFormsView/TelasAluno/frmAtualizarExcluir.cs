using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controllers;

namespace WindowsFormsView.TelasAluno
{
    public partial class frmAtualizarExcluir : Form
    {
        public frmAtualizarExcluir()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            AlunosController pesquisaAluno = new AlunosController();
            txtNome.Text = pesquisaAluno.ListarTodos();
        }
    }
}
