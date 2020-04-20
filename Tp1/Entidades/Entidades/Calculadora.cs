using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double calculo = 0;
            string validar = ValidarOperador(operador);

            if(validar == "+")
            {
                calculo = num1 + num2; 
            }
            else if(validar == "-")
            {
                calculo = num1 - num2;
            }
            else if (validar == "*")
            {
                calculo = num1 * num2;
            }
            else if (validar == "/")
            {
                calculo = num1 / num2;

                if(double.IsInfinity(calculo))
                {
                    calculo = double.MinValue;
                }
            }

            return calculo;
        }

        private static string ValidarOperador(string operador)
        {

            string retorno;

            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                retorno = operador;

            }
            else
            {
                retorno = "+";
            }

            return retorno;
        }
    }
}
