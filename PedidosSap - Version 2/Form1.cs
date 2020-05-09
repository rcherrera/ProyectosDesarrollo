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
using SAPbobsCOM;

namespace PedidosSap
{
    public partial class FrmIngreso : Form
        {
        Company oEmpresa = new Company();
        DBConnect cnn = new DBConnect();
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Select = "select ID, FechaPedido, CodCliente, Cliente,  Asesor, Referencia, Comentario, Status, Linea, FechaEntrega, TipoIngreso from Pedido_Cabecera where TipoIngreso='1' and Status='Ingresada Asesor'";
            SqlCommand comando = new SqlCommand(Select, cnn.conexion);
            comando.Connection = cnn.ObtenerConexion();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comando;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            DgvConsulta.DataSource = tabla;

            cnn.Desconectar();
            cnn.DescargarConexion();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int index2 = e.ColumnIndex;
            DataGridViewRow selectedRow = DgvConsulta.Rows[index];
            TxtID.Text = selectedRow.Cells[0].Value.ToString();
            TxtFecha.Text = selectedRow.Cells[1].Value.ToString();
            TxtCodCliente.Text = selectedRow.Cells[2].Value.ToString();
            TxtCliente.Text = selectedRow.Cells[3].Value.ToString();
            TxtAsesor.Text = selectedRow.Cells[4].Value.ToString();
            TxtOC.Text = selectedRow.Cells[5].Value.ToString();
            TxtComentario.Text = selectedRow.Cells[6].Value.ToString();
            TxtStatus.Text = selectedRow.Cells[7].Value.ToString();
            TxtLinea.Text = selectedRow.Cells[8].Value.ToString();
            TxtFechaEntrega.Text = selectedRow.Cells[9].Value.ToString();

            //--------------- DETALLE -------------------

            string Select2 = "select Cantidad, Producto, CodProducto, Unidad, Precio, Total from Pedidos_DetalleA where IdPedido=@IdPedido";
            SqlCommand comando2 = new SqlCommand(Select2, cnn.conexion);
            comando2.Connection = cnn.ObtenerConexion();
            comando2.Parameters.AddWithValue("@IdPedido", TxtID.Text);
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = comando2;
            DataTable tabla2 = new DataTable();
            da2.Fill(tabla2);
            DgvDetalle.DataSource = tabla2;

            cnn.Desconectar();
            cnn.DescargarConexion();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbEmpresa.DisplayMember = "Text";
            CmbEmpresa.ValueMember = "Value";

            var items8 = new[]{
                new{Text="Pruebas Qst",Value="Pruebas_SBO_Quisertec"},
                new{Text="Qst Gt",Value="SBO_Quisertec"},
                new{Text="Ing Verde Gt",Value="SBO_INGENIERIA_VERDE"},

            };
            CmbEmpresa.DataSource = items8;
            DgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Limpiar()
        {
            TxtAsesor.Text = "";
            TxtCliente.Text = "";
            TxtCodCliente.Text = "";
            TxtComentario.Text = "";
            TxtFecha.Text = "";
            TxtFechaEntrega.Text = "";
            TxtID.Text = "";
            TxtLinea.Text = "";
            TxtStatus.Text = "";
            TxtOC.Text = "";
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                //Instanciamos la clase oFactura de tipo Documents, en los parametros dfinimos el tipo de objeto oPurchaseInvoice

                //para trabajar con preliminares
                SAPbobsCOM.Documents oPedido = (SAPbobsCOM.Documents)oEmpresa.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oDrafts);
                oPedido.DocObjectCode = SAPbobsCOM.BoObjectTypes.oOrders;

                //SAPbobsCOM.Documents oPedido = oEmpresa.GetBusinessObject(BoObjectTypes.oOrders);


                //oPO.CardCode = "V10000";
                //ENCABEZADO DE LA FACTURA 
                oPedido.Series = 0;

                oPedido.CardCode = TxtCodCliente.Text;
                oPedido.DocType = BoDocumentTypes.dDocument_Items;
                oPedido.DocDueDate = DatePickerEntrega.Value;
                //----------

                //oPedido.HandWritten = tNO;
                //oPedido.PaymentGroupCode = -1;

                //-----

                oPedido.DocDate = DatePickerFecha.Value;
                //oPedido.TaxDate = DatePickTax.Value;
                oPedido.NumAtCard = TxtOC.Text;
                oPedido.Comments = TxtComentario.Text;
                oPedido.SalesPersonCode = 15;
                oPedido.UserFields.Fields.Item("U_AutCreditos").Value = "FV-LM";


                

                    //DETALLE DE LA FACTURA  
                    for (int i = 0; i <= DgvDetalle.RowCount-2; i++)

                {
                    //oPedido.Lines.SetCurrentLine(i);

                    //oPedido.Lines.SetCurrentLine(i);
                    //oPedido.Lines.Quantity = 1;
                    oPedido.Lines.Quantity = double.Parse(DgvDetalle.Rows[i].Cells[0].Value.ToString());
                    oPedido.Lines.PriceAfterVAT = double.Parse(DgvDetalle.Rows[i].Cells[4].Value.ToString());


                    oPedido.Lines.ItemDescription = DgvDetalle.Rows[i].Cells[1].Value.ToString();
                    oPedido.Lines.ItemCode = DgvDetalle.Rows[i].Cells[2].Value.ToString();

                    //oPedido.Lines.ItemCode = "QM000118";
                    //oPedido.Lines.UnitPrice = 100;
                  
                    //oPedido.Lines.PriceAfterVAT=Convert.ToDouble(DgvDetalle.Rows[i].Cells[3].Value.ToString());
                    //oPedido.Lines.Price = double.Parse(DgvDetalle.Rows[i].Cells[3].Value.ToString());
                    //oPedido.Lines.UnitPrice = double.Parse(DgvDetalle.Rows[i].Cells[3].Value.ToString());



                    oPedido.Lines.Add();

                }
                //oPedido.Lines.LineNum;
                //oPedido.Lines.ItemCode = TxtCodigo.Text;
                //oPedido.Lines.ItemDescription = TxtDescripcion.Text;
                //oPedido.Lines.Quantity = double.Parse(TxtCantidad.Text);
                //oPedido.Lines.UnitPrice = double.Parse(TxtPrecio.Text);
                //oPedido.Lines.UserFields.Fields.Item("U_TipoA").Value = CmbTipoTax.GetItemText(CmbTipoTax.SelectedValue);
                //oPedido.Lines.TaxCode = CmbTipoDeta.GetItemText(CmbTipoDeta.SelectedValue);
                //oPedido.Lines.ItemDetails = "1";

                int resultado = oPedido.Add();
                //Si la transaccion da error:
                if (resultado != 0)
                {
                    MessageBox.Show("Error al agregar Factura: " + oEmpresa.GetLastErrorDescription());
                }
                else
                {
                    MessageBox.Show("Pedido Ingresado Exitosamente");
                    //UPDATE PARA LA FILA
                    SqlCommand cmd = new SqlCommand();
                    //SqlCommand cmd = new SqlCommand(Update, cnn.conexion);
                    cmd.CommandText = "update Pedido_Cabecera set Status='Ingresado a SAP' where ID=@ID";
                    cmd.Connection = cnn.ObtenerConexion();

                    cmd.Parameters.AddWithValue("@ID", TxtID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ingresado a SAP!!  " + "@ID" + TxtID.Text);
                    cnn.conexion.Dispose();
                    cnn.conexion.Close();

                    //cnn.DescargarConexion();
                    Limpiar();
                    DgvDetalle.DataSource = null;
                    //limpiar();
                    //FIN DEL UPDATE PARA LA FILA
                }









                //---------------------------------------

                //string Update= "update Persons set nombre=@nombre, apellido=@apellido, fechaingreso=@fecha where id=@id";
      
       
           // DgvDetalle.Refresh();
        }
            catch (Exception err)
            {
                //Control de errores
                MessageBox.Show(err.Message, "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DgvDetalle.DataSource = null;

            DgvDetalle.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Intentando Conectar a SAP ...");
                oEmpresa.Server = "10.212.8.90";
                oEmpresa.DbServerType = BoDataServerTypes.dst_MSSQL2014;
                //UseTrusted cuando lo pongo verdadero da error
                oEmpresa.UseTrusted = false;
                oEmpresa.DbUserName = "ro";
                oEmpresa.DbPassword = "read0nly";
                oEmpresa.CompanyDB = CmbEmpresa.SelectedValue.ToString();
                oEmpresa.SLDServer = "10.212.8.90:30010";
                oEmpresa.UserName = "fac03";
                oEmpresa.Password = "1234";
                oEmpresa.language = BoSuppLangs.ln_Spanish;
                oEmpresa.AddonIdentifier = String.Empty;
                oEmpresa.LicenseServer = "10.212.8.90:40000";

                //------------------------

                //variable ret para almacenar el estado de conexion
                int ret = oEmpresa.Connect();
                if (ret != 0)
                {
                    MessageBox.Show("Error de Conexion!" + oEmpresa.GetLastErrorDescription());

                }
                else //conexion exitosa
                {
                    MessageBox.Show("Bienvenido " + oEmpresa.UserName + " a " + oEmpresa.CompanyName);
                    LblConectado.ForeColor = Color.Green;
                    LblConectado.Text = "Conectado a" + oEmpresa.CompanyDB;
                    BtnDesconectar.Enabled = true;
                    BtnConectar.Enabled = false;
                    //ACA IRIA TODAS MIS OPERACIONES
                }
            }
            //Si no funciona el Try el Catch mostrara el mensaje de error
            catch (Exception ex)
            {
                MessageBox.Show("Error en: " + ex.Message);
            }
        }

        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            oEmpresa.Disconnect();
            //oEmpresa.Connected = false;
            int ret2 = oEmpresa.Connect();
            if (ret2 != 0)
            {
                MessageBox.Show("Desconectado!!");

                LblConectado.ForeColor = Color.Red;
                LblConectado.Text = "Desconectado";
                BtnDesconectar.Enabled = false;
                BtnConectar.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            //int index3 = e.RowIndex;

            //DataGridViewRow selectedRow = DgvDetalle.Rows[index3];


        }
    }
}
