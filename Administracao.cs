namespace AdmCurso
{
    abstract class Administracao
    {
        public abstract void Cadastrar(Aluno aluno);

        public abstract void Remover(Aluno aluno);

        public virtual void Atualizar(Aluno aluno, int index)
        {

        }
        public virtual void ApresentarTodos()
        {

        }
    }
}




