using System;
using System.ComponentModel.Design;

namespace Calculadora
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a calculadora mastermind");
            Console.WriteLine("Para fazer suas operações digite uma das seguintes opções: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto da divisão");
            Console.WriteLine("4 - Potencialização");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();

            string opcao = Console.ReadLine();

            switch (opcao)
            {

                case "1":
                    Somar();
                    break;

                case "2":
                    Subtrair();
                    break;

                case "3":
                    Multiplicar();
                    break;

                case "4":
                    Dividir();
                    break;
                case "5":
                    RestoDivisao();
                    break;
                case "6":
                    Potenciacao();
                    break;

                case "0":
                    break;

            }

            static void Somar()
            {
                double valor1, valor2;

                Console.Write("Digite o primeiro valor: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo valor: ");
                valor2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
                Console.ReadLine();
                Menu();
            }

            static void Subtrair()
            {
                double valor1, valor2;

                Console.Write("Digite o primeiro numero: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero: ");
                valor2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
                Console.ReadLine();
                Menu();

            }

            static void Multiplicar()
            {
                double valor1, valor2;

                Console.Write("Digite o primeiro numero: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero: ");
                valor2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");
                Console.ReadLine();
                Menu();

            }

            static void Dividir()
            {
                double valor1, valor2;

                Console.Write("Digite o primeiro numero: ");
                valor1 = double.Parse(Console.ReadLine());


                Console.Write("Digite o segundo numero: ");
                valor2 = double.Parse(Console.ReadLine());
                if (valor2 != 0)
                {
                    Console.WriteLine($"{valor1} / {valor2} = {valor1 / valor2}");
                }
                else Console.WriteLine("Não é possivel dividir por 0");
                
                Console.ReadLine();
                Menu();

            }

            static void RestoDivisao()
            {
                double valor1, valor2;

                Console.Write("Digite o dividendo numero: ");
                valor1 = double.Parse(Console.ReadLine());


                Console.Write("Digite o divisor numero: ");
                valor2 = double.Parse(Console.ReadLine());
                if (valor2 != 0)
                {
                    Console.WriteLine($"o resto da divisao dos valores {valor1} e {valor2} = {valor1 % valor2}");
                }
                else Console.WriteLine("Não é possivel dividir por 0");

                Console.ReadLine();
                Menu();
            }

            static void Potenciacao()
            {
                double valor1, valor2;

                Console.Write("Informe a base: ");
                valor1 = double.Parse(Console.ReadLine());
                
                Console.Write("Informe a Expoente: ");
                valor2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"O resultado da potencialização entre {valor1} e {valor2} = {Math.Pow(valor1, valor2)}");
                Console.ReadLine();
                Menu();

            }


        }
    }
}