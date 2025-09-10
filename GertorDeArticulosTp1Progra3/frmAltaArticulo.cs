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
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            ArticuloService articuloService = new ArticuloService();
            try
            {
                nuevoArticulo.codigoArticulo = txbCodigoAIngresar.Text;
                nuevoArticulo.nombre = txbNombreAIngresar.Text;
                nuevoArticulo.descripcion = txbDescripcionAIngresar.Text;
                nuevoArticulo.marca = int.Parse(txbMarcaAIngresar.Text);
                nuevoArticulo.categoria = int.Parse(txbCategoriaAIngresar.Text);
                nuevoArticulo.precio = decimal.Parse(txbPrecioAIngresar.Text);
                articuloService.agregar(nuevoArticulo);
                MessageBox.Show("AGREGADO EXITOSAMENTE");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
