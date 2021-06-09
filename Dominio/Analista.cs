using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public sealed class Analista : Empregado 
    {
        private const double _bonus = 1.4;

        public Analista(string nome, double salario) : base(nome, salario)
        {
        }

        public override double CalcularSalarioBonificado()
        {
            return Salario * _bonus;
        }
    }
}
