﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao
{
    public class Divide
    {
        public void Div()
        {
            double firstNumber, secondNumber, total;

            Console.WriteLine("");

            Console.WriteLine("Escolha o primeiro número");
            firstNumber = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Escolha o segundo número");
            secondNumber = Convert.ToDouble(Console.ReadLine());


            total = firstNumber / secondNumber;

            Console.WriteLine("O resultado da divisão é: " + total + "!");

            Console.WriteLine("Press any button to exit");
            Console.ReadKey();
        }
    }
}
