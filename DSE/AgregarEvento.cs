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
    public partial class AgregarEvento : Form
    {
        public AgregarEvento()
        {
            InitializeComponent();

        }

        private void btnAgregar_Registros_Click(object sender, EventArgs e)
        {
            DSE_DAO agb = new DSE_DAO();
            DateTime fecha = DateTime.ParseExact(mskFecha.Text, "dd/MM/yyyy", null);
            TimeSpan tiempo;
            TimeSpan.TryParse(mskHora.Text, out tiempo);
            eventos evento = new eventos
            {
                id_evento = Convert.ToInt32(txtId.Text),
                nombre = txtNombre.Text,
                fecha = fecha,
                lugar = txtLugar.Text,
                hora = tiempo,
                precio_preventa = Convert.ToInt32(txtPrecio_Preventa.Text),
                precio_taquilla = Convert.ToInt32(txtPrecio_Taquilla.Text),
                capacidad_personas = Convert.ToInt32(txtCapacidad_Personas.Text)
            };

            agb.insertarEvento(evento);
        }



        private void mskFecha_Click(object sender, EventArgs e)
        {
            mskFecha.SelectAll();
            mskFecha.Select(0, 0);
        }

        private void mskHora_Click(object sender, EventArgs e)
        {
            mskFecha.SelectAll();
            mskFecha.Select(0, 0);
        }
    }
}
