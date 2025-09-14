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
        private Articulo ArticuloActual { get; set; }
        private int indexImagenActual { get; set; }

        // Métodos de clase
        private void cargarTabla()
        {
            ArticuloService service = new ArticuloService();
            dgvTablaArticulos.DataSource = service.Listar();
            ArticuloActual = service.lista[0];
            dgvTablaArticulos.Columns["idCategoria"].Visible = false;
            dgvTablaArticulos.Columns["idMarca"].Visible = false;
            dgvTablaArticulos.Columns["imagen"].Visible = false;
            indexImagenActual = 0;
            labelimagenActual.Text = "Imagen " + (indexImagenActual+ 1).ToString() + " de " + ArticuloActual.URLImagenes.Count.ToString();
            cargarImagen(indexImagenActual);

            if(ArticuloActual.URLImagenes.Count < 2)
            {
                btnImagenSiguiente.Enabled = false;
                btnImagenAnterior.Enabled = false;
            }
        }
        private void cargarImagen(int nuevoIndex)
        {
            
            labelimagenActual.Text = "Imagen " + (indexImagenActual + 1).ToString() + " de " + ArticuloActual.URLImagenes.Count.ToString();
            string imagenBackup = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOZugSlXrDIB3SLtuip9ZDU1iJScEqfby_Q&s";
            string imagenArticuloActual = ArticuloActual.URLImagenes[nuevoIndex].URL;

            // Botones imagen anterior-siguiente:
            if (ArticuloActual.URLImagenes.Count < 2)
            {
                btnImagenAnterior.Enabled = false;
                btnImagenSiguiente.Enabled = false;
            }
            else
            {
                btnImagenAnterior.Visible = true;
                btnImagenSiguiente.Visible = true;
                btnImagenAnterior.Enabled = true;
                btnImagenSiguiente.Enabled = true;
            }



            try
            {
            pbImagenProducto.Load(imagenArticuloActual);

            }
            catch (Exception ex)
            {
                pbImagenProducto.Load(imagenBackup);         
            }       
                 }

        private void cambiarImagen(int nuevoIndice) {

            int potencialNuevoindex = indexImagenActual + nuevoIndice;

            if(potencialNuevoindex < 0 || potencialNuevoindex >= ArticuloActual.URLImagenes.Count)
            {
                return;
            }
            else
            {

                indexImagenActual = potencialNuevoindex;
                string imagenBackup = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOZugSlXrDIB3SLtuip9ZDU1iJScEqfby_Q&s";
                string imagenArticuloActual = ArticuloActual.URLImagenes[indexImagenActual].URL;
                labelimagenActual.Text = "Imagen " + (indexImagenActual + 1).ToString() + " de " + ArticuloActual.URLImagenes.Count.ToString();
                cargarImagen(indexImagenActual);

            }


        }

        //eventos:
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarTabla();

        }
        private void GertorDeArticulos_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void dgvTablaArticulos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvTablaArticulos.CurrentRow == null) return;
            ArticuloActual = ((Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem);
            indexImagenActual = 0;
            cambiarImagen(0);           
               
        }
        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            int cantidadDeImagenesArticulo = ArticuloActual.URLImagenes.Count;

            if (cantidadDeImagenesArticulo == 1) return;

            cambiarImagen(1); 
        }
        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {

            int cantidadDeImagenesArticulo = ArticuloActual.URLImagenes.Count;

            if (cantidadDeImagenesArticulo == 1) return;

            cambiarImagen(-1);
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
                cargarTabla();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargarTabla();

        }

        private void btnModMarcas_Click(object sender, EventArgs e)
        {
            frmModificarMarcasyCategorias frmModificarMarcasyCategorias = new frmModificarMarcasyCategorias("Marca");
            frmModificarMarcasyCategorias.ShowDialog();
        }

        private void btnModCategoria_Click(object sender, EventArgs e)
        {
            frmModificarMarcasyCategorias frmModificarMarcasyCategorias = new frmModificarMarcasyCategorias("Categoria");
            frmModificarMarcasyCategorias.ShowDialog();
        }
    }
}
