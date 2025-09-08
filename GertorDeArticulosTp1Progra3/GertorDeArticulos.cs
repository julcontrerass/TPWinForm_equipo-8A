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
            ArticuloService service = new ArticuloService();
            dgvTablaArticulos.DataSource = service.listar();
        }
    }
}
