using ReserveOnWeb.ReserveOnService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReserveOnWeb
{
    public partial class Cadastro : PaginaControleAcesso
    {
        private bool UsuarioValido
        {
            get
            {
                try
                {
                    return (bool)ViewState["UsuarioValido"];
                }
                catch
                {
                    return false;
                }
            }
            set
            {
                ViewState["UsuarioValido"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtConfSenha.Text) && UsuarioValido)
            {
                PessoaEntity pessoa = new PessoaEntity();
                pessoa.Usuario = new UsuarioEntity();
                pessoa.Usuario.Perfil = new PerfilEntity();
                Service1 srv = new Service1();

                pessoa.Usuario.Login = txtUsuario.Text;
                pessoa.Usuario.Senha = txtSenha.Text;
                pessoa.Usuario.Perfil.Id = 1;
                pessoa.Usuario.Perfil.Descricao = "teste";
                pessoa.EnderecoEmail = txtEmail.Text;
                pessoa.NumeroTelefone = txtTelefone.Text;
                pessoa.Nome = txtNome.Text;
                pessoa.NumeroCpf = txtCpf.Text;
                pessoa.NumeroRg = txtRg.Text;

                bool result1, result2;
                srv.InsereClienteUsuario(pessoa, out result1, out result2);
                sPessoa = srv.AutenticarUsuario(pessoa.Usuario);

                System.Web.HttpContext.Current.Response.Redirect(@"~\\Default.aspx");
                
            }
            else
            {
                Response.Write("<script>alert('Favor conferir os campos destacados para dar continuidade no cadastro.');</script>");
            }
        }

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            txtUsuario.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            Service1 srv = new Service1();
            UsuarioEntity usr = new UsuarioEntity()
            {
                Login = txtUsuario.Text.Trim()
            };

            bool result1, result2;
            srv.ExisteUsuario(usr, out result1, out result2);

            if (result1)
            {
                txtUsuario.BackColor = ColorTranslator.FromHtml("#FFFFCC");
                txtUsuario.Focus();
                Response.Write("<script>alert('Usuário já existente.');</script>");

                UsuarioValido = false;
            }
            else
            {
                UsuarioValido = true;
            }
            btnCadastrar.Enabled = true;
        }
    }
}