using Modelos;
using System.Data.Entity;

namespace Controllers.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn") // base = (super do Java), "strConn" = nome da conexão com banco
        {
        }
        public DbSet<Aluno> Alunos { get; set; } // tabela de alunos
        public DbSet<Professor> Professores { get; set; } // tabela de professor
        public DbSet<Disciplina> Disciplinas { get; set; } // tabela de disciplinas
    }
}
