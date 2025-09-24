namespace Buscador_de_Respuestos
{
    partial class frmGestiondeRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestiondeRepuestos));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionI = new System.Windows.Forms.Label();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.cmbMarcaI = new System.Windows.Forms.ComboBox();
            this.lblMarcaI = new System.Windows.Forms.Label();
            this.opcImportadoI = new System.Windows.Forms.RadioButton();
            this.opcNacionalI = new System.Windows.Forms.RadioButton();
            this.lblOrigenI = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumeroI = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.cmbMarcaC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opcImportadoC = new System.Windows.Forms.RadioButton();
            this.opcNacionalC = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(136, 162);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(145, 20);
            this.txtDescripcion.TabIndex = 11;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lblDescripcionI
            // 
            this.lblDescripcionI.AutoSize = true;
            this.lblDescripcionI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionI.Location = new System.Drawing.Point(40, 162);
            this.lblDescripcionI.Name = "lblDescripcionI";
            this.lblDescripcionI.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionI.TabIndex = 10;
            this.lblDescripcionI.Text = "Descripción:";
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuesto.Location = new System.Drawing.Point(12, 9);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(154, 16);
            this.lblRepuesto.TabIndex = 12;
            this.lblRepuesto.Text = "Ingreso de repuestos";
            // 
            // cmbMarcaI
            // 
            this.cmbMarcaI.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMarcaI.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbMarcaI.FormattingEnabled = true;
            this.cmbMarcaI.Items.AddRange(new object[] {
            "P",
            "C",
            "F"});
            this.cmbMarcaI.Location = new System.Drawing.Point(136, 56);
            this.cmbMarcaI.Name = "cmbMarcaI";
            this.cmbMarcaI.Size = new System.Drawing.Size(145, 21);
            this.cmbMarcaI.TabIndex = 14;
            this.cmbMarcaI.SelectedIndexChanged += new System.EventHandler(this.cmbMarcaI_SelectedIndexChanged);
            // 
            // lblMarcaI
            // 
            this.lblMarcaI.AutoSize = true;
            this.lblMarcaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaI.Location = new System.Drawing.Point(40, 57);
            this.lblMarcaI.Name = "lblMarcaI";
            this.lblMarcaI.Size = new System.Drawing.Size(48, 16);
            this.lblMarcaI.TabIndex = 13;
            this.lblMarcaI.Text = "Marca:";
            // 
            // opcImportadoI
            // 
            this.opcImportadoI.AutoSize = true;
            this.opcImportadoI.Location = new System.Drawing.Point(209, 94);
            this.opcImportadoI.Name = "opcImportadoI";
            this.opcImportadoI.Size = new System.Drawing.Size(72, 17);
            this.opcImportadoI.TabIndex = 17;
            this.opcImportadoI.TabStop = true;
            this.opcImportadoI.Text = "Importado";
            this.opcImportadoI.UseVisualStyleBackColor = true;
            this.opcImportadoI.CheckedChanged += new System.EventHandler(this.opcImportadoI_CheckedChanged);
            // 
            // opcNacionalI
            // 
            this.opcNacionalI.AutoSize = true;
            this.opcNacionalI.Location = new System.Drawing.Point(136, 94);
            this.opcNacionalI.Name = "opcNacionalI";
            this.opcNacionalI.Size = new System.Drawing.Size(67, 17);
            this.opcNacionalI.TabIndex = 16;
            this.opcNacionalI.TabStop = true;
            this.opcNacionalI.Text = "Nacional";
            this.opcNacionalI.UseVisualStyleBackColor = true;
            this.opcNacionalI.CheckedChanged += new System.EventHandler(this.opcNacionalI_CheckedChanged);
            // 
            // lblOrigenI
            // 
            this.lblOrigenI.AutoSize = true;
            this.lblOrigenI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigenI.Location = new System.Drawing.Point(40, 94);
            this.lblOrigenI.Name = "lblOrigenI";
            this.lblOrigenI.Size = new System.Drawing.Size(50, 16);
            this.lblOrigenI.TabIndex = 15;
            this.lblOrigenI.Text = "Origen:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(136, 132);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 20);
            this.txtNumero.TabIndex = 19;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumeroI
            // 
            this.lblNumeroI.AutoSize = true;
            this.lblNumeroI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroI.Location = new System.Drawing.Point(41, 132);
            this.lblNumeroI.Name = "lblNumeroI";
            this.lblNumeroI.Size = new System.Drawing.Size(58, 16);
            this.lblNumeroI.TabIndex = 18;
            this.lblNumeroI.Text = "Número:";
            this.lblNumeroI.Click += new System.EventHandler(this.lblNumeroI_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(41, 193);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(95, 16);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio:             $";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(349, 230);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 23;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(12, 270);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(162, 16);
            this.lblConsulta.TabIndex = 24;
            this.lblConsulta.Text = "Consulta de repuestos";
            // 
            // cmbMarcaC
            // 
            this.cmbMarcaC.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbMarcaC.FormattingEnabled = true;
            this.cmbMarcaC.Location = new System.Drawing.Point(136, 305);
            this.cmbMarcaC.Name = "cmbMarcaC";
            this.cmbMarcaC.Size = new System.Drawing.Size(145, 21);
            this.cmbMarcaC.TabIndex = 26;
            this.cmbMarcaC.SelectedIndexChanged += new System.EventHandler(this.cmbMarcaC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Marca:";
            // 
            // opcImportadoC
            // 
            this.opcImportadoC.AutoSize = true;
            this.opcImportadoC.Location = new System.Drawing.Point(209, 341);
            this.opcImportadoC.Name = "opcImportadoC";
            this.opcImportadoC.Size = new System.Drawing.Size(72, 17);
            this.opcImportadoC.TabIndex = 29;
            this.opcImportadoC.TabStop = true;
            this.opcImportadoC.Text = "Importado";
            this.opcImportadoC.UseVisualStyleBackColor = true;
            this.opcImportadoC.CheckedChanged += new System.EventHandler(this.opcImportadoC_CheckedChanged);
            // 
            // opcNacionalC
            // 
            this.opcNacionalC.AutoSize = true;
            this.opcNacionalC.Location = new System.Drawing.Point(136, 341);
            this.opcNacionalC.Name = "opcNacionalC";
            this.opcNacionalC.Size = new System.Drawing.Size(67, 17);
            this.opcNacionalC.TabIndex = 28;
            this.opcNacionalC.TabStop = true;
            this.opcNacionalC.Text = "Nacional";
            this.opcNacionalC.UseVisualStyleBackColor = true;
            this.opcNacionalC.CheckedChanged += new System.EventHandler(this.opcNacionalC_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Origen:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(349, 373);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 30;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(15, 420);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(409, 82);
            this.lstResultados.TabIndex = 31;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGestiondeRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 512);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.opcImportadoC);
            this.Controls.Add(this.opcNacionalC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMarcaC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumeroI);
            this.Controls.Add(this.opcImportadoI);
            this.Controls.Add(this.opcNacionalI);
            this.Controls.Add(this.lblOrigenI);
            this.Controls.Add(this.cmbMarcaI);
            this.Controls.Add(this.lblMarcaI);
            this.Controls.Add(this.lblRepuesto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcionI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestiondeRepuestos";
            this.Text = "Gestión de Repuestos";
            this.Load += new System.EventHandler(this.frmGestiondeRepuestos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcionI;
        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.ComboBox cmbMarcaI;
        private System.Windows.Forms.Label lblMarcaI;
        private System.Windows.Forms.RadioButton opcImportadoI;
        private System.Windows.Forms.RadioButton opcNacionalI;
        private System.Windows.Forms.Label lblOrigenI;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumeroI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.ComboBox cmbMarcaC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton opcImportadoC;
        private System.Windows.Forms.RadioButton opcNacionalC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnSalir;
    }
}