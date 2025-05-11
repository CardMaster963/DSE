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
            dataGridView1.Location = new Point(258, 36);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1046, 364);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.FromArgb(67, 67, 67);
            btnConsulta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConsulta.ForeColor = Color.CornflowerBlue;
            btnConsulta.Location = new Point(15, 165);
            btnConsulta.Margin = new Padding(4);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(210, 71);
            btnConsulta.TabIndex = 1;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += btnConsultar;
            // 
            // txt1
            // 
            txt1.BackColor = Color.FromArgb(67, 67, 67);
            txt1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt1.ForeColor = Color.CornflowerBlue;
            txt1.Location = new Point(15, 289);
            txt1.Margin = new Padding(4);
            txt1.Name = "txt1";
            txt1.Size = new Size(210, 32);
            txt1.TabIndex = 2;
            // 
            // lblTotalRes
            // 
            lblTotalRes.AutoSize = true;
            lblTotalRes.Location = new Point(169, 268);
            lblTotalRes.Margin = new Padding(4, 0, 4, 0);
            lblTotalRes.Name = "lblTotalRes";
            lblTotalRes.Size = new Size(0, 25);
            lblTotalRes.TabIndex = 3;
            // 
            // lblCantidadRes
            // 
            lblCantidadRes.AutoSize = true;
            lblCantidadRes.Location = new Point(169, 352);
            lblCantidadRes.Margin = new Padding(4, 0, 4, 0);
            lblCantidadRes.Name = "lblCantidadRes";
            lblCantidadRes.Size = new Size(0, 25);
            lblCantidadRes.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.CornflowerBlue;
            lblTotal.Location = new Point(15, 435);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(210, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Dinero Total Conseguido";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.CornflowerBlue;
            lblCantidad.Location = new Point(15, 474);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(147, 25);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Boletos vendidos";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(67, 67, 67);
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.CornflowerBlue;
            btnBuscar.Location = new Point(15, 329);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(210, 71);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(67, 67, 67);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(258, 435);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1046, 249);
            dataGridView2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dkan_Music_Live;
            pictureBox1.Location = new Point(44, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 122);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 35);
            ClientSize = new Size(1328, 708);
            Controls.Add(pictureBox1);
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
        private PictureBox pictureBox1;
    }
}