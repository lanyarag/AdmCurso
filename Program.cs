namespace AdmCurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso();
            curso.Cadastrar(new Aluno(1, "João", "Da Silva", "32345487"));
            curso.ApresentarTodos();



        }
    }
}