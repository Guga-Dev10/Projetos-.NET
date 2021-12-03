using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroClienteFullStack.Class
{
    public class DadosCliente
    {
        [Key]
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public string Sexo { get; set; }
        public string Password { get; set; }
    }
}