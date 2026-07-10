namespace OrdenarCadena
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
            this.txtLetraFiltro = new System.Windows.Forms.TextBox();
            this.btnPasar = new System.Windows.Forms.Button();
            this.btnListar_Click = new System.Windows.Forms.Button();
            this.lstTodosNombre = new System.Windows.Forms.ListBox();
            this.txtTotalNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstNombresFiltrados = new System.Windows.Forms.ListBox();
            this.txtTotalFiltrados = new System.Windows.Forms.TextBox();
            this.txtCadenaOriginal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLetraFiltro
            // 
            this.txtLetraFiltro.Location = new System.Drawing.Point(369, 178);
            this.txtLetraFiltro.MaxLength = 1;
            this.txtLetraFiltro.Name = "txtLetraFiltro";
            this.txtLetraFiltro.Size = new System.Drawing.Size(89, 22);
            this.txtLetraFiltro.TabIndex = 0;
            this.txtLetraFiltro.TextChanged += new System.EventHandler(this.txtLetraFiltro_TextChanged);
            // 
            // btnPasar
            // 
            this.btnPasar.Location = new System.Drawing.Point(369, 239);
            this.btnPasar.Name = "btnPasar";
            this.btnPasar.Size = new System.Drawing.Size(75, 23);
            this.btnPasar.TabIndex = 1;
            this.btnPasar.Text = "<<Pasar>>>";
            this.btnPasar.UseVisualStyleBackColor = true;
            this.btnPasar.Click += new System.EventHandler(this.btnPasar_Click);
            // 
            // btnListar_Click
            // 
            this.btnListar_Click.Location = new System.Drawing.Point(50, 133);
            this.btnListar_Click.Name = "btnListar_Click";
            this.btnListar_Click.Size = new System.Drawing.Size(96, 23);
            this.btnListar_Click.TabIndex = 2;
            this.btnListar_Click.Text = "<<Listar>>";
            this.btnListar_Click.UseVisualStyleBackColor = true;
            this.btnListar_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstTodosNombre
            // 
            this.lstTodosNombre.FormattingEnabled = true;
            this.lstTodosNombre.ItemHeight = 16;
            this.lstTodosNombre.Location = new System.Drawing.Point(40, 178);
            this.lstTodosNombre.Name = "lstTodosNombre";
            this.lstTodosNombre.Size = new System.Drawing.Size(120, 180);
            this.lstTodosNombre.TabIndex = 3;
            // 
            // txtTotalNombres
            // 
            this.txtTotalNombres.Location = new System.Drawing.Point(180, 329);
            this.txtTotalNombres.Name = "txtTotalNombres";
            this.txtTotalNombres.ReadOnly = true;
            this.txtTotalNombres.Size = new System.Drawing.Size(31, 22);
            this.txtTotalNombres.TabIndex = 4;
            this.txtTotalNombres.TextChanged += new System.EventHandler(this.txtTotalNombres_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Letra";
            // 
            // lstNombresFiltrados
            // 
            this.lstNombresFiltrados.FormattingEnabled = true;
            this.lstNombresFiltrados.ItemHeight = 16;
            this.lstNombresFiltrados.Location = new System.Drawing.Point(624, 178);
            this.lstNombresFiltrados.Name = "lstNombresFiltrados";
            this.lstNombresFiltrados.Size = new System.Drawing.Size(120, 180);
            this.lstNombresFiltrados.TabIndex = 6;
            // 
            // txtTotalFiltrados
            // 
            this.txtTotalFiltrados.Location = new System.Drawing.Point(558, 329);
            this.txtTotalFiltrados.Name = "txtTotalFiltrados";
            this.txtTotalFiltrados.ReadOnly = true;
            this.txtTotalFiltrados.Size = new System.Drawing.Size(34, 22);
            this.txtTotalFiltrados.TabIndex = 7;
            // 
            // txtCadenaOriginal
            // 
            this.txtCadenaOriginal.Location = new System.Drawing.Point(40, 51);
            this.txtCadenaOriginal.Multiline = true;
            this.txtCadenaOriginal.Name = "txtCadenaOriginal";
            this.txtCadenaOriginal.Size = new System.Drawing.Size(704, 52);
            this.txtCadenaOriginal.TabIndex = 8;
            this.txtCadenaOriginal.Text = "Liliana Angelina Leticia Amanda Patricia Roxana Luana Kiara Kimberly Synthia Cint" +
    "ia Cecilia Ana Lina Thalia Teresa Pierina";
            this.txtCadenaOriginal.TextChanged += new System.EventHandler(this.txtCadenaOriginal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCadenaOriginal);
            this.Controls.Add(this.txtTotalFiltrados);
            this.Controls.Add(this.lstNombresFiltrados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalNombres);
            this.Controls.Add(this.lstTodosNombre);
            this.Controls.Add(this.btnListar_Click);
            this.Controls.Add(this.btnPasar);
            this.Controls.Add(this.txtLetraFiltro);
            this.Name = "Form1";
            this.Text = "OrdenarCadena";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetraFiltro;
        private System.Windows.Forms.Button btnPasar;
        private System.Windows.Forms.Button btnListar_Click;
        private System.Windows.Forms.ListBox lstTodosNombre;
        private System.Windows.Forms.TextBox txtTotalNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNombresFiltrados;
        private System.Windows.Forms.TextBox txtTotalFiltrados;
        private System.Windows.Forms.TextBox txtCadenaOriginal;
    }
}

