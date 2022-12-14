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
    public partial class frmBuscarEntrenador : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= DEPORTE.accdb";

        public frmBuscarEntrenador()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);

            string select = "SELECT * FROM ENTRENADORES WHERE CODIGO_ENTRENADORES='" + codigo + "'";

            OleDbDataAdapter adaptador = new OleDbDataAdapter(select, conexion);

            DataSet ds = new DataSet();

            conexion.Open();

            adaptador.Fill(ds);

            conexion.Close();

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Lo siento el código ingresado no existe", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Text = "";
                ds.Dispose();
                return;
            }
            else
            {
                txtNombre.Text = ds.Tables[0].Rows[0]["NOMBRE"].ToString();
                txtApellido.Text = ds.Tables[0].Rows[0]["APELLIDO"].ToString();
                txtDireccion.Text = ds.Tables[0].Rows[0]["DIRECCION"].ToString();
                lstProvincia.Text = ds.Tables[0].Rows[0]["PROVINCIA"].ToString();
                lstDeporte.Text = ds.Tables[0].Rows[0]["DEPORTE"].ToString();
                ds.Dispose();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                return;
            }
        }

        private void interfazInicial()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            lstProvincia.Enabled = false;
            lstDeporte.Enabled = false;

            btnGuardar.Enabled = false;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void habilitar()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            lstProvincia.Enabled = true;
            lstDeporte.Enabled = true;

            btnGuardar.Enabled = true;
        }

        private void frmBuscarEntrenador_Load(object sender, EventArgs e)
        {
            interfazInicial();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitar();
            txtCodigo.Enabled = false;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection(ruta);

            string update = "UPDATE ENTRENADORES SET NOMBRE=@Nombre,APELLIDO=@Apellido,DIRECCION=@Direccion,PROVINCIA=@Provincia,DEPORTE=@Deporte WHERE CODIGO_ENTRENADORES=@Codigo";

            try
            {
                OleDbCommand cmd = new OleDbCommand(update, conexion);

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Provincia", lstProvincia.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Deporte", lstDeporte.Text.ToUpper());

                cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Registro Actualizado Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            interfazInicial();
            limpiar();
            txtCodigo.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            string delete = "DELETE FROM ENTRENADORES WHERE CODIGO_ENTRENADORES='" + codigo + "'";
            OleDbCommand cmd = new OleDbCommand(delete, conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            interfazInicial();
            MessageBox.Show("Registro Eliminado Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            lstProvincia.Text = "";
            lstDeporte.Text = "";
            txtCodigo.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }
    }
}
