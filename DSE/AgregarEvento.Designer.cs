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
            txtId.ForeColor = Color.CornflowerBlue;
            txtId.Location = new Point(207, 211);
            txtId.Margin = new Padding(4);
            txtId.Name = "txtId";
            txtId.Size = new Size(155, 32);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(67, 67, 67);
            txtNombre.ForeColor = Color.CornflowerBlue;
            txtNombre.Location = new Point(207, 253);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 32);
            txtNombre.TabIndex = 4;
            // 
            // txtLugar
            // 
            txtLugar.BackColor = Color.FromArgb(67, 67, 67);
            txtLugar.ForeColor = Color.CornflowerBlue;
            txtLugar.Location = new Point(207, 335);
            txtLugar.Margin = new Padding(4);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(155, 32);
            txtLugar.TabIndex = 6;
            // 
            // txtPrecio_Preventa
            // 
            txtPrecio_Preventa.BackColor = Color.FromArgb(67, 67, 67);
            txtPrecio_Preventa.ForeColor = Color.CornflowerBlue;
            txtPrecio_Preventa.Location = new Point(207, 417);
            txtPrecio_Preventa.Margin = new Padding(4);
            txtPrecio_Preventa.Name = "txtPrecio_Preventa";
            txtPrecio_Preventa.Size = new Size(155, 32);
            txtPrecio_Preventa.TabIndex = 8;
            // 
            // txtPrecio_Taquilla
            // 
            txtPrecio_Taquilla.BackColor = Color.FromArgb(67, 67, 67);
            txtPrecio_Taquilla.ForeColor = Color.CornflowerBlue;
            txtPrecio_Taquilla.Location = new Point(207, 459);
            txtPrecio_Taquilla.Margin = new Padding(4);
            txtPrecio_Taquilla.Name = "txtPrecio_Taquilla";
            txtPrecio_Taquilla.Size = new Size(155, 32);
            txtPrecio_Taquilla.TabIndex = 9;
            // 
            // txtCapacidad_Personas
            // 
            txtCapacidad_Personas.BackColor = Color.FromArgb(67, 67, 67);
            txtCapacidad_Personas.ForeColor = Color.CornflowerBlue;
            txtCapacidad_Personas.Location = new Point(207, 500);
            txtCapacidad_Personas.Margin = new Padding(4);
            txtCapacidad_Personas.Name = "txtCapacidad_Personas";
            txtCapacidad_Personas.Size = new Size(155, 32);
            txtCapacidad_Personas.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(67, 67, 67);
            btnAgregar.ForeColor = Color.CornflowerBlue;
            btnAgregar.Location = new Point(512, 199);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(284, 211);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar Registros";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Registros_Click;
            // 
            // mskFecha
            // 
            mskFecha.BackColor = Color.FromArgb(67, 67, 67);
            mskFecha.ForeColor = Color.CornflowerBlue;
            mskFecha.Location = new Point(207, 294);
            mskFecha.Margin = new Padding(4);
            mskFecha.Mask = "00/00/0000";
            mskFecha.Name = "mskFecha";
            mskFecha.Size = new Size(155, 32);
            mskFecha.TabIndex = 12;
            mskFecha.ValidatingType = typeof(DateTime);
            // 
            // mskHora
            // 
            mskHora.BackColor = Color.FromArgb(67, 67, 67);
            mskHora.ForeColor = Color.CornflowerBlue;
            mskHora.Location = new Point(207, 376);
            mskHora.Margin = new Padding(4);
            mskHora.Mask = "00:00";
            mskHora.Name = "mskHora";
            mskHora.Size = new Size(155, 32);
            mskHora.TabIndex = 13;
            mskHora.ValidatingType = typeof(DateTime);
            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEvento.ForeColor = Color.CornflowerBlue;
            lblEvento.Location = new Point(31, 214);
            lblEvento.Margin = new Padding(4, 0, 4, 0);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(90, 25);
            lblEvento.TabIndex = 14;
            lblEvento.Text = "ID_Evento";
            // 
            // lblNombre_Evento
            // 
            lblNombre_Evento.AutoSize = true;
            lblNombre_Evento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNombre_Evento.ForeColor = Color.CornflowerBlue;
            lblNombre_Evento.Location = new Point(31, 256);
            lblNombre_Evento.Margin = new Padding(4, 0, 4, 0);
            lblNombre_Evento.Name = "lblNombre_Evento";
            lblNombre_Evento.Size = new Size(136, 25);
            lblNombre_Evento.TabIndex = 15;
            lblNombre_Evento.Text = "Nombre evento";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.CornflowerBlue;
            lblFecha.Location = new Point(31, 297);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(116, 25);
            lblFecha.TabIndex = 16;
            lblFecha.Text = "Fecha evento";
            // 
            // lblLugar
            // 
            lblLugar.AutoSize = true;
            lblLugar.ForeColor = Color.CornflowerBlue;
            lblLugar.Location = new Point(31, 338);
            lblLugar.Margin = new Padding(4, 0, 4, 0);
            lblLugar.Name = "lblLugar";
            lblLugar.Size = new Size(58, 25);
            lblLugar.TabIndex = 17;
            lblLugar.Text = "Lugar";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.ForeColor = Color.CornflowerBlue;
            lblHora.Location = new Point(31, 379);
            lblHora.Margin = new Padding(4, 0, 4, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(52, 25);
            lblHora.TabIndex = 18;
            lblHora.Text = "Hora";
            // 
            // lblPrecio_Taquilla
            // 
            lblPrecio_Taquilla.AutoSize = true;
            lblPrecio_Taquilla.ForeColor = Color.CornflowerBlue;
            lblPrecio_Taquilla.Location = new Point(31, 462);
            lblPrecio_Taquilla.Margin = new Padding(4, 0, 4, 0);
            lblPrecio_Taquilla.Name = "lblPrecio_Taquilla";
            lblPrecio_Taquilla.Size = new Size(128, 25);
            lblPrecio_Taquilla.TabIndex = 19;
            lblPrecio_Taquilla.Text = "Precio taquilla";
            // 
            // lblPrecio_Preventa
            // 
            lblPrecio_Preventa.AutoSize = true;
            lblPrecio_Preventa.ForeColor = Color.CornflowerBlue;
            lblPrecio_Preventa.Location = new Point(31, 420);
            lblPrecio_Preventa.Margin = new Padding(4, 0, 4, 0);
            lblPrecio_Preventa.Name = "lblPrecio_Preventa";
            lblPrecio_Preventa.Size = new Size(140, 25);
            lblPrecio_Preventa.TabIndex = 20;
            lblPrecio_Preventa.Text = "Precio_Preventa";
            // 
            // lblCapacidad_Persona
            // 
            lblCapacidad_Persona.AutoSize = true;
            lblCapacidad_Persona.ForeColor = Color.CornflowerBlue;
            lblCapacidad_Persona.Location = new Point(31, 503);
            lblCapacidad_Persona.Margin = new Padding(4, 0, 4, 0);
            lblCapacidad_Persona.Name = "lblCapacidad_Persona";
            lblCapacidad_Persona.Size = new Size(166, 25);
            lblCapacidad_Persona.TabIndex = 21;
            lblCapacidad_Persona.Text = "Capacidad Persona";
            // 
            // lblFechaFormato
            // 
            lblFechaFormato.AutoSize = true;
            lblFechaFormato.ForeColor = Color.CornflowerBlue;
            lblFechaFormato.Location = new Point(382, 297);
            lblFechaFormato.Margin = new Padding(4, 0, 4, 0);
            lblFechaFormato.Name = "lblFechaFormato";
            lblFechaFormato.Size = new Size(120, 25);
            lblFechaFormato.TabIndex = 22;
            lblFechaFormato.Text = "Dia/Mes/Año";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dkan_Music_Live;
            pictureBox1.Location = new Point(17, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 143);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // AgregarEvento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(829, 586);
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
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            Margin = new Padding(4);
            Name = "AgregarEvento";
            Text = "AgregarEvento";
            Load += AgregarEvento_Load;
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