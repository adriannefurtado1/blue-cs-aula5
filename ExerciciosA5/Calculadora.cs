using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosA5
{
    internal class Calculadora
    {
        public double Multiplicacao(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero*SegundoNumero;
        }

        public double Divisao(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero / SegundoNumero;
        }

        public double Subtracao(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero - SegundoNumero;
        }

        public double Soma(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero + SegundoNumero;
        }
    }
}
