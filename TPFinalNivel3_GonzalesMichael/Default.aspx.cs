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

    public partial class Default : System.Web.UI.Page
    {
        
        public List<Articulos> listArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            listArticulos = negocio.Listar();
            
        }

        
    }
}