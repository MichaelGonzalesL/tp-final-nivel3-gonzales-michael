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
            List<Articulos>articulos = new List<Articulos>();
            ArticulosNegocio negocio = new ArticulosNegocio();
            articulos = negocio.Listar();
            dgvArticulos.DataSource = articulos;
            dgvArticulos.DataBind();
        }

        protected void dgvArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvArticulos.SelectedDataKey.Value.ToString();
            Session.Add("idLista",id);
            Response.Redirect("Detalles.aspx",false);

        }
    }
}