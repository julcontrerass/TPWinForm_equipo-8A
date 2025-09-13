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
            cargarImagen(pbImagenProducto, ArticuloActual.URLImagenes[0].URL);
            indexImagenActual = 0;
            labelimagenActual.Text = "Imagen " + (indexImagenActual+ 1).ToString() + " de " + ArticuloActual.URLImagenes.Count.ToString();

            if(ArticuloActual.URLImagenes.Count < 2)
            {
                btnImagenSiguiente.Enabled = false;
                btnImagenAnterior.Enabled = false;
            }
        }
        private void cargarImagen(PictureBox pb, string URL)
        {
            
            try
            {
            pb.Load(URL);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                labelimagenActual.Text = "Imagen " + (indexImagenActual + 1).ToString() + " de " + ArticuloActual.URLImagenes.Count.ToString();
                cargarImagen(pbImagenProducto, ArticuloActual.URLImagenes[indexImagenActual].URL);

            }


        }


        //eventos:
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();

        }
        private void GertorDeArticulos_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void dgvTablaArticulos_SelectionChanged(object sender, EventArgs e)
        {
                     
            ArticuloActual = ((Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem);
            indexImagenActual = 0;
            labelimagenActual.Text = "Imagen " + (indexImagenActual + 1).ToString() + " de " + ArticuloActual.URLImagenes.Count.ToString();

            if (ArticuloActual.URLImagenes.Count < 2) { 
            btnImagenAnterior.Enabled = false;
            btnImagenSiguiente.Enabled = false;
            }
            else
            {
                btnImagenAnterior.Visible = true;
                btnImagenSiguiente.Visible = true;
                btnImagenAnterior.Enabled=true;
                btnImagenSiguiente.Enabled=true;
            }

                string imagenNoDisponible = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOZugSlXrDIB3SLtuip9ZDU1iJScEqfby_Q&s";
            
            try
            {
            string imagenArticuloActual = ArticuloActual.URLImagenes[indexImagenActual].URL;
                
                cargarImagen(pbImagenProducto, imagenArticuloActual);

            }
            catch (Exception)
            {
                cargarImagen(pbImagenProducto,imagenNoDisponible);

            }
                
               
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


    }
}
