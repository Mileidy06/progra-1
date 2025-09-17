namespace Academica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.lblDeAlumnos = new System.Windows.Forms.Label();
            this.txtCodigoAlumnos = new System.Windows.Forms.TextBox();
            this.grbNavegaccionAlumnos = new System.Windows.Forms.GroupBox();
            this.btnPrimerAlumno = new System.Windows.Forms.Button();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.txtDirecionAlumnos = new System.Windows.Forms.TextBox();
            this.lblNombreAlumnos = new System.Windows.Forms.Label();
            this.txtNombreAlumnos = new System.Windows.Forms.TextBox();
            this.txtTelefonoAlumnos = new System.Windows.Forms.TextBox();
            this.lblDireccionAlumnos = new System.Windows.Forms.Label();
            this.lblTelefonoAlumnos = new System.Windows.Forms.Label();
            this.idAlumno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumnbo = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.grbDatosAlumnos.SuspendLayout();
            this.grbNavegaccionAlumnos.SuspendLayout();
            this.grbEdicionAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosAlumnos
            // 
            this.grbDatosAlumnos.Controls.Add(this.idAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblTelefonoAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.txtTelefonoAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.lblDireccionAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.txtNombreAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.txtDirecionAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.label3);
            this.grbDatosAlumnos.Controls.Add(this.lblNombreAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.label2);
            this.grbDatosAlumnos.Controls.Add(this.lblCodigoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtCodigoAlumnos);
            this.grbDatosAlumnos.Controls.Add(this.label1);
            this.grbDatosAlumnos.Controls.Add(this.lblDeAlumnos);
            this.grbDatosAlumnos.Location = new System.Drawing.Point(36, 32);
            this.grbDatosAlumnos.Name = "grbDatosAlumnos";
            this.grbDatosAlumnos.Size = new System.Drawing.Size(301, 221);
            this.grbDatosAlumnos.TabIndex = 0;
            this.grbDatosAlumnos.TabStop = false;
            this.grbDatosAlumnos.Text = "Datos";
            // 
            // lblDeAlumnos
            // 
            this.lblDeAlumnos.AutoSize = true;
            this.lblDeAlumnos.Location = new System.Drawing.Point(23, 29);
            this.lblDeAlumnos.Name = "lblDeAlumnos";
            this.lblDeAlumnos.Size = new System.Drawing.Size(21, 13);
            this.lblDeAlumnos.TabIndex = 0;
            this.lblDeAlumnos.Text = "ID:";
            // 
            // txtCodigoAlumnos
            // 
            this.txtCodigoAlumnos.Location = new System.Drawing.Point(88, 69);
            this.txtCodigoAlumnos.Name = "txtCodigoAlumnos";
            this.txtCodigoAlumnos.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAlumnos.TabIndex = 1;
            // 
            // grbNavegaccionAlumnos
            // 
            this.grbNavegaccionAlumnos.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegaccionAlumnos.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegaccionAlumnos.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegaccionAlumnos.Controls.Add(this.btnPrimerAlumno);
            this.grbNavegaccionAlumnos.Location = new System.Drawing.Point(49, 287);
            this.grbNavegaccionAlumnos.Name = "grbNavegaccionAlumnos";
            this.grbNavegaccionAlumnos.Size = new System.Drawing.Size(257, 100);
            this.grbNavegaccionAlumnos.TabIndex = 1;
            this.grbNavegaccionAlumnos.TabStop = false;
            this.grbNavegaccionAlumnos.Text = "Navegaccion";
            // 
            // btnPrimerAlumno
            // 
            this.btnPrimerAlumno.Location = new System.Drawing.Point(6, 49);
            this.btnPrimerAlumno.Name = "btnPrimerAlumno";
            this.btnPrimerAlumno.Size = new System.Drawing.Size(37, 23);
            this.btnPrimerAlumno.TabIndex = 0;
            this.btnPrimerAlumno.Text = "|<";
            this.btnPrimerAlumno.UseVisualStyleBackColor = true;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(26, 72);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(52, 13);
            this.lblCodigoAlumno.TabIndex = 2;
            this.lblCodigoAlumno.Text = "CODIGO:";
            // 
            // txtDirecionAlumnos
            // 
            this.txtDirecionAlumnos.Location = new System.Drawing.Point(88, 140);
            this.txtDirecionAlumnos.Name = "txtDirecionAlumnos";
            this.txtDirecionAlumnos.Size = new System.Drawing.Size(100, 20);
            this.txtDirecionAlumnos.TabIndex = 4;
            // 
            // lblNombreAlumnos
            // 
            this.lblNombreAlumnos.AutoSize = true;
            this.lblNombreAlumnos.Location = new System.Drawing.Point(26, 106);
            this.lblNombreAlumnos.Name = "lblNombreAlumnos";
            this.lblNombreAlumnos.Size = new System.Drawing.Size(57, 13);
            this.lblNombreAlumnos.TabIndex = 3;
            this.lblNombreAlumnos.Text = "NOMBRE:";
            // 
            // txtNombreAlumnos
            // 
            this.txtNombreAlumnos.Location = new System.Drawing.Point(88, 103);
            this.txtNombreAlumnos.Name = "txtNombreAlumnos";
            this.txtNombreAlumnos.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAlumnos.TabIndex = 5;
            // 
            // txtTelefonoAlumnos
            // 
            this.txtTelefonoAlumnos.Location = new System.Drawing.Point(88, 173);
            this.txtTelefonoAlumnos.Name = "txtTelefonoAlumnos";
            this.txtTelefonoAlumnos.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoAlumnos.TabIndex = 7;
            // 
            // lblDireccionAlumnos
            // 
            this.lblDireccionAlumnos.AutoSize = true;
            this.lblDireccionAlumnos.Location = new System.Drawing.Point(26, 143);
            this.lblDireccionAlumnos.Name = "lblDireccionAlumnos";
            this.lblDireccionAlumnos.Size = new System.Drawing.Size(69, 13);
            this.lblDireccionAlumnos.TabIndex = 6;
            this.lblDireccionAlumnos.Text = "DIRECCION:";
            // 
            // lblTelefonoAlumnos
            // 
            this.lblTelefonoAlumnos.AutoSize = true;
            this.lblTelefonoAlumnos.Location = new System.Drawing.Point(26, 176);
            this.lblTelefonoAlumnos.Name = "lblTelefonoAlumnos";
            this.lblTelefonoAlumnos.Size = new System.Drawing.Size(67, 13);
            this.lblTelefonoAlumnos.TabIndex = 8;
            this.lblTelefonoAlumnos.Text = "TELEFONO:";
            // 
            // idAlumno
            // 
            this.idAlumno.AutoSize = true;
            this.idAlumno.Location = new System.Drawing.Point(88, 29);
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.Size = new System.Drawing.Size(50, 13);
            this.idAlumno.TabIndex = 9;
            this.idAlumno.Text = "idAlumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CODIGO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE:";
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(49, 49);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(33, 23);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(156, 49);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(32, 23);
            this.btnSiguienteAlumno.TabIndex = 2;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Location = new System.Drawing.Point(208, 49);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(35, 23);
            this.btnUltimoAlumno.TabIndex = 3;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumnbo);
            this.grbEdicionAlumno.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(356, 287);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(257, 100);
            this.grbEdicionAlumno.TabIndex = 4;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edicion ";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(165, 48);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(62, 23);
            this.btnEliminarAlumno.TabIndex = 2;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumnbo
            // 
            this.btnModificarAlumnbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumnbo.Location = new System.Drawing.Point(81, 48);
            this.btnModificarAlumnbo.Name = "btnModificarAlumnbo";
            this.btnModificarAlumnbo.Size = new System.Drawing.Size(78, 23);
            this.btnModificarAlumnbo.TabIndex = 1;
            this.btnModificarAlumnbo.Text = "Modificar";
            this.btnModificarAlumnbo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(6, 49);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(56, 23);
            this.btnAgregarAlumno.TabIndex = 0;
            this.btnAgregarAlumno.Text = "Nuevo";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 418);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegaccionAlumnos);
            this.Controls.Add(this.grbDatosAlumnos);
            this.Name = "Form1";
            this.Text = "ALMINISTRACION DE ALUMNOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosAlumnos.ResumeLayout(false);
            this.grbDatosAlumnos.PerformLayout();
            this.grbNavegaccionAlumnos.ResumeLayout(false);
            this.grbEdicionAlumno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAlumnos;
        private System.Windows.Forms.Label idAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumnos;
        private System.Windows.Forms.TextBox txtTelefonoAlumnos;
        private System.Windows.Forms.Label lblDireccionAlumnos;
        private System.Windows.Forms.TextBox txtNombreAlumnos;
        private System.Windows.Forms.TextBox txtDirecionAlumnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreAlumnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeAlumnos;
        private System.Windows.Forms.GroupBox grbNavegaccionAlumnos;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnPrimerAlumno;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumnbo;
        private System.Windows.Forms.Button btnAgregarAlumno;
    }
}

