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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(67, 67, 67);
            txtId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txtId.ForeColor = Color.CornflowerBlue;
            txtId.Location = new Point(165, 151);
            txtId.MaxLength = 8;
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 28);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(67, 67, 67);
            txtNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txtNombre.ForeColor = Color.CornflowerBlue;
            txtNombre.Location = new Point(165, 185);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 28);
            txtNombre.TabIndex = 4;
            // 
            // txtLugar
            // 
            txtLugar.BackColor = Color.FromArgb(67, 67, 67);
            txtLugar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txtLugar.ForeColor = Color.CornflowerBlue;
            txtLugar.Location = new Point(165, 250);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(125, 28);
            txtLugar.TabIndex = 6;
            // 
            // txtPrecio_Preventa
            // 
            txtPrecio_Preventa.BackColor = Color.FromArgb(67, 67, 67);
            txtPrecio_Preventa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txtPrecio_Preventa.ForeColor = Color.CornflowerBlue;
            txtPrecio_Preventa.Location = new Point(165, 316);
            txtPrecio_Preventa.Name = "txtPrecio_Preventa";
            txtPrecio_Preventa.Size = new Size(125, 28);
            txtPrecio_Preventa.TabIndex = 8;
            // 
            // txtPrecio_Taquilla
            // 
            txtPrecio_Taquilla.BackColor = Color.FromArgb(67, 67, 67);
            txtPrecio_Taquilla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txtPrecio_Taquilla.ForeColor = Color.CornflowerBlue;
            txtPrecio_Taquilla.Location = new Point(165, 350);
            txtPrecio_Taquilla.Name = "txtPrecio_Taquilla";
            txtPrecio_Taquilla.Size = new Size(125, 28);
            txtPrecio_Taquilla.TabIndex = 9;
            // 
            // txtCapacidad_Personas
            // 
            txtCapacidad_Personas.BackColor = Color.FromArgb(67, 67, 67);
            txtCapacidad_Personas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txtCapacidad_Personas.ForeColor = Color.CornflowerBlue;
            txtCapacidad_Personas.Location = new Point(165, 382);
            txtCapacidad_Personas.Name = "txtCapacidad_Personas";
            txtCapacidad_Personas.Size = new Size(125, 28);
            txtCapacidad_Personas.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(67, 67, 67);
            btnAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAgregar.ForeColor = Color.CornflowerBlue;
            btnAgregar.Location = new Point(421, 197);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(227, 81);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Registros_Click;
            // 
            // mskFecha
            // 
            mskFecha.BackColor = Color.FromArgb(67, 67, 67);
            mskFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            mskFecha.ForeColor = Color.CornflowerBlue;
            mskFecha.Location = new Point(165, 218);
            mskFecha.Mask = "00/00/0000";
            mskFecha.Name = "mskFecha";
            mskFecha.Size = new Size(125, 28);
            mskFecha.TabIndex = 8;
            mskFecha.ValidatingType = typeof(DateTime);
            mskFecha.Click += mskFecha_Click;
            // 
            // mskHora
            // 
            mskHora.BackColor = Color.FromArgb(67, 67, 67);
            mskHora.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            mskHora.ForeColor = Color.CornflowerBlue;
            mskHora.Location = new Point(165, 283);
            mskHora.Mask = "00:00";
            mskHora.Name = "mskHora";
            mskHora.Size = new Size(125, 28);
            mskHora.TabIndex = 13;
            mskHora.ValidatingType = typeof(DateTime);
            mskHora.Click += mskHora_Click;
            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblEvento.ForeColor = Color.CornflowerBlue;
            lblEvento.Location = new Point(18, 151);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(76, 20);
            lblEvento.TabIndex = 14;
            lblEvento.Text = "ID_Evento";
            // 
            // lblNombre_Evento
            // 
            lblNombre_Evento.AutoSize = true;
            lblNombre_Evento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblNombre_Evento.ForeColor = Color.CornflowerBlue;
            lblNombre_Evento.Location = new Point(18, 185);
            lblNombre_Evento.Name = "lblNombre_Evento";
            lblNombre_Evento.Size = new Size(115, 20);
            lblNombre_Evento.TabIndex = 15;
            lblNombre_Evento.Text = "Nombre evento";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblFecha.ForeColor = Color.CornflowerBlue;
            lblFecha.Location = new Point(18, 218);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(100, 20);
            lblFecha.TabIndex = 16;
            lblFecha.Text = "Fecha evento";
            // 
            // lblLugar
            // 
            lblLugar.AutoSize = true;
            lblLugar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblLugar.ForeColor = Color.CornflowerBlue;
            lblLugar.Location = new Point(18, 250);
            lblLugar.Name = "lblLugar";
            lblLugar.Size = new Size(49, 20);
            lblLugar.TabIndex = 17;
            lblLugar.Text = "Lugar";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblHora.ForeColor = Color.CornflowerBlue;
            lblHora.Location = new Point(18, 283);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(43, 20);
            lblHora.TabIndex = 18;
            lblHora.Text = "Hora";
            // 
            // lblPrecio_Taquilla
            // 
            lblPrecio_Taquilla.AutoSize = true;
            lblPrecio_Taquilla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblPrecio_Taquilla.ForeColor = Color.CornflowerBlue;
            lblPrecio_Taquilla.Location = new Point(18, 354);
            lblPrecio_Taquilla.Name = "lblPrecio_Taquilla";
            lblPrecio_Taquilla.Size = new Size(108, 20);
            lblPrecio_Taquilla.TabIndex = 19;
            lblPrecio_Taquilla.Text = "Precio taquilla";
            // 
            // lblPrecio_Preventa
            // 
            lblPrecio_Preventa.AutoSize = true;
            lblPrecio_Preventa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblPrecio_Preventa.ForeColor = Color.CornflowerBlue;
            lblPrecio_Preventa.Location = new Point(18, 321);
            lblPrecio_Preventa.Name = "lblPrecio_Preventa";
            lblPrecio_Preventa.Size = new Size(119, 20);
            lblPrecio_Preventa.TabIndex = 20;
            lblPrecio_Preventa.Text = "Precio_Preventa";
            // 
            // lblCapacidad_Persona
            // 
            lblCapacidad_Persona.AutoSize = true;
            lblCapacidad_Persona.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCapacidad_Persona.ForeColor = Color.CornflowerBlue;
            lblCapacidad_Persona.Location = new Point(18, 385);
            lblCapacidad_Persona.Name = "lblCapacidad_Persona";
            lblCapacidad_Persona.Size = new Size(143, 20);
            lblCapacidad_Persona.TabIndex = 21;
            lblCapacidad_Persona.Text = "Capacidad Persona";
            // 
            // lblFechaFormato
            // 
            lblFechaFormato.AutoSize = true;
            lblFechaFormato.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblFechaFormato.ForeColor = Color.CornflowerBlue;
            lblFechaFormato.Location = new Point(305, 220);
            lblFechaFormato.Name = "lblFechaFormato";
            lblFechaFormato.Size = new Size(99, 20);
            lblFechaFormato.TabIndex = 22;
            lblFechaFormato.Text = "Dia/Mes/Año";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dkan_Music_Live;
            pictureBox1.Location = new Point(227, -1);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 118);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // AgregarEvento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(660, 426);
            Controls.Add(pictureBox1);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AgregarEvento";
            Text = "AgregarEvento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}