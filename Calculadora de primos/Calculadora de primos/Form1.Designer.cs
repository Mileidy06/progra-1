namespace Calculadora_de_primos
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
            this.btnOpcionCalcular = new System.Windows.Forms.Button();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.gboOpciones = new System.Windows.Forms.GroupBox();
            this.optFactorial = new System.Windows.Forms.RadioButton();
            this.optPrimo = new System.Windows.Forms.RadioButton();
            this.optPorcentaje = new System.Windows.Forms.RadioButton();
            this.optExponente = new System.Windows.Forms.RadioButton();
            this.optDivision = new System.Windows.Forms.RadioButton();
            this.optMultiplicacion = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.gboOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpcionCalcular
            // 
            this.btnOpcionCalcular.Location = new System.Drawing.Point(544, 167);
            this.btnOpcionCalcular.Name = "btnOpcionCalcular";
            this.btnOpcionCalcular.Size = new System.Drawing.Size(125, 95);
            this.btnOpcionCalcular.TabIndex = 27;
            this.btnOpcionCalcular.Text = "Calcular";
            this.btnOpcionCalcular.UseVisualStyleBackColor = true;
            // 
            // cboOpciones
            // 
            this.cboOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division",
            "Porcentaje ",
            "Primo ",
            "Factorial"});
            this.cboOpciones.Location = new System.Drawing.Point(553, 125);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(116, 21);
            this.cboOpciones.TabIndex = 26;
            // 
            // gboOpciones
            // 
            this.gboOpciones.Controls.Add(this.optFactorial);
            this.gboOpciones.Controls.Add(this.optPrimo);
            this.gboOpciones.Controls.Add(this.optPorcentaje);
            this.gboOpciones.Controls.Add(this.optExponente);
            this.gboOpciones.Controls.Add(this.optDivision);
            this.gboOpciones.Controls.Add(this.optMultiplicacion);
            this.gboOpciones.Controls.Add(this.optResta);
            this.gboOpciones.Controls.Add(this.optSuma);
            this.gboOpciones.Location = new System.Drawing.Point(319, 109);
            this.gboOpciones.Name = "gboOpciones";
            this.gboOpciones.Size = new System.Drawing.Size(174, 232);
            this.gboOpciones.TabIndex = 25;
            this.gboOpciones.TabStop = false;
            this.gboOpciones.Text = "Opciones";
            // 
            // optFactorial
            // 
            this.optFactorial.AutoSize = true;
            this.optFactorial.Location = new System.Drawing.Point(6, 173);
            this.optFactorial.Name = "optFactorial";
            this.optFactorial.Size = new System.Drawing.Size(68, 17);
            this.optFactorial.TabIndex = 13;
            this.optFactorial.Text = "Factorial ";
            this.optFactorial.UseVisualStyleBackColor = true;
            // 
            // optPrimo
            // 
            this.optPrimo.AutoSize = true;
            this.optPrimo.Location = new System.Drawing.Point(6, 150);
            this.optPrimo.Name = "optPrimo";
            this.optPrimo.Size = new System.Drawing.Size(51, 17);
            this.optPrimo.TabIndex = 12;
            this.optPrimo.Text = "Primo";
            this.optPrimo.UseVisualStyleBackColor = true;
            // 
            // optPorcentaje
            // 
            this.optPorcentaje.AutoSize = true;
            this.optPorcentaje.Location = new System.Drawing.Point(6, 127);
            this.optPorcentaje.Name = "optPorcentaje";
            this.optPorcentaje.Size = new System.Drawing.Size(76, 17);
            this.optPorcentaje.TabIndex = 11;
            this.optPorcentaje.Text = "Porcentaje";
            this.optPorcentaje.UseVisualStyleBackColor = true;
            // 
            // optExponente
            // 
            this.optExponente.AutoSize = true;
            this.optExponente.Location = new System.Drawing.Point(6, 104);
            this.optExponente.Name = "optExponente";
            this.optExponente.Size = new System.Drawing.Size(76, 17);
            this.optExponente.TabIndex = 10;
            this.optExponente.Text = "Exponente";
            this.optExponente.UseVisualStyleBackColor = true;
            // 
            // optDivision
            // 
            this.optDivision.AutoSize = true;
            this.optDivision.Location = new System.Drawing.Point(6, 81);
            this.optDivision.Name = "optDivision";
            this.optDivision.Size = new System.Drawing.Size(62, 17);
            this.optDivision.TabIndex = 9;
            this.optDivision.Text = "Division";
            this.optDivision.UseVisualStyleBackColor = true;
            // 
            // optMultiplicacion
            // 
            this.optMultiplicacion.AutoSize = true;
            this.optMultiplicacion.Location = new System.Drawing.Point(6, 58);
            this.optMultiplicacion.Name = "optMultiplicacion";
            this.optMultiplicacion.Size = new System.Drawing.Size(92, 17);
            this.optMultiplicacion.TabIndex = 8;
            this.optMultiplicacion.Text = "Multiplicacion ";
            this.optMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(6, 39);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(53, 17);
            this.optResta.TabIndex = 7;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Checked = true;
            this.optSuma.Location = new System.Drawing.Point(6, 16);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(52, 17);
            this.optSuma.TabIndex = 6;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(134, 236);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(125, 95);
            this.btncalcular.TabIndex = 24;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(177, 170);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(95, 20);
            this.txtnum2.TabIndex = 23;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(131, 173);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(35, 13);
            this.lblNum2.TabIndex = 22;
            this.lblNum2.Text = "Num2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(177, 132);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(95, 20);
            this.txtnum1.TabIndex = 21;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(131, 215);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(64, 13);
            this.lblrespuesta.TabIndex = 20;
            this.lblrespuesta.Text = "Respuesta?";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(131, 135);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(35, 13);
            this.lblNum1.TabIndex = 19;
            this.lblNum1.Text = "Num1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpcionCalcular);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.gboOpciones);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboOpciones.ResumeLayout(false);
            this.gboOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpcionCalcular;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.GroupBox gboOpciones;
        private System.Windows.Forms.RadioButton optFactorial;
        private System.Windows.Forms.RadioButton optPrimo;
        private System.Windows.Forms.RadioButton optPorcentaje;
        private System.Windows.Forms.RadioButton optExponente;
        private System.Windows.Forms.RadioButton optDivision;
        private System.Windows.Forms.RadioButton optMultiplicacion;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Label lblNum1;
    }
}

