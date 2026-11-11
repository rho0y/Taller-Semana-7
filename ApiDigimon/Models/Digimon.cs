using System.ComponentModel.DataAnnotations;

namespace ApiDigimon.Models
{
    public class Digimon
    {
        [Key]
        public int DigimonId { get; set; }
        public string Nombre { get; set; }
        public string Etapa { get; set; }
    }
}