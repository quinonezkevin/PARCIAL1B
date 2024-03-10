using System.ComponentModel.DataAnnotations;

namespace PARCIAL1B.Models
{
    public class PlatosPorCombo
    {

        [Key]

        public int PlatosPorComboId { get; set; }
        public int EmpresaID { get; set; }
        public int ComboiD { get; set; }
        public int PlatoID { get; set; }
        public string Estado { get; set; }
    }
}
