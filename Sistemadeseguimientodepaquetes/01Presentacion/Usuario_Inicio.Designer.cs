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
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.icono = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Tiquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Tiquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_de_Asignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_de_Cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Herramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCentral.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Numero_Tiquete,
            this.Cliente,
            this.Estado_Tiquete,
            this.Hora_de_Asignacion,
            this.Hora_de_Cierre,
            this.Herramienta,
            this.Comentarios});
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Numero_Tiquete
            // 
            this.Numero_Tiquete.HeaderText = "Numero_Tiquete";
            this.Numero_Tiquete.Name = "Numero_Tiquete";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Estado_Tiquete
            // 
            this.Estado_Tiquete.HeaderText = "Estado_Tiquete";
            this.Estado_Tiquete.Name = "Estado_Tiquete";
            // 
            // Hora_de_Asignacion
            // 
            this.Hora_de_Asignacion.HeaderText = "Hora_de_Asignacion";
            this.Hora_de_Asignacion.Name = "Hora_de_Asignacion";
            // 
            // Hora_de_Cierre
            // 
            this.Hora_de_Cierre.HeaderText = "Hora_de_Cierre";
            this.Hora_de_Cierre.Name = "Hora_de_Cierre";
            // 
            // Herramienta
            // 
            this.Herramienta.HeaderText = "Herramienta";
            this.Herramienta.Name = "Herramienta";
            // 
            // Comentarios
            // 
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
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
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Tiquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Tiquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_de_Asignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_de_Cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Herramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
    }
}