using System;
using Adicao;
using Subtracao;
using Multiplicacao;
using Divisao;

namespace CalculadoraMain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Somar soma = new Somar();
            Diminuir diminuir = new Diminuir();
            Mult mult = new Mult();
            Divide divide = new Divide();

            Console.WriteLine("Calculadora básica em C#");

            Console.WriteLine("");

            Console.WriteLine("Escolha qual operação você vai realizar: (1) Adição, (2) Subtração, (3) Multiplicação, (4) Divisão");

            
            int operacao = int.Parse(Console.ReadLine());
            switch (operacao)
            {
                case 1:
                    soma.Soma();
                    break;
                case 2:
                    diminuir.Sub();
                    break;
                case 3:
                    mult.Multi();
                    break;
                case 4:
                    divide.Div();
                    break;

                default:
                    Console.WriteLine("Passe somente os valores corretos");
                    break;
            }
        }
    }
}
