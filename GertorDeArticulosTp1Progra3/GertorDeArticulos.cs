using dominio;
using service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        private ArticuloService ArticuloService{ get; set; } = new ArticuloService();
        private List<Articulo> listaArticulos {  get; set; }
        private Articulo ArticuloActual { get; set; }
        private int indexImagenActual { get; set; }
        


        // Métodos de clase
        private void cargarTabla()

        {            
            listaArticulos = ArticuloService.Listar();

           mostrarUOcultarImagenYSelector(listaArticulos);
            dgvTablaArticulos.DataSource = listaArticulos;
            ArticuloActual = listaArticulos[0];
            FormatearYOcultarColumnas();              

            indexImagenActual = 0;
            labelimagenActual.Text = "Imagen " + (indexImagenActual + 1).ToString() + " de " + ArticuloActual.URLImagenes.Count.ToString();
            cargarImagen(indexImagenActual);

            if (ArticuloActual.URLImagenes.Count < 2)
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

        private void cambiarImagen(int nuevoIndice)
        {

            int potencialNuevoindex = indexImagenActual + nuevoIndice;

            if (potencialNuevoindex < 0 || potencialNuevoindex >= ArticuloActual.URLImagenes.Count)
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

        private void mostrarUOcultarImagenYSelector(List<Articulo> listaArticulos)
        {

            if (listaArticulos.Count > 0)
            {
                pbImagenProducto.Visible = true;
                btnImagenAnterior.Visible = true;
                btnImagenSiguiente.Visible = true;
                labelimagenActual.Visible = true;
            }
            else
            {
                pbImagenProducto.Visible = false;
                btnImagenAnterior.Visible = false;
                btnImagenSiguiente.Visible = false;
                labelimagenActual.Visible = false;
            }
        }
        private void FormatearYOcultarColumnas() {
            dgvTablaArticulos.Columns["idCategoria"].Visible = false;
            dgvTablaArticulos.Columns["idMarca"].Visible = false;
            dgvTablaArticulos.Columns["precio"].DefaultCellStyle.Format = "C2";
            dgvTablaArticulos.Columns["imagen"].Visible = false;

        }

        private void CargarMarcas()
        {
            MarcaService marcaService = new MarcaService();

            List<Marca> listadoMarcas = marcaService.Listar();

            cbFiltroMarca.Items.Add("");
            listadoMarcas.ForEach(marca => cbFiltroMarca.Items.Add(marca.descripcion));
            

            
        }

        private void CargarCategorias()
        {
            CategoriaService categoriaService = new CategoriaService();

            List<Categoria> listaCategorias = categoriaService.Listar();

            cbFiltroCategoria.Items.Add("");

            listaCategorias.ForEach(categoria => cbFiltroCategoria.Items.Add(categoria.descripcion));
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
            CargarCategorias();
            CargarMarcas();
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
            if (dgvTablaArticulos.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún artículo seleccionado");
                return;
            }
            seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargarTabla();
        }


        private void txtbBuscador_TextChanged(object sender, EventArgs e)
        {
            //filtrar por nombre o marca
            string busqueda = txtbBuscador.Text;            
            List<Articulo> listaFiltrada;
            if (busqueda.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(el => el.nombre.ToUpper().Contains(busqueda.ToUpper()) || el.Marca.descripcion.ToUpper().Contains(busqueda.ToUpper()));

                    dgvTablaArticulos.DataSource = null;
                    dgvTablaArticulos.Rows.Clear();
                    dgvTablaArticulos.DataSource = listaFiltrada;
                    FormatearYOcultarColumnas();
                     mostrarUOcultarImagenYSelector(listaFiltrada);                   
                }               
            
            else
            {
                dgvTablaArticulos.DataSource = null;
                dgvTablaArticulos.Rows.Clear();
                dgvTablaArticulos.DataSource = listaArticulos;
                FormatearYOcultarColumnas();
                mostrarUOcultarImagenYSelector(listaArticulos);
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // metodo para busqueda avanzada
            string filtroMarca = "";
            string filtroCategoria = "";
            txtbBuscador.Text = "";
                
             if(cbFiltroMarca.SelectedItem != null){
                filtroMarca = cbFiltroMarca.SelectedItem.ToString();
             }
             if (cbFiltroCategoria.SelectedItem != null) {             
                filtroCategoria = cbFiltroCategoria.SelectedItem.ToString();
            }

            if(filtroMarca == "" && filtroCategoria == "")
            {
                dgvTablaArticulos.DataSource = null;
                dgvTablaArticulos.Rows.Clear();
                dgvTablaArticulos.DataSource = listaArticulos;
                FormatearYOcultarColumnas();
                mostrarUOcultarImagenYSelector(listaArticulos);
                return;
            }

            List<Articulo> listaArticulosFiltrada = ArticuloService.filtroAvanzado(filtroMarca, filtroCategoria);
                                 

            dgvTablaArticulos.DataSource = null;
            dgvTablaArticulos.Rows.Clear();
            dgvTablaArticulos.DataSource = listaArticulosFiltrada;
            FormatearYOcultarColumnas();
            mostrarUOcultarImagenYSelector(listaArticulosFiltrada);

        }

        private void btnModMarcas_Click(object sender, EventArgs e)
        {
            frmModificarMarcasyCategorias frmModificarMarcasyCategorias = new frmModificarMarcasyCategorias("Marca");
            frmModificarMarcasyCategorias.ShowDialog();
            cargarTabla();
        }

        private void btnModCategoria_Click(object sender, EventArgs e)
        {
            frmModificarMarcasyCategorias frmModificarMarcasyCategorias = new frmModificarMarcasyCategorias("Categoria");
            frmModificarMarcasyCategorias.ShowDialog();
            cargarTabla();
        }

    }
}

