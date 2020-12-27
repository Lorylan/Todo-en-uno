using System;

namespace Todo_en_uno
{
    partial class Home
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupOpciones = new System.Windows.Forms.GroupBox();
            this.btn_ganancias = new System.Windows.Forms.Button();
            this.btn_notas = new System.Windows.Forms.Button();
            this.btn_inv = new System.Windows.Forms.Button();
            this.groupReportes = new System.Windows.Forms.GroupBox();
            this.btn_reporte_mensual = new System.Windows.Forms.Button();
            this.btn_reporte_diario = new System.Windows.Forms.Button();
            this.groupVentas = new System.Windows.Forms.GroupBox();
            this.btn_venta_propia = new System.Windows.Forms.Button();
            this.btn_venta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupOpciones.SuspendLayout();
            this.groupReportes.SuspendLayout();
            this.groupVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.splitContainer1.Panel2.Controls.Add(this.groupReportes);
            this.splitContainer1.Panel2.Controls.Add(this.groupVentas);
            this.splitContainer1.Size = new System.Drawing.Size(653, 411);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.splitContainer2.Panel1.Controls.Add(this.labelTitulo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.splitContainer2.Panel2.Controls.Add(this.groupOpciones);
            this.splitContainer2.Size = new System.Drawing.Size(305, 411);
            this.splitContainer2.SplitterDistance = 91;
            this.splitContainer2.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelTitulo.Font = new System.Drawing.Font("Roboto Slab", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.labelTitulo.Location = new System.Drawing.Point(12, 22);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(278, 49);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "TODO en UNO";
            // 
            // groupOpciones
            // 
            this.groupOpciones.BackColor = System.Drawing.Color.Transparent;
            this.groupOpciones.Controls.Add(this.btn_ganancias);
            this.groupOpciones.Controls.Add(this.btn_notas);
            this.groupOpciones.Controls.Add(this.btn_inv);
            this.groupOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.groupOpciones.Location = new System.Drawing.Point(35, 23);
            this.groupOpciones.Name = "groupOpciones";
            this.groupOpciones.Size = new System.Drawing.Size(250, 275);
            this.groupOpciones.TabIndex = 2;
            this.groupOpciones.TabStop = false;
            this.groupOpciones.Text = "Opciones";
            // 
            // btn_ganancias
            // 
            this.btn_ganancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.btn_ganancias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(227)))), ((int)(((byte)(124)))));
            this.btn_ganancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ganancias.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ganancias.ForeColor = System.Drawing.Color.Black;
            this.btn_ganancias.Location = new System.Drawing.Point(34, 180);
            this.btn_ganancias.Name = "btn_ganancias";
            this.btn_ganancias.Size = new System.Drawing.Size(183, 70);
            this.btn_ganancias.TabIndex = 3;
            this.btn_ganancias.Text = "Configurar Ganancias";
            this.btn_ganancias.UseVisualStyleBackColor = false;
            this.btn_ganancias.Click += new System.EventHandler(this.btn_ganancias_Click);
            // 
            // btn_notas
            // 
            this.btn_notas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.btn_notas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(227)))), ((int)(((byte)(124)))));
            this.btn_notas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notas.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notas.ForeColor = System.Drawing.Color.Black;
            this.btn_notas.Location = new System.Drawing.Point(34, 111);
            this.btn_notas.Name = "btn_notas";
            this.btn_notas.Size = new System.Drawing.Size(183, 49);
            this.btn_notas.TabIndex = 2;
            this.btn_notas.Text = "Notas/Fiado";
            this.btn_notas.UseVisualStyleBackColor = false;
            this.btn_notas.Click += new System.EventHandler(this.btn_notas_Click);
            // 
            // btn_inv
            // 
            this.btn_inv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.btn_inv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(227)))), ((int)(((byte)(124)))));
            this.btn_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inv.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inv.ForeColor = System.Drawing.Color.Black;
            this.btn_inv.Location = new System.Drawing.Point(34, 42);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(183, 49);
            this.btn_inv.TabIndex = 0;
            this.btn_inv.Text = "Inventario";
            this.btn_inv.UseVisualStyleBackColor = false;
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
            // 
            // groupReportes
            // 
            this.groupReportes.Controls.Add(this.btn_reporte_mensual);
            this.groupReportes.Controls.Add(this.btn_reporte_diario);
            this.groupReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.groupReportes.Location = new System.Drawing.Point(45, 214);
            this.groupReportes.Name = "groupReportes";
            this.groupReportes.Size = new System.Drawing.Size(250, 179);
            this.groupReportes.TabIndex = 2;
            this.groupReportes.TabStop = false;
            this.groupReportes.Text = "Reportes";
            // 
            // btn_reporte_mensual
            // 
            this.btn_reporte_mensual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.btn_reporte_mensual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(227)))), ((int)(((byte)(124)))));
            this.btn_reporte_mensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte_mensual.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte_mensual.ForeColor = System.Drawing.Color.Black;
            this.btn_reporte_mensual.Location = new System.Drawing.Point(34, 105);
            this.btn_reporte_mensual.Name = "btn_reporte_mensual";
            this.btn_reporte_mensual.Size = new System.Drawing.Size(183, 49);
            this.btn_reporte_mensual.TabIndex = 2;
            this.btn_reporte_mensual.Text = "Reporte Mensual";
            this.btn_reporte_mensual.UseVisualStyleBackColor = false;
            this.btn_reporte_mensual.Click += new System.EventHandler(this.btn_reporte_mensual_Click);
            // 
            // btn_reporte_diario
            // 
            this.btn_reporte_diario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.btn_reporte_diario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(227)))), ((int)(((byte)(124)))));
            this.btn_reporte_diario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte_diario.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte_diario.ForeColor = System.Drawing.Color.Black;
            this.btn_reporte_diario.Location = new System.Drawing.Point(34, 38);
            this.btn_reporte_diario.Name = "btn_reporte_diario";
            this.btn_reporte_diario.Size = new System.Drawing.Size(183, 49);
            this.btn_reporte_diario.TabIndex = 1;
            this.btn_reporte_diario.Text = "Reporte Diario";
            this.btn_reporte_diario.UseVisualStyleBackColor = false;
            this.btn_reporte_diario.Click += new System.EventHandler(this.btn_reporte_diario_Click);
            // 
            // groupVentas
            // 
            this.groupVentas.Controls.Add(this.btn_venta_propia);
            this.groupVentas.Controls.Add(this.btn_venta);
            this.groupVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.groupVentas.Location = new System.Drawing.Point(45, 12);
            this.groupVentas.Name = "groupVentas";
            this.groupVentas.Size = new System.Drawing.Size(250, 184);
            this.groupVentas.TabIndex = 1;
            this.groupVentas.TabStop = false;
            this.groupVentas.Text = "Ventas";
            // 
            // btn_venta_propia
            // 
            this.btn_venta_propia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.btn_venta_propia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(227)))), ((int)(((byte)(124)))));
            this.btn_venta_propia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venta_propia.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venta_propia.ForeColor = System.Drawing.Color.Black;
            this.btn_venta_propia.Location = new System.Drawing.Point(34, 106);
            this.btn_venta_propia.Name = "btn_venta_propia";
            this.btn_venta_propia.Size = new System.Drawing.Size(183, 49);
            this.btn_venta_propia.TabIndex = 2;
            this.btn_venta_propia.Text = "Venta Propia";
            this.btn_venta_propia.UseVisualStyleBackColor = false;
            this.btn_venta_propia.Click += new System.EventHandler(this.btn_venta_propia_Click);
            // 
            // btn_venta
            // 
            this.btn_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(156)))), ((int)(((byte)(251)))));
            this.btn_venta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(227)))), ((int)(((byte)(124)))));
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venta.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venta.ForeColor = System.Drawing.Color.Black;
            this.btn_venta.Location = new System.Drawing.Point(34, 42);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(183, 49);
            this.btn_venta.TabIndex = 0;
            this.btn_venta.Text = "Venta";
            this.btn_venta.UseVisualStyleBackColor = false;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(108)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(653, 411);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo En Uno";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupOpciones.ResumeLayout(false);
            this.groupReportes.ResumeLayout(false);
            this.groupVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupVentas;
        private System.Windows.Forms.Button btn_venta_propia;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.GroupBox groupReportes;
        private System.Windows.Forms.Button btn_reporte_mensual;
        private System.Windows.Forms.Button btn_reporte_diario;
        private System.Windows.Forms.GroupBox groupOpciones;
        private System.Windows.Forms.Button btn_ganancias;
        private System.Windows.Forms.Button btn_notas;
        private System.Windows.Forms.Button btn_inv;
    }
}

