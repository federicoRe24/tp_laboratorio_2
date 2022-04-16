using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Entidades
{
    //Clase estática Calculadora:
    public static class Calculadora
    {
        //• El método ValidarOperador será privado y estático.Deberá validar que el operador
        //recibido sea +, -, / o*. Caso contrario retornará +.
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            return '+';
        }

        //• El método Operar será de clase: validará y realizará la operación pedida entre
        //ambos números.
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;

            }
            return resultado;
        }

    }
}
