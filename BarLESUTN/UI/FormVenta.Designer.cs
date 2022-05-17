namespace UI
{
    partial class FormVenta
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
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.chkEstacionamiento = new System.Windows.Forms.CheckBox();
            this.cmbMedioDePago = new System.Windows.Forms.ComboBox();
            this.lblMedioDePago = new System.Windows.Forms.Label();
            this.dtgvPedido = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarComida = new System.Windows.Forms.Button();
            this.btnAgregarBebida = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnAsignarCliente = new System.Windows.Forms.Button();
            this.btnModificarCantidad = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlDatosCiente = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedido)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlDatosCiente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumeroMesa.Enabled = false;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroMesa.Location = new System.Drawing.Point(0, 550);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(200, 50);
            this.lblNumeroMesa.TabIndex = 0;
            this.lblNumeroMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkEstacionamiento
            // 
            this.chkEstacionamiento.AutoSize = true;
            this.chkEstacionamiento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkEstacionamiento.ForeColor = System.Drawing.Color.White;
            this.chkEstacionamiento.Location = new System.Drawing.Point(73, 39);
            this.chkEstacionamiento.Name = "chkEstacionamiento";
            this.chkEstacionamiento.Size = new System.Drawing.Size(173, 23);
            this.chkEstacionamiento.TabIndex = 1;
            this.chkEstacionamiento.Text = "Con Estacionamiento";
            this.chkEstacionamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEstacionamiento.UseVisualStyleBackColor = true;
            this.chkEstacionamiento.CheckedChanged += new System.EventHandler(this.chkEstacionamiento_CheckedChanged);
            // 
            // cmbMedioDePago
            // 
            this.cmbMedioDePago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioDePago.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMedioDePago.FormattingEnabled = true;
            this.cmbMedioDePago.Location = new System.Drawing.Point(382, 39);
            this.cmbMedioDePago.Name = "cmbMedioDePago";
            this.cmbMedioDePago.Size = new System.Drawing.Size(173, 27);
            this.cmbMedioDePago.TabIndex = 2;
            this.cmbMedioDePago.SelectedValueChanged += new System.EventHandler(this.cmbMedioDePago_SelectedValueChanged);
            // 
            // lblMedioDePago
            // 
            this.lblMedioDePago.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedioDePago.Location = new System.Drawing.Point(382, 11);
            this.lblMedioDePago.Name = "lblMedioDePago";
            this.lblMedioDePago.Size = new System.Drawing.Size(173, 23);
            this.lblMedioDePago.TabIndex = 3;
            this.lblMedioDePago.Text = "Medio De Pago";
            this.lblMedioDePago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dtgvPedido
            // 
            this.dtgvPedido.AllowUserToAddRows = false;
            this.dtgvPedido.AllowUserToDeleteRows = false;
            this.dtgvPedido.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.descripcion,
            this.formato,
            this.precio,
            this.cantidad});
            this.dtgvPedido.Location = new System.Drawing.Point(18, 98);
            this.dtgvPedido.Name = "dtgvPedido";
            this.dtgvPedido.RowHeadersWidth = 51;
            this.dtgvPedido.RowTemplate.Height = 25;
            this.dtgvPedido.Size = new System.Drawing.Size(620, 385);
            this.dtgvPedido.TabIndex = 4;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 75;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // formato
            // 
            this.formato.HeaderText = "Formato";
            this.formato.Name = "formato";
            this.formato.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 75;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 75;
            // 
            // btnAgregarComida
            // 
            this.btnAgregarComida.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarComida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarComida.FlatAppearance.BorderSize = 0;
            this.btnAgregarComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarComida.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarComida.Location = new System.Drawing.Point(0, 75);
            this.btnAgregarComida.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarComida.Name = "btnAgregarComida";
            this.btnAgregarComida.Size = new System.Drawing.Size(200, 60);
            this.btnAgregarComida.TabIndex = 0;
            this.btnAgregarComida.Text = "Agregar Comida";
            this.btnAgregarComida.UseVisualStyleBackColor = false;
            this.btnAgregarComida.Click += new System.EventHandler(this.btnAgregarComida_Click);
            // 
            // btnAgregarBebida
            // 
            this.btnAgregarBebida.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarBebida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarBebida.FlatAppearance.BorderSize = 0;
            this.btnAgregarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarBebida.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarBebida.Location = new System.Drawing.Point(0, 135);
            this.btnAgregarBebida.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarBebida.Name = "btnAgregarBebida";
            this.btnAgregarBebida.Size = new System.Drawing.Size(200, 60);
            this.btnAgregarBebida.TabIndex = 1;
            this.btnAgregarBebida.Text = "Agregar Bebida";
            this.btnAgregarBebida.UseVisualStyleBackColor = false;
            this.btnAgregarBebida.Click += new System.EventHandler(this.btnAgregarBebida_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.Location = new System.Drawing.Point(0, 375);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(0);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(200, 60);
            this.btnContinuar.TabIndex = 5;
            this.btnContinuar.Text = "Continuar Sin Cerrar Mesa";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuitarProducto.FlatAppearance.BorderSize = 0;
            this.btnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProducto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitarProducto.Location = new System.Drawing.Point(0, 195);
            this.btnQuitarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(200, 60);
            this.btnQuitarProducto.TabIndex = 2;
            this.btnQuitarProducto.Text = "Quitar Producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = false;
            // 
            // btnCerrarMesa
            // 
            this.btnCerrarMesa.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarMesa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarMesa.FlatAppearance.BorderSize = 0;
            this.btnCerrarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarMesa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarMesa.Location = new System.Drawing.Point(0, 435);
            this.btnCerrarMesa.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(200, 60);
            this.btnCerrarMesa.TabIndex = 6;
            this.btnCerrarMesa.Text = "Cerrar Mesa";
            this.btnCerrarMesa.UseVisualStyleBackColor = false;
            this.btnCerrarMesa.Click += new System.EventHandler(this.btnCerrarMesa_Click);
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCostoTotal.ForeColor = System.Drawing.Color.White;
            this.lblCostoTotal.Location = new System.Drawing.Point(349, 506);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(90, 19);
            this.lblCostoTotal.TabIndex = 12;
            this.lblCostoTotal.Text = "Costo Total:";
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlOpciones.Controls.Add(this.btnCerrarMesa);
            this.pnlOpciones.Controls.Add(this.btnContinuar);
            this.pnlOpciones.Controls.Add(this.btnAsignarCliente);
            this.pnlOpciones.Controls.Add(this.btnModificarCantidad);
            this.pnlOpciones.Controls.Add(this.btnQuitarProducto);
            this.pnlOpciones.Controls.Add(this.btnAgregarBebida);
            this.pnlOpciones.Controls.Add(this.btnAgregarComida);
            this.pnlOpciones.Controls.Add(this.pctLogo);
            this.pnlOpciones.Controls.Add(this.lblNumeroMesa);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(200, 600);
            this.pnlOpciones.TabIndex = 13;
            // 
            // btnAsignarCliente
            // 
            this.btnAsignarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignarCliente.FlatAppearance.BorderSize = 0;
            this.btnAsignarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarCliente.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsignarCliente.Location = new System.Drawing.Point(0, 315);
            this.btnAsignarCliente.Name = "btnAsignarCliente";
            this.btnAsignarCliente.Size = new System.Drawing.Size(200, 60);
            this.btnAsignarCliente.TabIndex = 4;
            this.btnAsignarCliente.Text = "Asignar Cliente";
            this.btnAsignarCliente.UseVisualStyleBackColor = false;
            this.btnAsignarCliente.Click += new System.EventHandler(this.btnAsignarCliente_Click);
            // 
            // btnModificarCantidad
            // 
            this.btnModificarCantidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarCantidad.FlatAppearance.BorderSize = 0;
            this.btnModificarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCantidad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarCantidad.Location = new System.Drawing.Point(0, 255);
            this.btnModificarCantidad.Name = "btnModificarCantidad";
            this.btnModificarCantidad.Size = new System.Drawing.Size(200, 60);
            this.btnModificarCantidad.TabIndex = 3;
            this.btnModificarCantidad.Text = "Modificar Cantidad de Producto";
            this.btnModificarCantidad.UseVisualStyleBackColor = true;
            // 
            // pctLogo
            // 
            this.pctLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctLogo.Image = global::UI.Properties.Resources.logo_utn;
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(200, 75);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 6;
            this.pctLogo.TabStop = false;
            // 
            // pnlDatosCiente
            // 
            this.pnlDatosCiente.Controls.Add(this.chkEstacionamiento);
            this.pnlDatosCiente.Controls.Add(this.cmbMedioDePago);
            this.pnlDatosCiente.Controls.Add(this.dtgvPedido);
            this.pnlDatosCiente.Controls.Add(this.lblMedioDePago);
            this.pnlDatosCiente.Controls.Add(this.lblCostoTotal);
            this.pnlDatosCiente.Location = new System.Drawing.Point(215, 12);
            this.pnlDatosCiente.Name = "pnlDatosCiente";
            this.pnlDatosCiente.Size = new System.Drawing.Size(641, 545);
            this.pnlDatosCiente.TabIndex = 14;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(868, 600);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlDatosCiente);
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVenta_FormClosing);
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedido)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlDatosCiente.ResumeLayout(false);
            this.pnlDatosCiente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroMesa;
        private System.Windows.Forms.CheckBox chkEstacionamiento;
        private System.Windows.Forms.ComboBox cmbMedioDePago;
        private System.Windows.Forms.Label lblMedioDePago;
        private System.Windows.Forms.DataGridView dtgvPedido;
        private System.Windows.Forms.Button btnAgregarComida;
        private System.Windows.Forms.Button btnAgregarBebida;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnCerrarMesa;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel pnlDatosCiente;
        private System.Windows.Forms.Button btnAsignarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button btnModificarCantidad;
    }
}