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
    public partial class Detalles : System.Web.UI.Page
    {
       // Articulos artDel;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                List<Tipo> listaCategoria = catNegocio.Listar();

                ddlCategoria.DataSource = listaCategoria;
                ddlCategoria.DataValueField = "Id";
                ddlCategoria.DataTextField = "Descripcion";
                ddlCategoria.DataBind();

                MarcaNegocio marNegocio = new MarcaNegocio();
                List<Sello> listaMarca = marNegocio.Listar();

                ddlMarca.DataSource = listaMarca;
                ddlMarca.DataValueField = "Id";
                ddlMarca.DataTextField = "Descripcion";
                ddlMarca.DataBind();

                if (Session["idLista"] != null)
                {
                    ArticulosNegocio negocio = new ArticulosNegocio();
                    //txtId.Text = Session["idLista"].ToString();
                    Articulos seleccionado = (negocio.Listar(Session["idLista"].ToString()))[0];
                    txtId.Text = seleccionado.Id.ToString();
                    txtCodArticulo.Text = seleccionado.CodArticulo.ToString();
                    txtNombre.Text = seleccionado.Nombre;
                    txtDescripcion.Text = seleccionado.Descripcion;
                    txtPrecio.Text = seleccionado.Precio.ToString();
                    txtImagen.Text = seleccionado.Imagen;

                    ddlMarca.SelectedValue = seleccionado.Marca.Id.ToString();
                    ddlCategoria.SelectedValue = seleccionado.Categoria.Id.ToString();

                    btnAgregar.Text = "Modificar";
                    btnAgregar.CssClass = "btn btn-success";
                    txtId.ReadOnly = true;
                    txtImagen_TextChanged(sender, e);
                }
            }


        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                Articulos art = new Articulos();
                art.CodArticulo = txtCodArticulo.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Nombre = txtNombre.Text;
                art.Imagen = txtImagen.Text;
                art.Precio = decimal.Parse(txtPrecio.Text);

                art.Categoria = new Tipo();
                art.Categoria.Id = int.Parse(ddlCategoria.SelectedValue);
                art.Marca = new Sello();
                art.Marca.Id = int.Parse(ddlMarca.SelectedValue);
                //Si esta cargada la session, cambia la accion del boton agregar a modificar
                if (Session["idLista"] != null)
                {
                    art.Id = int.Parse(txtId.Text);
                    negocio.Modificar(art);
                }
                else
                {
                    negocio.Agregar(art);
                }
                Response.Redirect("ListadoDeArticulos.aspx", false);

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
            finally { Session.Contents.Remove("idLista"); }
        }

        protected void txtImagen_TextChanged(object sender, EventArgs e)
        {
            imgArticulos.ImageUrl = txtImagen.Text;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Session.Contents.Remove("idLista");
            Response.Redirect("ListadoDeArticulos.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio= new ArticulosNegocio();

            negocio.Eliminar(int.Parse(Session["idLista"].ToString()));
            Session.Contents.Remove("idLista");
            Response.Redirect("ListadoDeArticulos.aspx",false);
        }
    }
}