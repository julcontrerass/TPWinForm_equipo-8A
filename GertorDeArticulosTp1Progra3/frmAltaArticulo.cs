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
            Text = "Editar Artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                if(articulo != null)
                {
                    txbCodigoAIngresar.Text = articulo.codigoArticulo;
                    txbNombreAIngresar.Text = articulo.nombre;
                    txbDescripcionAIngresar.Text = articulo.descripcion;
                    txbPrecioAIngresar.Text = articulo.precio.ToString();
                    //txbUrlImagen.Text = articulo.URLImagen;
                    lblCodigoAIgresar.Text = "Modificar Artículo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                //articulo.URLImagen = txbUrlImagen.Text;
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

        private void frmAltaArticulo_Load_1(object sender, EventArgs e)
        {
            try
            {
                if (articulo != null)
                {
                    txbCodigoAIngresar.Text = articulo.codigoArticulo;
                    txbNombreAIngresar.Text = articulo.nombre;
                    txbDescripcionAIngresar.Text = articulo.descripcion;
                    txbPrecioAIngresar.Text = articulo.precio.ToString();

                    //txbUrlImagen.Text = articulo.URLImagen;
                    //lblCodigoAIgresar.Text = "Modificar Artículo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
