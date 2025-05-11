namespace DSE
{
    partial class Login
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
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(173, 316);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 31);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(173, 373);
            txtContraseña.Margin = new Padding(4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(155, 31);
            txtContraseña.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(67, 67, 67);
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.CornflowerBlue;
            btnLogin.Location = new Point(123, 444);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(153, 60);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(67, 322);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(67, 379);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DML__250x250_;
            pictureBox1.Location = new Point(67, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 196);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(402, 561);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Margin = new Padding(4);
            Name = "Login";
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}