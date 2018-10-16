using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoProva
{
    class Imc
    {
        private double peso;
        private double altura;

        public Imc()
        {
            this.peso = 0.0;
            this.altura = 0.0;
        }

        public Imc (double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public double calcular (double peso, double altura)
        {
            return peso/ (altura*altura));
        }

        public double classificar()
        {
            return 0;
        }
    }
}
