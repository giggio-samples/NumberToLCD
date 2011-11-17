using System;
using System.Collections.Generic;

namespace Digital
{
    public class Digitalizador
    {
        protected Dictionary<int, string> NumerosDigitalizados { get; set; }

        public Digitalizador()
        {
            NumerosDigitalizados = new Dictionary<int, string>();
            NumerosDigitalizados.Add(1, @"   
  |
  |");
            NumerosDigitalizados.Add(2, @" _ 
 _|
|_ ");
            NumerosDigitalizados.Add(3,
                                     @" _ 
 _|
 _|");
            NumerosDigitalizados.Add(4,
                                     @"   
|_|
  |");
            NumerosDigitalizados.Add(5,
                                     @" _ 
|_ 
 _|");
            NumerosDigitalizados.Add(6,
                                     @" _ 
|_ 
|_|");
            NumerosDigitalizados.Add(7,
                                     @" _ 
  |
  |");
            NumerosDigitalizados.Add(8,
                                     @" _ 
|_|
|_|");
            NumerosDigitalizados.Add(9,
                                     @" _ 
|_|
 _|");
            NumerosDigitalizados.Add(0,
                                     @" _ 
| |
|_|");
        }

        public string Digitalizar(int i)
        {
            if (i < 10)
            {
                var numero = NumerosDigitalizados[i];
                return numero;
            }
            var s = i.ToString();
            var retorno = NumerosDigitalizados[Convert.ToInt32(s.Substring(s.Length - 1, 1))];

            var restante = s.Substring(0, s.Length - 1);
            for (int j = restante.Length - 1; j > -1; j--)
            {
                var digito = restante[j];
                retorno = Reune2Numeros(NumerosDigitalizados[Convert.ToInt32(digito.ToString())], retorno);
            }
            return retorno;
        }

        public string Reune2Numeros(string a, string b)
        {
            var linhasA = a.Split(new char[] { '\r', '\n' });
            var linhasB = b.Split(new char[] { '\r', '\n' });
            var linhaUm = linhasA[0] + " " + linhasB[0];
            var linhaDois = linhasA[2] + " " + linhasB[2];
            var linhaTres = linhasA[4] + " " + linhasB[4];
            return linhaUm + "\r\n" + linhaDois + "\r\n" + linhaTres;
        }

    }
}