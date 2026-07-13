namespace GenerarEdad_13_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRango2 = new System.Windows.Forms.TextBox();
            this.txtRango1 = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMostrarEdad = new System.Windows.Forms.TextBox();
            this.btnCorrecto = new System.Windows.Forms.Button();
            this.btnIncorrecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indicale al Computador el Intervalo de Edades";
            // 
            // txtRango2
            // 
            this.txtRango2.Location = new System.Drawing.Point(496, 107);
            this.txtRango2.Name = "txtRango2";
            this.txtRango2.Size = new System.Drawing.Size(100, 22);
            this.txtRango2.TabIndex = 1;
            this.txtRango2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRango1
            // 
            this.txtRango1.Location = new System.Drawing.Point(167, 107);
            this.txtRango1.Name = "txtRango1";
            this.txtRango1.Size = new System.Drawing.Size(100, 22);
            this.txtRango1.TabIndex = 2;
            this.txtRango1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(295, 142);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnGenerar.Size = new System.Drawing.Size(157, 47);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Primer Intento";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "La computadora plasma que tu edad es:\r\n\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMostrarEdad
            // 
            this.txtMostrarEdad.Location = new System.Drawing.Point(323, 259);
            this.txtMostrarEdad.Name = "txtMostrarEdad";
            this.txtMostrarEdad.Size = new System.Drawing.Size(100, 22);
            this.txtMostrarEdad.TabIndex = 5;
            this.txtMostrarEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCorrecto
            // 
            this.btnCorrecto.Location = new System.Drawing.Point(167, 303);
            this.btnCorrecto.Name = "btnCorrecto";
            this.btnCorrecto.Size = new System.Drawing.Size(89, 32);
            this.btnCorrecto.TabIndex = 6;
            this.btnCorrecto.Text = "Correcto";
            this.btnCorrecto.UseVisualStyleBackColor = true;
            this.btnCorrecto.Click += new System.EventHandler(this.btnCorrecto_Click);
            // 
            // btnIncorrecto
            // 
            this.btnIncorrecto.Location = new System.Drawing.Point(512, 303);
            this.btnIncorrecto.Name = "btnIncorrecto";
            this.btnIncorrecto.Size = new System.Drawing.Size(84, 32);
            this.btnIncorrecto.TabIndex = 7;
            this.btnIncorrecto.Text = "Incorrecto";
            this.btnIncorrecto.UseVisualStyleBackColor = true;
            this.btnIncorrecto.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIncorrecto);
            this.Controls.Add(this.btnCorrecto);
            this.Controls.Add(this.txtMostrarEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtRango1);
            this.Controls.Add(this.txtRango2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AdivinaEdad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRango2;
        private System.Windows.Forms.TextBox txtRango1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMostrarEdad;
        private System.Windows.Forms.Button btnCorrecto;
        private System.Windows.Forms.Button btnIncorrecto;
    }
}

