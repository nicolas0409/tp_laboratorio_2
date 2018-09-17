using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Calculadora
    {
        public Double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado;
            operador = Validar(operador);
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;

                default:
                    resultado = 0;
                    break;
            }
            return resultado;
        }
        private static string Validar(string operador)
        {
            switch (operador)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    return operador;

                default:
                    return "+";

            }
        }
    }
}

