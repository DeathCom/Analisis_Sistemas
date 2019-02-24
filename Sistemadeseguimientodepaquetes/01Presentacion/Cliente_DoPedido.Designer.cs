namespace _01Presentacion
{
    partial class Cliente_DoPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente_DoPedido));
            this.icono = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btncalcular = new System.Windows.Forms.PictureBox();
            this.comboCostEnvio = new System.Windows.Forms.ComboBox();
            this.comboImpuesto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboCiudadDestino = new System.Windows.Forms.ComboBox();
            this.comboCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.comboPago = new System.Windows.Forms.ComboBox();
            this.comboEnvio = new System.Windows.Forms.ComboBox();
            this.comboPaisDestino = new System.Windows.Forms.ComboBox();
            this.comboPaisOrigen = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdEstado = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncalcular)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // icono
            // 
            this.icono.Image = ((System.Drawing.Image)(resources.GetObject("icono.Image")));
            this.icono.Location = new System.Drawing.Point(12, 4);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(25, 25);
            this.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono.TabIndex = 1;
            this.icono.TabStop = false;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.SteelBlue;
            this.panelCentral.Controls.Add(this.btncalcular);
            this.panelCentral.Controls.Add(this.comboCostEnvio);
            this.panelCentral.Controls.Add(this.comboImpuesto);
            this.panelCentral.Controls.Add(this.label11);
            this.panelCentral.Controls.Add(this.label10);
            this.panelCentral.Controls.Add(this.comboCiudadDestino);
            this.panelCentral.Controls.Add(this.comboCiudadOrigen);
            this.panelCentral.Controls.Add(this.comboPago);
            this.panelCentral.Controls.Add(this.comboEnvio);
            this.panelCentral.Controls.Add(this.comboPaisDestino);
            this.panelCentral.Controls.Add(this.comboPaisOrigen);
            this.panelCentral.Controls.Add(this.txtTotal);
            this.panelCentral.Controls.Add(this.txtDescripcion);
            this.panelCentral.Controls.Add(this.txtIdEstado);
            this.panelCentral.Controls.Add(this.txtIdUsuario);
            this.panelCentral.Controls.Add(this.label9);
            this.panelCentral.Controls.Add(this.label8);
            this.panelCentral.Controls.Add(this.label7);
            this.panelCentral.Controls.Add(this.label5);
            this.panelCentral.Controls.Add(this.label4);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Controls.Add(this.txtIdPedido);
            this.panelCentral.Controls.Add(this.label6);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 35);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(520, 320);
            this.panelCentral.TabIndex = 9;
            // 
            // btncalcular
            // 
            this.btncalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalcular.Image = ((System.Drawing.Image)(resources.GetObject("btncalcular.Image")));
            this.btncalcular.Location = new System.Drawing.Point(427, 227);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(67, 30);
            this.btncalcular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncalcular.TabIndex = 79;
            this.btncalcular.TabStop = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // comboCostEnvio
            // 
            this.comboCostEnvio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCostEnvio.Enabled = false;
            this.comboCostEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCostEnvio.FormattingEnabled = true;
            this.comboCostEnvio.Location = new System.Drawing.Point(404, 192);
            this.comboCostEnvio.Name = "comboCostEnvio";
            this.comboCostEnvio.Size = new System.Drawing.Size(90, 26);
            this.comboCostEnvio.TabIndex = 77;
            // 
            // comboImpuesto
            // 
            this.comboImpuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboImpuesto.Enabled = false;
            this.comboImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboImpuesto.FormattingEnabled = true;
            this.comboImpuesto.Location = new System.Drawing.Point(203, 192);
            this.comboImpuesto.Name = "comboImpuesto";
            this.comboImpuesto.Size = new System.Drawing.Size(90, 26);
            this.comboImpuesto.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(309, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 75;
            this.label11.Text = "Cost Envio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(108, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 74;
            this.label10.Text = "Impuesto";
            // 
            // comboCiudadDestino
            // 
            this.comboCiudadDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCiudadDestino.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCiudadDestino.FormattingEnabled = true;
            this.comboCiudadDestino.Items.AddRange(new object[] {
            "Alabama (AL)"});
            this.comboCiudadDestino.Location = new System.Drawing.Point(313, 72);
            this.comboCiudadDestino.Name = "comboCiudadDestino";
            this.comboCiudadDestino.Size = new System.Drawing.Size(181, 27);
            this.comboCiudadDestino.TabIndex = 71;
            // 
            // comboCiudadOrigen
            // 
            this.comboCiudadOrigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCiudadOrigen.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCiudadOrigen.FormattingEnabled = true;
            this.comboCiudadOrigen.Items.AddRange(new object[] {
            "Alabama (AL)"});
            this.comboCiudadOrigen.Location = new System.Drawing.Point(313, 39);
            this.comboCiudadOrigen.Name = "comboCiudadOrigen";
            this.comboCiudadOrigen.Size = new System.Drawing.Size(181, 27);
            this.comboCiudadOrigen.TabIndex = 70;
            // 
            // comboPago
            // 
            this.comboPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPago.FormattingEnabled = true;
            this.comboPago.Items.AddRange(new object[] {
            "TERRESTRE",
            "MARITIMO",
            "AEREO"});
            this.comboPago.Location = new System.Drawing.Point(112, 122);
            this.comboPago.Name = "comboPago";
            this.comboPago.Size = new System.Drawing.Size(181, 27);
            this.comboPago.TabIndex = 69;
            // 
            // comboEnvio
            // 
            this.comboEnvio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboEnvio.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEnvio.FormattingEnabled = true;
            this.comboEnvio.Items.AddRange(new object[] {
            "TARJETA CREDITO",
            "TARJETA DEBITO",
            "EFECTIVO"});
            this.comboEnvio.Location = new System.Drawing.Point(313, 122);
            this.comboEnvio.Name = "comboEnvio";
            this.comboEnvio.Size = new System.Drawing.Size(181, 27);
            this.comboEnvio.TabIndex = 67;
            // 
            // comboPaisDestino
            // 
            this.comboPaisDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPaisDestino.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPaisDestino.FormattingEnabled = true;
            this.comboPaisDestino.Items.AddRange(new object[] {
            "Alabama (AL)"});
            this.comboPaisDestino.Location = new System.Drawing.Point(112, 72);
            this.comboPaisDestino.Name = "comboPaisDestino";
            this.comboPaisDestino.Size = new System.Drawing.Size(181, 27);
            this.comboPaisDestino.TabIndex = 65;
            // 
            // comboPaisOrigen
            // 
            this.comboPaisOrigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPaisOrigen.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPaisOrigen.FormattingEnabled = true;
            this.comboPaisOrigen.Items.AddRange(new object[] {
            "Alabama (AL)"});
            this.comboPaisOrigen.Location = new System.Drawing.Point(112, 39);
            this.comboPaisOrigen.Name = "comboPaisOrigen";
            this.comboPaisOrigen.Size = new System.Drawing.Size(181, 27);
            this.comboPaisOrigen.TabIndex = 64;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(313, 227);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(90, 27);
            this.txtTotal.TabIndex = 63;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(112, 156);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(382, 27);
            this.txtDescripcion.TabIndex = 59;
            // 
            // txtIdEstado
            // 
            this.txtIdEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEstado.Location = new System.Drawing.Point(191, 272);
            this.txtIdEstado.Name = "txtIdEstado";
            this.txtIdEstado.ReadOnly = true;
            this.txtIdEstado.Size = new System.Drawing.Size(303, 27);
            this.txtIdEstado.TabIndex = 58;
            this.txtIdEstado.Text = "PROCESANDO";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(112, 6);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(137, 27);
            this.txtIdUsuario.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(2, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "Desc Pedido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(7, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "Id Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(8, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 53;
            this.label7.Text = "Origen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(8, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(323, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tipo Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(108, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "tipo Envio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(7, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Estado del pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(255, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Total:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPedido.Location = new System.Drawing.Point(112, 224);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.ReadOnly = true;
            this.txtIdPedido.Size = new System.Drawing.Size(137, 27);
            this.txtIdPedido.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(7, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Pedido  #:";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BarraTitulo.Controls.Add(this.icono);
            this.BarraTitulo.Controls.Add(this.btnGuardar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(520, 35);
            this.BarraTitulo.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(483, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(25, 25);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Cliente_DoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 355);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente_DoPedido";
            this.Text = "Usuario_DoPedido";
            this.Load += new System.EventHandler(this.Cliente_DoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncalcular)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdEstado;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboEnvio;
        private System.Windows.Forms.ComboBox comboPaisDestino;
        private System.Windows.Forms.ComboBox comboPaisOrigen;
        private System.Windows.Forms.ComboBox comboPago;
        private System.Windows.Forms.ComboBox comboCiudadDestino;
        private System.Windows.Forms.ComboBox comboCiudadOrigen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboImpuesto;
        private System.Windows.Forms.ComboBox comboCostEnvio;
        private System.Windows.Forms.PictureBox btncalcular;
    }
}