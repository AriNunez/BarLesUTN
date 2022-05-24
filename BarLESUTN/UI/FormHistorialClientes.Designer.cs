namespace UI
{
    partial class FormHistorialClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialClientes));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.empleadoACargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medioDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conEstacionamiento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(303, 410);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 50);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.AllowUserToAddRows = false;
            this.dtgvClientes.AllowUserToDeleteRows = false;
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empleadoACargo,
            this.horaIngreso,
            this.horaEgreso,
            this.medioDePago,
            this.conEstacionamiento,
            this.costoPedido});
            this.dtgvClientes.Location = new System.Drawing.Point(25, 15);
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.RowTemplate.Height = 25;
            this.dtgvClientes.Size = new System.Drawing.Size(643, 389);
            this.dtgvClientes.TabIndex = 1;
            // 
            // empleadoACargo
            // 
            this.empleadoACargo.HeaderText = "Empleado A Cargo";
            this.empleadoACargo.Name = "empleadoACargo";
            this.empleadoACargo.ReadOnly = true;
            // 
            // horaIngreso
            // 
            this.horaIngreso.HeaderText = "Hora Ingreso";
            this.horaIngreso.Name = "horaIngreso";
            this.horaIngreso.ReadOnly = true;
            // 
            // horaEgreso
            // 
            this.horaEgreso.HeaderText = "Hora Egreso";
            this.horaEgreso.Name = "horaEgreso";
            this.horaEgreso.ReadOnly = true;
            // 
            // medioDePago
            // 
            this.medioDePago.HeaderText = "Medio de Pago";
            this.medioDePago.Name = "medioDePago";
            this.medioDePago.ReadOnly = true;
            // 
            // conEstacionamiento
            // 
            this.conEstacionamiento.HeaderText = "Con Estacionamiento";
            this.conEstacionamiento.Name = "conEstacionamiento";
            this.conEstacionamiento.ReadOnly = true;
            // 
            // costoPedido
            // 
            this.costoPedido.HeaderText = "Costo Pedido (sin recargos)";
            this.costoPedido.Name = "costoPedido";
            this.costoPedido.ReadOnly = true;
            // 
            // FormHistorialClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 471);
            this.Controls.Add(this.dtgvClientes);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHistorialClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Clientes";
            this.Load += new System.EventHandler(this.FormHistorialClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dtgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoACargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn medioDePago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn conEstacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPedido;
    }
}