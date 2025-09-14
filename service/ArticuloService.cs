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

        public void agregar(Articulo nuevo)
        {
            var datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                  "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                  "OUTPUT INSERTED.Id VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.codigoArticulo);
                datos.setearParametro("@Nombre", nuevo.nombre);
                datos.setearParametro("@Descripcion", nuevo.descripcion);
                datos.setearParametro("@IdMarca", nuevo.idMarca);
                datos.setearParametro("@IdCategoria", nuevo.idCategoria);
                datos.setearParametro("@Precio", nuevo.precio);

                int nuevoId = (int)datos.ejecutarScalar();

                datos.cerrarConexion();

                if (!string.IsNullOrWhiteSpace(nuevo.Imagen?.URL))
                {
                    var datosImg = new AccesoDatos();
                    try
                    {
                        datosImg.setearConsulta(
                            "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                        datosImg.setearParametro("@IdArticulo", nuevoId);
                        datosImg.setearParametro("@ImagenUrl", nuevo.Imagen.URL);
                        datosImg.ejecutarAccion();
                    }
                    finally
                    {
                        datosImg.cerrarConexion();
                    }
                }
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
                datos.setearConsulta("delete from ARTICULOS where Id = @Id");
                datos.setearParametro("@Id", id);
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

    }
}
