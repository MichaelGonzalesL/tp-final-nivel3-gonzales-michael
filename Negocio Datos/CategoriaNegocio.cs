using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using NegocioDatos;

namespace NegocioDatos
{
    public class CategoriaNegocio
    {

        public List<Tipo> Listar()
        {
			List<Tipo> listaCategoria = new List<Tipo>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Tipo categoria = new Tipo();
					categoria.Id = (int)datos.Lector["Id"];
					categoria.Descripcion = (string)datos.Lector["Descripcion"];

					listaCategoria.Add(categoria);
				}


				return listaCategoria;
			}
			catch (Exception ex)
			{
				
				throw ex;
			}
			finally { datos.cerrarConexion(); }
        }




    }
}
