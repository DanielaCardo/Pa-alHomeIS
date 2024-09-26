namespace PañalHome
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            btnSolicitudDomicilio = new Button();
            btnSeguirDomicilio = new Button();
            btnAyuda = new Button();
            menuStrip1 = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            gbMenu = new GroupBox();
            lblPañalHomeMenu = new Label();
            lblDescripcion = new Label();
            pictureBox2 = new PictureBox();
            btnSalir = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSolicitudDomicilio
            // 
            btnSolicitudDomicilio.BackColor = Color.Snow;
            btnSolicitudDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSolicitudDomicilio.Location = new Point(62, 22);
            btnSolicitudDomicilio.Name = "btnSolicitudDomicilio";
            btnSolicitudDomicilio.Size = new Size(186, 43);
            btnSolicitudDomicilio.TabIndex = 0;
            btnSolicitudDomicilio.Text = "Solicitud Domicilio";
            btnSolicitudDomicilio.UseVisualStyleBackColor = false;
            btnSolicitudDomicilio.Click += btnSolicitudDomicilio_Click;
            // 
            // btnSeguirDomicilio
            // 
            btnSeguirDomicilio.BackColor = Color.Snow;
            btnSeguirDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeguirDomicilio.Location = new Point(323, 22);
            btnSeguirDomicilio.Name = "btnSeguirDomicilio";
            btnSeguirDomicilio.Size = new Size(190, 43);
            btnSeguirDomicilio.TabIndex = 1;
            btnSeguirDomicilio.Text = "Seguir Domicilio";
            btnSeguirDomicilio.UseVisualStyleBackColor = false;
            // 
            // btnAyuda
            // 
            btnAyuda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAyuda.Location = new Point(601, 22);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(140, 43);
            btnAyuda.TabIndex = 2;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(877, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            fileMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(140, 25);
            fileMenu.Text = "Datos Personales";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 246);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // gbMenu
            // 
            gbMenu.BackColor = Color.SandyBrown;
            gbMenu.Controls.Add(btnAyuda);
            gbMenu.Controls.Add(btnSolicitudDomicilio);
            gbMenu.Controls.Add(btnSeguirDomicilio);
            gbMenu.Location = new Point(37, 357);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(807, 81);
            gbMenu.TabIndex = 0;
            gbMenu.TabStop = false;
            // 
            // lblPañalHomeMenu
            // 
            lblPañalHomeMenu.AutoSize = true;
            lblPañalHomeMenu.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPañalHomeMenu.Location = new Point(446, 73);
            lblPañalHomeMenu.Name = "lblPañalHomeMenu";
            lblPañalHomeMenu.Size = new Size(232, 50);
            lblPañalHomeMenu.TabIndex = 3;
            lblPañalHomeMenu.Text = "Pañal Home";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(389, 168);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(389, 100);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "              Bienvenido a PañalHome \r\n\r\nUna aplicación que te permite pedir pañales \r\n     a domicilio de forma rápida y sencilla.\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(673, 64);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 59);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLightLight;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(527, 297);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 35);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 458);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox2);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPañalHomeMenu);
            Controls.Add(pictureBox1);
            Controls.Add(gbMenu);
            Controls.Add(menuStrip1);
            Name = "FormMenu";
            Text = "FormMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSeguirDomicilio;
        private Button btnSolicitudDomicilio;
        private Button btnAyuda;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenu;
        private PictureBox pictureBox1;
        private GroupBox gbMenu;
        private Label lblPañalHomeMenu;
        private Label lblDescripcion;
        private PictureBox pictureBox2;
        private Button btnSalir;
    }
}