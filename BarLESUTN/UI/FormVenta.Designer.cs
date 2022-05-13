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
            this.lblMesa = new System.Windows.Forms.Label();
            this.chkEstacionamiento = new System.Windows.Forms.CheckBox();
            this.cmbMedioDePago = new System.Windows.Forms.ComboBox();
            this.lblMedioDePago = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEmpleadoACargo = new System.Windows.Forms.Label();
            this.btnAgregarComida = new System.Windows.Forms.Button();
            this.brnAgregarBebida = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnModificarCantidad = new System.Windows.Forms.Button();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMesa.Location = new System.Drawing.Point(188, 9);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(94, 40);
            this.lblMesa.TabIndex = 0;
            this.lblMesa.Text = "Mesa";
            // 
            // chkEstacionamiento
            // 
            this.chkEstacionamiento.AutoSize = true;
            this.chkEstacionamiento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkEstacionamiento.Location = new System.Drawing.Point(138, 173);
            this.chkEstacionamiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkEstacionamiento.Name = "chkEstacionamiento";
            this.chkEstacionamiento.Size = new System.Drawing.Size(216, 27);
            this.chkEstacionamiento.TabIndex = 1;
            this.chkEstacionamiento.Text = "Con Estacionamiento";
            this.chkEstacionamiento.UseVisualStyleBackColor = true;
            // 
            // cmbMedioDePago
            // 
            this.cmbMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioDePago.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMedioDePago.FormattingEnabled = true;
            this.cmbMedioDePago.Location = new System.Drawing.Point(147, 110);
            this.cmbMedioDePago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMedioDePago.Name = "cmbMedioDePago";
            this.cmbMedioDePago.Size = new System.Drawing.Size(197, 31);
            this.cmbMedioDePago.TabIndex = 2;
            // 
            // lblMedioDePago
            // 
            this.lblMedioDePago.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedioDePago.Location = new System.Drawing.Point(147, 75);
            this.lblMedioDePago.Name = "lblMedioDePago";
            this.lblMedioDePago.Size = new System.Drawing.Size(198, 31);
            this.lblMedioDePago.TabIndex = 3;
            this.lblMedioDePago.Text = "Medio De Pago";
            this.lblMedioDePago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(522, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(513, 316);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblEmpleadoACargo
            // 
            this.lblEmpleadoACargo.AutoSize = true;
            this.lblEmpleadoACargo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleadoACargo.Location = new System.Drawing.Point(843, 21);
            this.lblEmpleadoACargo.Name = "lblEmpleadoACargo";
            this.lblEmpleadoACargo.Size = new System.Drawing.Size(172, 23);
            this.lblEmpleadoACargo.TabIndex = 5;
            this.lblEmpleadoACargo.Text = "Atendida por: Ariel";
            // 
            // btnAgregarComida
            // 
            this.btnAgregarComida.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarComida.Location = new System.Drawing.Point(77, 236);
            this.btnAgregarComida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarComida.Name = "btnAgregarComida";
            this.btnAgregarComida.Size = new System.Drawing.Size(120, 80);
            this.btnAgregarComida.TabIndex = 6;
            this.btnAgregarComida.Text = "Agregar Comida";
            this.btnAgregarComida.UseVisualStyleBackColor = true;
            // 
            // brnAgregarBebida
            // 
            this.brnAgregarBebida.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brnAgregarBebida.Location = new System.Drawing.Point(203, 236);
            this.brnAgregarBebida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brnAgregarBebida.Name = "brnAgregarBebida";
            this.brnAgregarBebida.Size = new System.Drawing.Size(120, 80);
            this.brnAgregarBebida.TabIndex = 7;
            this.brnAgregarBebida.Text = "Agregar Bebida";
            this.brnAgregarBebida.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.Location = new System.Drawing.Point(203, 324);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(120, 80);
            this.btnContinuar.TabIndex = 8;
            this.btnContinuar.Text = "Continuar Sin Cerrar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitarProducto.Location = new System.Drawing.Point(77, 324);
            this.btnQuitarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(120, 80);
            this.btnQuitarProducto.TabIndex = 9;
            this.btnQuitarProducto.Text = "Quitar Producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificarCantidad
            // 
            this.btnModificarCantidad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarCantidad.Location = new System.Drawing.Point(329, 236);
            this.btnModificarCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificarCantidad.Name = "btnModificarCantidad";
            this.btnModificarCantidad.Size = new System.Drawing.Size(120, 80);
            this.btnModificarCantidad.TabIndex = 10;
            this.btnModificarCantidad.Text = "Modificar Cantidad de Producto";
            this.btnModificarCantidad.UseVisualStyleBackColor = true;
            // 
            // btnCerrarMesa
            // 
            this.btnCerrarMesa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarMesa.Location = new System.Drawing.Point(329, 324);
            this.btnCerrarMesa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(120, 80);
            this.btnCerrarMesa.TabIndex = 11;
            this.btnCerrarMesa.Text = "Cerrar Mesa";
            this.btnCerrarMesa.UseVisualStyleBackColor = true;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCostoTotal.Location = new System.Drawing.Point(820, 410);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(111, 23);
            this.lblCostoTotal.TabIndex = 12;
            this.lblCostoTotal.Text = "Costo Total:";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1049, 463);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.btnCerrarMesa);
            this.Controls.Add(this.btnModificarCantidad);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.brnAgregarBebida);
            this.Controls.Add(this.btnAgregarComida);
            this.Controls.Add(this.lblEmpleadoACargo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMedioDePago);
            this.Controls.Add(this.cmbMedioDePago);
            this.Controls.Add(this.chkEstacionamiento);
            this.Controls.Add(this.lblMesa);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormVenta";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.CheckBox chkEstacionamiento;
        private System.Windows.Forms.ComboBox cmbMedioDePago;
        private System.Windows.Forms.Label lblMedioDePago;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEmpleadoACargo;
        private System.Windows.Forms.Button btnAgregarComida;
        private System.Windows.Forms.Button brnAgregarBebida;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnModificarCantidad;
        private System.Windows.Forms.Button btnCerrarMesa;
        private System.Windows.Forms.Label lblCostoTotal;
    }
}