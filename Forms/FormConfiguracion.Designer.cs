
namespace Todo_en_uno.Forms
{
    partial class FormConfiguracion
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Configuracion";
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_credito = new System.Windows.Forms.TextBox();
            this.txt_debito = new System.Windows.Forms.TextBox();
            this.txt_cigarrillo = new System.Windows.Forms.TextBox();
            this.txt_mercaderia = new System.Windows.Forms.TextBox();
            this.credito = new System.Windows.Forms.Label();
            this.debito = new System.Windows.Forms.Label();
            this.cigarrillo = new System.Windows.Forms.Label();
            this.mercaderia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuracion ganancia";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(136, 391);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(170, 43);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_credito);
            this.groupBox1.Controls.Add(this.txt_debito);
            this.groupBox1.Controls.Add(this.txt_cigarrillo);
            this.groupBox1.Controls.Add(this.txt_mercaderia);
            this.groupBox1.Controls.Add(this.credito);
            this.groupBox1.Controls.Add(this.debito);
            this.groupBox1.Controls.Add(this.cigarrillo);
            this.groupBox1.Controls.Add(this.mercaderia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 236);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ganancia";
            // 
            // txt_credito
            // 
            this.txt_credito.Location = new System.Drawing.Point(173, 183);
            this.txt_credito.Name = "txt_credito";
            this.txt_credito.Size = new System.Drawing.Size(114, 24);
            this.txt_credito.TabIndex = 14;
            // 
            // txt_debito
            // 
            this.txt_debito.Location = new System.Drawing.Point(173, 134);
            this.txt_debito.Name = "txt_debito";
            this.txt_debito.Size = new System.Drawing.Size(114, 24);
            this.txt_debito.TabIndex = 13;
            // 
            // txt_cigarrillo
            // 
            this.txt_cigarrillo.Location = new System.Drawing.Point(173, 90);
            this.txt_cigarrillo.Name = "txt_cigarrillo";
            this.txt_cigarrillo.Size = new System.Drawing.Size(114, 24);
            this.txt_cigarrillo.TabIndex = 12;
            // 
            // txt_mercaderia
            // 
            this.txt_mercaderia.Location = new System.Drawing.Point(173, 45);
            this.txt_mercaderia.Name = "txt_mercaderia";
            this.txt_mercaderia.Size = new System.Drawing.Size(114, 24);
            this.txt_mercaderia.TabIndex = 11;
            // 
            // credito
            // 
            this.credito.AutoSize = true;
            this.credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credito.Location = new System.Drawing.Point(37, 185);
            this.credito.Name = "credito";
            this.credito.Size = new System.Drawing.Size(126, 20);
            this.credito.TabIndex = 10;
            this.credito.Text = "Crédito             %";
            // 
            // debito
            // 
            this.debito.AutoSize = true;
            this.debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debito.Location = new System.Drawing.Point(37, 136);
            this.debito.Name = "debito";
            this.debito.Size = new System.Drawing.Size(130, 20);
            this.debito.TabIndex = 9;
            this.debito.Text = "Débito               %";
            // 
            // cigarrillo
            // 
            this.cigarrillo.AutoSize = true;
            this.cigarrillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cigarrillo.Location = new System.Drawing.Point(37, 90);
            this.cigarrillo.Name = "cigarrillo";
            this.cigarrillo.Size = new System.Drawing.Size(126, 20);
            this.cigarrillo.TabIndex = 8;
            this.cigarrillo.Text = "Cigarrillo            $";
            // 
            // mercaderia
            // 
            this.mercaderia.AutoSize = true;
            this.mercaderia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercaderia.Location = new System.Drawing.Point(37, 46);
            this.mercaderia.Name = "mercaderia";
            this.mercaderia.Size = new System.Drawing.Size(130, 20);
            this.mercaderia.TabIndex = 7;
            this.mercaderia.Text = "Mercaderia       %";
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label1);
            this.Name = "FormConfiguracion";
            this.Text = "Configuracion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label credito;
        private System.Windows.Forms.Label debito;
        private System.Windows.Forms.Label cigarrillo;
        private System.Windows.Forms.Label mercaderia;
        private System.Windows.Forms.TextBox txt_credito;
        private System.Windows.Forms.TextBox txt_debito;
        private System.Windows.Forms.TextBox txt_cigarrillo;
        private System.Windows.Forms.TextBox txt_mercaderia;
    }
}