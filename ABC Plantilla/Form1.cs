using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nomina
{
    public partial class Form1 : Form
    {
        DBConnect cnn = new DBConnect();     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatePickIngreso.Format = DateTimePickerFormat.Custom;
            DatePickIngreso.CustomFormat = "dd-MM-yyyy";
            TxtNombre.Focus();
            TxtApellido.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BOTON INSERT DE 3 FORMAS DISTINTAS

            //con variable cnn:
            // SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=MicroSys;User ID=sa;Password=donadona");


            //Conexion con una clase: 



            //Primer Metodo de Insert:
            //string cadena = "insert into persons values('"+TxtNombre.Text + "', '"+TxtApellido.Text +"','"+DatePickIngreso.Value+"')";
            //SqlCommand comando = new SqlCommand(cadena, cnn.conexion);
            //comando.Connection=cnn.ObtenerConexion();
            //comando.ExecuteNonQuery();

            //Segundo Metodo:
            //SqlDataAdapter da = new SqlDataAdapter();       
            ////cnn.Open();
            //da.InsertCommand = new SqlCommand("Insert into persons values(@nombre, @apellido,@fecha)",cnn);
            //da.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
            //da.InsertCommand.Parameters.Add("@apellido", SqlDbType.VarChar).Value = TxtApellido.Text;
            //da.InsertCommand.Parameters.Add("@fecha", SqlDbType.Date).Value = DatePickIngreso.Value;
            //cnn.Open();
            ////MessageBox.Show("Agregado con Exito! " + cnn.State.ToString());
            //da.InsertCommand.ExecuteNonQuery();


            //Tercer metodo: Invocando a la clase
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn.ObtenerConexion();

            cmd.CommandText = "Insert into persons values(@nombre, @apellido,@fecha)";
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 60).Value = TxtNombre.Text;
            cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 60).Value = TxtApellido.Text;
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = DatePickIngreso.Value;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ingresado Exitosamente!!");
            Limpiar();
            cnn.Desconectar();
            
        }


        //Boton Llenar DataGridView
        private void button2_Click(object sender, EventArgs e)
        {
            string Select = "select * from persons order by id";          
            SqlCommand comando = new SqlCommand(Select, cnn.conexion);
            comando.Connection = cnn.ObtenerConexion();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comando;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            DgvPersonas.DataSource = tabla;

            cnn.Desconectar();
            cnn.DescargarConexion();
        }

        //Boton Actualizar
        private void button3_Click(object sender, EventArgs e)
        {
            //string Update= "update Persons set nombre=@nombre, apellido=@apellido, fechaingreso=@fecha where id=@id";
            SqlCommand cmd = new SqlCommand();
            //SqlCommand cmd = new SqlCommand(Update, cnn.conexion);
            cmd.CommandText= "update Persons set nombre=@nombre, apellido=@apellido, fechaingreso=@fecha where id=@id";
            cmd.Connection = cnn.ObtenerConexion();

            cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text);
            cmd.Parameters.AddWithValue("@apellido", TxtApellido.Text);
            cmd.Parameters.AddWithValue("@fecha", DatePickIngreso.Value);
            cmd.Parameters.AddWithValue("@id", TxtId.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Actualizao!!");
            cnn.conexion.Dispose();
            cnn.conexion.Close();
           
            //cnn.DescargarConexion();
            Limpiar();
        }

        //Boton Borrar
        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from Persons where id=@id2";
            cmd.Connection = cnn.ObtenerConexion();

            cmd.Parameters.AddWithValue("@id2", TxtId.Text);
            cmd.ExecuteNonQuery();
            cnn.DescargarConexion();
            cnn.Desconectar();
            MessageBox.Show("Borrado!!");
            Limpiar();
        }

        //Metodo Limpiar
        private void Limpiar()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtId.Text = "";
        }
    }
}
