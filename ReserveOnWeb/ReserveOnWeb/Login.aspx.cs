using ReserveOnWeb.ReserveOnService;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReserveOnWeb
{
    public partial class Login : PaginaControleAcesso
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sPessoa = null;
            Service1 srv = new Service1();
            Boolean t1, t2;
            srv.TesteConexao(out t1, out t2);
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioEntity usr = new UsuarioEntity();
            usr.Login = txtLogin.Text;
            usr.Senha = txtSenha.Text;

            Service1 srv = new Service1();
            sPessoa = srv.AutenticarUsuario(usr);
            if (sPessoa != null)
                System.Web.HttpContext.Current.Response.Redirect(@"~\\Default.aspx");
            else
                Response.Write("<script>alert('Login ou senha incorretos.');</script>");
        }
    }
}