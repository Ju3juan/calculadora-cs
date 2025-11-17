using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace calculadora_web_api.Models.WS.Historial
{
    public class Historial
    {
        public long Id { get; set; }
        public double Num1 { get; set; }
        public char Op { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }
    }
}