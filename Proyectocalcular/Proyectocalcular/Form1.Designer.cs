namespace Proyectocalcular
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
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblIsss = new System.Windows.Forms.Label();
            this.lblAfp = new System.Windows.Forms.Label();
            this.lblIsr = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.lblTotalDeduciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(46, 34);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(98, 24);
            this.lblSueldo.TabIndex = 1;
            this.lblSueldo.Text = "SUELDO:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(150, 39);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(117, 20);
            this.txtSueldo.TabIndex = 2;
            // 
            // lblIsss
            // 
            this.lblIsss.AutoSize = true;
            this.lblIsss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsss.Location = new System.Drawing.Point(47, 68);
            this.lblIsss.Name = "lblIsss";
            this.lblIsss.Size = new System.Drawing.Size(77, 24);
            this.lblIsss.TabIndex = 3;
            this.lblIsss.Text = "ISSS: ?";
            // 
            // lblAfp
            // 
            this.lblAfp.AutoSize = true;
            this.lblAfp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfp.Location = new System.Drawing.Point(47, 109);
            this.lblAfp.Name = "lblAfp";
            this.lblAfp.Size = new System.Drawing.Size(73, 24);
            this.lblAfp.TabIndex = 4;
            this.lblAfp.Text = "AFP: ?";
            // 
            // lblIsr
            // 
            this.lblIsr.AutoSize = true;
            this.lblIsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsr.Location = new System.Drawing.Point(53, 145);
            this.lblIsr.Name = "lblIsr";
            this.lblIsr.Size = new System.Drawing.Size(65, 24);
            this.lblIsr.TabIndex = 5;
            this.lblIsr.Text = "ISR: ?";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(334, 25);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(177, 135);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoNeto.Location = new System.Drawing.Point(34, 236);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(179, 24);
            this.lblSueldoNeto.TabIndex = 6;
            this.lblSueldoNeto.Text = "SUELDO NETO: ?";
            // 
            // lblTotalDeduciones
            // 
            this.lblTotalDeduciones.AutoSize = true;
            this.lblTotalDeduciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeduciones.Location = new System.Drawing.Point(53, 191);
            this.lblTotalDeduciones.Name = "lblTotalDeduciones";
            this.lblTotalDeduciones.Size = new System.Drawing.Size(197, 24);
            this.lblTotalDeduciones.TabIndex = 7;
            this.lblTotalDeduciones.Text = "Total Deduciones: ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalDeduciones);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblIsr);
            this.Controls.Add(this.lblAfp);
            this.Controls.Add(this.lblIsss);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblIsss;
        private System.Windows.Forms.Label lblAfp;
        private System.Windows.Forms.Label lblIsr;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.Label lblTotalDeduciones;
    }
}

