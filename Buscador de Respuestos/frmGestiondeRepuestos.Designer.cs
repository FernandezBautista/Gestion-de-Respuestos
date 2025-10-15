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
            this.txtPrecio = new System.Windows.Forms.TextBox();
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(143, 133);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(142, 20);
            this.txtDescripcion.TabIndex = 11;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lblDescripcionI
            // 
            this.lblDescripcionI.AutoSize = true;
            this.lblDescripcionI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionI.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionI.Location = new System.Drawing.Point(3, 133);
            this.lblDescripcionI.Name = "lblDescripcionI";
            this.lblDescripcionI.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionI.TabIndex = 10;
            this.lblDescripcionI.Text = "Descripción:";
            this.lblDescripcionI.Click += new System.EventHandler(this.lblDescripcionI_Click);
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuesto.ForeColor = System.Drawing.Color.Black;
            this.lblRepuesto.Location = new System.Drawing.Point(6, 18);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(154, 16);
            this.lblRepuesto.TabIndex = 12;
            this.lblRepuesto.Text = "Ingreso de repuestos";
            // 
            // cmbMarcaI
            // 
            this.cmbMarcaI.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMarcaI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaI.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbMarcaI.FormattingEnabled = true;
            this.cmbMarcaI.Items.AddRange(new object[] {
            "P",
            "C",
            "F"});
            this.cmbMarcaI.Location = new System.Drawing.Point(143, 59);
            this.cmbMarcaI.Name = "cmbMarcaI";
            this.cmbMarcaI.Size = new System.Drawing.Size(142, 21);
            this.cmbMarcaI.TabIndex = 14;
            this.cmbMarcaI.SelectedIndexChanged += new System.EventHandler(this.cmbMarcaI_SelectedIndexChanged);
            // 
            // lblMarcaI
            // 
            this.lblMarcaI.AutoSize = true;
            this.lblMarcaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaI.ForeColor = System.Drawing.Color.Black;
            this.lblMarcaI.Location = new System.Drawing.Point(3, 59);
            this.lblMarcaI.Name = "lblMarcaI";
            this.lblMarcaI.Size = new System.Drawing.Size(48, 16);
            this.lblMarcaI.TabIndex = 13;
            this.lblMarcaI.Text = "Marca:";
            // 
            // opcImportadoI
            // 
            this.opcImportadoI.AutoSize = true;
            this.opcImportadoI.ForeColor = System.Drawing.Color.Black;
            this.opcImportadoI.Location = new System.Drawing.Point(216, 87);
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
            this.opcNacionalI.ForeColor = System.Drawing.Color.Black;
            this.opcNacionalI.Location = new System.Drawing.Point(143, 87);
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
            this.lblOrigenI.ForeColor = System.Drawing.Color.Black;
            this.lblOrigenI.Location = new System.Drawing.Point(3, 87);
            this.lblOrigenI.Name = "lblOrigenI";
            this.lblOrigenI.Size = new System.Drawing.Size(50, 16);
            this.lblOrigenI.TabIndex = 15;
            this.lblOrigenI.Text = "Origen:";
            this.lblOrigenI.Click += new System.EventHandler(this.lblOrigenI_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(143, 110);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(142, 20);
            this.txtNumero.TabIndex = 19;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumeroI
            // 
            this.lblNumeroI.AutoSize = true;
            this.lblNumeroI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroI.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroI.Location = new System.Drawing.Point(3, 111);
            this.lblNumeroI.Name = "lblNumeroI";
            this.lblNumeroI.Size = new System.Drawing.Size(58, 16);
            this.lblNumeroI.TabIndex = 18;
            this.lblNumeroI.Text = "Número:";
            this.lblNumeroI.Click += new System.EventHandler(this.lblNumeroI_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(143, 156);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(142, 20);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(3, 157);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(134, 16);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio:                          $";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnIngresar.Location = new System.Drawing.Point(143, 191);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(142, 23);
            this.btnIngresar.TabIndex = 23;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(13, 6);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(162, 16);
            this.lblConsulta.TabIndex = 24;
            this.lblConsulta.Text = "Consulta de repuestos";
            // 
            // cmbMarcaC
            // 
            this.cmbMarcaC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaC.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbMarcaC.FormattingEnabled = true;
            this.cmbMarcaC.Items.AddRange(new object[] {
            "P",
            "C",
            "F"});
            this.cmbMarcaC.Location = new System.Drawing.Point(137, 35);
            this.cmbMarcaC.Name = "cmbMarcaC";
            this.cmbMarcaC.Size = new System.Drawing.Size(145, 21);
            this.cmbMarcaC.TabIndex = 26;
            this.cmbMarcaC.SelectedIndexChanged += new System.EventHandler(this.cmbMarcaC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Marca:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // opcImportadoC
            // 
            this.opcImportadoC.AutoSize = true;
            this.opcImportadoC.Location = new System.Drawing.Point(210, 64);
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
            this.opcNacionalC.Location = new System.Drawing.Point(137, 64);
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
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Origen:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(159, 98);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 23);
            this.btnConsultar.TabIndex = 30;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(16, 127);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(269, 82);
            this.lstResultados.TabIndex = 31;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(16, 217);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(269, 23);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.Location = new System.Drawing.Point(6, 191);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 23);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar2.Location = new System.Drawing.Point(16, 98);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(123, 23);
            this.btnLimpiar2.TabIndex = 34;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Controls.Add(this.tabConsulta);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(299, 275);
            this.tabControl1.TabIndex = 35;
            // 
            // tabRegistro
            // 
            this.tabRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRegistro.Controls.Add(this.lblRepuesto);
            this.tabRegistro.Controls.Add(this.lblDescripcionI);
            this.tabRegistro.Controls.Add(this.btnLimpiar);
            this.tabRegistro.Controls.Add(this.txtDescripcion);
            this.tabRegistro.Controls.Add(this.lblMarcaI);
            this.tabRegistro.Controls.Add(this.cmbMarcaI);
            this.tabRegistro.Controls.Add(this.lblOrigenI);
            this.tabRegistro.Controls.Add(this.opcNacionalI);
            this.tabRegistro.Controls.Add(this.opcImportadoI);
            this.tabRegistro.Controls.Add(this.lblNumeroI);
            this.tabRegistro.Controls.Add(this.txtNumero);
            this.tabRegistro.Controls.Add(this.lblPrecio);
            this.tabRegistro.Controls.Add(this.txtPrecio);
            this.tabRegistro.Controls.Add(this.btnIngresar);
            this.tabRegistro.ForeColor = System.Drawing.Color.Transparent;
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(291, 249);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Ingreso de repuestos";
            this.tabRegistro.Click += new System.EventHandler(this.tabRegistro_Click);
            // 
            // tabConsulta
            // 
            this.tabConsulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabConsulta.Controls.Add(this.lstResultados);
            this.tabConsulta.Controls.Add(this.btnLimpiar2);
            this.tabConsulta.Controls.Add(this.lblConsulta);
            this.tabConsulta.Controls.Add(this.btnSalir);
            this.tabConsulta.Controls.Add(this.label1);
            this.tabConsulta.Controls.Add(this.cmbMarcaC);
            this.tabConsulta.Controls.Add(this.btnConsultar);
            this.tabConsulta.Controls.Add(this.label2);
            this.tabConsulta.Controls.Add(this.opcImportadoC);
            this.tabConsulta.Controls.Add(this.opcNacionalC);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(291, 249);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta de repuestos";
            // 
            // frmGestiondeRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 302);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestiondeRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Repuestos";
            this.Load += new System.EventHandler(this.frmGestiondeRepuestos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtPrecio;
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
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabConsulta;
    }
}