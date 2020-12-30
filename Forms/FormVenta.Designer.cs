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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
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
            this.txt_pago_cliente = new System.Windows.Forms.TextBox();
            this.txt_vuelto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datos_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.Titulo.Location = new System.Drawing.Point(220, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(204, 39);
            this.Titulo.TabIndex = 21;
            this.Titulo.Text = "Nueva venta";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(71, 98);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(186, 29);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo de barra";
            // 
            // cant
            // 
            this.cant.AutoSize = true;
            this.cant.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cant.Location = new System.Drawing.Point(315, 70);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(96, 25);
            this.cant.TabIndex = 17;
            this.cant.Text = "Cantidad";
            // 
            // txt_cant
            // 
            this.txt_cant.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_cant.Location = new System.Drawing.Point(334, 99);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(58, 29);
            this.txt_cant.TabIndex = 2;
            this.txt_cant.Text = "1";
            // 
            // datos_venta
            // 
            this.datos_venta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datos_venta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datos_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datos_venta.DefaultCellStyle = dataGridViewCellStyle2;
            this.datos_venta.Location = new System.Drawing.Point(13, 182);
            this.datos_venta.Name = "datos_venta";
            this.datos_venta.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datos_venta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datos_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_venta.Size = new System.Drawing.Size(617, 285);
            this.datos_venta.TabIndex = 5;
            this.datos_venta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_venta_CellClick);
            this.datos_venta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_venta_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total con débito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total con crédito";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(28, 507);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(24, 25);
            this.txt_total.TabIndex = 9;
            this.txt_total.Text = "$";
            // 
            // txt_total_debito
            // 
            this.txt_total_debito.AutoSize = true;
            this.txt_total_debito.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_debito.Location = new System.Drawing.Point(209, 507);
            this.txt_total_debito.Name = "txt_total_debito";
            this.txt_total_debito.Size = new System.Drawing.Size(24, 25);
            this.txt_total_debito.TabIndex = 10;
            this.txt_total_debito.Text = "$";
            // 
            // txt_total_credito
            // 
            this.txt_total_credito.AutoSize = true;
            this.txt_total_credito.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_credito.Location = new System.Drawing.Point(454, 507);
            this.txt_total_credito.Name = "txt_total_credito";
            this.txt_total_credito.Size = new System.Drawing.Size(24, 25);
            this.txt_total_credito.TabIndex = 11;
            this.txt_total_credito.Text = "$";
            // 
            // btn_nueva_venta
            // 
            this.btn_nueva_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.btn_nueva_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nueva_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nueva_venta.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_venta.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_nueva_venta.Location = new System.Drawing.Point(22, 601);
            this.btn_nueva_venta.Name = "btn_nueva_venta";
            this.btn_nueva_venta.Size = new System.Drawing.Size(310, 40);
            this.btn_nueva_venta.TabIndex = 7;
            this.btn_nueva_venta.Text = "Fin de venta";
            this.btn_nueva_venta.UseVisualStyleBackColor = false;
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
            this.precio.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(485, 71);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(66, 25);
            this.precio.TabIndex = 14;
            this.precio.Text = "Precio";
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_precio.Location = new System.Drawing.Point(490, 99);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(81, 29);
            this.txt_precio.TabIndex = 3;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.DimGray;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_eliminar.Location = new System.Drawing.Point(13, 142);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(116, 34);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_pago_cliente
            // 
            this.txt_pago_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_pago_cliente.Location = new System.Drawing.Point(239, 548);
            this.txt_pago_cliente.Name = "txt_pago_cliente";
            this.txt_pago_cliente.Size = new System.Drawing.Size(106, 29);
            this.txt_pago_cliente.TabIndex = 6;
            this.txt_pago_cliente.TextChanged += new System.EventHandler(this.txt_pago_cliente_TextChanged);
            // 
            // txt_vuelto
            // 
            this.txt_vuelto.AutoSize = true;
            this.txt_vuelto.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vuelto.Location = new System.Drawing.Point(431, 552);
            this.txt_vuelto.Name = "txt_vuelto";
            this.txt_vuelto.Size = new System.Drawing.Size(24, 25);
            this.txt_vuelto.TabIndex = 24;
            this.txt_vuelto.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Vuelto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Pago cliente:";
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.btnEliminarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVenta.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVenta.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnEliminarVenta.Location = new System.Drawing.Point(367, 601);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(239, 40);
            this.btnEliminarVenta.TabIndex = 26;
            this.btnEliminarVenta.Text = "Eliminar una venta";
            this.btnEliminarVenta.UseVisualStyleBackColor = false;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(642, 653);
            this.Controls.Add(this.btnEliminarVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_vuelto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pago_cliente);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txt_pago_cliente;
        private System.Windows.Forms.Label txt_vuelto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminarVenta;
    }
}