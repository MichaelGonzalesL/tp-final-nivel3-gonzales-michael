using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using NegocioDatos;

namespace TPFinalNivel3_GonzalesMichael
{
    public partial class error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["error"] == null))
            {
                string mensaje = Session["error"].ToString();
                lblError.Text = mensaje;
                if(string.Compare(mensaje, "User o Pass incorrectos")==0)
                {
                    btnErrorLoguearse.Visible = true;
                }
            }
        }

        protected void btnErrorLoguearse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx",false);
        }
    }
}