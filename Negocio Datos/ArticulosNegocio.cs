using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using static System.Net.Mime.MediaTypeNames;

namespace NegocioDatos
{
    public class ArticulosNegocio
    {


        public List<Articulos> Listar(string id = "")
        {
            List<Articulos>lista= new List<Articulos>();
            AccesoDatos datos= new AccesoDatos();

            try
            {
                string consulta = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M,CATEGORIAS C  where A.IdMarca=M.Id and A.IdCategoria=C.Id ";
                if (id != "")
                    consulta += " and A.Id= " + id;

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read()==true)
                {
                    Articulos articulo = new Articulos();
                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.CodArticulo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Marca = new Sello();
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Categoria = new Tipo();
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.Imagen = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(articulo);            
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void Agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)values(@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @imagen, @precio)";
                datos.setearConsulta(consulta);
                datos.setearParametros("@codigo",nuevo.CodArticulo);
                datos.setearParametros("@nombre", nuevo.Nombre);
                datos.setearParametros("@descripcion", nuevo.Descripcion);
                datos.setearParametros("@idMarca", nuevo.Marca.Id);
                datos.setearParametros("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@imagen", nuevo.Imagen);
                datos.setearParametros("@precio", nuevo.Precio);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }
        public void Modificar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo=@codigo, Nombre=@nombre, Descripcion=@descripcion, IdMarca=@idMarca, IdCategoria=@idCategoria, ImagenUrl=@imagen, Precio=@precio where Id=@id");
                datos.setearParametros("@codigo", nuevo.CodArticulo);
                datos.setearParametros("@nombre", nuevo.Nombre);
                datos.setearParametros("@descripcion", nuevo.Descripcion);
                datos.setearParametros("@idMarca", nuevo.Marca.Id);
                datos.setearParametros("idCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@imagen", nuevo.Imagen);
                datos.setearParametros("@precio", nuevo.Precio);
                datos.setearParametros("@id", nuevo.Id);


                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id = @id ");
                datos.setearParametros("@id",id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); };


        }

    }

}
