using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegocioDatos;
using Dominio;

namespace TPFinalNivel3_GonzalesMichael
{
    public partial class ListadoDeArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Seguridad.esAdmin(Session["usuarioActivo"])))
            {
                Session.Add("error", "Necesita permisos admin");
                Response.Redirect("error.aspx",false);
            }

            List<Articulos> articulos = new List<Articulos>();
            ArticulosNegocio negocio = new ArticulosNegocio();
            //articulos = negocio.Listar();
            Session.Add("listaArticulos", negocio.Listar());
            dgvArticulos.DataSource = Session["listaArticulos"];
            dgvArticulos.DataBind();
        }

        protected void dgvArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvArticulos.SelectedDataKey.Value.ToString();
            Session.Add("idLista", id);
            Response.Redirect("Detalles.aspx", false);

        }

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> lista = (List<Articulos>)Session["listaArticulos"];
            List<Articulos> listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));
            dgvArticulos.DataSource=listaFiltrada;
            ddlPrecio.SelectedIndex= 0;
            dgvArticulos.DataBind();
        }

        protected void ddlPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            List<Articulos> listaNueva;
            if (ddlPrecio.SelectedItem.ToString()=="Mayor a menor")
            {
                listaNueva = ((List<Articulos>)Session["listaArticulos"]).OrderByDescending(x=>x.Precio).ToList();    
            }
            else if(ddlPrecio.SelectedItem.ToString()=="Menor a mayor"){
                listaNueva = ((List<Articulos>)Session["listaArticulos"]).OrderBy(x=>x.Precio).ToList();
            }
            else
            {
                listaNueva = (List<Articulos>)Session["listaArticulos"];
            }
            dgvArticulos.DataSource= null;
            dgvArticulos.DataSource=listaNueva;
            dgvArticulos.DataBind();
        }
 
    }
}