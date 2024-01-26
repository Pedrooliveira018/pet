using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacao = 0;

            while (operacao != 4)
            {

                if (operacao == 0)
                {
                    Console.WriteLine("Bem vindo ou Petshop");
                    Console.WriteLine("Opções");
                    Console.WriteLine(" 1 - Calcular a medicação do seu pet");
                    Console.WriteLine(" 2 - Agendar banho");
                    Console.WriteLine(" 3 - Calcular a alimentação");
                    Console.WriteLine(" 4 - Sair ");
                }
                bool resposta = int.TryParse(Console.ReadLine(), out operacao);

                if (operacao == 1)
                {
                    Console.WriteLine("Informa o peso do seu pet?");
                    int peso = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a dosagem da medicação?");
                    int dose = int.Parse(Console.ReadLine());
                    int div = peso / dose;
                    Console.WriteLine("A dosagem da sua medicação é " + div);   
                }
                if (operacao == 2)
                {
                    Console.WriteLine("Qual o porte do seu pet pequeno, medio ou grande?");
                    string porte = (Console.ReadLine());
                    Console.WriteLine("Deseja ter cuidados extras ? ");
                    string resposta_um = (Console.ReadLine());
                    decimal total = 80;

                    if (resposta_um == "sim")
                    {
                        Console.WriteLine("Tirar Parisitas?");
                        string resp = (Console.ReadLine());

                        if (resp == "sim")
                        {
                            decimal conta_um = total + 20;
                            Console.WriteLine("oi" + conta_um);
                        }





                    }

                    if (operacao == 3)
                    {
                        Console.WriteLine("Quantos pets senhor(a) tem? ");
                        int numero_pet = int.Parse(Console.ReadLine());

                        Console.WriteLine("E de ração tem quantos disponivel");
                        int racao = int.Parse(Console.ReadLine());
                    }
                }
            }   
        }
    }
}
