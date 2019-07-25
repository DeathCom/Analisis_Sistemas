namespace _01Presentacion
{
    partial class Usuario_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Inicio));
            this.panelCentral = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.icono = new System.Windows.Forms.PictureBox();
            this.Numero_Tiquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Severidad_Tiquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Tiquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios_Tiquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorayFecha_Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorayFecha_Cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(42)))));
            this.panelCentral.Controls.Add(this.dataGridView1);
            this.panelCentral.Controls.Add(this.lblTipoUsuario);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 35);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(520, 320);
            this.panelCentral.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Tiquete,
            this.Nombre_Supervisor,
            this.Nombre_Usuario,
            this.Nombre_Cliente,
            this.Nombre_Aplicacion,
            this.Severidad_Tiquete,
            this.Estado_Tiquete,
            this.Comentarios_Tiquete,
            this.HorayFecha_Apertura,
            this.HorayFecha_Cierre});
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTipoUsuario.Location = new System.Drawing.Point(12, 287);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(66, 24);
            this.lblTipoUsuario.TabIndex = 0;
            this.lblTipoUsuario.Text = "label1";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BarraTitulo.Controls.Add(this.icono);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(520, 35);
            this.BarraTitulo.TabIndex = 7;
            // 
            // icono
            // 
            this.icono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icono.Image = ((System.Drawing.Image)(resources.GetObject("icono.Image")));
            this.icono.Location = new System.Drawing.Point(483, 4);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(25, 25);
            this.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono.TabIndex = 0;
            this.icono.TabStop = false;
            // 
            // Numero_Tiquete
            // 
            this.Numero_Tiquete.HeaderText = "Numero_Tiquete";
            this.Numero_Tiquete.Name = "Numero_Tiquete";
            // 
            // Nombre_Supervisor
            // 
            this.Nombre_Supervisor.HeaderText = "Nombre_Supervisor";
            this.Nombre_Supervisor.Name = "Nombre_Supervisor";
            // 
            // Nombre_Usuario
            // 
            this.Nombre_Usuario.HeaderText = "Nombre_Usuario";
            this.Nombre_Usuario.Name = "Nombre_Usuario";
            // 
            // Nombre_Cliente
            // 
            this.Nombre_Cliente.HeaderText = "Nombre_Cliente";
            this.Nombre_Cliente.Name = "Nombre_Cliente";
            // 
            // Nombre_Aplicacion
            // 
            this.Nombre_Aplicacion.HeaderText = "Nombre_Aplicacion";
            this.Nombre_Aplicacion.Name = "Nombre_Aplicacion";
            // 
            // Severidad_Tiquete
            // 
            this.Severidad_Tiquete.HeaderText = "Severidad_Tiquete";
            this.Severidad_Tiquete.Name = "Severidad_Tiquete";
            // 
            // Estado_Tiquete
            // 
            this.Estado_Tiquete.HeaderText = "Estado_Tiquete ";
            this.Estado_Tiquete.Name = "Estado_Tiquete";
            // 
            // Comentarios_Tiquete
            // 
            this.Comentarios_Tiquete.HeaderText = "Comentarios_Tiquete";
            this.Comentarios_Tiquete.Name = "Comentarios_Tiquete";
            // 
            // HorayFecha_Apertura
            // 
            this.HorayFecha_Apertura.HeaderText = "HorayFecha_Apertura";
            this.HorayFecha_Apertura.Name = "HorayFecha_Apertura";
            // 
            // HorayFecha_Cierre
            // 
            this.HorayFecha_Cierre.HeaderText = "HorayFecha_Cierre";
            this.HorayFecha_Cierre.Name = "HorayFecha_Cierre";
            // 
            // Usuario_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 355);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuario_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario_Inicio";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Tiquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Supervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Aplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Severidad_Tiquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Tiquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios_Tiquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorayFecha_Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorayFecha_Cierre;
    }
}