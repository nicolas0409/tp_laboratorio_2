using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{/// <summary>
/// Clase que se utiliza para idendificar las propiedades campos y metodos  de
/// la abstracion numero
/// </summary>
     public class Numero
    {
        private double numero;
        /// <summary>
        /// Constructor  de clase  Numero
        /// no recive parametro, inicializa en 0 el numero
        /// </summary>
        public Numero()
        {
            this.numero = 0;  
        }
        /// <summary>
        /// Constructor  de clase  Numero
        /// </summary>
        /// <param name="strNumero">string con valor numerico con que se desea
        /// inicializar el numero</param>
        public Numero(string strNumero) 
        {
            this.SetNumero=strNumero;
        }
        /// <summary>
        /// Constructor  de clase  Numero
        /// </summary>
        /// <param name="numero">double con que se desea
        /// inicializar el numero</param</param>
        public Numero(double numero) : this(Convert.ToString(numero))
        {

        }
        /// <summary>
        /// Propieda para setear y validar el valor que se le va a asignar al numero
        /// </summary>
        private string SetNumero
        {
            set
            {
               this.numero = ValidarNumero(value);
            }
        }
        /// <summary>
        /// metodo para validar si el srting ingresado es una valor valido 
        /// para convertirse a numerico,de ser valido  el valor lo retornar como tipo double,
        /// de no ser valido retornara 0
        /// </summary>
        /// <param name="strNumero">valor a validar</param>
        /// <returns>el valor numerico del string </returns>
        private static double ValidarNumero(string strNumero)
        {
            double valorRetornar;
            
            double.TryParse(strNumero, out valorRetornar);

            return valorRetornar;
        }
        /// <summary>
        /// Operador para sumar  dos numeros
        /// reotrnara el valor sumado de los dos parametros
        /// </summary>
        /// <param name="n1">primer valor a sumar</param>
        /// <param name="n2">segundo valor a sumar</param>
        /// <returns> la suma de los numeros pasador por  parametro</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;

        }
        /// <summary>
        ///  Operacion  para restar el valor numerdo  de s¿ las dos instancias de nuemro pasadas
        ///  por parametro
        /// </summary>
        /// <param name="n1">numero a ser restado</param>
        /// <param name="n2">numero que resta</param>
        /// <returns>el valor restado entre n1-n2</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;

        }
        /// <summary>
        /// Operacion que multiplica  lo valores nuemricos  de las instancias
        /// de la clase de  tipo numero 
        /// </summary>
        /// <param name="n1">valor a multipllicar</param>
        /// <param name="n2">valor a multipllicar</param>
        /// <returns>el valor numerico de la multiplicacion entre n1 y n2</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        ///  Ejecuta la operacion de division entre el valor numerico de 
        ///  dos instancias de clase de tipo Numero pasadas por parametro
        /// </summary>
        /// <param name="n1">instancia de numero para  ser el divisor</param>
        /// <param name="n2">instancia e¿de nuemero para se el dividendo</param>
        /// <returns>El resultado de la divison  entre n1/n2</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }
        /// <summary>
        /// Convierte el decimal pasado por  parametro a binario
        /// </summary>
        /// <param name="decimal1">decimal a convertir</param>
        /// <returns>El valor del decimal en binario si se pudo convertir en caso contrario 
        /// retorna "VALOR NO VALIDO"</returns>
        public static string DecimalBinario(double decimal1)
        {
            double resultado;
            byte resto;
            string binario = "";

            if (ValidoDecimal(decimal1))
            {
                do
                {

                    resultado = Math.Floor(decimal1) / 2;
                    if (Math.Floor(decimal1) % 2 == 0)
                    {
                        resto = 0;
                    }
                    else
                    {
                        resto = 1;
                    }
                    binario = binario + resto;

                    decimal1 = resultado;

                }
                while (resultado >= 1);


                char[] charArray = binario.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            else
            {
                return "VALOR NO VALIDO";
            }
             
        }
        /// <summary>
        /// Convierte el string pasado por  parametro a binario
        /// </summary>
        /// <param name="Decimal">Valor a convertir</param>
        /// <returns>El valor del decimal en binario si se pudo convertir en caso contrario 
        /// retorna "VALOR NO VALIDO"</returns>
        public static string DecimalBinario(string Decimal)
        {

            double numero;
            double.TryParse(Decimal, out numero);
           return DecimalBinario(numero);
        }
        /// <summary>
        /// Convierte el string pasado por parametro a un string con su valor convertido
        /// de binario a decimal
        /// </summary>
        /// <param name="binario">string a convertir</param>
        /// <returns>retorna el valor conrtido  en decimal  del string si pudo convertirlo en 
        /// caso contrario retorna"VALOR NO VALIDO"</returns>
        public static string BinarioADecimal(string binario)
        {
            int index;
            double NumeroDecimal = 0;
            double suma = 0;
            char[] charArray;
            char[] charArray2;

            if (ValidoBinario(binario))
            {
                charArray = binario.ToCharArray();
                Array.Reverse(charArray);
                binario = new string(charArray);

                while (1 == 1)
                {

                    index = binario.IndexOf('1');

                    if (index == -1)
                    {
                        break;
                    }
                    else
                    {
                        NumeroDecimal = Math.Pow(2, index);
                        suma += NumeroDecimal;
                    }
                    charArray2 = binario.ToCharArray();

                    charArray2[index] = '0';
                    binario = new string(charArray2);

                }
                return suma.ToString();
            }
            else
                return "VALOR NO VALIDO";
        }
        /// <summary>
        /// Valida que el string  sea un numero binario valido
        /// </summary>
        /// <param name="binario">stirng a validar</param>
        /// <returns>retorna true si  el string contiene un numero binario valido
        /// caso contrario retorna false</returns>
        private static bool ValidoBinario(string binario)
        {
            bool flag = true;
            foreach (char x in binario)
            {
                if(x!='0' && x!='1')
                {
                    flag = false;
                }

            }
            return flag;
        }
        /// <summary>
        /// valida  si el valor de  decimal1 se puede convertir a entero
        /// </summary>
        /// <param name="decimal1">Numero a validar</param>
        /// <returns>retorna true si el decimal1 es un numero convertible a entero,
        /// false caso contrario  </returns>
        private static bool ValidoDecimal(double decimal1)
        {
            bool flag = true;
            int resultado;
            if (decimal1!=0)
            {

                int.TryParse(Convert.ToString(decimal1), out resultado);
                if(resultado==0)
                {
                    flag = false;

                }
            }
            return flag;
        }

    }
}

