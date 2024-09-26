namespace PañalHome
{
    partial class FormIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngreso));
            gbIngreso = new GroupBox();
            btnIngresar = new Button();
            txtContraseña = new TextBox();
            txtUsuarioIngreso = new TextBox();
            lblIniciarSesion = new Label();
            picIngresoPH = new PictureBox();
            label1 = new Label();
            gbIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIngresoPH).BeginInit();
            SuspendLayout();
            // 
            // gbIngreso
            // 
            gbIngreso.BackColor = SystemColors.ControlLightLight;
            gbIngreso.Controls.Add(btnIngresar);
            gbIngreso.Controls.Add(txtContraseña);
            gbIngreso.Controls.Add(txtUsuarioIngreso);
            gbIngreso.Controls.Add(lblIniciarSesion);
            gbIngreso.Location = new Point(429, 43);
            gbIngreso.Name = "gbIngreso";
            gbIngreso.Size = new Size(442, 360);
            gbIngreso.TabIndex = 0;
            gbIngreso.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.SandyBrown;
            btnIngresar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(130, 255);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(212, 53);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "&Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = SystemColors.ControlDark;
            txtContraseña.Location = new Point(25, 173);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(393, 33);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "Contraseña";
            // 
            // txtUsuarioIngreso
            // 
            txtUsuarioIngreso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuarioIngreso.ForeColor = SystemColors.ControlDark;
            txtUsuarioIngreso.Location = new Point(25, 115);
            txtUsuarioIngreso.Name = "txtUsuarioIngreso";
            txtUsuarioIngreso.Size = new Size(393, 33);
            txtUsuarioIngreso.TabIndex = 1;
            txtUsuarioIngreso.Text = "Numero de documento";
            // 
            // lblIniciarSesion
            // 
            lblIniciarSesion.AutoSize = true;
            lblIniciarSesion.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIniciarSesion.Location = new Point(130, 38);
            lblIniciarSesion.Name = "lblIniciarSesion";
            lblIniciarSesion.Size = new Size(196, 40);
            lblIniciarSesion.TabIndex = 0;
            lblIniciarSesion.Text = "Iniciar sesión";
            // 
            // picIngresoPH
            // 
            picIngresoPH.Image = (Image)resources.GetObject("picIngresoPH.Image");
            picIngresoPH.Location = new Point(113, 59);
            picIngresoPH.Name = "picIngresoPH";
            picIngresoPH.Size = new Size(185, 155);
            picIngresoPH.TabIndex = 1;
            picIngresoPH.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 239);
            label1.Name = "label1";
            label1.Size = new Size(385, 147);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(901, 450);
            Controls.Add(label1);
            Controls.Add(picIngresoPH);
            Controls.Add(gbIngreso);
            Name = "FormIngreso";
            Text = "FormIngreso";
            gbIngreso.ResumeLayout(false);
            gbIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIngresoPH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbIngreso;
        private Label lblIniciarSesion;
        private Button btnIngresar;
        private TextBox txtContraseña;
        private TextBox txtUsuarioIngreso;
        private PictureBox picIngresoPH;
        private Label label1;
    }
}