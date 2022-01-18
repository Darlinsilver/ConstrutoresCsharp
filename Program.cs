// See https://aka.ms/new-console-template for more information
using ExemploConstrutores.Models;
namespace ExemploConstrutores
{
    class Program
    {   
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica m = new Matematica(40, 50);
            m.Somar();
            
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            // op.Invoke(9,0);

            //op(7,90);
            //Operacao op = Calculadora.Somar;
            
            // Console.WriteLine("Hello, World!");
            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

            // Aluno p1 = new Aluno("Luba", "Lagosta", "Artes");
            // p1.Apresentar();

            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste instância";
            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Data data = new Data();
            // data.SetMes(1);

            // data.Mes = 11;

            // data.ApresentarMes();
            // System.Console.WriteLine(data.Mes);
        }    
    }  
}

