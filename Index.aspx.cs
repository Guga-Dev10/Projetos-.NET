using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CadastroClienteFullStack.Class;
using CadastroClienteFullStack.DAO;

namespace CadastroClienteFullStack
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private object novoAmigo;
        private object ltMensagem;

        protected override void OnInit(EventArgs e)
        {
            Botão.ServerClick += botão_Click;
        }
        private void botão_Click(object sender, EventArgs e)
        {
            var novoCadastro = new DadosCliente();
            novoCadastro.Nome = NomeCliente.Value;
            novoCadastro.Email = EmailCliente.Value;
            novoCadastro.CNPJ = CNPJCliente.Value;
            novoCadastro.Sexo = sexo.Value;
            novoCadastro.Password = Senha.Value;

            bool cadastrado = ValidaCadastro.Cadastrar(novoCadastro);

            //if (cadastrado)
            //{
            //    ltMensagem.Text = novoCadastro.Nome + " Foi cadastrado com sucesso.";
            //}
            //else
            //{
            //    ltMensagem.Text = novoCadastro.Nome + " NÂO foi cadastrado com sucesso.";

            //}
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack)
            //{
            //    var dados = Request.Form;
            //    string idNome = dados.AllKeys.Where(c => c.Contains("NomeCliente")).First().ToString();
            //    var nome = dados[idNome];
            //}
        }
    }
}