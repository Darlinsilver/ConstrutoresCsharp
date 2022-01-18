namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoas
    {
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Construtor da classe aluno!");
        }
    }
}