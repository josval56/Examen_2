namespace Moreno_Jose
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
            this.gbo_ingreso = new System.Windows.Forms.GroupBox();
            this.gbo_informacion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_patente = new System.Windows.Forms.TextBox();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.txt_horas = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.dg_informacion = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_autos = new System.Windows.Forms.Label();
            this.lbl_motos = new System.Windows.Forms.Label();
            this.lbl_camionetas = new System.Windows.Forms.Label();
            this.lbl_ingresos = new System.Windows.Forms.Label();
            this.lbl_mayor_horas = new System.Windows.Forms.Label();
            this.gbo_ingreso.SuspendLayout();
            this.gbo_informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_informacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbo_ingreso
            // 
            this.gbo_ingreso.Controls.Add(this.btn_ingresar);
            this.gbo_ingreso.Controls.Add(this.txt_horas);
            this.gbo_ingreso.Controls.Add(this.cbo_tipo);
            this.gbo_ingreso.Controls.Add(this.txt_patente);
            this.gbo_ingreso.Controls.Add(this.label3);
            this.gbo_ingreso.Controls.Add(this.label2);
            this.gbo_ingreso.Controls.Add(this.label1);
            this.gbo_ingreso.Location = new System.Drawing.Point(12, 12);
            this.gbo_ingreso.Name = "gbo_ingreso";
            this.gbo_ingreso.Size = new System.Drawing.Size(291, 262);
            this.gbo_ingreso.TabIndex = 0;
            this.gbo_ingreso.TabStop = false;
            this.gbo_ingreso.Text = "Ingreso";
            this.gbo_ingreso.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbo_informacion
            // 
            this.gbo_informacion.Controls.Add(this.lbl_mayor_horas);
            this.gbo_informacion.Controls.Add(this.lbl_ingresos);
            this.gbo_informacion.Controls.Add(this.lbl_camionetas);
            this.gbo_informacion.Controls.Add(this.lbl_motos);
            this.gbo_informacion.Controls.Add(this.lbl_autos);
            this.gbo_informacion.Controls.Add(this.lbl_total);
            this.gbo_informacion.Controls.Add(this.btn_calcular);
            this.gbo_informacion.Controls.Add(this.label9);
            this.gbo_informacion.Controls.Add(this.label8);
            this.gbo_informacion.Controls.Add(this.label7);
            this.gbo_informacion.Controls.Add(this.label6);
            this.gbo_informacion.Controls.Add(this.label5);
            this.gbo_informacion.Controls.Add(this.label4);
            this.gbo_informacion.Controls.Add(this.dg_informacion);
            this.gbo_informacion.Location = new System.Drawing.Point(333, 12);
            this.gbo_informacion.Name = "gbo_informacion";
            this.gbo_informacion.Size = new System.Drawing.Size(491, 262);
            this.gbo_informacion.TabIndex = 1;
            this.gbo_informacion.TabStop = false;
            this.gbo_informacion.Text = "Información";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas:";
            // 
            // txt_patente
            // 
            this.txt_patente.Location = new System.Drawing.Point(89, 72);
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Size = new System.Drawing.Size(124, 20);
            this.txt_patente.TabIndex = 3;
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Location = new System.Drawing.Point(88, 115);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(123, 21);
            this.cbo_tipo.TabIndex = 4;
            // 
            // txt_horas
            // 
            this.txt_horas.Location = new System.Drawing.Point(88, 157);
            this.txt_horas.Name = "txt_horas";
            this.txt_horas.Size = new System.Drawing.Size(124, 20);
            this.txt_horas.TabIndex = 5;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(100, 211);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(90, 23);
            this.btn_ingresar.TabIndex = 6;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // dg_informacion
            // 
            this.dg_informacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_informacion.Location = new System.Drawing.Point(27, 24);
            this.dg_informacion.Name = "dg_informacion";
            this.dg_informacion.Size = new System.Drawing.Size(441, 112);
            this.dg_informacion.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total de Vehiculos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Autos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Motos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Camionetas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ingresos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Patente con Mayor Horas:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(277, 227);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 23);
            this.btn_calcular.TabIndex = 7;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(139, 157);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(10, 13);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "-";
            // 
            // lbl_autos
            // 
            this.lbl_autos.AutoSize = true;
            this.lbl_autos.Location = new System.Drawing.Point(139, 184);
            this.lbl_autos.Name = "lbl_autos";
            this.lbl_autos.Size = new System.Drawing.Size(10, 13);
            this.lbl_autos.TabIndex = 9;
            this.lbl_autos.Text = "-";
            // 
            // lbl_motos
            // 
            this.lbl_motos.AutoSize = true;
            this.lbl_motos.Location = new System.Drawing.Point(139, 211);
            this.lbl_motos.Name = "lbl_motos";
            this.lbl_motos.Size = new System.Drawing.Size(10, 13);
            this.lbl_motos.TabIndex = 10;
            this.lbl_motos.Text = "-";
            // 
            // lbl_camionetas
            // 
            this.lbl_camionetas.AutoSize = true;
            this.lbl_camionetas.Location = new System.Drawing.Point(139, 237);
            this.lbl_camionetas.Name = "lbl_camionetas";
            this.lbl_camionetas.Size = new System.Drawing.Size(10, 13);
            this.lbl_camionetas.TabIndex = 11;
            this.lbl_camionetas.Text = "-";
            // 
            // lbl_ingresos
            // 
            this.lbl_ingresos.AutoSize = true;
            this.lbl_ingresos.Location = new System.Drawing.Point(393, 154);
            this.lbl_ingresos.Name = "lbl_ingresos";
            this.lbl_ingresos.Size = new System.Drawing.Size(10, 13);
            this.lbl_ingresos.TabIndex = 12;
            this.lbl_ingresos.Text = "-";
            // 
            // lbl_mayor_horas
            // 
            this.lbl_mayor_horas.AutoSize = true;
            this.lbl_mayor_horas.Location = new System.Drawing.Point(393, 184);
            this.lbl_mayor_horas.Name = "lbl_mayor_horas";
            this.lbl_mayor_horas.Size = new System.Drawing.Size(10, 13);
            this.lbl_mayor_horas.TabIndex = 13;
            this.lbl_mayor_horas.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 316);
            this.Controls.Add(this.gbo_informacion);
            this.Controls.Add(this.gbo_ingreso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbo_ingreso.ResumeLayout(false);
            this.gbo_ingreso.PerformLayout();
            this.gbo_informacion.ResumeLayout(false);
            this.gbo_informacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_informacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbo_ingreso;
        private System.Windows.Forms.GroupBox gbo_informacion;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.TextBox txt_horas;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.TextBox txt_patente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_mayor_horas;
        private System.Windows.Forms.Label lbl_ingresos;
        private System.Windows.Forms.Label lbl_camionetas;
        private System.Windows.Forms.Label lbl_motos;
        private System.Windows.Forms.Label lbl_autos;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg_informacion;
    }
}

