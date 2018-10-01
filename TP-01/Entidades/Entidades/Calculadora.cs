using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Calculadora
    {
        /// <summary>
        /// metodo  que recibe 2 obejtos tipo Numero  y retorna el valor de la operacion
        /// pasada por parametro
        /// </summary>
        /// <param name="num1">Numero1 a operar</param>
        /// <param name="num2">Numero2 a operar</param>
        /// <param name="operador">operacion elejida para ser calcuada con los parametros 
        /// </param>  num1 y num2
        /// <returns>Resultado de la operacion realizada</returns>
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
        /// <summary>
        /// metodo para validar el valor del operador sea uno dentro de los que estan definidos
        /// retorna  el operador valido   de no ser vaalido el operador retornara +
        /// </summary>
        /// <param name="operador">String con el valor del operador</param>
        /// <returns>el operador  validado o "+" en caso de no ser valido</returns>
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

