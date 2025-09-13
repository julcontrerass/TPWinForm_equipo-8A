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

                //datos.setearConsulta("select A.id idArticulo, A.Codigo, A.Nombre, A.descripcion descArticulo, A.Precio, A.IdMarca, A.IdCategoria, M.Id codigoMarca, M.Descripcion descMarca, C.Id codigoCategoria, C.Descripcion descCategoria,(select top 1 I.ImagenUrl FROM IMAGENES I WHERE A.Id = I.IdArticulo) AS URLImagen from ARTICULOS A, MARCAS M, CATEGORIAS C where M.id = A.idMarca and C.id = A.IdCategoria");
                datos.setearConsulta("select A.id idArticulo,A.Codigo,A.Nombre,A.descripcion descArticulo,A.Precio,A.IdMarca,A.IdCategoria,M.Id codigoMarca,M.Descripcion descMarca,C.Id codigoCategoria,C.Descripcion descCategoria,I.ImagenUrl URLImagen, I.Id idImagen from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I where M.id = A.idMarca and C.id = A.IdCategoria and A.Id = I.IdArticulo");
                datos.ejecutarLectura();

                int? prodAnterior = null;


                while (datos.Lector.Read())
                { 

                    int idProductoActual = (int)datos.Lector["idArticulo"];
                    string URL = (string)datos.Lector["URLImagen"];
                    int idImagen = (int)datos.Lector["idImagen"];

                    if (idProductoActual == prodAnterior)
                    {
                        Imagen imagen = new Imagen();
                        imagen.IdImagen = idImagen;
                        imagen.URL = URL;
                        imagen.IdArticulo = idProductoActual;
                        lista.Last().URLImagenes.Add(imagen);                        
                    }
                    else
                    {
                        //Articulo:
                        Articulo aux = new Articulo();
                        aux.id = idProductoActual;
                        aux.codigoArticulo = (string)datos.Lector["Codigo"];
                        aux.nombre = (string)datos.Lector["Nombre"];
                        aux.descripcion = (string)datos.Lector["descArticulo"];
                        aux.idMarca = (int)datos.Lector["idMarca"];
                        aux.idCategoria = (int)datos.Lector["idCategoria"];
                        aux.precio = (decimal)datos.Lector["Precio"];
                        //Imagen:
                        Imagen imagen = new Imagen();
                        imagen.IdImagen = idImagen;
                        imagen.URL = URL;
                        imagen.IdArticulo = idProductoActual;
                        aux.URLImagenes.Add(imagen);
                        //Marca:
                        aux.Marca = new Marca();
                        aux.Marca.id = (int)datos.Lector["codigoMarca"];
                        aux.Marca.descripcion = (string)datos.Lector["descMarca"];
                        //Categoria:
                        aux.Categoria = new Categoria();
                        aux.Categoria.id = (int)datos.Lector["codigoCategoria"];
                        aux.Categoria.descripcion = (string)datos.Lector["descCategoria"];
                        lista.Add(aux);
                    }
                    prodAnterior = idProductoActual;                    
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void CargarImagen(string url) {
        
            // este metodo esta resuelto mostrando las imagenes desde el formulario gestordearticulo. Los string de las url ya estan en la tabla de listado de productos inicial

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
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES ('"+ nuevo.codigoArticulo + "','"+ nuevo.nombre + "','"+ nuevo.descripcion + "',"+ nuevo.Marca + ","+ nuevo.Categoria + ","+ nuevo.precio.ToString(System.Globalization.CultureInfo.InvariantCulture) + ")");
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
