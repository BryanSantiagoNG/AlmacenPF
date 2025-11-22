using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmacenPF.Models
{
    [Table("Facturas")]
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }

        public DateTime Fecha { get; set; }

        public int? IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }

        public decimal Total { get; set; }

        public ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}