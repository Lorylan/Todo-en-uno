
namespace Todo_en_uno.Forms
{
    partial class Reporte
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
            this.detalle = new System.Windows.Forms.Label();
            this.datos_ventas = new System.Windows.Forms.DataGridView();
            this.mercaderia_ganancia = new System.Windows.Forms.Label();
            this.cigarrillo_ganancia = new System.Windows.Forms.Label();
            this.ganancia = new System.Windows.Forms.GroupBox();
            this.ventaTotal = new System.Windows.Forms.GroupBox();
            this.cigarrillo_venta = new System.Windows.Forms.Label();
            this.mercaderia_venta = new System.Windows.Forms.Label();
            this.PagoNegocio = new System.Windows.Forms.GroupBox();
            this.cigarrillo_pago_n = new System.Windows.Forms.Label();
            this.mercaderia_pago_n = new System.Windows.Forms.Label();
            this.reporner = new System.Windows.Forms.GroupBox();
            this.cigarrillo_reponer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ganancia_m = new System.Windows.Forms.TextBox();
            this.txt_venta_c = new System.Windows.Forms.TextBox();
            this.txt_venta_m = new System.Windows.Forms.TextBox();
            this.txt_pago_c = new System.Windows.Forms.TextBox();
            this.txt_pago_m = new System.Windows.Forms.TextBox();
            this.txt_reponer_c = new System.Windows.Forms.TextBox();
            this.txt_ganancia_c = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datos_ventas)).BeginInit();
            this.ganancia.SuspendLayout();
            this.ventaTotal.SuspendLayout();
            this.PagoNegocio.SuspendLayout();
            this.reporner.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte diario";
            // 
            // detalle
            // 
            this.detalle.AutoSize = true;
            this.detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalle.Location = new System.Drawing.Point(59, 238);
            this.detalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(79, 25);
            this.detalle.TabIndex = 2;
            this.detalle.Text = "Detalle";
            // 
            // datos_ventas
            // 
            this.datos_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_ventas.Location = new System.Drawing.Point(64, 267);
            this.datos_ventas.Margin = new System.Windows.Forms.Padding(4);
            this.datos_ventas.Name = "datos_ventas";
            this.datos_ventas.Size = new System.Drawing.Size(1116, 432);
            this.datos_ventas.TabIndex = 5;
            // 
            // mercaderia_ganancia
            // 
            this.mercaderia_ganancia.AutoSize = true;
            this.mercaderia_ganancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercaderia_ganancia.Location = new System.Drawing.Point(22, 83);
            this.mercaderia_ganancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mercaderia_ganancia.Name = "mercaderia_ganancia";
            this.mercaderia_ganancia.Size = new System.Drawing.Size(88, 20);
            this.mercaderia_ganancia.TabIndex = 6;
            this.mercaderia_ganancia.Text = "Mercaderia";
            // 
            // cigarrillo_ganancia
            // 
            this.cigarrillo_ganancia.AutoSize = true;
            this.cigarrillo_ganancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cigarrillo_ganancia.Location = new System.Drawing.Point(22, 40);
            this.cigarrillo_ganancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cigarrillo_ganancia.Name = "cigarrillo_ganancia";
            this.cigarrillo_ganancia.Size = new System.Drawing.Size(69, 20);
            this.cigarrillo_ganancia.TabIndex = 8;
            this.cigarrillo_ganancia.Text = "Cigarrillo";
            // 
            // ganancia
            // 
            this.ganancia.Controls.Add(this.txt_ganancia_c);
            this.ganancia.Controls.Add(this.txt_ganancia_m);
            this.ganancia.Controls.Add(this.label3);
            this.ganancia.Controls.Add(this.label2);
            this.ganancia.Controls.Add(this.cigarrillo_ganancia);
            this.ganancia.Controls.Add(this.mercaderia_ganancia);
            this.ganancia.Location = new System.Drawing.Point(64, 72);
            this.ganancia.Margin = new System.Windows.Forms.Padding(4);
            this.ganancia.Name = "ganancia";
            this.ganancia.Padding = new System.Windows.Forms.Padding(4);
            this.ganancia.Size = new System.Drawing.Size(256, 119);
            this.ganancia.TabIndex = 12;
            this.ganancia.TabStop = false;
            this.ganancia.Text = "Ganancia";
            // 
            // ventaTotal
            // 
            this.ventaTotal.Controls.Add(this.txt_venta_m);
            this.ventaTotal.Controls.Add(this.txt_venta_c);
            this.ventaTotal.Controls.Add(this.label5);
            this.ventaTotal.Controls.Add(this.label4);
            this.ventaTotal.Controls.Add(this.cigarrillo_venta);
            this.ventaTotal.Controls.Add(this.mercaderia_venta);
            this.ventaTotal.Location = new System.Drawing.Point(340, 72);
            this.ventaTotal.Margin = new System.Windows.Forms.Padding(4);
            this.ventaTotal.Name = "ventaTotal";
            this.ventaTotal.Padding = new System.Windows.Forms.Padding(4);
            this.ventaTotal.Size = new System.Drawing.Size(260, 119);
            this.ventaTotal.TabIndex = 13;
            this.ventaTotal.TabStop = false;
            this.ventaTotal.Text = "Venta total";
            // 
            // cigarrillo_venta
            // 
            this.cigarrillo_venta.AutoSize = true;
            this.cigarrillo_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cigarrillo_venta.Location = new System.Drawing.Point(24, 37);
            this.cigarrillo_venta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cigarrillo_venta.Name = "cigarrillo_venta";
            this.cigarrillo_venta.Size = new System.Drawing.Size(69, 20);
            this.cigarrillo_venta.TabIndex = 10;
            this.cigarrillo_venta.Text = "Cigarrillo";
            // 
            // mercaderia_venta
            // 
            this.mercaderia_venta.AutoSize = true;
            this.mercaderia_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercaderia_venta.Location = new System.Drawing.Point(24, 80);
            this.mercaderia_venta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mercaderia_venta.Name = "mercaderia_venta";
            this.mercaderia_venta.Size = new System.Drawing.Size(88, 20);
            this.mercaderia_venta.TabIndex = 9;
            this.mercaderia_venta.Text = "Mercaderia";
            // 
            // PagoNegocio
            // 
            this.PagoNegocio.Controls.Add(this.txt_pago_m);
            this.PagoNegocio.Controls.Add(this.txt_pago_c);
            this.PagoNegocio.Controls.Add(this.label7);
            this.PagoNegocio.Controls.Add(this.label6);
            this.PagoNegocio.Controls.Add(this.cigarrillo_pago_n);
            this.PagoNegocio.Controls.Add(this.mercaderia_pago_n);
            this.PagoNegocio.Location = new System.Drawing.Point(623, 72);
            this.PagoNegocio.Margin = new System.Windows.Forms.Padding(4);
            this.PagoNegocio.Name = "PagoNegocio";
            this.PagoNegocio.Padding = new System.Windows.Forms.Padding(4);
            this.PagoNegocio.Size = new System.Drawing.Size(264, 119);
            this.PagoNegocio.TabIndex = 13;
            this.PagoNegocio.TabStop = false;
            this.PagoNegocio.Text = "Pago al negocio";
            // 
            // cigarrillo_pago_n
            // 
            this.cigarrillo_pago_n.AutoSize = true;
            this.cigarrillo_pago_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cigarrillo_pago_n.Location = new System.Drawing.Point(21, 37);
            this.cigarrillo_pago_n.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cigarrillo_pago_n.Name = "cigarrillo_pago_n";
            this.cigarrillo_pago_n.Size = new System.Drawing.Size(69, 20);
            this.cigarrillo_pago_n.TabIndex = 12;
            this.cigarrillo_pago_n.Text = "Cigarrillo";
            // 
            // mercaderia_pago_n
            // 
            this.mercaderia_pago_n.AutoSize = true;
            this.mercaderia_pago_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercaderia_pago_n.Location = new System.Drawing.Point(21, 80);
            this.mercaderia_pago_n.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mercaderia_pago_n.Name = "mercaderia_pago_n";
            this.mercaderia_pago_n.Size = new System.Drawing.Size(88, 20);
            this.mercaderia_pago_n.TabIndex = 11;
            this.mercaderia_pago_n.Text = "Mercaderia";
            // 
            // reporner
            // 
            this.reporner.Controls.Add(this.txt_reponer_c);
            this.reporner.Controls.Add(this.label8);
            this.reporner.Controls.Add(this.cigarrillo_reponer);
            this.reporner.Location = new System.Drawing.Point(908, 72);
            this.reporner.Margin = new System.Windows.Forms.Padding(4);
            this.reporner.Name = "reporner";
            this.reporner.Padding = new System.Windows.Forms.Padding(4);
            this.reporner.Size = new System.Drawing.Size(262, 119);
            this.reporner.TabIndex = 14;
            this.reporner.TabStop = false;
            this.reporner.Text = "Reponer";
            // 
            // cigarrillo_reponer
            // 
            this.cigarrillo_reponer.AutoSize = true;
            this.cigarrillo_reponer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cigarrillo_reponer.Location = new System.Drawing.Point(21, 37);
            this.cigarrillo_reponer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cigarrillo_reponer.Name = "cigarrillo_reponer";
            this.cigarrillo_reponer.Size = new System.Drawing.Size(69, 20);
            this.cigarrillo_reponer.TabIndex = 12;
            this.cigarrillo_reponer.Text = "Cigarrillo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(130, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "$";
            // 
            // txt_ganancia_m
            // 
            this.txt_ganancia_m.Location = new System.Drawing.Point(132, 78);
            this.txt_ganancia_m.Name = "txt_ganancia_m";
            this.txt_ganancia_m.Size = new System.Drawing.Size(100, 24);
            this.txt_ganancia_m.TabIndex = 16;
            this.txt_ganancia_m.Text = "0";
            this.txt_ganancia_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_venta_c
            // 
            this.txt_venta_c.Location = new System.Drawing.Point(152, 36);
            this.txt_venta_c.Name = "txt_venta_c";
            this.txt_venta_c.Size = new System.Drawing.Size(100, 24);
            this.txt_venta_c.TabIndex = 17;
            this.txt_venta_c.Text = "0";
            this.txt_venta_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_venta_m
            // 
            this.txt_venta_m.Location = new System.Drawing.Point(153, 76);
            this.txt_venta_m.Name = "txt_venta_m";
            this.txt_venta_m.Size = new System.Drawing.Size(100, 24);
            this.txt_venta_m.TabIndex = 18;
            this.txt_venta_m.Text = "0";
            this.txt_venta_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_pago_c
            // 
            this.txt_pago_c.Location = new System.Drawing.Point(148, 37);
            this.txt_pago_c.Name = "txt_pago_c";
            this.txt_pago_c.Size = new System.Drawing.Size(100, 24);
            this.txt_pago_c.TabIndex = 19;
            this.txt_pago_c.Text = "0";
            this.txt_pago_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_pago_m
            // 
            this.txt_pago_m.Location = new System.Drawing.Point(148, 76);
            this.txt_pago_m.Name = "txt_pago_m";
            this.txt_pago_m.Size = new System.Drawing.Size(100, 24);
            this.txt_pago_m.TabIndex = 20;
            this.txt_pago_m.Text = "0";
            this.txt_pago_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_reponer_c
            // 
            this.txt_reponer_c.Location = new System.Drawing.Point(134, 35);
            this.txt_reponer_c.Name = "txt_reponer_c";
            this.txt_reponer_c.Size = new System.Drawing.Size(100, 24);
            this.txt_reponer_c.TabIndex = 21;
            this.txt_reponer_c.Text = "0";
            this.txt_reponer_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ganancia_c
            // 
            this.txt_ganancia_c.Location = new System.Drawing.Point(132, 40);
            this.txt_ganancia_c.Name = "txt_ganancia_c";
            this.txt_ganancia_c.Size = new System.Drawing.Size(100, 24);
            this.txt_ganancia_c.TabIndex = 17;
            this.txt_ganancia_c.Text = "0";
            this.txt_ganancia_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReporteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 719);
            this.Controls.Add(this.reporner);
            this.Controls.Add(this.PagoNegocio);
            this.Controls.Add(this.ventaTotal);
            this.Controls.Add(this.ganancia);
            this.Controls.Add(this.datos_ventas);
            this.Controls.Add(this.detalle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteDiario";
            this.Text = "ReporteDiario";
            ((System.ComponentModel.ISupportInitialize)(this.datos_ventas)).EndInit();
            this.ganancia.ResumeLayout(false);
            this.ganancia.PerformLayout();
            this.ventaTotal.ResumeLayout(false);
            this.ventaTotal.PerformLayout();
            this.PagoNegocio.ResumeLayout(false);
            this.PagoNegocio.PerformLayout();
            this.reporner.ResumeLayout(false);
            this.reporner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label detalle;
        private System.Windows.Forms.DataGridView datos_ventas;
        private System.Windows.Forms.Label mercaderia_ganancia;
        private System.Windows.Forms.Label cigarrillo_ganancia;
        private System.Windows.Forms.GroupBox ganancia;
        private System.Windows.Forms.GroupBox ventaTotal;
        private System.Windows.Forms.Label cigarrillo_venta;
        private System.Windows.Forms.Label mercaderia_venta;
        private System.Windows.Forms.GroupBox PagoNegocio;
        private System.Windows.Forms.Label cigarrillo_pago_n;
        private System.Windows.Forms.Label mercaderia_pago_n;
        private System.Windows.Forms.GroupBox reporner;
        private System.Windows.Forms.Label cigarrillo_reponer;
        private System.Windows.Forms.TextBox txt_ganancia_m;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_venta_m;
        private System.Windows.Forms.TextBox txt_venta_c;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pago_m;
        private System.Windows.Forms.TextBox txt_pago_c;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_reponer_c;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ganancia_c;
    }
}