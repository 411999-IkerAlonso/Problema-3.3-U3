using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3._3
{
    public class Cuenta
    {
        public int Numero {  get; set; }
        public int Tipo { get; set; }
        public double Saldo { get; set; }
        public Cliente Cliente { get; set; }

        public Cuenta() 
        {
        Numero = 0;
        Tipo = 1;
        Saldo = 0.0;
        Cliente = new Cliente();    
        }

        public Cuenta(int numero, int tipo, double saldo, Cliente cliente)
        {
            Numero = numero;
            Tipo = tipo;
            Saldo = saldo;
            Cliente = cliente;
        }

        public override string ToString()
        {
            return $"|Numero de Cuenta: {Numero} |Tipo Cuenta: {Tipo} |Saldo: {Saldo} |Cliente: {Cliente.ToString()}";
        }
    }
}
