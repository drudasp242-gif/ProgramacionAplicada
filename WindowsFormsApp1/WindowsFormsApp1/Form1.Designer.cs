namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.checkb1 = new System.Windows.Forms.CheckBox();
            this.checkb2 = new System.Windows.Forms.CheckBox();
            this.checkb3 = new System.Windows.Forms.CheckBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtb1);
            this.panel1.Controls.Add(this.bt1);
            this.panel1.Controls.Add(this.checkb3);
            this.panel1.Controls.Add(this.checkb2);
            this.panel1.Controls.Add(this.checkb1);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 134);
            this.panel1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(113, 16);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Control CheckBox";
            // 
            // checkb1
            // 
            this.checkb1.AutoSize = true;
            this.checkb1.Location = new System.Drawing.Point(18, 12);
            this.checkb1.Name = "checkb1";
            this.checkb1.Size = new System.Drawing.Size(163, 20);
            this.checkb1.TabIndex = 0;
            this.checkb1.Text = "Cambiar Tipo de Letra";
            this.checkb1.UseVisualStyleBackColor = true;
            this.checkb1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkb2
            // 
            this.checkb2.AutoSize = true;
            this.checkb2.Location = new System.Drawing.Point(18, 49);
            this.checkb2.Name = "checkb2";
            this.checkb2.Size = new System.Drawing.Size(169, 20);
            this.checkb2.TabIndex = 1;
            this.checkb2.Text = "Cambiar color de Texto";
            this.checkb2.UseVisualStyleBackColor = true;
            // 
            // checkb3
            // 
            this.checkb3.AutoSize = true;
            this.checkb3.Location = new System.Drawing.Point(18, 87);
            this.checkb3.Name = "checkb3";
            this.checkb3.Size = new System.Drawing.Size(169, 20);
            this.checkb3.TabIndex = 2;
            this.checkb3.Text = "Cambiar color de fondo";
            this.checkb3.UseVisualStyleBackColor = true;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(359, 8);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "Aplicar";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // txtb1
            // 
            this.txtb1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtb1.ForeColor = System.Drawing.Color.Black;
            this.txtb1.Location = new System.Drawing.Point(281, 47);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(190, 22);
            this.txtb1.TabIndex = 4;
            this.txtb1.Tag = "Uso de control de CheckBox";
            this.txtb1.Text = "Uso de control de CheckBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.CheckBox checkb1;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.CheckBox checkb3;
        private System.Windows.Forms.CheckBox checkb2;
        private System.Windows.Forms.Label label1;
    }
}

