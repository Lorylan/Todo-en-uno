
namespace Todo_en_uno.Forms
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckCigarrillo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelPrecioUnidad = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtPCaja = new System.Windows.Forms.TextBox();
            this.TxtUnidades = new System.Windows.Forms.TextBox();
            this.TxtPVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtStockMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label1.Location = new System.Drawing.Point(105, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label2.Location = new System.Drawing.Point(58, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio de Caja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label3.Location = new System.Drawing.Point(237, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label4.Location = new System.Drawing.Point(131, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de Venta";
            // 
            // CheckCigarrillo
            // 
            this.CheckCigarrillo.AutoSize = true;
            this.CheckCigarrillo.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.CheckCigarrillo.Location = new System.Drawing.Point(149, 375);
            this.CheckCigarrillo.Name = "CheckCigarrillo";
            this.CheckCigarrillo.Size = new System.Drawing.Size(134, 29);
            this.CheckCigarrillo.TabIndex = 7;
            this.CheckCigarrillo.Text = "Es Cigarrillo";
            this.CheckCigarrillo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label5.Location = new System.Drawing.Point(68, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio por Unidad:";
            // 
            // LabelPrecioUnidad
            // 
            this.LabelPrecioUnidad.AutoSize = true;
            this.LabelPrecioUnidad.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.LabelPrecioUnidad.Location = new System.Drawing.Point(245, 274);
            this.LabelPrecioUnidad.Name = "LabelPrecioUnidad";
            this.LabelPrecioUnidad.Size = new System.Drawing.Size(25, 25);
            this.LabelPrecioUnidad.TabIndex = 6;
            this.LabelPrecioUnidad.Text = "0";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(83, 114);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(241, 29);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtPCaja
            // 
            this.TxtPCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPCaja.Location = new System.Drawing.Point(83, 246);
            this.TxtPCaja.Name = "TxtPCaja";
            this.TxtPCaja.Size = new System.Drawing.Size(108, 29);
            this.TxtPCaja.TabIndex = 3;
            this.TxtPCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPCaja.TextChanged += new System.EventHandler(this.TxtPCaja_TextChanged);
            // 
            // TxtUnidades
            // 
            this.TxtUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnidades.Location = new System.Drawing.Point(229, 243);
            this.TxtUnidades.Name = "TxtUnidades";
            this.TxtUnidades.Size = new System.Drawing.Size(108, 29);
            this.TxtUnidades.TabIndex = 4;
            this.TxtUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUnidades.TextChanged += new System.EventHandler(this.TxtPCaja_TextChanged);
            // 
            // TxtPVenta
            // 
            this.TxtPVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPVenta.Location = new System.Drawing.Point(150, 444);
            this.TxtPVenta.Name = "TxtPVenta";
            this.TxtPVenta.Size = new System.Drawing.Size(133, 29);
            this.TxtPVenta.TabIndex = 8;
            this.TxtPVenta.Text = "0";
            this.TxtPVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label8.Location = new System.Drawing.Point(201, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "/";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(110, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label7.Location = new System.Drawing.Point(78, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stock Inicial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label9.Location = new System.Drawing.Point(218, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Stock Minimo";
            // 
            // TxtStock
            // 
            this.TxtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStock.Location = new System.Drawing.Point(100, 341);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(71, 29);
            this.TxtStock.TabIndex = 5;
            this.TxtStock.Text = "0";
            this.TxtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtStockMin
            // 
            this.TxtStockMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockMin.Location = new System.Drawing.Point(258, 341);
            this.TxtStockMin.Name = "TxtStockMin";
            this.TxtStockMin.Size = new System.Drawing.Size(66, 29);
            this.TxtStockMin.TabIndex = 6;
            this.TxtStockMin.Text = "0";
            this.TxtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label10.Location = new System.Drawing.Point(117, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Codigo de Producto";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(83, 176);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(241, 29);
            this.TxtCodigo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(44, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 49);
            this.label6.TabIndex = 20;
            this.label6.Text = "Agregar producto";
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(414, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtStockMin);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPVenta);
            this.Controls.Add(this.TxtUnidades);
            this.Controls.Add(this.TxtPCaja);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LabelPrecioUnidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckCigarrillo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckCigarrillo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelPrecioUnidad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtPCaja;
        private System.Windows.Forms.TextBox TxtUnidades;
        private System.Windows.Forms.TextBox TxtPVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtStockMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label6;
    }
}