using System;

namespace Dominio
{
    public abstract class Empregado
    {
        private const double _bonus = 1.3;

        public Empregado(string nome, double salario)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Salario = salario;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public void AlterarNome(string nome)
        {
            //if (dataNascimento < 18)
            //throw new Exception("Não é possível alterar o nome do empregado.");
            Nome = nome;
        }

        public abstract double CalcularSalarioBonificado();

        public override string ToString()
        {
            return $"{Nome} - {CalcularSalarioBonificado()}";
        }
    }
}
