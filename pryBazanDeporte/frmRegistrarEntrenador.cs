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
    public partial class frmRegistrarEntrenador : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= DEPORTE.accdb";
        public frmRegistrarEntrenador()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();

            string insert = @"INSERT INTO ENTRENADORES(CODIGO_ENTRENADORES,NOMBRE,APELLIDO,DIRECCION,PROVINCIA,DEPORTE)
                                VALUES(@CODIGO_ENTRENADORES, @NOMBRE, @APELLIDO, @DIRECCION, @PROVINCIA, @DEPORTE)";

            OleDbCommand cmd = new OleDbCommand(insert, conexion);

            cmd.Parameters.AddWithValue("@CODIGO_ENTRENADORES", txtCodigo.Text.ToUpper());
            cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text.ToUpper());
            cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text.ToUpper());
            cmd.Parameters.AddWithValue("@DIRECCION", txtDireccion.Text.ToUpper());
            cmd.Parameters.AddWithValue("@PROVINCIA", lstProvincia.Text.ToUpper());
            cmd.Parameters.AddWithValue("@DEPORTE", lstDeporte.Text.ToUpper());

            cmd.ExecuteNonQuery();

            MessageBox.Show("Entrenador Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Close();

            limpiar();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            lstProvincia.Text = "";
            lstDeporte.Text = "";
        }
    }
}
