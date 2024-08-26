using Dominio;
using NegocioDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioDatos
{
    public class UsuarioNegocio
    {
        public void Actualizar(Usuario user)
        {
                AccesoDatos datos=new AccesoDatos();
            try
            {
                datos.setearConsulta("Update USERS set urlImagenPerfil=@imagen, nombre=@nombre, apellido=@apellido  Where Id=@id");
                datos.setearParametros("@imagen",user.imagenPerfil);
                datos.setearParametros("@id",user.Id);
                datos.setearParametros("@nombre",user.Nombre);
                datos.setearParametros("@apellido",user.Apellido);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }

        public int insertarNuevo(Usuario user)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "insert into USERS (email,pass,admin) output inserted.Id values (@email, @pass, 0)";
            try
            {
                datos.setearConsulta(consulta);
                datos.setearParametros("@email", user.Email);
                datos.setearParametros("@pass", user.Pass);
                return datos.ejecutarAccionScalar();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }

        public bool Login(Usuario user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id, email, pass, admin, urlImagenPerfil, nombre, apellido from USERS Where email=@email And pass=@pass");
                datos.setearParametros("@email",user.Email);
                datos.setearParametros("@pass", user.Pass);
                //datos.setearParametros("@nombre",user.Nombre);
                //datos.setearParametros("@apellido",user.Apellido);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    user.Id = (int)datos.Lector["Id"];
                    user.Admin = (bool)datos.Lector["admin"];
                    if (!(datos.Lector["urlImagenPerfil"] is DBNull))
                        user.imagenPerfil = (string)datos.Lector["urlImagenPerfil"];
                    if (!(datos.Lector["nombre"]is DBNull))
                        user.Nombre = (string)datos.Lector["nombre"];
                    if (!(datos.Lector["apellido"] is DBNull))
                        user.Apellido = (string)datos.Lector["apellido"];

                    return true;
                }
                return false;
            
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

    }


}
