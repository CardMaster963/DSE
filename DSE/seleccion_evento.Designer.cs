namespace DSE
{
    partial class seleccion_evento
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
            txt1 = new TextBox();
            lblIdEvento = new Label();
            btnSeleccionEvento = new Button();
            dataGridView1 = new DataGridView();
            btnBuscar = new Button();
            btn_Alta_Evento = new Button();
            label1 = new Label();
            btnBD = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.BackColor = Color.FromArgb(67, 67, 67);
            txt1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txt1.ForeColor = Color.CornflowerBlue;
            txt1.Location = new Point(333, 38);
            txt1.Name = "txt1";
            txt1.Size = new Size(191, 27);
            txt1.TabIndex = 13;
            // 
            // lblIdEvento
            // 
            lblIdEvento.AutoSize = true;
            lblIdEvento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblIdEvento.ForeColor = Color.CornflowerBlue;
            lblIdEvento.Location = new Point(333, 14);
            lblIdEvento.Name = "lblIdEvento";
            lblIdEvento.Size = new Size(54, 20);
            lblIdEvento.TabIndex = 19;
            lblIdEvento.Text = "Buscar";
            // 
            // btnSeleccionEvento
            // 
            btnSeleccionEvento.BackColor = Color.FromArgb(67, 67, 67);
            btnSeleccionEvento.Enabled = false;
            btnSeleccionEvento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSeleccionEvento.ForeColor = Color.CornflowerBlue;
            btnSeleccionEvento.Location = new Point(991, 47);
            btnSeleccionEvento.Name = "btnSeleccionEvento";
            btnSeleccionEvento.Size = new Size(176, 96);
            btnSeleccionEvento.TabIndex = 25;
            btnSeleccionEvento.Text = "Caja";
            btnSeleccionEvento.UseVisualStyleBackColor = false;
            btnSeleccionEvento.Click += btnSeleccionEvento_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(67, 67, 67);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1144, 425);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(67, 67, 67);
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.CornflowerBlue;
            btnBuscar.Location = new Point(333, 83);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(191, 77);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Mostrar eventos";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btn_Alta_Evento
            // 
            btn_Alta_Evento.BackColor = Color.FromArgb(67, 67, 67);
            btn_Alta_Evento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Alta_Evento.ForeColor = Color.CornflowerBlue;
            btn_Alta_Evento.Location = new Point(660, 100);
            btn_Alta_Evento.Name = "btn_Alta_Evento";
            btn_Alta_Evento.Size = new Size(185, 60);
            btn_Alta_Evento.TabIndex = 29;
            btn_Alta_Evento.Text = "Dar de alta evento";
            btn_Alta_Evento.UseVisualStyleBackColor = false;
            btn_Alta_Evento.Click += btn_Alta_Evento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(23, 178);
            label1.Name = "label1";
            label1.Size = new Size(272, 20);
            label1.TabIndex = 30;
            label1.Text = "Has clic en el evento correspondiente: ";
            // 
            // btnBD
            // 
            btnBD.BackColor = Color.FromArgb(67, 67, 67);
            btnBD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBD.ForeColor = Color.CornflowerBlue;
            btnBD.Location = new Point(660, 22);
            btnBD.Name = "btnBD";
            btnBD.Size = new Size(185, 58);
            btnBD.TabIndex = 31;
            btnBD.Text = "Base de datos";
            btnBD.UseVisualStyleBackColor = false;
            btnBD.Click += btnBD_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DML__250x250_;
            pictureBox1.Location = new Point(23, -40);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 216);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // seleccion_evento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(1188, 651);
            Controls.Add(pictureBox1);
            Controls.Add(btnBD);
            Controls.Add(label1);
            Controls.Add(btn_Alta_Evento);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(btnSeleccionEvento);
            Controls.Add(lblIdEvento);
            Controls.Add(txt1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "seleccion_evento";
            Text = "seleccion_evento";
            Load += seleccion_evento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private Label lblIdEvento;
        private Button btnSeleccionEvento;
        private DataGridView dataGridView1;
        private Button btnBuscar;
        private Button btn_Alta_Evento;
        private Label label1;
        private Button btnBD;
        private PictureBox pictureBox1;
    }
}