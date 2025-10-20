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
                case "mod":
                // TODO: mod
                case "fact(":
                // TODO: factorial
                default:
                    return b;
            }
        }
    }
}
