using System;

namespace CadastroDeFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos funcionarios serao registrados: ");
            int qt = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

           
            for (int i = 0; i < qt; i++)
            {
                Console.Write("Digite o ID do funcionario: ");
                int idFuncionario = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do funcionario: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o salario do funcionario: ");
                double salario = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionario(idFuncionario, nome, salario));
                Console.WriteLine();
            }

            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }

            Console.WriteLine();

            Console.Write("Entre com o ID do funcionario cujo vai acrescentar aumento: ");
            int id = int.Parse(Console.ReadLine());

            Funcionario emp = funcionarios.Find(x => x.Id == id);

            if (emp != null)
            {
                Console.WriteLine();
                Console.Write("Entre com a porcentagem de aumento: ");
                double porc = double.Parse(Console.ReadLine());
                emp.AumentoSalario(porc);
            }
            else
            {
                Console.WriteLine("Esse funcionário não existe! ");
                Console.WriteLine();
            }

            Console.WriteLine("Lista de funcionários atualizados: ");

            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }

            Console.ReadLine();
        }
    }
}