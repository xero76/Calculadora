﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    internal class Operaciones
    {
        public double Sumar(Double ValorA, Double ValorB)
        {
            Double suma = 0;
            suma = ValorA + ValorB;
            return suma;
        }
        public double Restar(Double ValorA, Double ValorB)
        {
            Double resta = 0;
            resta = ValorA - ValorB;
            return resta;
        }

        public double Multiplicar(Double ValorA, Double ValorB)
        {
            Double multiplicacion = 0;
            multiplicacion = ValorA * ValorB;
            return multiplicacion;
        }

        public double Dividir(Double ValorA, Double ValorB)
        {
            Double division = 0;
            division = ValorA / ValorB;
            return (division);
        }
    }
}
