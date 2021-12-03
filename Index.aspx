<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CadastroClienteFullStack.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Cadastro de Cliente</title>
    <link rel="stylesheet" href="style/Style.css" />
</head>
<body>
    <main class="conteiner">
        <h2>Cadastro</h2>
        <form id="form1" action="/index.aspx"
            runat="server" method="post" onsubmit="return validateForm()">
            <div class="input-field">
                <input type="text" runat="server" name="NomeCliente" id="NomeCliente"
                    placeholder="Entre com o Nome do Cliente" />
                <div class="underline"></div>
            </div>
            <div class="input-field">
                <input type="text" runat="server" name="EmailCliente" id="EmailCliente"
                    placeholder="Entre com o Email do Cliente" />
                <div class="underline"></div>
            </div>
            <div class="input-field">
                <input type="text" runat="server" name="CNPJCliente" id="CNPJCliente"
                    placeholder="Entre com o CNPJ do Cliente" />
                <div class="underline"></div>
            </div>
            <div class="input-field">
                <label for="sexo" runat="server" >Escolha o sexo:</label>
                <select runat="server" name="sexo" id="sexo">
                    <option value="Masculino">Masculino</option>
                    <option value="Feminino">Feminino</option>
                </select>
                <div class="underline"></div>
            </div>
            <div class="input-field">
                <input runat="server" type="password" name="Senha" id="Senha"
                    placeholder="Entre com a Senha do Cliente" />
                <div class="underline"></div>
            </div>
            <input runat="server" type="button" id="Botão" value="Cadastrar" />
        </form>
    </main>
    <script>

        function validateForm() {
            //var nome = form1.NomeCliente;
            var nome = document.getElementById("NomeCliente")
            //var email = form1.EmailCliente;
            var email = document.getElementById("EmailCliente");
            //var CNPJ = form1.CNPJCliente;
            var CNPJ = document.getElementById("CNPJCliente");

            var sexo = document.getElementById("sexo");
            //var senha = form1.Senha;
            var senha = document.getElementById("Senha");

            var construtorString = "Dados faltando nos campos = ";

            if (!nome.value || !email.value || !CNPJ.value || !sexo.value || !senha.value) {
                if (!nome.value) {
                    construtorString += "Nome";
                }
                if (!email.value) {
                    construtorString += ", Email";
                }
                if (!CNPJ.value) {
                    construtorString += ", CNPJ";
                }
                if (!sexo.value) {
                    construtorString += ", Sexo";
                }
                if (!senha.value) {
                    construtorString += ", Senha";
                }

                alert(construtorString)

                //impedir que a página recarregue quando faltar dados nos campos
                window.onbeforeunload = function () {
                    return " ";
                }
            }
        }
    </script>
</body>
</html>
