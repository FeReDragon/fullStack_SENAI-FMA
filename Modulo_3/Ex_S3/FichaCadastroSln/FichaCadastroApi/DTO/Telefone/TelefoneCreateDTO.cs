using System.ComponentModel.DataAnnotations;

namespace FichaCadastroApi.DTO.Telefone
{
public class TelefoneCreateDTO
    {
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public bool Ativo { get; set; }
    }
}