using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    class Iva
        {
            private const decimal IvaNormal = 0.12m;
            public decimal PorcentajeIva
        {
                get
                {
                    return IvaNormal;
                }
            }

            public decimal CalcularIVA(decimal importe)
            {
                return importe * IvaNormal;
            }
        }
    }
}
