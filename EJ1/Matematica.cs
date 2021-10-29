using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    static class Matematica
    {
        public static double Dividir(double pDividendo, double pDivisor)
        {
            if(pDivisor != 0)
            {
                return pDividendo / pDivisor;
            }
            else
            {
                throw new DivisionPorCeroException("Se ha intentado dividir por cero");
            }
        }
    }
}
