namespace DSE
{
    partial class AgregarEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLugar = new TextBox();
            txtPrecio_Preventa = new TextBox();
            txtPrecio_Taquilla = new TextBox();
            txtCapacidad_Personas = new TextBox();
            btnAgregar = new Button();
            mskFecha = new MaskedTextBox();
            mskHora = new MaskedTextBox();
            lblEvento = new Label();
            lblNombre_Evento = new Label();
            lblFecha = new Label();
            lblLugar = new Label();
            lblHora = new Label();
            lblPrecio_Taquilla = new Label();
            lblPrecio_Preventa = new Label();
            lblCapacidad_Persona = new Label();
            lblFechaFormato = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(293, 53);
            txtId.MaxLength = 8;
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(293, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(293, 152);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(125, 27);
            txtLugar.TabIndex = 6;
            // 
            // txtPrecio_Preventa
            // 
            txtPrecio_Preventa.Location = new Point(293, 218);
            txtPrecio_Preventa.Name = "txtPrecio_Preventa";
            txtPrecio_Preventa.Size = new Size(125, 27);
            txtPrecio_Preventa.TabIndex = 8;
            // 
            // txtPrecio_Taquilla
            // 
            txtPrecio_Taquilla.Location = new Point(293, 251);
            txtPrecio_Taquilla.Name = "txtPrecio_Taquilla";
            txtPrecio_Taquilla.Size = new Size(125, 27);
            txtPrecio_Taquilla.TabIndex = 9;
            // 
            // txtCapacidad_Personas
            // 
            txtCapacidad_Personas.Location = new Point(293, 284);
            txtCapacidad_Personas.Name = "txtCapacidad_Personas";
            txtCapacidad_Personas.Size = new Size(125, 27);
            txtCapacidad_Personas.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(537, 43);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(227, 169);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar Registros";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Registros_Click;
            // 
            // mskFecha
            // 
            mskFecha.Location = new Point(293, 119);
            mskFecha.Mask = "00/00/0000";
            mskFecha.Name = "mskFecha";
            mskFecha.Size = new Size(125, 27);
            mskFecha.TabIndex = 8;
            mskFecha.ValidatingType = typeof(DateTime);
            mskFecha.Click += mskFecha_Click;
            // 
            // mskHora
            // 
            mskHora.Location = new Point(293, 185);
            mskHora.Mask = "00:00";
            mskHora.Name = "mskHora";
            mskHora.Size = new Size(125, 27);
            mskHora.TabIndex = 13;
            mskHora.ValidatingType = typeof(DateTime);
            mskHora.Click += mskHora_Click;
            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.Location = new Point(184, 53);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(75, 20);
            lblEvento.TabIndex = 14;
            lblEvento.Text = "ID_Evento";
            // 
            // lblNombre_Evento
            // 
            lblNombre_Evento.AutoSize = true;
            lblNombre_Evento.Location = new Point(163, 86);
            lblNombre_Evento.Name = "lblNombre_Evento";
            lblNombre_Evento.Size = new Size(113, 20);
            lblNombre_Evento.TabIndex = 15;
            lblNombre_Evento.Text = "Nombre evento";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(171, 119);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(96, 20);
            lblFecha.TabIndex = 16;
            lblFecha.Text = "Fecha evento";
            // 
            // lblLugar
            // 
            lblLugar.AutoSize = true;
            lblLugar.Location = new Point(184, 152);
            lblLugar.Name = "lblLugar";
            lblLugar.Size = new Size(46, 20);
            lblLugar.TabIndex = 17;
            lblLugar.Text = "Lugar";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(184, 185);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(42, 20);
            lblHora.TabIndex = 18;
            lblHora.Text = "Hora";
            // 
            // lblPrecio_Taquilla
            // 
            lblPrecio_Taquilla.AutoSize = true;
            lblPrecio_Taquilla.Location = new Point(163, 258);
            lblPrecio_Taquilla.Name = "lblPrecio_Taquilla";
            lblPrecio_Taquilla.Size = new Size(104, 20);
            lblPrecio_Taquilla.TabIndex = 19;
            lblPrecio_Taquilla.Text = "Precio taquilla";
            // 
            // lblPrecio_Preventa
            // 
            lblPrecio_Preventa.AutoSize = true;
            lblPrecio_Preventa.Location = new Point(163, 225);
            lblPrecio_Preventa.Name = "lblPrecio_Preventa";
            lblPrecio_Preventa.Size = new Size(113, 20);
            lblPrecio_Preventa.TabIndex = 20;
            lblPrecio_Preventa.Text = "Precio_Preventa";
            // 
            // lblCapacidad_Persona
            // 
            lblCapacidad_Persona.AutoSize = true;
            lblCapacidad_Persona.Location = new Point(152, 287);
            lblCapacidad_Persona.Name = "lblCapacidad_Persona";
            lblCapacidad_Persona.Size = new Size(135, 20);
            lblCapacidad_Persona.TabIndex = 21;
            lblCapacidad_Persona.Text = "Capacidad Persona";
            // 
            // lblFechaFormato
            // 
            lblFechaFormato.AutoSize = true;
            lblFechaFormato.Location = new Point(433, 122);
            lblFechaFormato.Name = "lblFechaFormato";
            lblFechaFormato.Size = new Size(98, 20);
            lblFechaFormato.TabIndex = 22;
            lblFechaFormato.Text = "Dia/Mes/Año";
            // 
            // AgregarEvento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFechaFormato);
            Controls.Add(lblCapacidad_Persona);
            Controls.Add(lblPrecio_Preventa);
            Controls.Add(lblPrecio_Taquilla);
            Controls.Add(lblHora);
            Controls.Add(lblLugar);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre_Evento);
            Controls.Add(lblEvento);
            Controls.Add(mskHora);
            Controls.Add(mskFecha);
            Controls.Add(btnAgregar);
            Controls.Add(txtCapacidad_Personas);
            Controls.Add(txtPrecio_Taquilla);
            Controls.Add(txtPrecio_Preventa);
            Controls.Add(txtLugar);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Name = "AgregarEvento";
            Text = "AgregarEvento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLugar;
        private TextBox txtPrecio_Preventa;
        private TextBox txtPrecio_Taquilla;
        private TextBox txtCapacidad_Personas;
        private Button btnAgregar;
        private MaskedTextBox mskFecha;
        private MaskedTextBox mskHora;
        private Label lblEvento;
        private Label lblNombre_Evento;
        private Label lblFecha;
        private Label lblLugar;
        private Label lblHora;
        private Label lblPrecio_Taquilla;
        private Label lblPrecio_Preventa;
        private Label lblCapacidad_Persona;
        private Label lblFechaFormato;
    }
}