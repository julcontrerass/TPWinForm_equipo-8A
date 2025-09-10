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
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenProducto
            // 
            this.pbImagenProducto.Location = new System.Drawing.Point(1328, 215);
            this.pbImagenProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(276, 191);
            this.pbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImagenProducto.TabIndex = 27;
            this.pbImagenProducto.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(844, 160);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblCategoriaFiltro
            // 
            this.lblCategoriaFiltro.AutoSize = true;
            this.lblCategoriaFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaFiltro.Location = new System.Drawing.Point(147, 345);
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
            this.lblMarcaFiltro.Location = new System.Drawing.Point(147, 266);
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
            this.cbFiltroCategoria.Location = new System.Drawing.Point(152, 369);
            this.cbFiltroCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFiltroCategoria.Name = "cbFiltroCategoria";
            this.cbFiltroCategoria.Size = new System.Drawing.Size(180, 28);
            this.cbFiltroCategoria.TabIndex = 23;
            // 
            // cbFiltroMarca
            // 
            this.cbFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroMarca.FormattingEnabled = true;
            this.cbFiltroMarca.Items.AddRange(new object[] {
            "Ninguno"});
            this.cbFiltroMarca.Location = new System.Drawing.Point(152, 297);
            this.cbFiltroMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFiltroMarca.Name = "cbFiltroMarca";
            this.cbFiltroMarca.Size = new System.Drawing.Size(180, 28);
            this.cbFiltroMarca.TabIndex = 22;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(146, 217);
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
            this.lblBuscador.Location = new System.Drawing.Point(602, 160);
            this.lblBuscador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(80, 27);
            this.lblBuscador.TabIndex = 20;
            this.lblBuscador.Text = "Buscar:";
            // 
            // txtbBuscador
            // 
            this.txtbBuscador.Location = new System.Drawing.Point(686, 162);
            this.txtbBuscador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbBuscador.Name = "txtbBuscador";
            this.txtbBuscador.Size = new System.Drawing.Size(148, 26);
            this.txtbBuscador.TabIndex = 19;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(946, 611);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(723, 612);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 35);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(507, 612);
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
            this.dgvTablaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTablaArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablaArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTablaArticulos.Location = new System.Drawing.Point(402, 217);
            this.dgvTablaArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTablaArticulos.MultiSelect = false;
            this.dgvTablaArticulos.Name = "dgvTablaArticulos";
            this.dgvTablaArticulos.ReadOnly = true;
            this.dgvTablaArticulos.RowHeadersWidth = 62;
            this.dgvTablaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaArticulos.Size = new System.Drawing.Size(896, 292);
            this.dgvTablaArticulos.TabIndex = 15;
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.AutoSize = true;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.Location = new System.Drawing.Point(567, 69);
            this.lblTituloArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.Size = new System.Drawing.Size(342, 64);
            this.lblTituloArticulos.TabIndex = 14;
            this.lblTituloArticulos.Text = "Tus Articulos";
            // 
            // GertorDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 852);
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
            this.Name = "GertorDeArticulos";
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
    }
}

