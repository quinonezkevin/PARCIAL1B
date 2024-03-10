using System.ComponentModel.DataAnnotations;

namespace PARCIAL1B.Models
{
    public class Elementos
    {
        [Key]

        public int ElementoID { get; set; }
        public int EmpresaID { get; set; }
        public string Elemento { get; set; }
        public string CantidadMinima { get; set; }
        public string UnidadMinima { get; set; }
        public string Costo { get; set; }
        public string Estado { get; set; }
    }
}
