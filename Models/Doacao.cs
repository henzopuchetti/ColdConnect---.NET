using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColdConnectApp.Models
{
    public class Doacao
    {
        public int Id { get; set; }

        [Required]
        public string Tipo { get; set; }

        public int Quantidade { get; set; }

        [ForeignKey("Abrigo")]
        public int AbrigoId { get; set; }
        public Abrigo Abrigo { get; set; }
    }
}
