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
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Seguridad.sessionActiva(Session["usuarioActivo"]))
                    {

                        Usuario user = (Usuario)Session["usuarioActivo"];
                        txtNombre.Text = user.Nombre;
                        txtApellido.Text = user.Apellido;
                        txtId.Text = user.Id.ToString();
                        txtEmail.Text = user.Email;
                        txtEmail.ReadOnly = true;
                        txtId.ReadOnly = true;
                        if (!string.IsNullOrEmpty(user.imagenPerfil))
                            imgArticulos.ImageUrl = "~/Images/" + user.imagenPerfil;
                        btnAgregar.Text = "Actualizar";
                    }
                }


            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }


        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                UsuarioNegocio negocio = new UsuarioNegocio();
                Usuario user = (Usuario)Session["usuarioActivo"];
                if (txtImagen.PostedFile.FileName != "")
                {
                    string ruta = Server.MapPath("./Images/");
                    txtImagen.PostedFile.SaveAs(ruta + "perfil-" + user.Id + ".jpg");
                    user.imagenPerfil = "perfil-" + user.Id + ".jpg";
                }
                
                txtId.Text = user.Id.ToString();
                //txtEmail.Text = user.Email;
                user.Nombre = txtNombre.Text;
                user.Apellido= txtApellido.Text;
                

                negocio.Actualizar(user);
                ///leer la imagen.
                Image img = (Image)Master.FindControl("imgAvatar");
                img.ImageUrl = "~/Images/" + user.imagenPerfil;

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());

            }

        }
    }
}