using csharp_list_exercicio;
using System.Globalization;

Console.Write("Quantos funcionários você quer cadastrar? ");
int resp = int.Parse(Console.ReadLine());

List<Funcionario> funcionarios = new List<Funcionario>();

for (int i = 0; i < resp; i++)
{
    Console.Write("Insira o id do funcionário: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Insira o nome do funcionário: ");
    string nome = Console.ReadLine();
    Console.Write("Insira o salário do funcionário: ");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    funcionarios.Add(new Funcionario(nome, id, salario));
    Console.WriteLine("==================================\n");
}
foreach (Funcionario obj in funcionarios)
{
    Console.WriteLine(obj);
}

Console.Write("Insira o Id do funcionário do qual você quer aumentar o salário: ");
int idSearch = int.Parse(Console.ReadLine());
Console.Write("Qual a porcentagem de aumento? ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
if(funcionarios.Find(x => x.Id == idSearch) != null)
{
    funcionarios.Find(x => x.Id == idSearch).AumentaSalario(porcentagem);
} else
{
    Console.WriteLine("Id inválido");
}
Console.WriteLine("Dados atualizados: ");
foreach (Funcionario obj in funcionarios)
{
    Console.WriteLine(obj);
}