namespace CAPManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AbrirBiblioteca = new System.Windows.Forms.Button();
            this.AbrirPacientes = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.CrearExpediente = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.AbrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarSesionComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrasOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextoDia = new System.Windows.Forms.TextBox();
            this.TextoCuatrimestre = new System.Windows.Forms.TextBox();
            this.TextoAsunto = new System.Windows.Forms.TextBox();
            this.TextoTipo = new System.Windows.Forms.TextBox();
            this.TextoFecha = new System.Windows.Forms.TextBox();
            this.Quitar = new System.Windows.Forms.Button();
            this.DGVAgenda = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guardar1 = new System.Windows.Forms.SaveFileDialog();
            this.Abrir = new System.Windows.Forms.OpenFileDialog();
            this.MenuStrip.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // AbrirBiblioteca
            // 
            this.AbrirBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirBiblioteca.Location = new System.Drawing.Point(442, 550);
            this.AbrirBiblioteca.Name = "AbrirBiblioteca";
            this.AbrirBiblioteca.Size = new System.Drawing.Size(187, 35);
            this.AbrirBiblioteca.TabIndex = 0;
            this.AbrirBiblioteca.Text = "Abrir biblioteca";
            this.AbrirBiblioteca.UseVisualStyleBackColor = true;
            this.AbrirBiblioteca.Click += new System.EventHandler(this.AbrirBiblioteca_Click);
            // 
            // AbrirPacientes
            // 
            this.AbrirPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirPacientes.Location = new System.Drawing.Point(635, 550);
            this.AbrirPacientes.Name = "AbrirPacientes";
            this.AbrirPacientes.Size = new System.Drawing.Size(208, 35);
            this.AbrirPacientes.TabIndex = 1;
            this.AbrirPacientes.Text = "Abrir por pacientes";
            this.AbrirPacientes.UseVisualStyleBackColor = true;
            this.AbrirPacientes.Click += new System.EventHandler(this.AbrirPacientes_Click);
            // 
            // Agregar
            // 
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(1018, 384);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(212, 35);
            this.Agregar.TabIndex = 7;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // CrearExpediente
            // 
            this.CrearExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearExpediente.Location = new System.Drawing.Point(203, 550);
            this.CrearExpediente.Name = "CrearExpediente";
            this.CrearExpediente.Size = new System.Drawing.Size(233, 35);
            this.CrearExpediente.TabIndex = 8;
            this.CrearExpediente.Text = "Crear expediente";
            this.CrearExpediente.UseVisualStyleBackColor = true;
            this.CrearExpediente.Click += new System.EventHandler(this.CrearExpediente_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirToolStripMenuItem,
            this.otrasOpcionesToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1465, 28);
            this.MenuStrip.TabIndex = 9;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // AbrirToolStripMenuItem
            // 
            this.AbrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirSesionToolStripMenuItem,
            this.GuardarSesionToolStripMenuItem,
            this.GuardarSesionComoToolStripMenuItem});
            this.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem";
            this.AbrirToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.AbrirToolStripMenuItem.Text = "Abrir";
            // 
            // AbrirSesionToolStripMenuItem
            // 
            this.AbrirSesionToolStripMenuItem.Name = "AbrirSesionToolStripMenuItem";
            this.AbrirSesionToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.AbrirSesionToolStripMenuItem.Text = "Abrir sesion";
            this.AbrirSesionToolStripMenuItem.Click += new System.EventHandler(this.AbrirSesionToolStripMenuItem_Click);
            // 
            // GuardarSesionToolStripMenuItem
            // 
            this.GuardarSesionToolStripMenuItem.Name = "GuardarSesionToolStripMenuItem";
            this.GuardarSesionToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.GuardarSesionToolStripMenuItem.Text = "Guardar sesion";
            this.GuardarSesionToolStripMenuItem.Click += new System.EventHandler(this.GuardarSesionToolStripMenuItem_Click);
            // 
            // GuardarSesionComoToolStripMenuItem
            // 
            this.GuardarSesionComoToolStripMenuItem.Name = "GuardarSesionComoToolStripMenuItem";
            this.GuardarSesionComoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.GuardarSesionComoToolStripMenuItem.Text = "Guardar sesion como....";
            this.GuardarSesionComoToolStripMenuItem.Click += new System.EventHandler(this.GuardarSesionComoToolStripMenuItem_Click);
            // 
            // otrasOpcionesToolStripMenuItem
            // 
            this.otrasOpcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaDeToolStripMenuItem});
            this.otrasOpcionesToolStripMenuItem.Name = "otrasOpcionesToolStripMenuItem";
            this.otrasOpcionesToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.otrasOpcionesToolStripMenuItem.Text = "Otras opciones";
            // 
            // AcercaDeToolStripMenuItem
            // 
            this.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem";
            this.AcercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.AcercaDeToolStripMenuItem.Text = "Acerca de";
            this.AcercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.TextoDia);
            this.Panel1.Controls.Add(this.TextoCuatrimestre);
            this.Panel1.Controls.Add(this.TextoAsunto);
            this.Panel1.Controls.Add(this.TextoTipo);
            this.Panel1.Controls.Add(this.TextoFecha);
            this.Panel1.Controls.Add(this.Quitar);
            this.Panel1.Controls.Add(this.DGVAgenda);
            this.Panel1.Controls.Add(this.Agregar);
            this.Panel1.Controls.Add(this.AbrirPacientes);
            this.Panel1.Controls.Add(this.CrearExpediente);
            this.Panel1.Controls.Add(this.AbrirBiblioteca);
            this.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(0, 32);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1467, 594);
            this.Panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1095, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1013, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cuatrimestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1062, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Asunto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1085, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1069, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha";
            // 
            // TextoDia
            // 
            this.TextoDia.Location = new System.Drawing.Point(1154, 327);
            this.TextoDia.Name = "TextoDia";
            this.TextoDia.Size = new System.Drawing.Size(297, 30);
            this.TextoDia.TabIndex = 17;
            // 
            // TextoCuatrimestre
            // 
            this.TextoCuatrimestre.Location = new System.Drawing.Point(1154, 291);
            this.TextoCuatrimestre.Name = "TextoCuatrimestre";
            this.TextoCuatrimestre.Size = new System.Drawing.Size(297, 30);
            this.TextoCuatrimestre.TabIndex = 16;
            // 
            // TextoAsunto
            // 
            this.TextoAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoAsunto.Location = new System.Drawing.Point(1154, 255);
            this.TextoAsunto.Name = "TextoAsunto";
            this.TextoAsunto.Size = new System.Drawing.Size(297, 30);
            this.TextoAsunto.TabIndex = 15;
            // 
            // TextoTipo
            // 
            this.TextoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoTipo.Location = new System.Drawing.Point(1154, 219);
            this.TextoTipo.Name = "TextoTipo";
            this.TextoTipo.Size = new System.Drawing.Size(297, 30);
            this.TextoTipo.TabIndex = 14;
            // 
            // TextoFecha
            // 
            this.TextoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoFecha.Location = new System.Drawing.Point(1154, 180);
            this.TextoFecha.Name = "TextoFecha";
            this.TextoFecha.Size = new System.Drawing.Size(297, 30);
            this.TextoFecha.TabIndex = 13;
            // 
            // Quitar
            // 
            this.Quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitar.Location = new System.Drawing.Point(1239, 384);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(212, 35);
            this.Quitar.TabIndex = 12;
            this.Quitar.Text = "Quitar";
            this.Quitar.UseVisualStyleBackColor = true;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // DGVAgenda
            // 
            this.DGVAgenda.CausesValidation = false;
            this.DGVAgenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGVAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Tipo,
            this.Asunto,
            this.Cuatrimestre,
            this.Dia});
            this.DGVAgenda.Location = new System.Drawing.Point(12, 0);
            this.DGVAgenda.Name = "DGVAgenda";
            this.DGVAgenda.ReadOnly = true;
            this.DGVAgenda.RowHeadersWidth = 51;
            this.DGVAgenda.RowTemplate.Height = 24;
            this.DGVAgenda.Size = new System.Drawing.Size(981, 540);
            this.DGVAgenda.TabIndex = 11;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MaxInputLength = 30000;
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 120;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 8;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 125;
            // 
            // Asunto
            // 
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.MinimumWidth = 8;
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            this.Asunto.Width = 200;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Cuatrimestre.MinimumWidth = 6;
            this.Cuatrimestre.Name = "Cuatrimestre";
            this.Cuatrimestre.ReadOnly = true;
            this.Cuatrimestre.Width = 120;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            this.Dia.Width = 125;
            // 
            // Guardar1
            // 
            this.Guardar1.CheckFileExists = true;
            this.Guardar1.FileName = ".txt";
            this.Guardar1.InitialDirectory = "C:\\Users\\defaultuser0\\source\\repos\\CAPManager\\CAPManager\\bin\\Debug\\Sesiones";
            this.Guardar1.OverwritePrompt = false;
            this.Guardar1.Tag = "";
            // 
            // Abrir
            // 
            this.Abrir.InitialDirectory = "C:\\Users\\defaultuser0\\source\\repos\\CAPManager\\CAPManager\\bin\\Debug\\Sesiones";
            this.Abrir.Tag = "Archivos TXT (*txt)|*txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 625);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPManager";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbrirBiblioteca;
        private System.Windows.Forms.Button AbrirPacientes;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button CrearExpediente;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AbrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrasOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AcercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarSesionComoToolStripMenuItem;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DataGridView DGVAgenda;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.TextBox TextoTipo;
        private System.Windows.Forms.TextBox TextoFecha;
        private System.Windows.Forms.TextBox TextoDia;
        private System.Windows.Forms.TextBox TextoCuatrimestre;
        private System.Windows.Forms.TextBox TextoAsunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog Guardar1;
        private System.Windows.Forms.OpenFileDialog Abrir;
    }
}