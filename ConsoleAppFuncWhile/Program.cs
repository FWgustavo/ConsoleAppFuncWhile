using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFuncWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            double total = 0;
            string resp;
            Console.WriteLine("Deseja começar? (S/N)");
            resp = Console.ReadLine().ToUpper();
            while(resp == "S")
            {
                Console.WriteLine("Qual a forma de contratação do funcionário [A-Assalariado,C-Comissado,H-Horista]");
                string resp2 = Console.ReadLine().ToUpper();
                switch (resp2) 
                {
                    case "A":
                        Console.WriteLine("Digite o valor do salário: ");
                         double sal = double.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o desconto: ");
                        double desc = double.Parse(Console.ReadLine());
                        double sb = sal - desc;
                        Console.WriteLine("O salário bruto é de: " + sb.ToString("C"));
                        cont++;
                        total += sb;
                        break;

                    case "C":
                        Console.WriteLine("Insira o valor que o funcionário ganha por peça: ");
                        double vp = double.Parse(Console.ReadLine());
                        Console.WriteLine("Quantas peças o funcionário vendeu: ");
                        int quantp = int.Parse(Console.ReadLine());

                        sb = quantp * vp;
                        Console.WriteLine("Salário bruto é de: " + sb .ToString("C"));
                        cont++;
                        total += sb;
                        break;

                    case "H":
                        Console.WriteLine("Insira o valor por hora: ");
                        double vh = double.Parse(Console.ReadLine());
                        Console.WriteLine("Quantidade de horas trabalhadas: ");
                        int quanth = int.Parse(Console.ReadLine());

                        sb = quanth * vh;
                        Console.WriteLine("Salário bruto é de: " + sb.ToString("C"));
                        cont++;
                        total += sb;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Deseja continuar: ");
                resp = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("A quantidade de funcionários cadastrados foi: " + cont);
            Console.WriteLine("O total da folha de pagamento é de: " + total.ToString("C"));
            Console.WriteLine("A média de salário é: " + (total / cont).ToString("C"));
            Console.ReadKey();
        }
    }
}
