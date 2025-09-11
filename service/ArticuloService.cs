using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace service
{
    public class ArticuloService
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("select A.id idArticulo, codigo, nombre, A.descripcion descArticulo, Precio, idMarca, idCategoria, M.Id codigoMarca,M.Descripcion descMarca, C.Id codigoCategoria, C.Descripcion descCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C  where M.id = idMarca and C.id = IdMarca");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["idArticulo"];
                    aux.codigoArticulo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["descArticulo"];
                    aux.idMarca = (int)datos.Lector["idMarca"];
                    aux.idCategoria = (int)datos.Lector["idCategoria"];
                    aux.precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.id = (int)datos.Lector["codigoMarca"];
                    aux.Marca.descripcion = (string)datos.Lector["descMarca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.id = (int)datos.Lector["codigoCategoria"];
                    aux.Categoria.descripcion = (string)datos.Lector["descCategoria"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
