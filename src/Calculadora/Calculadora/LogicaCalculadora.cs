using System;

namespace Calculadora
{
    public class LogicaCalculadora
    {
        public double Ejecutar(double a, double b, string operador)
        {
            switch (operador)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                case "^2":
                // TODO: Al cuadrado
                case "√":
                // TODO: Raiz cuadrada
                default:
                    return b;
            }
        }
    }
}
