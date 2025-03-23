
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSE
{
    public partial class Consulta : Form
    {
        BindingSource bindingSource = new BindingSource();
        BindingSource bindingSourceBusqueda = new BindingSource();
        string comandosql;
        List<int> seleccionsql = new List<int>();
        public int fila_activa;

        public Consulta()
        {
            InitializeComponent();
        }
        private void btnConsultar(object sender, EventArgs e)
        {
            DSE_DAO agb = new DSE_DAO();

            (bindingSource.DataSource, seleccionsql) = agb.obtenerEvento();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DSE_DAO agb = new DSE_DAO();
            (bindingSource.DataSource, seleccionsql) = agb.Buscar(txt1.Text);
            dataGridView1.DataSource = bindingSource;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            DSE_DAO agb = new DSE_DAO();
            fila_activa = dataGrid.CurrentRow.Index;
            fila_activa = seleccionsql[fila_activa];
            bindingSourceBusqueda.DataSource = agb.obtenerVenta(fila_activa);
            dataGridView2.DataSource = bindingSourceBusqueda;
            (lblTotalRes.Text, lblCantidadRes.Text) = agb.total(fila_activa);
        }


    }
}
