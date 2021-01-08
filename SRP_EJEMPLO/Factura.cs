using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Factura
    {
        public string Codigo { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal ImporteFactura { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal ImporteDeduccion { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal PorcentajeDeduccion { get; set; }


        // Método que calcula el total de la factura
        public void CalcularTotal()
        {
         
            ImporteDeduccion = (ImporteFactura * PorcentajeDeduccion) / 100;
        
            ImporteIVA = ImporteFactura * 0.12m;
  
            ImporteTotal = (ImporteFactura - ImporteDeduccion) + ImporteIVA;
        }
    }
}