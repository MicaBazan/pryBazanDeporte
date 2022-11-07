namespace pryBazanDeporte
{
    partial class frmRegistrarDeportista
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lstEdad = new System.Windows.Forms.ComboBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(152)))));
            this.pnlMenu.Controls.Add(this.picCerrar);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Location = new System.Drawing.Point(-4, -6);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(518, 41);
            this.pnlMenu.TabIndex = 0;
            // 
            // picCerrar
            // 
            this.picCerrar.Image = global::pryBazanDeporte.Properties.Resources.cerrar;
            this.picCerrar.Location = new System.Drawing.Point(479, 14);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(19, 21);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 2;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(13, 14);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(178, 18);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Registro de Deportista";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 36);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 78);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(279, 78);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 122);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(279, 122);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(17, 166);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Location = new System.Drawing.Point(283, 166);
            this.lblDeporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(45, 13);
            this.lblDeporte.TabIndex = 7;
            this.lblDeporte.Text = "Deporte";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(82, 25);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 28);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(82, 67);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 28);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(344, 67);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(126, 28);
            this.txtApellido.TabIndex = 10;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(82, 111);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(179, 28);
            this.txtDireccion.TabIndex = 11;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // mskTelefono
            // 
            this.mskTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.Location = new System.Drawing.Point(344, 111);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskTelefono.Mask = "999999999";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(94, 28);
            this.mskTelefono.TabIndex = 12;
            this.mskTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefono_MaskInputRejected);
            this.mskTelefono.TextChanged += new System.EventHandler(this.mskTelefono_TextChanged);
            // 
            // lstEdad
            // 
            this.lstEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEdad.FormattingEnabled = true;
            this.lstEdad.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.lstEdad.Location = new System.Drawing.Point(82, 155);
            this.lstEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstEdad.Name = "lstEdad";
            this.lstEdad.Size = new System.Drawing.Size(56, 30);
            this.lstEdad.TabIndex = 13;
            this.lstEdad.TextChanged += new System.EventHandler(this.lstEdad_TextChanged);
            // 
            // lstDeporte
            // 
            this.lstDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Items.AddRange(new object[] {
            "BASQUET",
            "TENIS",
            "CICLISMO",
            "FUTBOL",
            "VOLEY",
            "HANDBALL",
            "BOXEO",
            "RUGBY",
            "CICLISMO",
            "HOCKEY"});
            this.lstDeporte.Location = new System.Drawing.Point(344, 155);
            this.lstDeporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(94, 30);
            this.lstDeporte.TabIndex = 14;
            this.lstDeporte.TextChanged += new System.EventHandler(this.lstDeporte_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(370, 286);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 50);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtCodigo);
            this.gbDatos.Controls.Add(this.lblCodigo);
            this.gbDatos.Controls.Add(this.lstDeporte);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lstEdad);
            this.gbDatos.Controls.Add(this.lblDeporte);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblEdad);
            this.gbDatos.Controls.Add(this.mskTelefono);
            this.gbDatos.Controls.Add(this.lblApellido);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.txtApellido);
            this.gbDatos.Controls.Add(this.lblDireccion);
            this.gbDatos.Controls.Add(this.lblTelefono);
            this.gbDatos.Location = new System.Drawing.Point(12, 49);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatos.Size = new System.Drawing.Size(482, 223);
            this.gbDatos.TabIndex = 16;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // frmRegistrarDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 348);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegistrarDeportista";
            this.Text = "Registro Deportista";
            this.Load += new System.EventHandler(this.frmRegistrarDeportista_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.ComboBox lstEdad;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gbDatos;
    }
}