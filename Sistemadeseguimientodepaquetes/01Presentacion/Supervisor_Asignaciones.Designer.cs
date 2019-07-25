namespace _01Presentacion
{
    partial class Supervisor_Asignaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor_Asignaciones));
            this.icono = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumTiquete = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.comboSeveridad = new System.Windows.Forms.ComboBox();
            this.comboEstadoTiquete = new System.Windows.Forms.ComboBox();
            this.comboAplicaciones = new System.Windows.Forms.ComboBox();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
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
            this.panelCentral.Controls.Add(this.dataGridView1);
            this.panelCentral.Controls.Add(this.txtSupervisor);
            this.panelCentral.Controls.Add(this.txtComentario);
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Controls.Add(this.txtNumTiquete);
            this.panelCentral.Controls.Add(this.label12);
            this.panelCentral.Controls.Add(this.comboUsuarios);
            this.panelCentral.Controls.Add(this.comboSeveridad);
            this.panelCentral.Controls.Add(this.comboEstadoTiquete);
            this.panelCentral.Controls.Add(this.comboAplicaciones);
            this.panelCentral.Controls.Add(this.comboClientes);
            this.panelCentral.Controls.Add(this.label9);
            this.panelCentral.Controls.Add(this.label8);
            this.panelCentral.Controls.Add(this.label7);
            this.panelCentral.Controls.Add(this.label5);
            this.panelCentral.Controls.Add(this.label4);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 35);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(520, 320);
            this.panelCentral.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 122);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSupervisor.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupervisor.Location = new System.Drawing.Point(105, 43);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(201, 27);
            this.txtSupervisor.TabIndex = 88;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(316, 96);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(192, 75);
            this.txtComentario.TabIndex = 87;
            this.txtComentario.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tiquete:";
            // 
            // txtNumTiquete
            // 
            this.txtNumTiquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumTiquete.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTiquete.Location = new System.Drawing.Point(105, 7);
            this.txtNumTiquete.Name = "txtNumTiquete";
            this.txtNumTiquete.Size = new System.Drawing.Size(150, 27);
            this.txtNumTiquete.TabIndex = 84;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(12, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 80;
            this.label12.Text = "Usuario:";
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboUsuarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(105, 76);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(201, 28);
            this.comboUsuarios.TabIndex = 71;
            // 
            // comboSeveridad
            // 
            this.comboSeveridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboSeveridad.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSeveridad.FormattingEnabled = true;
            this.comboSeveridad.Location = new System.Drawing.Point(376, 8);
            this.comboSeveridad.Name = "comboSeveridad";
            this.comboSeveridad.Size = new System.Drawing.Size(135, 28);
            this.comboSeveridad.TabIndex = 69;
            // 
            // comboEstadoTiquete
            // 
            this.comboEstadoTiquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboEstadoTiquete.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstadoTiquete.FormattingEnabled = true;
            this.comboEstadoTiquete.Location = new System.Drawing.Point(376, 42);
            this.comboEstadoTiquete.Name = "comboEstadoTiquete";
            this.comboEstadoTiquete.Size = new System.Drawing.Size(132, 28);
            this.comboEstadoTiquete.TabIndex = 67;
            // 
            // comboAplicaciones
            // 
            this.comboAplicaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAplicaciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAplicaciones.FormattingEnabled = true;
            this.comboAplicaciones.Location = new System.Drawing.Point(105, 145);
            this.comboAplicaciones.Name = "comboAplicaciones";
            this.comboAplicaciones.Size = new System.Drawing.Size(201, 28);
            this.comboAplicaciones.TabIndex = 65;
            // 
            // comboClientes
            // 
            this.comboClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(105, 111);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(201, 28);
            this.comboClientes.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(312, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Comentarios:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(12, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Supervisor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(13, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(13, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Apliación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(312, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(312, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Sev:";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BarraTitulo.Controls.Add(this.btnBuscar);
            this.BarraTitulo.Controls.Add(this.icono);
            this.BarraTitulo.Controls.Add(this.btnEditar);
            this.BarraTitulo.Controls.Add(this.btnGuardar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(520, 35);
            this.BarraTitulo.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(421, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 25);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 103;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(452, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(25, 25);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 102;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // Supervisor_Asignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 355);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supervisor_Asignaciones";
            this.Text = "Usuario_DoPedido";
            this.Load += new System.EventHandler(this.Cliente_DoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboEstadoTiquete;
        private System.Windows.Forms.ComboBox comboAplicaciones;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.ComboBox comboSeveridad;
        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumTiquete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.PictureBox btnEditar;
    }
}