namespace AdmCurso
{
    class Aluno
    {
        int Matricula;
        string Nome;
        string Sobrenome;
        string Telefone;
        double[] Notas;

        public Aluno(int matricula, string nome, string sobrenome, string telefone)
        {
            Matricula = matricula;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Notas = new double[4];
        }

        public void Atualizar()
        {
            //Atualizar cadastro
        }

        public void RegistrarNota()
        {
            //Deverá receber um número referente ao bimestre (1-4) e a nota (0-10)
            //enum?
            enum
            {
            Bimestre1 = 10;



        }

    }

    public void ApresentarNotas()
    {
        //Deverá apresentar todas as notas cadastradas por bimestre

    }

    void MediaDasNotas()
    {

    }

    void Estagio()
    {

    }
}
}

