using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base ("strConn") //base - classe mãe (Super do Java), strConn - nome da conexão com o banco de dados
        {

        }
    
    public DbSet<Aluno> Alunos { get; set;}//tabela de alunos
    }
}
