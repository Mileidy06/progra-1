namespace Uso_de_conversores
{
    partial class Frm_usuario
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
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosUsuario = new System.Windows.Forms.Label();
            this.btnUltimoUsuario = new System.Windows.Forms.Button();
            this.btnSiguienteUsuario = new System.Windows.Forms.Button();
            this.btnAnteriorUsuario = new System.Windows.Forms.Button();
            this.btnPrimerUsuario = new System.Windows.Forms.Button();
            this.grbBotones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbUsuario = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.grbNavegacion.SuspendLayout();
            this.grbBotones.SuspendLayout();
            this.grbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblnRegistrosUsuario);
            this.grbNavegacion.Controls.Add(this.btnUltimoUsuario);
            this.grbNavegacion.Controls.Add(this.btnSiguienteUsuario);
            this.grbNavegacion.Controls.Add(this.btnAnteriorUsuario);
            this.grbNavegacion.Controls.Add(this.btnPrimerUsuario);
            this.grbNavegacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbNavegacion.Location = new System.Drawing.Point(315, 314);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(209, 93);
            this.grbNavegacion.TabIndex = 11;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "NAVEGACION";
            // 
            // lblnRegistrosUsuario
            // 
            this.lblnRegistrosUsuario.AutoSize = true;
            this.lblnRegistrosUsuario.Location = new System.Drawing.Point(86, 37);
            this.lblnRegistrosUsuario.Name = "lblnRegistrosUsuario";
            this.lblnRegistrosUsuario.Size = new System.Drawing.Size(36, 13);
            this.lblnRegistrosUsuario.TabIndex = 9;
            this.lblnRegistrosUsuario.Text = "x de n";
            // 
            // btnUltimoUsuario
            // 
            this.btnUltimoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUltimoUsuario.Location = new System.Drawing.Point(128, 18);
            this.btnUltimoUsuario.Name = "btnUltimoUsuario";
            this.btnUltimoUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnUltimoUsuario.TabIndex = 3;
            this.btnUltimoUsuario.Text = "Ultimo";
            this.btnUltimoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteUsuario
            // 
            this.btnSiguienteUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiguienteUsuario.Location = new System.Drawing.Point(128, 53);
            this.btnSiguienteUsuario.Name = "btnSiguienteUsuario";
            this.btnSiguienteUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteUsuario.TabIndex = 2;
            this.btnSiguienteUsuario.Text = "Siguiente";
            this.btnSiguienteUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorUsuario
            // 
            this.btnAnteriorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnteriorUsuario.Location = new System.Drawing.Point(11, 50);
            this.btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            this.btnAnteriorUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorUsuario.TabIndex = 1;
            this.btnAnteriorUsuario.Text = "Anterior";
            this.btnAnteriorUsuario.UseVisualStyleBackColor = true;
            // 
            // btnPrimerUsuario
            // 
            this.btnPrimerUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrimerUsuario.Location = new System.Drawing.Point(15, 20);
            this.btnPrimerUsuario.Name = "btnPrimerUsuario";
            this.btnPrimerUsuario.Size = new System.Drawing.Size(65, 23);
            this.btnPrimerUsuario.TabIndex = 0;
            this.btnPrimerUsuario.Text = "Primer";
            this.btnPrimerUsuario.UseVisualStyleBackColor = true;
            this.btnPrimerUsuario.Click += new System.EventHandler(this.btnPrimerUsuario_Click);
            // 
            // grbBotones
            // 
            this.grbBotones.Controls.Add(this.btnEliminar);
            this.grbBotones.Controls.Add(this.btnModificar);
            this.grbBotones.Controls.Add(this.btnAgregar);
            this.grbBotones.Location = new System.Drawing.Point(480, 94);
            this.grbBotones.Name = "grbBotones";
            this.grbBotones.Size = new System.Drawing.Size(261, 193);
            this.grbBotones.TabIndex = 10;
            this.grbBotones.TabStop = false;
            this.grbBotones.Text = "Botones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(137, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 91);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(29, 61);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grbUsuario
            // 
            this.grbUsuario.Controls.Add(this.txtTelefono);
            this.grbUsuario.Controls.Add(this.txtDireccion);
            this.grbUsuario.Controls.Add(this.txtNombre);
            this.grbUsuario.Controls.Add(this.txtClave);
            this.grbUsuario.Controls.Add(this.txtUsuario);
            this.grbUsuario.Controls.Add(this.lblId);
            this.grbUsuario.Controls.Add(this.lblTelefono);
            this.grbUsuario.Controls.Add(this.lblDireccion);
            this.grbUsuario.Controls.Add(this.lblNombre);
            this.grbUsuario.Controls.Add(this.lblClave);
            this.grbUsuario.Controls.Add(this.lblUsuario);
            this.grbUsuario.Controls.Add(this.lblIdUsuario);
            this.grbUsuario.Location = new System.Drawing.Point(59, 43);
            this.grbUsuario.Name = "grbUsuario";
            this.grbUsuario.Size = new System.Drawing.Size(343, 265);
            this.grbUsuario.TabIndex = 9;
            this.grbUsuario.TabStop = false;
            this.grbUsuario.Text = "Usuarios";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(96, 175);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(79, 149);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(79, 80);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(79, 51);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(76, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(17, 173);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 142);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(17, 80);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(17, 51);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(16, 20);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(52, 13);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "IdUsuario";
            // 
            // Frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbBotones);
            this.Controls.Add(this.grbUsuario);
            this.Name = "Frm_usuario";
            this.Text = "Frm_usuario";
            this.Load += new System.EventHandler(this.Frm_usuario_Load);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbBotones.ResumeLayout(false);
            this.grbUsuario.ResumeLayout(false);
            this.grbUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Label lblnRegistrosUsuario;
        private System.Windows.Forms.Button btnUltimoUsuario;
        private System.Windows.Forms.Button btnSiguienteUsuario;
        private System.Windows.Forms.Button btnAnteriorUsuario;
        private System.Windows.Forms.Button btnPrimerUsuario;
        private System.Windows.Forms.GroupBox grbBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grbUsuario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
    }
}