using System;
using System.Collections.Generic;
using System.Text;

namespace hello_word{
    public class Calculadora{
        public double n1;
        public double n2;
        public double resultado;
        public double resultadof = 1;
        public double somar(double n1, double n2) {
            resultado = n1 + n2;
            return resultado;
        }
        public double subtrair(double n1, double n2) {
            resultado = n1 - n2;
            return resultado;
        }
        public double multiplicar(double n1, double n2) {
            resultado = n1 * n2;
            return resultado;
        }
        public double dividir(double n1, double n2) {
            resultado = n1 / n2;
            return resultado;
        }
        public double Fatorial(double n1) {
            resultado = 1;
            for (int i = 1; i<=n1; i++) {
                resultado = resultado * i;
            }
            return resultado;
        }
    }
}
