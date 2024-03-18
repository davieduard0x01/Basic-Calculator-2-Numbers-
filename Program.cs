using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Somar dois números.");
            Console.WriteLine("2. Subtrair dois números.");
            Console.WriteLine("3. Multiplicação de dois números.");
            Console.WriteLine("4. Divisão de dois números");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine("BEM VINDO A ABA DE SOMA \n");
                Console.WriteLine("Digite o 1° Numero ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o 2° Numero ");
                int num3 = int.Parse(Console.ReadLine());
                num2 += num3;
                Console.WriteLine("-R-E-S-U-L-T-A-D-O : " + num2);

            }
            else if (num1 == 2)
            {
                Console.WriteLine("BEM VINDO A ABA DE SUBTRAÇÃO");
                Console.WriteLine("Digite o 1° Numero ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o 2° Numero ");
                int n2 = int.Parse(Console.ReadLine());
                n2 += n1;
                Console.WriteLine("-R-E-S-U-L-T-A-D-O : " + n2);

            }
            else if (num1 == 3)
            {
                Console.WriteLine("BEM VINDO A ABA DE MUTIPLICAÇÃO");
                Console.WriteLine("Digite o 1° Numero ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o 2° Numero ");
                int n2 = int.Parse(Console.ReadLine());
                n2 *= n1;
                Console.WriteLine("-R-E-S-U-L-T-A-D-O : " + n2);

            }
            else if (num1 == 4)
            {
                Console.WriteLine("BEM VINDO A ABA DE DIVISÃO");
                Console.WriteLine("Digite o 1° Numero ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o 2° Numero ");
                int n2 = int.Parse(Console.ReadLine());

                if (n1 <= 0 %% n2 <= 0)
                {
                    Console.WriteLine("Error");
                }

                n2 /= n1;
                Console.WriteLine("-R-E-S-U-L-T-A-D-O : " + n2);

            }
            Console.ReadKey();
        }
    }
}
 //Escreva um programa para mostrar o menu de opções abaixo. Na sequência, leia a opção do usuário e
 //os dados necessários para executar cada operação. Calcule a operação selecionada pelo usuário e imprima
 //na tela o resultado