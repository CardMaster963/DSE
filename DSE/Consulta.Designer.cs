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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(237, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(906, 473);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(12, 12);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(94, 29);
            btnConsulta.TabIndex = 1;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsultar;
            // 
            // txt1
            // 
            txt1.Location = new Point(103, 111);
            txt1.Name = "txt1";
            txt1.Size = new Size(125, 27);
            txt1.TabIndex = 2;
            // 
            // lblTotalRes
            // 
            lblTotalRes.AutoSize = true;
            lblTotalRes.Location = new Point(135, 214);
            lblTotalRes.Name = "lblTotalRes";
            lblTotalRes.Size = new Size(0, 20);
            lblTotalRes.TabIndex = 3;
            // 
            // lblCantidadRes
            // 
            lblCantidadRes.AutoSize = true;
            lblCantidadRes.Location = new Point(135, 282);
            lblCantidadRes.Name = "lblCantidadRes";
            lblCantidadRes.Size = new Size(0, 20);
            lblCantidadRes.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 180);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(174, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Dinero Total Conseguido";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(12, 249);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(123, 20);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Boletos vendidos";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(3, 109);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(237, 542);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(906, 199);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btn_BorrarVenta
            // 
            btn_BorrarVenta.Location = new Point(92, 491);
            btn_BorrarVenta.Name = "btn_BorrarVenta";
            btn_BorrarVenta.Size = new Size(94, 29);
            btn_BorrarVenta.TabIndex = 10;
            btn_BorrarVenta.Text = "Borrar";
            btn_BorrarVenta.UseVisualStyleBackColor = true;
            btn_BorrarVenta.Click += btn_BorrarVenta_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1636, 772);
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
            Name = "Consulta";
            Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
    }
}