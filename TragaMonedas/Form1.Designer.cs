namespace TragaMonedas
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
            this.lblReloj = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtJugada1 = new System.Windows.Forms.TextBox();
            this.txtJugada2 = new System.Windows.Forms.TextBox();
            this.txtJugada3 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReloj
            // 
            this.lblReloj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(282, 43);
            this.lblReloj.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblReloj.Size = new System.Drawing.Size(188, 56);
            this.lblReloj.TabIndex = 0;
            this.lblReloj.Text = "00:00:00";
            this.lblReloj.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(319, 120);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(109, 47);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Juego";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtJugada1
            // 
            this.txtJugada1.Location = new System.Drawing.Point(121, 199);
            this.txtJugada1.Name = "txtJugada1";
            this.txtJugada1.Size = new System.Drawing.Size(100, 22);
            this.txtJugada1.TabIndex = 3;
            // 
            // txtJugada2
            // 
            this.txtJugada2.Location = new System.Drawing.Point(328, 199);
            this.txtJugada2.Name = "txtJugada2";
            this.txtJugada2.Size = new System.Drawing.Size(100, 22);
            this.txtJugada2.TabIndex = 4;
            // 
            // txtJugada3
            // 
            this.txtJugada3.Location = new System.Drawing.Point(522, 198);
            this.txtJugada3.Name = "txtJugada3";
            this.txtJugada3.Size = new System.Drawing.Size(100, 22);
            this.txtJugada3.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(245, 281);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(258, 30);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Perdiste";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Visible = false;
            this.lblResultado.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtJugada3);
            this.Controls.Add(this.txtJugada2);
            this.Controls.Add(this.txtJugada1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblReloj);
            this.Name = "Form1";
            this.Text = "Traga Monedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtJugada1;
        private System.Windows.Forms.TextBox txtJugada2;
        private System.Windows.Forms.TextBox txtJugada3;
        private System.Windows.Forms.Label lblResultado;
    }
}

