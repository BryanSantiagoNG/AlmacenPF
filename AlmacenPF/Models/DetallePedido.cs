using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmacenPF.Models
{
    [Table("DetallePedidos")]
    public class DetallePedido
    {
        [Key]
        public int IdDetallePedido { get; set; }

        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }

        public int IdArticulo { get; set; }
        public Articulo Articulo { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
