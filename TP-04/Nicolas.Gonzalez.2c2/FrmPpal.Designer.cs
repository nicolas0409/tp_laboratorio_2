namespace Nicolas.Gonzalez._2c2
{
    partial class FrmPpal
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
            this.components = new System.ComponentModel.Container();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtTrakingID = new System.Windows.Forms.MaskedTextBox();
            this.lblTrakngID = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.rtxbox = new System.Windows.Forms.RichTextBox();
            this.cmsListas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(28, 45);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(185, 147);
            this.lstEstadoIngresado.TabIndex = 0;
            // 
            // cmsListas
            // 
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.cmsListas.Name = "contextMenuStrip1";
            this.cmsListas.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(254, 45);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(185, 147);
            this.lstEstadoEnViaje.TabIndex = 1;
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.ContextMenuStrip = this.cmsListas;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(463, 45);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(185, 147);
            this.lstEstadoEntregado.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(126, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 36);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(126, 65);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(100, 38);
            this.btnMostrarTodos.TabIndex = 4;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(25, 16);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblEstadoIngresado.TabIndex = 5;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(251, 16);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoEnViaje.TabIndex = 6;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(466, 16);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEstadoEntregado.TabIndex = 7;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstEstadoIngresado);
            this.groupBox1.Controls.Add(this.lblEstadoEntregado);
            this.groupBox1.Controls.Add(this.lstEstadoEnViaje);
            this.groupBox1.Controls.Add(this.lblEstadoEnViaje);
            this.groupBox1.Controls.Add(this.lstEstadoEntregado);
            this.groupBox1.Controls.Add(this.lblEstadoIngresado);
            this.groupBox1.Location = new System.Drawing.Point(50, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 203);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Paquetes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(20, 75);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtxtTrakingID);
            this.groupBox2.Controls.Add(this.lblTrakngID);
            this.groupBox2.Controls.Add(this.lblDireccion);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.btnMostrarTodos);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(472, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 118);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paqete";
            // 
            // mtxtTrakingID
            // 
            this.mtxtTrakingID.Location = new System.Drawing.Point(20, 32);
            this.mtxtTrakingID.Mask = "000-000-0000";
            this.mtxtTrakingID.Name = "mtxtTrakingID";
            this.mtxtTrakingID.Size = new System.Drawing.Size(100, 20);
            this.mtxtTrakingID.TabIndex = 11;
            // 
            // lblTrakngID
            // 
            this.lblTrakngID.AutoSize = true;
            this.lblTrakngID.Location = new System.Drawing.Point(17, 16);
            this.lblTrakngID.Name = "lblTrakngID";
            this.lblTrakngID.Size = new System.Drawing.Size(66, 13);
            this.lblTrakngID.TabIndex = 8;
            this.lblTrakngID.Text = "Tracking  ID";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 55);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección";
            // 
            // rtxbox
            // 
            this.rtxbox.Location = new System.Drawing.Point(50, 277);
            this.rtxbox.Name = "rtxbox";
            this.rtxbox.Size = new System.Drawing.Size(393, 96);
            this.rtxbox.TabIndex = 12;
            this.rtxbox.Text = "";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Nicolas.Gonzalez.2c";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.cmsListas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxbox;
        private System.Windows.Forms.Label lblTrakngID;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.MaskedTextBox mtxtTrakingID;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

