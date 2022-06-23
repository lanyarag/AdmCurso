namespace AdmCurso
{
    class Aluno
    {
       public int Matricula;
       public string Nome;
       public string Sobrenome;
       public string Telefone;
       public Dictionary<int, double> NotasBimestre;

        public Aluno(int matricula, string nome, string sobrenome, string telefone)
        {
            Matricula = matricula;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            NotasBimestre = new Dictionary<int, double>();
        }

        public void Atualizar()
        {

        }

        public void RegistrarNota(int bimestre, double nota)
        {
            NotasBimestre.Add(bimestre, nota);
        }
        public void ApresentarNotas()
        {
            foreach (var nota in NotasBimestre)
            {
                Console.WriteLine($"{nota.Key} bimestre / nota {nota.Value}");
            }
        }

        double MediaDasNotas()
        {
            double media = NotasBimestre.Values.Sum() / 4;
            return media;
        }

        bool Estagio()
        {
            double media = MediaDasNotas();

            if (media <= 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}


