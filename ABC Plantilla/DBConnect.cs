using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nomina
{
 public class DBConnect
    {
        public SqlConnection conexion = new SqlConnection();
        public SqlConnection ObtenerConexion()
        {
             conexion = new SqlConnection("Data Source = localhost; Initial Catalog = MicroSys; User ID = sa; Password = donadona");
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