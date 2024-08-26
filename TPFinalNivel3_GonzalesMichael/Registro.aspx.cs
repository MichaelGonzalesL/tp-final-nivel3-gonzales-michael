using Dominio;
using NegocioDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPFinalNivel3_GonzalesMichael
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user=new Usuario();
                UsuarioNegocio usuarioNuevo=new UsuarioNegocio();
                user.Email=txtEmail.Text;
                user.Pass=txtPass.Text;
                int id=usuarioNuevo.insertarNuevo(user);
                user.Id = id;

                Session.Add("usuarioActivo",user);
                Response.Redirect("Default.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error.aspx", ex.ToString());
                throw ex;
            } 
           

        }
    }
}