namespace PedidosSap
{
    partial class FrmIngreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngreso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.DatePickerEntrega = new System.Windows.Forms.DateTimePicker();
            this.DatePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.CmbEmpresa = new System.Windows.Forms.ComboBox();
            this.BtnDesconectar = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAsesor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLinea = new System.Windows.Forms.TextBox();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtFechaEntrega = new System.Windows.Forms.TextBox();
            this.TxtOC = new System.Windows.Forms.TextBox();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.BtnRechazar = new System.Windows.Forms.Button();
            this.BtnSAP = new System.Windows.Forms.Button();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.LblConectado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblConectado);
            this.panel1.Controls.Add(this.DgvDetalle);
            this.panel1.Controls.Add(this.DatePickerEntrega);
            this.panel1.Controls.Add(this.DatePickerFecha);
            this.panel1.Controls.Add(this.CmbEmpresa);
            this.panel1.Controls.Add(this.BtnDesconectar);
            this.panel1.Controls.Add(this.BtnConectar);
            this.panel1.Controls.Add(this.TxtID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TxtCodCliente);
            this.panel1.Controls.Add(this.TxtComentario);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtAsesor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtLinea);
            this.panel1.Controls.Add(this.TxtStatus);
            this.panel1.Controls.Add(this.TxtFecha);
            this.panel1.Controls.Add(this.TxtFechaEntrega);
            this.panel1.Controls.Add(this.TxtOC);
            this.panel1.Controls.Add(this.TxtCliente);
            this.panel1.Location = new System.Drawing.Point(9, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 273);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Location = new System.Drawing.Point(18, 92);
            this.DgvDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.RowHeadersWidth = 51;
            this.DgvDetalle.RowTemplate.Height = 24;
            this.DgvDetalle.Size = new System.Drawing.Size(640, 145);
            this.DgvDetalle.TabIndex = 22;
            this.DgvDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalle_CellContentClick);
            this.DgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalle_CellContentClick);
            // 
            // DatePickerEntrega
            // 
            this.DatePickerEntrega.Location = new System.Drawing.Point(671, 3);
            this.DatePickerEntrega.Name = "DatePickerEntrega";
            this.DatePickerEntrega.Size = new System.Drawing.Size(114, 20);
            this.DatePickerEntrega.TabIndex = 21;
            // 
            // DatePickerFecha
            // 
            this.DatePickerFecha.Location = new System.Drawing.Point(671, 26);
            this.DatePickerFecha.Name = "DatePickerFecha";
            this.DatePickerFecha.Size = new System.Drawing.Size(114, 20);
            this.DatePickerFecha.TabIndex = 20;
            // 
            // CmbEmpresa
            // 
            this.CmbEmpresa.FormattingEnabled = true;
            this.CmbEmpresa.Location = new System.Drawing.Point(666, 109);
            this.CmbEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.CmbEmpresa.Name = "CmbEmpresa";
            this.CmbEmpresa.Size = new System.Drawing.Size(129, 21);
            this.CmbEmpresa.TabIndex = 18;
            // 
            // BtnDesconectar
            // 
            this.BtnDesconectar.Image = ((System.Drawing.Image)(resources.GetObject("BtnDesconectar.Image")));
            this.BtnDesconectar.Location = new System.Drawing.Point(734, 134);
            this.BtnDesconectar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDesconectar.Name = "BtnDesconectar";
            this.BtnDesconectar.Size = new System.Drawing.Size(61, 58);
            this.BtnDesconectar.TabIndex = 17;
            this.BtnDesconectar.UseVisualStyleBackColor = true;
            this.BtnDesconectar.Click += new System.EventHandler(this.BtnDesconectar_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConectar.Image")));
            this.BtnConectar.Location = new System.Drawing.Point(666, 134);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(61, 58);
            this.BtnConectar.TabIndex = 16;
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.button4_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(664, 68);
            this.TxtID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtID.Name = "TxtID";
            this.TxtID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtID.Size = new System.Drawing.Size(123, 20);
            this.TxtID.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(585, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Id Pedido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Codigo Cliente:";
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.Location = new System.Drawing.Point(112, 6);
            this.TxtCodCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.Size = new System.Drawing.Size(191, 20);
            this.TxtCodCliente.TabIndex = 12;
            // 
            // TxtComentario
            // 
            this.TxtComentario.Location = new System.Drawing.Point(340, 248);
            this.TxtComentario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(246, 20);
            this.TxtComentario.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Comentario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Linea";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // TxtAsesor
            // 
            this.TxtAsesor.Location = new System.Drawing.Point(71, 248);
            this.TxtAsesor.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAsesor.Name = "TxtAsesor";
            this.TxtAsesor.Size = new System.Drawing.Size(150, 20);
            this.TxtAsesor.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Creacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de Entrega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Orden de Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtLinea
            // 
            this.TxtLinea.Location = new System.Drawing.Point(112, 68);
            this.TxtLinea.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLinea.Name = "TxtLinea";
            this.TxtLinea.Size = new System.Drawing.Size(191, 20);
            this.TxtLinea.TabIndex = 5;
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(664, 47);
            this.TxtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtStatus.Size = new System.Drawing.Size(123, 20);
            this.TxtStatus.TabIndex = 4;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(664, 25);
            this.TxtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(123, 20);
            this.TxtFecha.TabIndex = 3;
            // 
            // TxtFechaEntrega
            // 
            this.TxtFechaEntrega.Location = new System.Drawing.Point(664, 4);
            this.TxtFechaEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFechaEntrega.Name = "TxtFechaEntrega";
            this.TxtFechaEntrega.Size = new System.Drawing.Size(123, 20);
            this.TxtFechaEntrega.TabIndex = 2;
            // 
            // TxtOC
            // 
            this.TxtOC.Location = new System.Drawing.Point(138, 47);
            this.TxtOC.Margin = new System.Windows.Forms.Padding(2);
            this.TxtOC.Name = "TxtOC";
            this.TxtOC.Size = new System.Drawing.Size(165, 20);
            this.TxtOC.TabIndex = 1;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(112, 27);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(191, 20);
            this.TxtCliente.TabIndex = 0;
            // 
            // BtnRechazar
            // 
            this.BtnRechazar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRechazar.Image")));
            this.BtnRechazar.Location = new System.Drawing.Point(750, 408);
            this.BtnRechazar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRechazar.Name = "BtnRechazar";
            this.BtnRechazar.Size = new System.Drawing.Size(56, 85);
            this.BtnRechazar.TabIndex = 10;
            this.BtnRechazar.UseVisualStyleBackColor = true;
            this.BtnRechazar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSAP
            // 
            this.BtnSAP.Image = ((System.Drawing.Image)(resources.GetObject("BtnSAP.Image")));
            this.BtnSAP.Location = new System.Drawing.Point(625, 408);
            this.BtnSAP.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSAP.Name = "BtnSAP";
            this.BtnSAP.Size = new System.Drawing.Size(121, 85);
            this.BtnSAP.TabIndex = 11;
            this.BtnSAP.UseVisualStyleBackColor = true;
            this.BtnSAP.Click += new System.EventHandler(this.button3_Click);
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Location = new System.Drawing.Point(27, 10);
            this.DgvConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.RowHeadersWidth = 51;
            this.DgvConsulta.RowTemplate.Height = 24;
            this.DgvConsulta.Size = new System.Drawing.Size(646, 114);
            this.DgvConsulta.TabIndex = 12;
            this.DgvConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.DgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(703, 10);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(103, 114);
            this.BtnActualizar.TabIndex = 13;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblConectado
            // 
            this.LblConectado.AutoSize = true;
            this.LblConectado.Location = new System.Drawing.Point(606, 248);
            this.LblConectado.Name = "LblConectado";
            this.LblConectado.Size = new System.Drawing.Size(48, 15);
            this.LblConectado.TabIndex = 23;
            this.LblConectado.Text = "label11";
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 505);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.DgvConsulta);
            this.Controls.Add(this.BtnSAP);
            this.Controls.Add(this.BtnRechazar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmIngreso";
            this.Text = "INGRESO PEDIDO A SAP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLinea;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtFechaEntrega;
        private System.Windows.Forms.TextBox TxtOC;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtAsesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRechazar;
        private System.Windows.Forms.Button BtnSAP;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnDesconectar;
        private System.Windows.Forms.ComboBox CmbEmpresa;
        private System.Windows.Forms.DateTimePicker DatePickerFecha;
        private System.Windows.Forms.DateTimePicker DatePickerEntrega;
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.Label LblConectado;
    }
}

