using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Modelos;

namespace WindowsFormsView.TelasProfessor
{
    public partial class frmCadastroProfessor : Form
    {
        public frmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtMatricula.Text = string.Empty;
            txtDisciplina.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Professor novoProf = new Professor();

            novoProf.Nome = txtNome.Text;
            novoProf.Matricula = int.Parse(txtMatricula.Text);
            novoProf.Disciplina = txtDisciplina.Text;

            ProfessorController professorController = new ProfessorController();
            professorController.Inserir(novoProf);
        }
    }
}
