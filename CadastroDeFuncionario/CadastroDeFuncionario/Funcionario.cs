
namespace CadastroDeFuncionario
{
     class Funcionario
    {

        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario()
        {
        }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double salario)
        {
            Salario += Salario * salario / 100.0;
        }

        public override string ToString()
        {
            return Id.ToString() + ", "
                + Nome
                + ", Salario: "
                + Salario.ToString("F2");
        }
    }
}
