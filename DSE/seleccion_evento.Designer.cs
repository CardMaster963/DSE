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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(252, 46);
            txt1.Name = "txt1";
            txt1.Size = new Size(184, 27);
            txt1.TabIndex = 13;
            // 
            // lblIdEvento
            // 
            lblIdEvento.AutoSize = true;
            lblIdEvento.Location = new Point(293, 23);
            lblIdEvento.Name = "lblIdEvento";
            lblIdEvento.Size = new Size(94, 20);
            lblIdEvento.TabIndex = 19;
            lblIdEvento.Text = "Clave evento";
            // 
            // btnSeleccionEvento
            // 
            btnSeleccionEvento.Enabled = false;
            btnSeleccionEvento.Location = new Point(973, 29);
            btnSeleccionEvento.Name = "btnSeleccionEvento";
            btnSeleccionEvento.Size = new Size(176, 79);
            btnSeleccionEvento.TabIndex = 25;
            btnSeleccionEvento.Text = "Caja";
            btnSeleccionEvento.UseVisualStyleBackColor = true;
            btnSeleccionEvento.Click += btnSeleccionEvento_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1144, 371);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(13, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(200, 50);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Mostrar eventos";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(519, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 124);
            listBox1.TabIndex = 28;
            // 
            // btn_Alta_Evento
            // 
            btn_Alta_Evento.Location = new Point(23, 97);
            btn_Alta_Evento.Name = "btn_Alta_Evento";
            btn_Alta_Evento.Size = new Size(176, 65);
            btn_Alta_Evento.TabIndex = 29;
            btn_Alta_Evento.Text = "Dar de alta evento";
            btn_Alta_Evento.UseVisualStyleBackColor = true;
            btn_Alta_Evento.Click += btn_Alta_Evento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 178);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 30;
            label1.Text = "Has clic en el evento correspondiente: ";
            // 
            // btnBD
            // 
            btnBD.Location = new Point(238, 97);
            btnBD.Name = "btnBD";
            btnBD.Size = new Size(198, 65);
            btnBD.TabIndex = 31;
            btnBD.Text = "Base de datos";
            btnBD.UseVisualStyleBackColor = true;
            btnBD.Click += btnBD_Click;
            // 
            // seleccion_evento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 628);
            Controls.Add(btnBD);
            Controls.Add(label1);
            Controls.Add(btn_Alta_Evento);
            Controls.Add(listBox1);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(btnSeleccionEvento);
            Controls.Add(lblIdEvento);
            Controls.Add(txt1);
            Name = "seleccion_evento";
            Text = "seleccion_evento";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}