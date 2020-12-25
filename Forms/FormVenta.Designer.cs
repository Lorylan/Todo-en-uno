namespace Todo_en_uno.Forms
{
    partial class FormVenta
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
            this.components = new System.ComponentModel.Container();
            this.Titulo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cant = new System.Windows.Forms.Label();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.datos_venta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            this.txt_total_debito = new System.Windows.Forms.Label();
            this.txt_total_credito = new System.Windows.Forms.Label();
            this.btn_nueva_venta = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.precio = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datos_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(318, 20);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(167, 31);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Nueva venta";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(190, 68);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(186, 30);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo barra";
            // 
            // cant
            // 
            this.cant.AutoSize = true;
            this.cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cant.Location = new System.Drawing.Point(394, 74);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(91, 25);
            this.cant.TabIndex = 4;
            this.cant.Text = "Cantidad";
            // 
            // txt_cant
            // 
            this.txt_cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cant.Location = new System.Drawing.Point(491, 71);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(69, 30);
            this.txt_cant.TabIndex = 3;
            this.txt_cant.Text = "1";
            // 
            // datos_venta
            // 
            this.datos_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_venta.Location = new System.Drawing.Point(64, 169);
            this.datos_venta.Name = "datos_venta";
            this.datos_venta.Size = new System.Drawing.Size(668, 285);
            this.datos_venta.TabIndex = 5;
            this.datos_venta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_venta_CellClick);
            this.datos_venta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_venta_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total con débito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total con crédito";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(630, 483);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(23, 25);
            this.txt_total.TabIndex = 9;
            this.txt_total.Text = "$";
            // 
            // txt_total_debito
            // 
            this.txt_total_debito.AutoSize = true;
            this.txt_total_debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_debito.Location = new System.Drawing.Point(630, 517);
            this.txt_total_debito.Name = "txt_total_debito";
            this.txt_total_debito.Size = new System.Drawing.Size(23, 25);
            this.txt_total_debito.TabIndex = 10;
            this.txt_total_debito.Text = "$";
            // 
            // txt_total_credito
            // 
            this.txt_total_credito.AutoSize = true;
            this.txt_total_credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_credito.Location = new System.Drawing.Point(630, 552);
            this.txt_total_credito.Name = "txt_total_credito";
            this.txt_total_credito.Size = new System.Drawing.Size(23, 25);
            this.txt_total_credito.TabIndex = 11;
            this.txt_total_credito.Text = "$";
            // 
            // btn_nueva_venta
            // 
            this.btn_nueva_venta.Location = new System.Drawing.Point(127, 599);
            this.btn_nueva_venta.Name = "btn_nueva_venta";
            this.btn_nueva_venta.Size = new System.Drawing.Size(544, 40);
            this.btn_nueva_venta.TabIndex = 12;
            this.btn_nueva_venta.Text = "Fin de venta";
            this.btn_nueva_venta.UseVisualStyleBackColor = true;
            this.btn_nueva_venta.Click += new System.EventHandler(this.btn_nueva_venta_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(580, 74);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(67, 25);
            this.precio.TabIndex = 14;
            this.precio.Text = "Precio";
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(653, 71);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(69, 30);
            this.txt_precio.TabIndex = 13;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(64, 119);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(116, 23);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 651);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.btn_nueva_venta);
            this.Controls.Add(this.txt_total_credito);
            this.Controls.Add(this.txt_total_debito);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datos_venta);
            this.Controls.Add(this.cant);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.Titulo);
            this.Name = "FormVenta";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.datos_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cant;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.DataGridView datos_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label txt_total_debito;
        private System.Windows.Forms.Label txt_total_credito;
        private System.Windows.Forms.Button btn_nueva_venta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Button btn_eliminar;
    }
}