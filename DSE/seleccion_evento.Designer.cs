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
            listBox1 = new ListBox();
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
            txt1.Location = new Point(529, 53);
            txt1.Margin = new Padding(4);
            txt1.Name = "txt1";
            txt1.Size = new Size(181, 31);
            txt1.TabIndex = 13;
            // 
            // lblIdEvento
            // 
            lblIdEvento.AutoSize = true;
            lblIdEvento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblIdEvento.ForeColor = Color.CornflowerBlue;
            lblIdEvento.Location = new Point(556, 25);
            lblIdEvento.Margin = new Padding(4, 0, 4, 0);
            lblIdEvento.Name = "lblIdEvento";
            lblIdEvento.Size = new Size(119, 25);
            lblIdEvento.TabIndex = 19;
            lblIdEvento.Text = "Clave evento";
            // 
            // btnSeleccionEvento
            // 
            btnSeleccionEvento.BackColor = Color.FromArgb(67, 67, 67);
            btnSeleccionEvento.Enabled = false;
            btnSeleccionEvento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSeleccionEvento.ForeColor = Color.CornflowerBlue;
            btnSeleccionEvento.Location = new Point(1239, 25);
            btnSeleccionEvento.Margin = new Padding(4);
            btnSeleccionEvento.Name = "btnSeleccionEvento";
            btnSeleccionEvento.Size = new Size(220, 154);
            btnSeleccionEvento.TabIndex = 25;
            btnSeleccionEvento.Text = "Caja";
            btnSeleccionEvento.UseVisualStyleBackColor = false;
            btnSeleccionEvento.Click += btnSeleccionEvento_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(67, 67, 67);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 251);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1430, 464);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(67, 67, 67);
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.CornflowerBlue;
            btnBuscar.Location = new Point(330, 25);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(181, 59);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Mostrar eventos";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(67, 67, 67);
            listBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            listBox1.ForeColor = Color.CornflowerBlue;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(731, 25);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(484, 154);
            listBox1.TabIndex = 28;
            // 
            // btn_Alta_Evento
            // 
            btn_Alta_Evento.BackColor = Color.FromArgb(67, 67, 67);
            btn_Alta_Evento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Alta_Evento.ForeColor = Color.CornflowerBlue;
            btn_Alta_Evento.Location = new Point(330, 120);
            btn_Alta_Evento.Margin = new Padding(4);
            btn_Alta_Evento.Name = "btn_Alta_Evento";
            btn_Alta_Evento.Size = new Size(181, 59);
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
            label1.Location = new Point(29, 222);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 25);
            label1.TabIndex = 30;
            label1.Text = "Has clic en el evento correspondiente: ";
            // 
            // btnBD
            // 
            btnBD.BackColor = Color.FromArgb(67, 67, 67);
            btnBD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBD.ForeColor = Color.CornflowerBlue;
            btnBD.Location = new Point(529, 120);
            btnBD.Margin = new Padding(4);
            btnBD.Name = "btnBD";
            btnBD.Size = new Size(181, 59);
            btnBD.TabIndex = 31;
            btnBD.Text = "Base de datos";
            btnBD.UseVisualStyleBackColor = false;
            btnBD.Click += btnBD_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dkan_Music_Live;
            pictureBox1.Location = new Point(29, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 154);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // seleccion_evento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(1485, 742);
            Controls.Add(pictureBox1);
            Controls.Add(btnBD);
            Controls.Add(label1);
            Controls.Add(btn_Alta_Evento);
            Controls.Add(listBox1);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(btnSeleccionEvento);
            Controls.Add(lblIdEvento);
            Controls.Add(txt1);
            Margin = new Padding(4);
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
        private ListBox listBox1;
        private Button btn_Alta_Evento;
        private Label label1;
        private Button btnBD;
        private PictureBox pictureBox1;
    }
}