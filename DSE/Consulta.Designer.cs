namespace DSE
{
    partial class Consulta
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
            dataGridView1 = new DataGridView();
            btnConsulta = new Button();
            txt1 = new TextBox();
            lblTotalRes = new Label();
            lblCantidadRes = new Label();
            lblTotal = new Label();
            lblCantidad = new Label();
            btnBuscar = new Button();
            dataGridView2 = new DataGridView();
            btn_BorrarVenta = new Button();
            btn_BorrarEvento = new Button();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(67, 67, 67);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(269, 38);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1111, 499);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.FromArgb(67, 67, 67);
            btnConsulta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConsulta.ForeColor = Color.CornflowerBlue;
            btnConsulta.Location = new Point(32, 170);
            btnConsulta.Margin = new Padding(4);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(210, 55);
            btnConsulta.TabIndex = 1;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += btnConsultar;
            // 
            // txt1
            // 
            txt1.BackColor = Color.FromArgb(67, 67, 67);
            txt1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            txt1.ForeColor = Color.CornflowerBlue;
            txt1.Location = new Point(32, 267);
            txt1.Margin = new Padding(4);
            txt1.Name = "txt1";
            txt1.Size = new Size(210, 32);
            txt1.TabIndex = 2;
            // 
            // lblTotalRes
            // 
            lblTotalRes.AutoSize = true;
            lblTotalRes.BackColor = Color.FromArgb(67, 67, 67);
            lblTotalRes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblTotalRes.ForeColor = Color.CornflowerBlue;
            lblTotalRes.Location = new Point(186, 447);
            lblTotalRes.Margin = new Padding(4, 0, 4, 0);
            lblTotalRes.Name = "lblTotalRes";
            lblTotalRes.Size = new Size(0, 25);
            lblTotalRes.TabIndex = 3;
            // 
            // lblCantidadRes
            // 
            lblCantidadRes.AutoSize = true;
            lblCantidadRes.BackColor = Color.FromArgb(67, 67, 67);
            lblCantidadRes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCantidadRes.ForeColor = Color.CornflowerBlue;
            lblCantidadRes.Location = new Point(176, 429);
            lblCantidadRes.Margin = new Padding(4, 0, 4, 0);
            lblCantidadRes.Name = "lblCantidadRes";
            lblCantidadRes.Size = new Size(0, 25);
            lblCantidadRes.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblTotal.ForeColor = Color.CornflowerBlue;
            lblTotal.Location = new Point(32, 404);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(210, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Dinero Total Conseguido";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCantidad.ForeColor = Color.CornflowerBlue;
            lblCantidad.Location = new Point(32, 490);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(147, 25);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Boletos vendidos";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(67, 67, 67);
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnBuscar.ForeColor = Color.CornflowerBlue;
            btnBuscar.Location = new Point(32, 309);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(210, 45);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(67, 67, 67);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(269, 561);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1111, 156);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btn_BorrarVenta
            // 
            btn_BorrarVenta.BackColor = Color.FromArgb(67, 67, 67);
            btn_BorrarVenta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_BorrarVenta.ForeColor = Color.CornflowerBlue;
            btn_BorrarVenta.Location = new Point(39, 662);
            btn_BorrarVenta.Margin = new Padding(4);
            btn_BorrarVenta.Name = "btn_BorrarVenta";
            btn_BorrarVenta.Size = new Size(203, 55);
            btn_BorrarVenta.TabIndex = 10;
            btn_BorrarVenta.Text = "Borrar venta";
            btn_BorrarVenta.UseVisualStyleBackColor = false;
            btn_BorrarVenta.Click += btn_BorrarVenta_Click;
            // 
            // btn_BorrarEvento
            // 
            btn_BorrarEvento.BackColor = Color.FromArgb(67, 67, 67);
            btn_BorrarEvento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_BorrarEvento.ForeColor = Color.CornflowerBlue;
            btn_BorrarEvento.Location = new Point(39, 599);
            btn_BorrarEvento.Margin = new Padding(4);
            btn_BorrarEvento.Name = "btn_BorrarEvento";
            btn_BorrarEvento.Size = new Size(203, 55);
            btn_BorrarEvento.TabIndex = 11;
            btn_BorrarEvento.Text = "Borrar evento";
            btn_BorrarEvento.UseVisualStyleBackColor = false;
            btn_BorrarEvento.Click += btn_BorrarEvento_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(966, 490);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(68, 570);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 15;
            label1.Text = "Boletos vendidos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dkan_Music_Live;
            pictureBox1.Location = new Point(32, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 119);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(1406, 735);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btn_BorrarEvento);
            Controls.Add(btn_BorrarVenta);
            Controls.Add(dataGridView2);
            Controls.Add(btnBuscar);
            Controls.Add(lblCantidad);
            Controls.Add(lblTotal);
            Controls.Add(lblCantidadRes);
            Controls.Add(lblTotalRes);
            Controls.Add(txt1);
            Controls.Add(btnConsulta);
            Controls.Add(dataGridView1);
            Margin = new Padding(4);
            Name = "Consulta";
            Text = "Consulta";
            Load += Consulta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnConsulta;
        private TextBox textBox1;
        private Label lblTotalRes;
        private Label lblCantidadRes;
        private Label lblTotal;
        private Label lblCantidad;
        private Button btnBuscar;
        private TextBox txt1;
        private DataGridView dataGridView2;
        private Button btn_BorrarVenta;
        private Button btn_BorrarEvento;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}