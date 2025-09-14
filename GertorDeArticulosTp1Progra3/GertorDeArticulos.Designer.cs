namespace GertorDeArticulosTp1Progra3
{
    partial class GertorDeArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbImagenProducto = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCategoriaFiltro = new System.Windows.Forms.Label();
            this.lblMarcaFiltro = new System.Windows.Forms.Label();
            this.cbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.cbFiltroMarca = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.txtbBuscador = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvTablaArticulos = new System.Windows.Forms.DataGridView();
            this.lblTituloArticulos = new System.Windows.Forms.Label();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.labelimagenActual = new System.Windows.Forms.Label();
            this.btnModCategoria = new System.Windows.Forms.Button();
            this.btnModMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenProducto
            // 
            this.pbImagenProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagenProducto.Location = new System.Drawing.Point(1299, 188);
            this.pbImagenProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(506, 337);
            this.pbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenProducto.TabIndex = 27;
            this.pbImagenProducto.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));

            this.btnBuscar.Location = new System.Drawing.Point(24, 277);

            
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;

            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

//            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // 
            // lblCategoriaFiltro
            // 
            this.lblCategoriaFiltro.AutoSize = true;
            this.lblCategoriaFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaFiltro.Location = new System.Drawing.Point(32, 340);
            this.lblCategoriaFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaFiltro.Name = "lblCategoriaFiltro";
            this.lblCategoriaFiltro.Size = new System.Drawing.Size(88, 23);
            this.lblCategoriaFiltro.TabIndex = 25;
            this.lblCategoriaFiltro.Text = "Categoria";
            // 
            // lblMarcaFiltro
            // 
            this.lblMarcaFiltro.AutoSize = true;
            this.lblMarcaFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaFiltro.Location = new System.Drawing.Point(32, 262);
            this.lblMarcaFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaFiltro.Name = "lblMarcaFiltro";
            this.lblMarcaFiltro.Size = new System.Drawing.Size(64, 24);
            this.lblMarcaFiltro.TabIndex = 24;
            this.lblMarcaFiltro.Text = "Marca";
            // 
            // cbFiltroCategoria
            // 
            this.cbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroCategoria.FormattingEnabled = true;
            this.cbFiltroCategoria.Location = new System.Drawing.Point(36, 365);
            this.cbFiltroCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFiltroCategoria.Name = "cbFiltroCategoria";
            this.cbFiltroCategoria.Size = new System.Drawing.Size(180, 28);
            this.cbFiltroCategoria.TabIndex = 23;
            // 
            // cbFiltroMarca
            // 
            this.cbFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroMarca.FormattingEnabled = true;

            
            this.cbFiltroMarca.Location = new System.Drawing.Point(24, 190);

            
            this.cbFiltroMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.cbFiltroMarca.Name = "cbFiltroMarca";
            this.cbFiltroMarca.Size = new System.Drawing.Size(180, 28);
            this.cbFiltroMarca.TabIndex = 22;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(30, 212);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(72, 31);
            this.lblFiltro.TabIndex = 21;
            this.lblFiltro.Text = "Filtro";
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.Location = new System.Drawing.Point(408, 155);
            this.lblBuscador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(80, 27);
            this.lblBuscador.TabIndex = 20;
            this.lblBuscador.Text = "Buscar:";
            // 
            // txtbBuscador
            // 
            this.txtbBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbBuscador.Location = new System.Drawing.Point(496, 158);
            this.txtbBuscador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbBuscador.Name = "txtbBuscador";
            this.txtbBuscador.Size = new System.Drawing.Size(272, 26);
            this.txtbBuscador.TabIndex = 19;
            this.txtbBuscador.TextChanged += new System.EventHandler(this.txtbBuscador_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(956, 537);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(741, 537);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 35);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(525, 537);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvTablaArticulos
            // 
            this.dgvTablaArticulos.AllowUserToAddRows = false;
            this.dgvTablaArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTablaArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTablaArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablaArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTablaArticulos.Location = new System.Drawing.Point(270, 212);
            this.dgvTablaArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTablaArticulos.MultiSelect = false;
            this.dgvTablaArticulos.Name = "dgvTablaArticulos";
            this.dgvTablaArticulos.ReadOnly = true;
            this.dgvTablaArticulos.RowHeadersWidth = 62;
            this.dgvTablaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaArticulos.Size = new System.Drawing.Size(1020, 292);
            this.dgvTablaArticulos.TabIndex = 15;
            this.dgvTablaArticulos.SelectionChanged += new System.EventHandler(this.dgvTablaArticulos_SelectionChanged);
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloArticulos.AutoSize = true;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.Location = new System.Drawing.Point(486, 65);
            this.lblTituloArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.Size = new System.Drawing.Size(342, 64);
            this.lblTituloArticulos.TabIndex = 14;
            this.lblTituloArticulos.Text = "Tus Articulos";
            // 
            // btnImagenAnterior
            // 

            this.btnImagenAnterior.Location = new System.Drawing.Point(1017, 379);
            this.btnImagenAnterior.Margin = new System.Windows.Forms.Padding(2);

           // this.btnImagenAnterior.Location = new System.Drawing.Point(1444, 572);
            //this.btnImagenAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(111, 37);
            this.btnImagenAnterior.TabIndex = 28;
            this.btnImagenAnterior.Text = "Anterior";
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // btnImagenSiguiente
            // 

            this.btnImagenSiguiente.Location = new System.Drawing.Point(1095, 379);
            this.btnImagenSiguiente.Margin = new System.Windows.Forms.Padding(2);

            //this.btnImagenSiguiente.Location = new System.Drawing.Point(1581, 572);
            //this.btnImagenSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(111, 37);
            this.btnImagenSiguiente.TabIndex = 29;
            this.btnImagenSiguiente.Text = "Siguiente";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // labelimagenActual
            // 
            this.labelimagenActual.AutoSize = true;
            this.labelimagenActual.Location = new System.Drawing.Point(1494, 538);
            this.labelimagenActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelimagenActual.Name = "labelimagenActual";
            this.labelimagenActual.Size = new System.Drawing.Size(63, 20);
            this.labelimagenActual.TabIndex = 30;
            this.labelimagenActual.Text = "Imagen";
            // 
            // btnModCategoria
            // 
            this.btnModCategoria.Location = new System.Drawing.Point(36, 489);
            this.btnModCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModCategoria.Name = "btnModCategoria";
            this.btnModCategoria.Size = new System.Drawing.Size(182, 35);
            this.btnModCategoria.TabIndex = 32;
            this.btnModCategoria.Text = "Modificar Categorias";
            this.btnModCategoria.UseVisualStyleBackColor = true;
            this.btnModCategoria.Click += new System.EventHandler(this.btnModCategoria_Click);
            // 
            // btnModMarcas
            // 
            this.btnModMarcas.Location = new System.Drawing.Point(36, 423);
            this.btnModMarcas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModMarcas.Name = "btnModMarcas";
            this.btnModMarcas.Size = new System.Drawing.Size(182, 35);
            this.btnModMarcas.TabIndex = 31;
            this.btnModMarcas.Text = "Modificar marcas";
            this.btnModMarcas.UseVisualStyleBackColor = true;
            this.btnModMarcas.Click += new System.EventHandler(this.btnModMarcas_Click);
            // 
            // GertorDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 852);
            this.Controls.Add(this.btnModCategoria);
            this.Controls.Add(this.btnModMarcas);
            this.Controls.Add(this.labelimagenActual);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.pbImagenProducto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCategoriaFiltro);
            this.Controls.Add(this.lblMarcaFiltro);
            this.Controls.Add(this.cbFiltroCategoria);
            this.Controls.Add(this.cbFiltroMarca);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.txtbBuscador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTablaArticulos);
            this.Controls.Add(this.lblTituloArticulos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1915, 873);
            this.Name = "GertorDeArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor De Articulos";
            this.Load += new System.EventHandler(this.GertorDeArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCategoriaFiltro;
        private System.Windows.Forms.Label lblMarcaFiltro;
        private System.Windows.Forms.ComboBox cbFiltroCategoria;
        private System.Windows.Forms.ComboBox cbFiltroMarca;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.TextBox txtbBuscador;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTablaArticulos;
        private System.Windows.Forms.Label lblTituloArticulos;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.Label labelimagenActual;
        private System.Windows.Forms.Button btnModCategoria;
        private System.Windows.Forms.Button btnModMarcas;
    }
}


