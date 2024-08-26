using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegocioDatos;

namespace TPFinalNivel3_GonzalesMichael
{
    public partial class Master : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            //Usuario user1 = (Usuario)Session["usuarioActivo"];
            //Usuario user = Session["usuarioActivo"] != null ? (Usuario)Session["usuarioActivo"] : null;
            if (!(Page is Login || Page is Default || Page is Registro || Page is error))
            {
                if (!(Seguridad.sessionActiva(Session["usuarioActivo"])))
                {
                    Response.Redirect("Login.aspx", false);
                }

            }

            if ((Seguridad.sessionActiva(Session["usuarioActivo"])))
            {
                Usuario user = (Usuario)Session["usuarioActivo"];
                lblUser.Text = user.Email;
                if (!string.IsNullOrEmpty(user.imagenPerfil))
                    imgAvatar.ImageUrl = "~/Images/" + user.imagenPerfil.ToString();
            }
            else
                imgAvatar.ImageUrl = "https://st3.depositphotos.com/6672868/13701/v/450/depositphotos_137014128-stock-illustration-user-profile-icon.jpg";


        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx", false);
        }
    }
}