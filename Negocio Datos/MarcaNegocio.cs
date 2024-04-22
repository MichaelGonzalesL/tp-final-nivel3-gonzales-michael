using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
//using NegocioDatos;

namespace NegocioDatos
{
    public class MarcaNegocio
    {
        private List<Sello> marcas = new List<Sello>();
        private AccesoDatos datos = new AccesoDatos();
        public List<Sello> Listar()

        {
            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Sello aux = new Sello();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    marcas.Add(aux);
                }
                return marcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }


    }
}
