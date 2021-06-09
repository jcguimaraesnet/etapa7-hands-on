using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Vendedor : Empregado
    {
        private const double _bonus = 1.7;

        public Vendedor(string nome, double salario) : base(nome, salario)
        {
        }

        public override double CalcularSalarioBonificado()
        {
            return Salario * _bonus;
        }
    }
}
