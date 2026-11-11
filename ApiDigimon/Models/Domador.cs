using System.ComponentModel.DataAnnotations;

namespace ApiDigimon.Models
{
    public class Domador
    {
        [Key]
        public int DomadorId { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}