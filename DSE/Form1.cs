namespace DSE
{
    public partial class Form1 : Form
    {
        public string boletos_cant;
        public string ID;
        public string pago;
        public string focus;
        public List<string> Data = new List<string>();
        public Form1(List<string> data)
        {
            Data = data;
            InitializeComponent();
            txt_Nombre_Evento.Text = data[1];
            txt_Precio_Boleto.Text = data[2];
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
            txtTotal.Text = Convert.ToString(boletos * Precio_Boleto);

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
            focus = "textBox1";
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
            feria();
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
            }
            else
            {
                double Precio_Boleto = Convert.ToDouble(Data[3]);
                double boletos = Convert.ToInt64(textBox1.Text);

                //Imprimimos el total
                txtTotal.Text = Convert.ToString(boletos * Precio_Boleto);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
