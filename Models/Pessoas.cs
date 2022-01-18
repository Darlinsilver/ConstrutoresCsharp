namespace ExemploConstrutores.Models
{
    public class Pessoas
    {
        private readonly string nome = "Luba";
        private readonly string sobrenome;
        public Pessoas()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        public Pessoas(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor da classe Pessoas!");
        }
        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }
    }
}