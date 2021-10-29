using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    static class Facade
    {
        public static double DividirDosNumeros(double pNumero1, double pNumero2)
        {
            return Matematica.Dividir(pNumero1, pNumero2);
        }
    }
}
