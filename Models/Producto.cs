using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proyectoasp.netmvc.Models
{
    public class Producto
    {
        private long id;
        private string titulo;
        private string descripcion;
        private string cantidadStock;

        [DisplayName("Id auto generado")]
        public long Id { get => id; set => id = value; }

        [DisplayName ("Titulo del producto")]
        [Required]

        public string Titulo { get => titulo; set => titulo = value; }

        [DisplayName("description")]
        [Required]
        [StringLength(100)]

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string CantidadStock { get => cantidadStock; set => cantidadStock = value; }
    }
}
