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
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.lblEmpleadoACargo = new System.Windows.Forms.Label();
            this.btnAgregarComida = new System.Windows.Forms.Button();
            this.brnAgregarBebida = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumeroMesa.Enabled = false;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroMesa.Location = new System.Drawing.Point(0, 436);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(200, 55);
            this.lblNumeroMesa.TabIndex = 0;
            this.lblNumeroMesa.Text = "-";
            this.lblNumeroMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkEstacionamiento
            // 
            this.chkEstacionamiento.AutoSize = true;
            this.chkEstacionamiento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkEstacionamiento.Location = new System.Drawing.Point(300, 55);
            this.chkEstacionamiento.Name = "chkEstacionamiento";
            this.chkEstacionamiento.Size = new System.Drawing.Size(173, 23);
            this.chkEstacionamiento.TabIndex = 1;
            this.chkEstacionamiento.Text = "Con Estacionamiento";
            this.chkEstacionamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEstacionamiento.UseVisualStyleBackColor = true;
            // 
            // cmbMedioDePago
            // 
            this.cmbMedioDePago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioDePago.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMedioDePago.FormattingEnabled = true;
            this.cmbMedioDePago.Location = new System.Drawing.Point(538, 53);
            this.cmbMedioDePago.Name = "cmbMedioDePago";
            this.cmbMedioDePago.Size = new System.Drawing.Size(173, 27);
            this.cmbMedioDePago.TabIndex = 2;
            // 
            // lblMedioDePago
            // 
            this.lblMedioDePago.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedioDePago.Location = new System.Drawing.Point(538, 27);
            this.lblMedioDePago.Name = "lblMedioDePago";
            this.lblMedioDePago.Size = new System.Drawing.Size(173, 23);
            this.lblMedioDePago.TabIndex = 3;
            this.lblMedioDePago.Text = "Medio De Pago";
            this.lblMedioDePago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dgvPedido
            // 
            this.dgvPedido.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.descripcion,
            this.formato,
            this.precio,
            this.cantidad});
            this.dgvPedido.Location = new System.Drawing.Point(245, 109);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.RowTemplate.Height = 25;
            this.dgvPedido.Size = new System.Drawing.Size(578, 336);
            this.dgvPedido.TabIndex = 4;
            // 
            // lblEmpleadoACargo
            // 
            this.lblEmpleadoACargo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEmpleadoACargo.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleadoACargo.Location = new System.Drawing.Point(0, 491);
            this.lblEmpleadoACargo.Name = "lblEmpleadoACargo";
            this.lblEmpleadoACargo.Size = new System.Drawing.Size(200, 51);
            this.lblEmpleadoACargo.TabIndex = 5;
            this.lblEmpleadoACargo.Text = "-";
            this.lblEmpleadoACargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAgregarComida.TabIndex = 6;
            this.btnAgregarComida.Text = "Agregar Comida";
            this.btnAgregarComida.UseVisualStyleBackColor = false;
            // 
            // brnAgregarBebida
            // 
            this.brnAgregarBebida.BackColor = System.Drawing.Color.Transparent;
            this.brnAgregarBebida.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnAgregarBebida.FlatAppearance.BorderSize = 0;
            this.brnAgregarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnAgregarBebida.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brnAgregarBebida.Location = new System.Drawing.Point(0, 135);
            this.brnAgregarBebida.Margin = new System.Windows.Forms.Padding(0);
            this.brnAgregarBebida.Name = "brnAgregarBebida";
            this.brnAgregarBebida.Size = new System.Drawing.Size(200, 60);
            this.brnAgregarBebida.TabIndex = 7;
            this.brnAgregarBebida.Text = "Agregar Bebida";
            this.brnAgregarBebida.UseVisualStyleBackColor = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.Location = new System.Drawing.Point(0, 255);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(0);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(200, 60);
            this.btnContinuar.TabIndex = 8;
            this.btnContinuar.Text = "Continuar Sin Cerrar";
            this.btnContinuar.UseVisualStyleBackColor = false;
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
            this.btnQuitarProducto.TabIndex = 9;
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
            this.btnCerrarMesa.Location = new System.Drawing.Point(0, 315);
            this.btnCerrarMesa.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(200, 60);
            this.btnCerrarMesa.TabIndex = 11;
            this.btnCerrarMesa.Text = "Cerrar Mesa";
            this.btnCerrarMesa.UseVisualStyleBackColor = false;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCostoTotal.Location = new System.Drawing.Point(657, 472);
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
            this.pnlOpciones.Controls.Add(this.btnQuitarProducto);
            this.pnlOpciones.Controls.Add(this.brnAgregarBebida);
            this.pnlOpciones.Controls.Add(this.btnAgregarComida);
            this.pnlOpciones.Controls.Add(this.pctLogo);
            this.pnlOpciones.Controls.Add(this.lblNumeroMesa);
            this.pnlOpciones.Controls.Add(this.lblEmpleadoACargo);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(200, 542);
            this.pnlOpciones.TabIndex = 13;
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
            this.cantidad.Width = 75;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(861, 542);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.cmbMedioDePago);
            this.Controls.Add(this.lblMedioDePago);
            this.Controls.Add(this.chkEstacionamiento);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.dgvPedido);
            this.Name = "FormVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroMesa;
        private System.Windows.Forms.CheckBox chkEstacionamiento;
        private System.Windows.Forms.ComboBox cmbMedioDePago;
        private System.Windows.Forms.Label lblMedioDePago;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label lblEmpleadoACargo;
        private System.Windows.Forms.Button btnAgregarComida;
        private System.Windows.Forms.Button brnAgregarBebida;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnCerrarMesa;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}