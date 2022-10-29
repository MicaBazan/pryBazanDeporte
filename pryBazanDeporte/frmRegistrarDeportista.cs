using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazanDeporte
{
    public partial class frmRegistrarDeportista : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= DEPORTE.accdb";

        public frmRegistrarDeportista()
        {
            InitializeComponent();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRegistrarDeportista_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();

            string insert = @"INSERT INTO DEPORTISTA(CODIGO_DEPORTISTA,NOMBRE,APELLIDO,DIRECCION,TELEFONO,EDAD,DEPORTE)
                                VALUES(@CODIGO_DEPORTISTA, @NOMBRE, @APELLIDO, @DIRECCION, @TELEFONO, @EDAD, @DEPORTE)";

            OleDbCommand cmd = new OleDbCommand(insert, conexion);

            cmd.Parameters.AddWithValue("@CODIGO_DEPORTISTA", txtCodigo.Text.ToUpper());
            cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text.ToUpper());
            cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text.ToUpper());
            cmd.Parameters.AddWithValue("@DIRECCION", txtDireccion.Text.ToUpper());
            cmd.Parameters.AddWithValue("@TELEFONO", mskTelefono.Text);
            cmd.Parameters.AddWithValue("@EDAD", lstEdad.Text);
            cmd.Parameters.AddWithValue("@DEPORTE", lstDeporte.Text.ToUpper());

            cmd.ExecuteNonQuery();

            MessageBox.Show("Deportista Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Close();

            limpiar();
        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            mskTelefono.Text = "";
            lstEdad.Text = "";
            lstDeporte.Text = "";
        }

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
