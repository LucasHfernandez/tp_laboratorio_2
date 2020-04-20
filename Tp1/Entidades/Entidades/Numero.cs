using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
           set
           {
                numero = ValidarNumero(value);
           }
            
        }

        public Numero()
        {
            SetNumero = Convert.ToString(0);
        }

        public Numero(double numero)
        {
            SetNumero = Convert.ToString(numero);
        }

        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        private double ValidarNumero(string strNumero)
        {
            int i;
            int flag = 1;
            int comas = 0;
            int negativo = 0;
            bool valor;
            double retorno = 0;


            for (i = 0; i < strNumero.Length; i++)
            {
                if (strNumero[i] == ',' && comas != 1)
                {
                    comas++;
                    continue;
                }

                if (strNumero[i] == '-' && negativo != 1)
                {
                    negativo++;
                    i++;
                    continue;
                }

                if (strNumero[i] < '0' || strNumero[i] > '9')
                {
                    flag = 0;
                    break;
                }

            }

            if (flag == 1)
            {
                valor = double.TryParse(strNumero, out retorno);
            }

            return retorno;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double resultado = 0;

            resultado = n1.numero - n2.numero;

            return resultado;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double resultado = 0;

            resultado = n1.numero + n2.numero;

            return resultado;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double resultado = 0;

            resultado = n1.numero * n2.numero;

            return resultado;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double resultado = 0;

            resultado = n1.numero / n2.numero;

            return resultado;
        }

        public string DecimalBinario(double numero)
        {
            string cadena = "";
            int auxNum = (int)numero;

            if (auxNum > 0)
            {
                while(auxNum > 0)
                {
                    if(auxNum % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }

                    auxNum = auxNum / 2;
                }
            }
            else
            {
                cadena = "VALOR INVALIDO";
            }

            return cadena;
        }

        public string DecimalBinario(string numero)
        {
            string cadena = "";
            int.TryParse(numero, out int auxNum);

            if (auxNum > 0)
            {
                while (auxNum > 0)
                {
                    if (auxNum % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }

                    auxNum = auxNum / 2;
                }
            }
            else
            {
                cadena = "VALOR INVALIDO";
            }

            return cadena;
        }

        public string BinarioDecimal(string binario)
        {
            string cadena = "";
            int flag = 1;
            double cantPotencia = 0;
            double resultado = 0;
            int i;

            for(i = binario.Length -1; i >= 0; i--)
            {
                if(binario[i] == '0')
                {
                    cantPotencia++;
                }
                else if(binario[i] == '1')
                {
                    resultado = resultado + (Math.Pow(2, cantPotencia)*1);
                    cantPotencia++;
                }
                else
                {
                    cadena = "VALOR INVALIDO";
                    flag = 0;
                    break;
                }

                if(flag == 1)
                {
                    cadena = Convert.ToString(resultado);
                }
            }

            return cadena;

        }
    }
}
