using ReserveOnWeb.ReserveOnService;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReserveOnWeb
{
    public partial class ReserveOn : System.Web.UI.MasterPage
    {
        public PessoaEntity sPessoa
        {
            get
            {
                try
                {
                    return (PessoaEntity)Session["sUsuario"];
                }
                catch
                {
                    return null;
                }
            }
            set
            {
                Session["sUsuario"] = value;
            }
        }

        protected String LoginLogout
        {
            get
            {
                try
                {
                    return Session["LoginLogout"].ToString();
                }
                catch
                {
                    return "Log in";
                }
            }
            set
            {
                Session["LoginLogout"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ControleAcesso();
        }


        private void ControleAcesso()
        {
            if (sPessoa == null)
            {
                liLogin.Visible = true;
                liCadastro.Visible = true;
                lblSejaBemVindo.Text = "";
                lblSejaBemVindo.Visible = false;
                LoginLogout = "Log in";
                lkbFCadastro.Visible = true;
            }
            else
            {
                liLogin.Visible = false;
                liCadastro.Visible = false;
                lblSejaBemVindo.Text = "Seja bem vindo " + sPessoa.Nome;
                lblSejaBemVindo.Visible = true;
                LoginLogout = "Log out";
                lkbFCadastro.Visible = false;
            }
        }

        protected void lkbHome_Click(object sender, EventArgs e)
        {
            System.Web.HttpContext.Current.Response.Redirect(@"~\\Default.aspx");
        }

        protected void lkbLogin_Click(object sender, EventArgs e)
        {
            System.Web.HttpContext.Current.Response.Redirect(@"~\\Login.aspx");
        }

        protected void lkbCadastro_Click(object sender, EventArgs e)
        {
            System.Web.HttpContext.Current.Response.Redirect(@"~\\Cadastro.aspx");
        }

        protected void lkbLoginLogout_Click(object sender, EventArgs e)
        {
            System.Web.HttpContext.Current.Response.Redirect(@"~\\Login.aspx");
        }
    }
}