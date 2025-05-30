using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColdConnectApp.Models
{
    public class Abrigo
    {
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }
        
        public string Endereco { get; set; }
        
        public ICollection<Doacao> Doacoes { get; set; }
    }
}
