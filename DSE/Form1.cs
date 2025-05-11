using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace DSE
{
    public partial class Form1 : Form
    {
        public string boletos_cant;
        public string ID;
        public string pago;
        public string focus;
        public string Tipo_Boleto;
        BindingSource bindingSource = new BindingSource();
        public List<string> Data = new List<string>();
        public Form1(List<string> data)
        {
            Data = data;
            InitializeComponent();
            txt_Nombre_Evento.Text = data[1];
            txt_Precio_Boleto.Text = data[2];
            txt_Fecha_Evento.Text = data[5];
        }
        // Esta funcion nos ayudara a agregar valores a una cadena string, para manipularlos despues
        private void numero(string valor)
        {
            if (focus == "textBox1")
            {
                boletos_cant = boletos_cant + valor;
                textBox1.Text = boletos_cant;
            }
            else if (focus == "textBox2")
            {
                pago = pago + valor;
                textBox2.Text = pago;
            }

        }

        private void feria()
        {
            double Monto = Convert.ToInt64(textBox2.Text);
            double Precio_Boleto = Convert.ToDouble(Data[3]);
            double boletos = Convert.ToInt64(textBox1.Text);

            //Imprimimos el total
 

            // |||Aqui falta la conexion con base de datos
            double feria = Monto - (boletos * Precio_Boleto);
            if (feria < 0)
            {
                lblMsgError.Text = "No cuenta con el dinero suficiente";
                txtCambio.Text = "";
            }
            else
            {
                lblMsgError.Text = "";
                txtCambio.Text = Convert.ToString(feria);
            }


        }

        // Aqui simplemente centro la atencion en un objeto
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                this.ActiveControl = null;
                MessageBox.Show("Elige el tipo de boleto", "ERROR");
            }
            else
            {
                focus = "textBox1";
            }
            
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            focus = "textBox2";
        }
        private void txtIdEv_MouseClick(object sender, MouseEventArgs e)
        {
            focus = "txtIdEv";
        }
        // referencia que hago para cada boton a la funcion de numero
        private void button1_Click(object sender, EventArgs e)
        {
            numero(btn1.Text);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            numero(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numero(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numero(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numero(btn5.Text);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            numero(btn6.Text);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            numero(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numero(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numero(btn9.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numero(btn0.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                if (comboBox1.SelectedItem != null)
                {
                    List<string> ventadata = new List<string>(6);
                    DSE_DAO agb = new DSE_DAO();
                    Ventas venta = new Ventas
                    {
                        ID = agb.ObtenerIDVenta(Data[0]),
                        ID_Evento =Convert.ToInt32(Data[0]),
                        Fecha = Convert.ToDateTime(Data[5]),
                        tipo_boleto = Tipo_Boleto,
                        cantidad = Convert.ToInt32(textBox1.Text),
                        total = Convert.ToInt32(txtTotal.Text)
                    };
                    
                    bindingSource.DataSource = venta;
                    listBox1.DataSource = bindingSource;
                    if(Tipo_Boleto == "general")
                    {
                        txtCambio.Text = "Es gratuito";
                    }
                    else
                    {
                        feria();
                    }
                    
                    agb.insertarVenta(venta);
                    
                }
                else
                {
                    MessageBox.Show("Elige el tipo de boleto", "ERROR");
                }

            }
            else
            {
                MessageBox.Show("llena todos los campos", "ERROR");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            txtCambio.Text = "";
            txtTotal.Text = "";
            pago = "";
            boletos_cant = "";
        }

        private void Consulta(object sender, EventArgs e)
        {
                Consulta cn = new Consulta();
                cn.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                txtTotal.Text = "";
                boletos_cant = "";
            }
            else
            {
                if(comboBox1.SelectedIndex == 0)
                {
                double Precio_Boleto = Convert.ToDouble(Data[3]);
                double boletos = Convert.ToInt64(textBox1.Text);
                txtTotal.Text = Convert.ToString(boletos * Precio_Boleto);
                }
                else if( comboBox1.SelectedIndex == 1){
                    double Precio_Boleto = 0;
                    double boletos = Convert.ToInt64(textBox1.Text);
                    txtTotal.Text = Convert.ToString(boletos * Precio_Boleto);
                }
                else if(comboBox1.SelectedIndex == 2)
                {
                    double Precio_Boleto = Convert.ToDouble(Data[2]);
                    double boletos = Convert.ToInt64(textBox1.Text);
                    txtTotal.Text = Convert.ToString(boletos * Precio_Boleto);
                }


                //Imprimimos el total
                
            }

        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }

        }
        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "0";
            }
        }
        



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Seleccion_Tipo_boleto = comboBox1.SelectedIndex;
            
            if (Seleccion_Tipo_boleto == 0)
            {
                Tipo_Boleto = "taquilla";
            }
            else if(Seleccion_Tipo_boleto == 1){
                Tipo_Boleto = "general";
            }
            else if (Seleccion_Tipo_boleto == 2)
            {
                Tipo_Boleto = "preventa";
            }
            if (textBox1_TextChanged != null)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    double Precio_Boleto = Convert.ToDouble(Data[3]);
                    double boletos = Convert.ToInt64(textBox1.Text);
                    txtTotal.Text = Convert.ToString(boletos * Precio_Boleto);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    double Precio_Boleto = 0;
                    double boletos = Convert.ToInt64(textBox1.Text);
                    txtTotal.Text = Convert.ToString(boletos * Precio_Boleto * 0);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    double Precio_Boleto = Convert.ToDouble(Data[2]);
                    double boletos = Convert.ToInt64(textBox1.Text);
                    txtTotal.Text = Convert.ToString(boletos * Precio_Boleto);
                }
            }

        }
    }
}
