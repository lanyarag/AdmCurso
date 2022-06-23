namespace AdmCurso
{
    class Curso : Administracao
    {

        List<Aluno> alunos;

        public Curso()
        {
            alunos = new List<Aluno>();
        }

        public override void Cadastrar(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public override void Remover(Aluno aluno)
        {
            alunos.Remove(aluno);
        }

        public override void Atualizar(Aluno aluno, int index)
        {
            alunos[index] = aluno;
        }

        public override void ApresentarTodos()
        {
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine(aluno.Nome);
            }
        }
    }
}

