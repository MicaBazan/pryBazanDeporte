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
    public partial class frmBuscarDeportista : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= DEPORTE.accdb";

        public frmBuscarDeportista()
        {
            InitializeComponent();
        }

        private void frmBuscarDeportista_Load(object sender, EventArgs e)
        {
            interfazInicial();
        }

        private void interfazInicial()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            mskTelefono.Enabled = false;
            lstDeporte.Enabled = false;
            lstEdad.Enabled = false;

            btnGuardar.Enabled = false;
        }

        private void habilitar()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            mskTelefono.Enabled = true;
            lstDeporte.Enabled = true;
            lstEdad.Enabled = true;

            btnGuardar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);

            string select = "SELECT * FROM DEPORTISTA WHERE CODIGO_DEPORTISTA='" + codigo + "'";

            OleDbDataAdapter adaptador = new OleDbDataAdapter(select, conexion);

            DataSet ds = new DataSet();

            conexion.Open();

            adaptador.Fill(ds);

            conexion.Close();

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Lo siento el código ingresado no existe", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Dispose();
                return;
            }
            else
            {
                txtNombre.Text = ds.Tables[0].Rows[0]["NOMBRE"].ToString();
                txtApellido.Text = ds.Tables[0].Rows[0]["APELLIDO"].ToString();
                txtDireccion.Text = ds.Tables[0].Rows[0]["DIRECCION"].ToString();
                mskTelefono.Text = ds.Tables[0].Rows[0]["TELEFONO"].ToString();
                lstEdad.Text = ds.Tables[0].Rows[0]["EDAD"].ToString();
                lstDeporte.Text = ds.Tables[0].Rows[0]["DEPORTE"].ToString();
                ds.Dispose();
                return;
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection(ruta);

            string update = "UPDATE DEPORTISTA SET NOMBRE=@Nombre,APELLIDO=@Direccion,TELEFONO=@Telefono,EDAD=@Edad,DEPORTE=@Deporte WHERE CODIGO_DEPORTISTA=@Codigo";

            try
            {
                OleDbCommand cmd = new OleDbCommand(update, conexion);

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Telefono", mskTelefono.Text);
                cmd.Parameters.AddWithValue("@Edad", lstEdad.Text);
                cmd.Parameters.AddWithValue("@Deporte", lstDeporte.Text);

                cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Registro Actualizado Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                interfazInicial();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                interfazInicial();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            string delete = "DELETE FROM DEPORTISTA WHERE CODIGO_DEPORTISTA='" + codigo + "'";
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
            mskTelefono.Text = "";
            lstDeporte.Text = "";
            lstEdad.Text = "";
            txtCodigo.Text = "";
        }
    }
}
