using Microsoft.AspNetCore.Identity;

namespace ControleFinenceiro.BLL.Models
{
    public class Funcao : IdentityRole<string>
    {
        public string Descricao { get; set; }
    }
}
