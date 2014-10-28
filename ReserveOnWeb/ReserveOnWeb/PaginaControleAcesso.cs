using ReserveOnWeb.ReserveOnService;
using System;
using System.Collections.Generic;
using System.Web;

namespace ReserveOnWeb
{
    public class PaginaControleAcesso : System.Web.UI.Page
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

        protected override void OnPreInit(EventArgs e)
        {
            String pagina = Request.Url.Segments[Request.Url.Segments.Length - 1];
        }
    }
}