using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continuar = true;

            Console.WriteLine("Calculadora\n");

            while (continuar)
            {
                Console.WriteLine("Selecione a opção desejada: \n");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair \n");

                string entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "1":
                        calcSoma();
                        break;

                    case "2":
                        calcMenos();
                        break;

                    case "3":
                        calcMult();
                        break;

                    case "4":
                        calcDivis();
                        break;

                    case "5":
                        Console.WriteLine("Fechando calculadora...");
                        Thread.Sleep(1800);
                        Console.WriteLine("Desativando multiplicadores...");
                        Thread.Sleep(1800);
                        Console.WriteLine("Desligamento de subtratores...");
                        Thread.Sleep(1800);
                        Console.WriteLine("Servidores de soma em desligamento...");
                        Thread.Sleep(1800);
                        Console.WriteLine("Divisores entrando em descanso...");
                        Thread.Sleep(1800);
                        Console.WriteLine("Servidores descarregados, pronto para finalizar tarefas...");
                        Thread.Sleep(1800);
                        Console.WriteLine("Calculadora desativada. Volte sempre!");
                        Console.ReadLine();
                        
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;

                }
            }

        }

        static void calcSoma()
        {
            Console.Clear();
            Console.WriteLine("Selecionada opção de SOMA... \n");
            Console.WriteLine("Informe o primeiro numero:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da soma é " + (a + b));

        }
        static void calcMenos()
        {
            Console.Clear();
            Console.WriteLine("Selecionada opção de SUBTRACAO... \n");
            Console.WriteLine("Informe o primeiro numero:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da subtracao é " + (a - b));

        }
        static void calcMult()
        {
            Console.Clear();
            Console.WriteLine("Selecionada opção de MULTIPLICACAO... \n");
            Console.WriteLine("Informe o primeiro numero:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da multiplicacao é " + (a * b));

        }
        static void calcDivis()
        {
            Console.Clear();
            Console.WriteLine("Selecionada opção de DIVISAO... \n");
            Console.WriteLine("Informe o primeiro numero:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da divisao é " + (a / b));

        }

    }
}
