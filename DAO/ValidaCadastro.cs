using CadastroClienteFullStack.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroClienteFullStack.DAO
{
    public class ValidaCadastro
    {
        public static bool Cadastrar(DadosCliente dadosCliente)
        {
            try
            {
                using (var conexão = new Model1())
                {
                    conexão.dadosClientes.Add(dadosCliente);
                    conexão.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}