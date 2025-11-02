using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmacenPF.Models
{
    [Table("DetalleFacturas")]
    public class DetalleFactura
    {
        [Key]
        public int IdDetalleFactura { get; set; }

        public int IdFactura { get; set; }
        public Factura Factura { get; set; }

        public int IdArticulo { get; set; }
        public Articulo Articulo { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
