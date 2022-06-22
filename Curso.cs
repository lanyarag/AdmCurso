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

        void Atualizar()
        {

        }

        void ApresentarTodos()
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}

