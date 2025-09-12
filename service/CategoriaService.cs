using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class CategoriaService
    {
        public List<dominio.Categoria> Listar()
        {
            List<dominio.Categoria> lista = new List<dominio.Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion FROM CATEGORIAS;");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    dominio.Categoria aux = new dominio.Categoria();
                    aux.id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
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
