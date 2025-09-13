using dominio;
using service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GertorDeArticulosTp1Progra3
{
    public partial class GertorDeArticulos : Form
    {
        public GertorDeArticulos()
        {
            InitializeComponent();
        }

        private void GertorDeArticulos_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();

        }

        private void cargarTabla()
        {
            ArticuloService service = new ArticuloService();
            dgvTablaArticulos.DataSource = service.Listar();
            dgvTablaArticulos.Columns["idCategoria"].Visible = false;
            dgvTablaArticulos.Columns["idMarca"].Visible = false;
            dgvTablaArticulos.Columns["URLImagen"].Visible = false;
            cargarImagen(pbImagenProducto, service.lista[0].URLImagen);
        }

        private void dgvTablaArticulos_SelectionChanged(object sender, EventArgs e)
        {

            string imagenArticuloActual = ((Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem).URLImagen;
            string imagenNoDisponible = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOZugSlXrDIB3SLtuip9ZDU1iJScEqfby_Q&s";
            
            try
            {
                cargarImagen(pbImagenProducto, imagenArticuloActual);

            }
            catch (Exception)
            {
                cargarImagen(pbImagenProducto,imagenNoDisponible);

            }
                
               
        }

        private void cargarImagen(PictureBox pb, string URL)
        {
            pb.Load(URL);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloService articuloService = new ArticuloService();
            Articulo seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;
                    articuloService.eliminar(seleccionado.id);
                    MessageBox.Show("Artículo eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if(dgvTablaArticulos.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún artículo seleccionado");
                return;
            }
            seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargarTabla();
        }
    }
}
