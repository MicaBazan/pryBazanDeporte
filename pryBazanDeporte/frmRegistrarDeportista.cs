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
        string[] vecCodigo = new string[100];
        int indice = 0;

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
            lstDeporte.SelectedIndex = -1;
            lstEdad.SelectedIndex = -1;
            btnRegistrar.Enabled = false;


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string codigo = txtCodigo.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();


            //Mover al vector el codigo deportista
            string selectVec = "SELECT CODIGO_DEPORTISTA FROM DEPORTISTA";
            OleDbCommand cmdVec = new OleDbCommand(selectVec, conexion);


            OleDbDataReader objLector = cmdVec.ExecuteReader();
            while (objLector.Read())
            {
                vecCodigo[indice] = Convert.ToString(objLector);
                indice++;
            }


            if(!vecCodigo.Contains(codigo))
            {
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
            }
            else
            {

                MessageBox.Show("El codigo que ingreso ya existe", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
                           

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

        private void validar()
        {
            if(txtCodigo.Text != string.Empty && txtNombre.Text != string.Empty && txtApellido.Text != string.Empty && txtDireccion.Text != string.Empty && mskTelefono.Text != string.Empty && lstEdad.Text != string.Empty && lstDeporte.Text != string.Empty)
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void mskTelefono_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void lstEdad_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void lstDeporte_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
