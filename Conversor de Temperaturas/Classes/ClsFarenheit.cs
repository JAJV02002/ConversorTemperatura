using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Temperaturas.Classes
{
    class ClsFarenheit
    {
        public double Farenheit(double a)
        {
            double F;
            F = (a * (9/5)) + 32;
            return F;
        }
    }
}
