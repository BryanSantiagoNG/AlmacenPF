using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmacenPF.Models
{
    [Table("Articulos")]
    public class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }

        [MaxLength(50)]
        public string CodigoInterno { get; set; }

        [MaxLength(50)]
        public string CodigoBarras { get; set; }

        [MaxLength(200)]
        public string Descripcion { get; set; }

        [MaxLength(100)]
        public string Marca { get; set; }

        public int Cantidad { get; set; }

        [ForeignKey("Proveedor")]
        public int? IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }

        [ForeignKey("Distribuidor")]
        public int? IdDistribuidor { get; set; }
        public Distribuidor Distribuidor { get; set; }

        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}
