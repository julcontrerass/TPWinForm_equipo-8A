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
        public List<Articulo> lista = new List<Articulo>();
        public List<Articulo> Listar()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                //datos.setearConsulta("select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS;");
                datos.setearConsulta("select ART.Id, ART.Codigo, ART.Nombre, ART.Descripcion, ART.IdMarca, ART.IdCategoria, ART.Precio,(SELECT TOP 1 IMG.ImagenUrl FROM IMAGENES AS IMG WHERE ART.Id = IMG.IdArticulo) AS ImagenUrl FROM ARTICULOS as ART");

                //select ART.Id, ART.Codigo, ART.Nombre, ART.Descripcion, ART.IdMarca, ART.IdCategoria, ART.Precio,(SELECT TOP 1 IMG.ImagenUrl FROM IMAGENES AS IMG WHERE ART.Id = IMG.IdArticulo) AS ImagenUrlFROM ARTICULOS as ART


                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["Id"];
                    aux.codigoArticulo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.marca = (int)datos.Lector["IDMarca"];
                    aux.categoria = (int)datos.Lector["IdCategoria"];
                    aux.precio = (decimal)datos.Lector["Precio"];
                    aux.URLImagen = (string)datos.Lector["ImagenUrl"];
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

        public void CargarImagen(string url)
        {

        }

        /*public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database= CATALOGO_P3_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS;";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = lector.GetInt32(0);
                    aux.codigoArticulo = (string)lector["Codigo"];
                    aux.nombre = (string)lector["Nombre"];
                    aux.descripcion = (string)lector["Descripcion"];
                    aux.marca = (Int32)lector["IDMarca"];
                    aux.categoria = (Int32)lector["IdCategoria"];
                    aux.precio = (decimal)lector["Precio"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception)
            {
                //   MessageBox.Show("Error al listar artículos: " + ex.Message);
            }
            return lista;

        }*/

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)values(" + nuevo.codigoArticulo + "," + nuevo.nombre + "," + nuevo.descripcion + ", " + nuevo.marca + "," + nuevo.categoria + ", " + nuevo.precio.ToString(System.Globalization.CultureInfo.InvariantCulture) + " )");
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES ('"+ nuevo.codigoArticulo + "','"+ nuevo.nombre + "','"+ nuevo.descripcion + "',"+ nuevo.marca + ","+ nuevo.categoria + ","+ nuevo.precio.ToString(System.Globalization.CultureInfo.InvariantCulture) + ")");
                datos.ejecutarAccion();
                



            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
