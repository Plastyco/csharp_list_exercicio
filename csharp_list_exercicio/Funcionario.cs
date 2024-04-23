using System.Globalization;

namespace csharp_list_exercicio
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; private set; }
        public double Salario { get; private set; }

        
        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public void AumentaSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }

        public override string ToString()
        {
            return Id + ", "
                + Nome + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
