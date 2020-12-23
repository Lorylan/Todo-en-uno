
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio de Caja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de Venta";
            // 
            // CheckCigarrillo
            // 
            this.CheckCigarrillo.AutoSize = true;
            this.CheckCigarrillo.Location = new System.Drawing.Point(97, 203);
            this.CheckCigarrillo.Name = "CheckCigarrillo";
            this.CheckCigarrillo.Size = new System.Drawing.Size(80, 17);
            this.CheckCigarrillo.TabIndex = 4;
            this.CheckCigarrillo.Text = "Es Cigarrillo";
            this.CheckCigarrillo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio por Unidad:";
            // 
            // LabelPrecioUnidad
            // 
            this.LabelPrecioUnidad.AutoSize = true;
            this.LabelPrecioUnidad.Location = new System.Drawing.Point(155, 161);
            this.LabelPrecioUnidad.Name = "LabelPrecioUnidad";
            this.LabelPrecioUnidad.Size = new System.Drawing.Size(13, 13);
            this.LabelPrecioUnidad.TabIndex = 6;
            this.LabelPrecioUnidad.Text = "0";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(12, 37);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(241, 20);
            this.TxtNombre.TabIndex = 7;
            // 
            // TxtPCaja
            // 
            this.TxtPCaja.Location = new System.Drawing.Point(12, 138);
            this.TxtPCaja.Name = "TxtPCaja";
            this.TxtPCaja.Size = new System.Drawing.Size(108, 20);
            this.TxtPCaja.TabIndex = 8;
            this.TxtPCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPCaja.TextChanged += new System.EventHandler(this.TxtPCaja_TextChanged);
            // 
            // TxtUnidades
            // 
            this.TxtUnidades.Location = new System.Drawing.Point(145, 138);
            this.TxtUnidades.Name = "TxtUnidades";
            this.TxtUnidades.Size = new System.Drawing.Size(108, 20);
            this.TxtUnidades.TabIndex = 9;
            this.TxtUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUnidades.TextChanged += new System.EventHandler(this.TxtPCaja_TextChanged);
            // 
            // TxtPVenta
            // 
            this.TxtPVenta.Location = new System.Drawing.Point(63, 246);
            this.TxtPVenta.Name = "TxtPVenta";
            this.TxtPVenta.Size = new System.Drawing.Size(133, 20);
            this.TxtPVenta.TabIndex = 10;
            this.TxtPVenta.Text = "0";
            this.TxtPVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stock Inicial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Stock Minimo";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(14, 200);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(71, 20);
            this.TxtStock.TabIndex = 16;
            this.TxtStock.Text = "0";
            this.TxtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtStockMin
            // 
            this.TxtStockMin.Location = new System.Drawing.Point(187, 200);
            this.TxtStockMin.Name = "TxtStockMin";
            this.TxtStockMin.Size = new System.Drawing.Size(66, 20);
            this.TxtStockMin.TabIndex = 17;
            this.TxtStockMin.Text = "0";
            this.TxtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Codigo de Producto";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(12, 89);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(241, 20);
            this.TxtCodigo.TabIndex = 19;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 321);
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
    }
}