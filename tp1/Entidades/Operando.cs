using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Clase Operando:
    public class Operando
    {
        //• El atributo numero es privado.
        private double numero;

        //• La propiedad Numero asignará un valor al atributo número, previa validación.
        //En este lugar será el único en todo el código que llame al método ValidarNumero.
        private string Numero
        {
            set { numero = ValidarOperando(value); }
        }

        //• El constructor por defecto(sin parámetros) asignará valor 0 al atributo numero.
        public Operando() : this(0)
        {
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string numero)
        {
            Numero = numero;
        }

        //• ValidarOperando comprobará que el valor recibido sea numérico, y lo retornará en
        //formato double. Caso contrario, retornará 0.
        private double ValidarOperando(string strNumero)
        {
            double numero;
            if (double.TryParse(strNumero, out numero))
                return numero;
            return 0;
        }

        //• El método privado EsBinario validará que la cadena de caracteres esté compuesta
        //SOLAMENTE por caracteres '0' o '1'.
        private static bool EsBinario(string strNum)
        {
            bool esBinario = true;
            foreach (char digito in strNum)
            {
                if (digito != '0' && digito != '1')
                {
                    esBinario = false;
                    break;
                }
            }
            return esBinario;
        }

        //• Los métodos BinarioDecimal y DecimalBinario convertirán el Resultado, trabajarán
        //con enteros positivos, quedándose para esto con el valor absoluto y entero del
        //double recibido:
        //o El método BinarioDecimal validará que se trate de un binario y luego
        //convertirá ese número binario a decimal, en caso de ser posible.Caso
        //contrario retornará "Valor inválido".
        public static string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                int entero = 0;
                int potencia = 1;
                int len = binario.Length - 1;
                for (int i = 0; i <= len; i++)
                {
                    potencia = (int)Math.Pow(2, i);
                    entero += (int.Parse(binario[len - i].ToString()) * potencia);
                }
                return entero.ToString();
            }
            else
                return "Valor inválido";
        }

        //o Ambas opciones del método DecimalBinario convertirán un número
        //decimal a binario, en caso de ser posible.Caso contrario retornará "Valor
        //inválido". Reutilizar código.
        public static string DecimalBinario(double numero)
        {
            string binario = string.Empty;
            double resto;

            do
            {
                resto = numero % 2;
                numero = (int)(numero / 2);
                if (resto == 0)
                    binario = "0" + binario;
                else
                    binario = "1" + binario;
            }
            while (numero >= 1);

            return binario;
        }

        public static string DecimalBinario(string numero)
        {
            double doubleNum;
            if (double.TryParse(numero, out doubleNum))
            {
                return DecimalBinario(doubleNum);
            }
            else
                return "Valor inválido";
        }

        //• Los operadores realizarán las operaciones correspondientes entre dos números.
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        //o Si se tratara de una división por 0, retornará double.MinValue.
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
                return double.MinValue;
            else
                return n1.numero / n2.numero;
        }
    }
}
