namespace Calculadora
{
    public class ControladorCalculadora
    {
        private LogicaCalculadora logica = new LogicaCalculadora();
        private bool primerNumeroAsignado = false;
        public double PrimerNumero { get; set; }
        public double UltimoNumero { get; set; }
        public string OperadorActual { get; set; }
        public string UltimoOperador { get; set; }
        public string UltimaOperacion { get; set; }
        public bool EstaEscribiendoNumero { get; set; }

        public string ProcesarOperador(double numeroActual, string operador)
        {
            if (!primerNumeroAsignado)
            {
                PrimerNumero = numeroActual;
                primerNumeroAsignado = true;
            }
            else if (OperadorActual != null)
            {
                PrimerNumero = logica.Ejecutar(PrimerNumero, numeroActual, OperadorActual);
            }
            OperadorActual = operador;
            EstaEscribiendoNumero = false;
            UltimaOperacion = $"{PrimerNumero} {OperadorActual}";
            return UltimaOperacion;

        }

        public double ProcesarIgual(double numeroActual)
        {
            double resultado;

            if (primerNumeroAsignado && OperadorActual != null)
            {
                resultado = logica.Ejecutar(PrimerNumero, numeroActual, OperadorActual);
                UltimoNumero = numeroActual;
                UltimoOperador = OperadorActual;
                PrimerNumero = resultado;
                OperadorActual = null;
                EstaEscribiendoNumero = false;
            }
            else if (UltimoOperador != null)
            {
                resultado = logica.Ejecutar(PrimerNumero, UltimoNumero, UltimoOperador);
                PrimerNumero = resultado;
            }
            else
            {
                resultado = numeroActual;
            }

            UltimaOperacion = $"{PrimerNumero} {OperadorActual ?? ""} {numeroActual}";
            return resultado;

        }

        public void Reset()
        {
            PrimerNumero = 0;
            OperadorActual = null;
            UltimoNumero = 0;
            UltimoOperador = null;
            EstaEscribiendoNumero = false;
            primerNumeroAsignado = false;
        }

        public string AgregarNumero(string displayActual, string numero)
        {
            if (!EstaEscribiendoNumero || displayActual == "0")
                displayActual = numero;
            else
                displayActual += numero;

            EstaEscribiendoNumero = true;
            return displayActual;
        }
    }
}
