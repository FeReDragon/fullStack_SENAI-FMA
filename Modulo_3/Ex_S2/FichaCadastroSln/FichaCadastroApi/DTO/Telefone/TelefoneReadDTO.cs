using System.ComponentModel.DataAnnotations;

namespace FichaCadastroApi.DTO.Telefone
{
    public class TelefoneReadDTO
    {
        public string Contato { get; set; }
        public bool Ativo { get; set; }
    }
}