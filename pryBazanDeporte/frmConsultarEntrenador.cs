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
    public partial class frmConsultarEntrenador : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= DEPORTE.accdb";
        public frmConsultarEntrenador()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection conexion = new OleDbConnection(ruta);

                conexion.Open();

                //Creo un DataTable para que se almacene temporalmente mi tabla
                DataTable dt = new DataTable();

                //Variable para seleccionar la tabla
                string select = @"SELECT * FROM ENTRENADORES";

                //Para que ejecute el select y haga conexion
                OleDbCommand cmd = new OleDbCommand(select, conexion);

                //Para llenar el DataTable con lo que hay en la tabla de access
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                //Para que mande los registros seleccionados al da
                da.SelectCommand = cmd;

                //Llena DataTable con lo que tiene el da
                da.Fill(dt);

                //Muestra en la grilla
                dgvEntrenador.DataSource = dt;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
