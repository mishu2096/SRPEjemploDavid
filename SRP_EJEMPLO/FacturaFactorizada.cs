using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    class FacturaFactorizada
    {
        public string Codigo { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal ImporteFactura { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal ImporteDeduccion { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal PorcentajeDeduccion { get; set; }


        public void CalcularTotal()
        {

            Deduccion deduccion = new Deduccion(PorcentajeDeduccion);
            ImporteDeduccion = deduccion.CalcularDeduccion(ImporteFactura);

            Iva iva = new Iva();
            ImporteIVA = iva.CalcularIVA(ImporteFactura);

            ImporteTotal = (ImporteFactura - ImporteDeduccion) + ImporteIVA;
        }
    }
}