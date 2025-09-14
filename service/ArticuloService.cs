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
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();

            try
            {

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

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
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

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio where id = @id");
                datos.setearParametro("@codigo", articulo.codigoArticulo);
                datos.setearParametro("@nombre", articulo.nombre);
                datos.setearParametro("@descripcion", articulo.descripcion);
                datos.setearParametro("@idMarca", articulo.idMarca);
                datos.setearParametro("@idCategoria", articulo.idCategoria);
                datos.setearParametro("@precio", articulo.precio);
                datos.setearParametro("@id", articulo.id);
                datos.ejecutarAccion();
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

        public List<Articulo> filtroAvanzado(string marca, string categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            List<Articulo> listaFiltrada = new List<Articulo>();

            bool hayFiltroMarca = marca != "";
            bool hayFiltroCategoria = categoria != "";
            string consulta; 

            if(hayFiltroMarca && hayFiltroCategoria)
            {
                consulta = "select A.id idArticulo, A.Codigo, A.Nombre, A.descripcion descArticulo, A.Precio, A.IdMarca, A.IdCategoria, M.Id codigoMarca, M.Descripcion descMarca, C.Id codigoCategoria, C.Descripcion descCategoria,I.ImagenUrl URLImagen, I.Id idImagen from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I where M.id = A.idMarca and C.id = A.IdCategoria and A.Id = I.IdArticulo and C.Descripcion = @categoria and M.Descripcion= @marca";

                datos.setearConsulta(consulta);
                datos.setearParametro("@categoria", categoria);
                datos.setearParametro("@marca", marca);
            }
            else if (hayFiltroMarca)
            {
                consulta = "select A.id idArticulo, A.Codigo, A.Nombre, A.descripcion descArticulo, A.Precio, A.IdMarca, A.IdCategoria, M.Id codigoMarca, M.Descripcion descMarca, C.Id codigoCategoria, C.Descripcion descCategoria,I.ImagenUrl URLImagen, I.Id idImagen from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I where M.id = A.idMarca and C.id = A.IdCategoria and A.Id = I.IdArticulo and M.Descripcion = @marca";
                datos.setearConsulta(consulta);
                datos.setearParametro("@marca", marca);

            }
            else
            {
                consulta = "select A.id idArticulo, A.Codigo, A.Nombre, A.descripcion descArticulo, A.Precio, A.IdMarca, A.IdCategoria, M.Id codigoMarca, M.Descripcion descMarca, C.Id codigoCategoria, C.Descripcion descCategoria,I.ImagenUrl URLImagen, I.Id idImagen from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I where M.id = A.idMarca and C.id = A.IdCategoria and A.Id = I.IdArticulo and C.Descripcion = @categoria";
                datos.setearConsulta(consulta);
                datos.setearParametro("@categoria", categoria);

            }


            try
                {

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
                            listaFiltrada.Last().URLImagenes.Add(imagen);
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
                            listaFiltrada.Add(aux);
                        }
                        prodAnterior = idProductoActual;
                    }

                    return listaFiltrada;
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
    }
}
