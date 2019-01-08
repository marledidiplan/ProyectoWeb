using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Articulo
    {
        [Key]
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Costo { get; set; }
        public int Ganancia { get; set; }
        public int Inventario { get; set; }

        public Articulo()
        {
            ArticuloId = 0;
            Descripcion = string.Empty;
            Precio = 0;
            Costo = 0;
            Ganancia = 0;
            Inventario = 0;
        }

    }
}
