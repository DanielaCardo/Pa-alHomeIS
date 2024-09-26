namespace PañalHome
{
    partial class FormSolicitudDomicilio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolicitudDomicilio));
            lblBienvenidaSolicitud = new Label();
            label2 = new Label();
            gbSolicitud = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            btnRealizarPedido = new Button();
            pictureBox2 = new PictureBox();
            btnVolver = new Button();
            ttpMensajeSD = new ToolTip(components);
            gbSolicitud.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenidaSolicitud
            // 
            lblBienvenidaSolicitud.AutoSize = true;
            lblBienvenidaSolicitud.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenidaSolicitud.Location = new Point(38, 36);
            lblBienvenidaSolicitud.Name = "lblBienvenidaSolicitud";
            lblBienvenidaSolicitud.Size = new Size(300, 32);
            lblBienvenidaSolicitud.TabIndex = 0;
            lblBienvenidaSolicitud.Text = "Bienvenido a su solicitud\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 34);
            label2.Name = "label2";
            label2.Size = new Size(262, 25);
            label2.TabIndex = 1;
            label2.Text = "Seleccione la fórmula médica";
            // 
            // gbSolicitud
            // 
            gbSolicitud.Controls.Add(comboBox1);
            gbSolicitud.Controls.Add(label2);
            gbSolicitud.Location = new Point(38, 98);
            gbSolicitud.Name = "gbSolicitud";
            gbSolicitud.Size = new Size(823, 85);
            gbSolicitud.TabIndex = 2;
            gbSolicitud.TabStop = false;
            gbSolicitud.Text = "Información de su Prescripción";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Formula - 001" });
            comboBox1.Location = new Point(301, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(501, 29);
            comboBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(823, 84);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(301, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(501, 29);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 34);
            label1.Name = "label1";
            label1.Size = new Size(275, 25);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la dirección de entrega";
            // 
            // btnRealizarPedido
            // 
            btnRealizarPedido.BackColor = Color.SandyBrown;
            btnRealizarPedido.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRealizarPedido.Location = new Point(38, 314);
            btnRealizarPedido.Name = "btnRealizarPedido";
            btnRealizarPedido.Size = new Size(218, 43);
            btnRealizarPedido.TabIndex = 4;
            btnRealizarPedido.Text = "Realizar Pedido";
            btnRealizarPedido.UseVisualStyleBackColor = false;
            btnRealizarPedido.Click += btnRealizarPedido_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(797, 350);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 59);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ScrollBar;
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(38, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 45);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "<< Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormSolicitudDomicilio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 436);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox2);
            Controls.Add(btnRealizarPedido);
            Controls.Add(groupBox1);
            Controls.Add(gbSolicitud);
            Controls.Add(lblBienvenidaSolicitud);
            Name = "FormSolicitudDomicilio";
            Text = "SolicitudDomicilio";
            gbSolicitud.ResumeLayout(false);
            gbSolicitud.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenidaSolicitud;
        private Label label2;
        private GroupBox gbSolicitud;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Button btnRealizarPedido;
        private PictureBox pictureBox2;
        private Button btnVolver;
        private ToolTip ttpMensajeSD;
    }
}