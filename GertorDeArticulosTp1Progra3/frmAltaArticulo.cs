using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using service;
using static System.Net.Mime.MediaTypeNames;

namespace GertorDeArticulosTp1Progra3
{
    public partial class frmAltaArticulo : Form
    {

        private Articulo articulo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloService articuloService = new ArticuloService();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.codigoArticulo = txbCodigoAIngresar.Text;
                articulo.nombre = txbNombreAIngresar.Text;
                articulo.descripcion = txbDescripcionAIngresar.Text;
                articulo.precio = decimal.Parse(txbPrecioAIngresar.Text);
                articulo.idMarca = (int)cbxMarca.SelectedValue;
                articulo.idCategoria = (int)cbxCategoria.SelectedValue;

                // Asegurar que Imagen no sea null y setear URL
                articulo.Imagen = new Imagen();
                articulo.Imagen.URL = txbUrlImagen.Text?.Trim();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                if (articulo.id != 0)
                {
                    articuloService.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    articuloService.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaService marca = new MarcaService();
                List<Marca> listaMarcas = marca.Listar();
                cbxMarca.DataSource = listaMarcas;
                cbxMarca.DisplayMember = "descripcion";
                cbxMarca.ValueMember = "id";

                CategoriaService categoria = new CategoriaService();
                List<Categoria> listaCategorias = categoria.Listar();
                cbxCategoria.DataSource = listaCategorias;
                cbxCategoria.DisplayMember = "descripcion";
                cbxCategoria.ValueMember = "id";

                if (articulo != null)
                {
                    lblTituloNuevoArticulo.Text = "Editar articulo";

                    txbCodigoAIngresar.Text = articulo.codigoArticulo;
                    txbNombreAIngresar.Text = articulo.nombre;
                    txbDescripcionAIngresar.Text = articulo.descripcion;
                    txbPrecioAIngresar.Text = articulo.precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
