namespace Uso_de_conversores
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblTipoCoversor = new System.Windows.Forms.Label();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.lblDeconversor = new System.Windows.Forms.Label();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.lblCantidadconversor = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblResConversor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(352, 273);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(144, 78);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblTipoCoversor
            // 
            this.lblTipoCoversor.AutoSize = true;
            this.lblTipoCoversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCoversor.Location = new System.Drawing.Point(68, 41);
            this.lblTipoCoversor.Name = "lblTipoCoversor";
            this.lblTipoCoversor.Size = new System.Drawing.Size(59, 20);
            this.lblTipoCoversor.TabIndex = 1;
            this.lblTipoCoversor.Text = "TIPO: ";
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Monedas ",
            "Longitud",
            "Masa ",
            "Volumen",
            "Almacenamiento ",
            "Tiempo"});
            this.cboTipoConversor.Location = new System.Drawing.Point(118, 43);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(145, 21);
            this.cboTipoConversor.TabIndex = 3;
            this.cboTipoConversor.SelectionChangeCommitted += new System.EventHandler(this.cboTipoConversor_SelectionChangeCommitted);
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Location = new System.Drawing.Point(118, 109);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(145, 21);
            this.cboDeConversor.TabIndex = 5;
            // 
            // lblDeconversor
            // 
            this.lblDeconversor.AutoSize = true;
            this.lblDeconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeconversor.Location = new System.Drawing.Point(68, 107);
            this.lblDeconversor.Name = "lblDeconversor";
            this.lblDeconversor.Size = new System.Drawing.Size(44, 20);
            this.lblDeconversor.TabIndex = 4;
            this.lblDeconversor.Text = "DE: ";
            // 
            // cboAConversor
            // 
            this.cboAConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Location = new System.Drawing.Point(118, 154);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(145, 21);
            this.cboAConversor.TabIndex = 7;
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversor.Location = new System.Drawing.Point(68, 165);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(31, 20);
            this.lblAConversor.TabIndex = 6;
            this.lblAConversor.Text = "A: ";
            // 
            // lblCantidadconversor
            // 
            this.lblCantidadconversor.Location = new System.Drawing.Point(0, 0);
            this.lblCantidadconversor.Name = "lblCantidadconversor";
            this.lblCantidadconversor.Size = new System.Drawing.Size(100, 23);
            this.lblCantidadconversor.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(157, 230);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(145, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // lblResConversor
            // 
            this.lblResConversor.AutoSize = true;
            this.lblResConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResConversor.Location = new System.Drawing.Point(42, 302);
            this.lblResConversor.Name = "lblResConversor";
            this.lblResConversor.Size = new System.Drawing.Size(116, 20);
            this.lblResConversor.TabIndex = 10;
            this.lblResConversor.Text = "RESPUESTA";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(42, 228);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 20);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "CANTIDAD: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblResConversor);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.lblDeconversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblTipoCoversor);
            this.Controls.Add(this.btnConvertir);
            this.Name = "Form1";
            this.Text = "CONVERSORES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblTipoCoversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.Label lblDeconversor;
        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.Label lblCantidadconversor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblResConversor;
        private System.Windows.Forms.Label lblCantidad;
    }
}

