
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_credito = new System.Windows.Forms.TextBox();
            this.txt_debito = new System.Windows.Forms.TextBox();
            this.txt_cigarrillo = new System.Windows.Forms.TextBox();
            this.txt_mercaderia = new System.Windows.Forms.TextBox();
            this.credito = new System.Windows.Forms.Label();
            this.debito = new System.Windows.Forms.Label();
            this.cigarrillo = new System.Windows.Forms.Label();
            this.mercaderia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuracion ganancia";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btn_guardar.Location = new System.Drawing.Point(97, 343);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(184, 60);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_credito);
            this.panel1.Controls.Add(this.txt_debito);
            this.panel1.Controls.Add(this.txt_cigarrillo);
            this.panel1.Controls.Add(this.txt_mercaderia);
            this.panel1.Controls.Add(this.credito);
            this.panel1.Controls.Add(this.debito);
            this.panel1.Controls.Add(this.cigarrillo);
            this.panel1.Controls.Add(this.mercaderia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Ink Free", 14.25F);
            this.panel1.Location = new System.Drawing.Point(21, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 219);
            this.panel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.label6.Location = new System.Drawing.Point(139, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.label5.Location = new System.Drawing.Point(139, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(139, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(139, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "%";
            // 
            // txt_credito
            // 
            this.txt_credito.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_credito.Location = new System.Drawing.Point(186, 171);
            this.txt_credito.Name = "txt_credito";
            this.txt_credito.Size = new System.Drawing.Size(114, 30);
            this.txt_credito.TabIndex = 22;
            // 
            // txt_debito
            // 
            this.txt_debito.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_debito.Location = new System.Drawing.Point(186, 130);
            this.txt_debito.Name = "txt_debito";
            this.txt_debito.Size = new System.Drawing.Size(114, 30);
            this.txt_debito.TabIndex = 21;
            // 
            // txt_cigarrillo
            // 
            this.txt_cigarrillo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cigarrillo.Location = new System.Drawing.Point(186, 86);
            this.txt_cigarrillo.Name = "txt_cigarrillo";
            this.txt_cigarrillo.Size = new System.Drawing.Size(114, 30);
            this.txt_cigarrillo.TabIndex = 20;
            // 
            // txt_mercaderia
            // 
            this.txt_mercaderia.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mercaderia.Location = new System.Drawing.Point(186, 43);
            this.txt_mercaderia.Name = "txt_mercaderia";
            this.txt_mercaderia.Size = new System.Drawing.Size(114, 30);
            this.txt_mercaderia.TabIndex = 19;
            // 
            // credito
            // 
            this.credito.AutoSize = true;
            this.credito.BackColor = System.Drawing.Color.Transparent;
            this.credito.Font = new System.Drawing.Font("Ink Free", 14.25F);
            this.credito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.credito.Location = new System.Drawing.Point(34, 174);
            this.credito.Name = "credito";
            this.credito.Size = new System.Drawing.Size(77, 23);
            this.credito.TabIndex = 18;
            this.credito.Text = "Crédito  ";
            // 
            // debito
            // 
            this.debito.AutoSize = true;
            this.debito.BackColor = System.Drawing.Color.Transparent;
            this.debito.Font = new System.Drawing.Font("Ink Free", 14.25F);
            this.debito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.debito.Location = new System.Drawing.Point(34, 130);
            this.debito.Name = "debito";
            this.debito.Size = new System.Drawing.Size(67, 23);
            this.debito.TabIndex = 17;
            this.debito.Text = "Débito ";
            // 
            // cigarrillo
            // 
            this.cigarrillo.AutoSize = true;
            this.cigarrillo.Font = new System.Drawing.Font("Ink Free", 14.25F);
            this.cigarrillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.cigarrillo.Location = new System.Drawing.Point(31, 86);
            this.cigarrillo.Name = "cigarrillo";
            this.cigarrillo.Size = new System.Drawing.Size(80, 23);
            this.cigarrillo.TabIndex = 16;
            this.cigarrillo.Text = "Cigarrillo";
            // 
            // mercaderia
            // 
            this.mercaderia.AutoSize = true;
            this.mercaderia.Font = new System.Drawing.Font("Ink Free", 14.25F);
            this.mercaderia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.mercaderia.Location = new System.Drawing.Point(34, 46);
            this.mercaderia.Name = "mercaderia";
            this.mercaderia.Size = new System.Drawing.Size(99, 23);
            this.mercaderia.TabIndex = 15;
            this.mercaderia.Text = "Mercaderia";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ganancia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(385, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.Name = "FormConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_credito;
        private System.Windows.Forms.TextBox txt_debito;
        private System.Windows.Forms.TextBox txt_cigarrillo;
        private System.Windows.Forms.TextBox txt_mercaderia;
        private System.Windows.Forms.Label credito;
        private System.Windows.Forms.Label debito;
        private System.Windows.Forms.Label cigarrillo;
        private System.Windows.Forms.Label mercaderia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}