using FichaCadastroApi.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FichaCadastroApi.Model
{
    [Table("Telefone")]
    public class TelefoneModel : RelacionalBase
    {
        [Required]
        public string Ddd { get; set; }

        [Required]
        public string Numero { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Required]
        public virtual FichaModel Ficha { get; set; }
    }
}
