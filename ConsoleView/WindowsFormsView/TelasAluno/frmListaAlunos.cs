using System;
using System.Windows.Forms;
using Controllers;
using Modelos;
using Controllers.DAL;

namespace WindowsFormsView.TelasAluno
{
    public partial class frmListaAlunos : Form
    {
        private readonly object SelectedItems;

        public frmListaAlunos()
        {
            InitializeComponent();
        }

        private void frmListaAlunos_Load(object sender, EventArgs e)
        {
            AlunosController alunosController = new AlunosController();
            dvgAlunos.DataSource = alunosController.ListarTodos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Linha = dvgAlunos.CurrentRow.Index;

            dvgAlunos.Rows[Linha].Cells[0].ToString();

            this.dvgAlunos.Rows.Remove(this.dvgAlunos.CurrentRow); 

        }
    }
}
