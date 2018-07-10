﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace WindowsFormsView.TelasProfessor
{
    public partial class frmListaProfessor : Form
    {
        public frmListaProfessor()
        {
            InitializeComponent();
        }

        private void frmListaProfessor_Load(object sender, EventArgs e)
        {
            ProfessorController professorController = new ProfessorController();
            dgvProfessor.DataSource = professorController.ListarTodosProfessor();
        }
    }
}
