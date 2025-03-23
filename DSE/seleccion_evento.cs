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
    public partial class seleccion_evento : Form
    {
        BindingSource bindingSource = new BindingSource();
        List<int> seleccionsql = new List<int>();
        public int fila_activa;
        BindingSource bindingSourceBusqueda = new BindingSource();

        public List<string> data = new List<string>(new string[5]);
        public seleccion_evento()
        {
            InitializeComponent();
        }

        private void btnSeleccionEvento_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(data);
            form1.Show();
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
            data = agb.eventoData(seleccionsql[fila_activa]);
            bindingSourceBusqueda.DataSource = agb.eventoData(seleccionsql[fila_activa]);
            listBox1.DataSource = bindingSourceBusqueda;
            btnSeleccionEvento.Enabled = true;


        }

        private void btn_Alta_Evento_Click(object sender, EventArgs e)
        {
            AgregarEvento form = new AgregarEvento();
            form.Show();
        }


    }
}
