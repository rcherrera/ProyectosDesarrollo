using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PedidosSap
{
    public class DBConnect
    {
        public SqlConnection conexion = new SqlConnection();
        public SqlConnection ObtenerConexion()
        {
            conexion = new SqlConnection("Data Source=181.189.141.90;Initial Catalog=sysGI;User ID=sa;Password=S0p0rteInve");
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DescargarConexion()
        {
            conexion.Dispose();
            return true;
        }
        public bool Desconectar()
        {
            conexion.Close();
            return true;
        }
    }
}
