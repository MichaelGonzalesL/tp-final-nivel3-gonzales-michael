using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        public int Id { get; set; }
        [DisplayName("Codigo de Articulo")]
        public string CodArticulo { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public Sello Marca { get; set; }
        public Tipo Categoria { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }

    }
}
