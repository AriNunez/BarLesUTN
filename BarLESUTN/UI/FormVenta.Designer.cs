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
            this.btnQuitarComida = new System.Windows.Forms.Button();
            this.btnQuitarBebida = new System.Windows.Forms.Button();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMesa.Location = new System.Drawing.Point(38, 9);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(74, 32);
            this.lblMesa.TabIndex = 0;
            this.lblMesa.Text = "Mesa";
            // 
            // chkEstacionamiento
            // 
            this.chkEstacionamiento.AutoSize = true;
            this.chkEstacionamiento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkEstacionamiento.Location = new System.Drawing.Point(21, 158);
            this.chkEstacionamiento.Name = "chkEstacionamiento";
            this.chkEstacionamiento.Size = new System.Drawing.Size(173, 23);
            this.chkEstacionamiento.TabIndex = 1;
            this.chkEstacionamiento.Text = "Con Estacionamiento";
            this.chkEstacionamiento.UseVisualStyleBackColor = true;
            // 
            // cmbMedioDePago
            // 
            this.cmbMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioDePago.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMedioDePago.FormattingEnabled = true;
            this.cmbMedioDePago.Location = new System.Drawing.Point(21, 109);
            this.cmbMedioDePago.Name = "cmbMedioDePago";
            this.cmbMedioDePago.Size = new System.Drawing.Size(173, 27);
            this.cmbMedioDePago.TabIndex = 2;
            // 
            // lblMedioDePago
            // 
            this.lblMedioDePago.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedioDePago.Location = new System.Drawing.Point(21, 74);
            this.lblMedioDePago.Name = "lblMedioDePago";
            this.lblMedioDePago.Size = new System.Drawing.Size(173, 23);
            this.lblMedioDePago.TabIndex = 3;
            this.lblMedioDePago.Text = "Medio De Pago";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(457, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(449, 424);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblEmpleadoACargo
            // 
            this.lblEmpleadoACargo.AutoSize = true;
            this.lblEmpleadoACargo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleadoACargo.Location = new System.Drawing.Point(738, 9);
            this.lblEmpleadoACargo.Name = "lblEmpleadoACargo";
            this.lblEmpleadoACargo.Size = new System.Drawing.Size(141, 19);
            this.lblEmpleadoACargo.TabIndex = 5;
            this.lblEmpleadoACargo.Text = "Atendida por: Ariel";
            // 
            // btnAgregarComida
            // 
            this.btnAgregarComida.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarComida.Location = new System.Drawing.Point(21, 383);
            this.btnAgregarComida.Name = "btnAgregarComida";
            this.btnAgregarComida.Size = new System.Drawing.Size(100, 50);
            this.btnAgregarComida.TabIndex = 6;
            this.btnAgregarComida.Text = "Agregar Comida";
            this.btnAgregarComida.UseVisualStyleBackColor = true;
            // 
            // brnAgregarBebida
            // 
            this.brnAgregarBebida.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brnAgregarBebida.Location = new System.Drawing.Point(119, 383);
            this.brnAgregarBebida.Name = "brnAgregarBebida";
            this.brnAgregarBebida.Size = new System.Drawing.Size(100, 50);
            this.brnAgregarBebida.TabIndex = 7;
            this.brnAgregarBebida.Text = "Agregar Bebida";
            this.brnAgregarBebida.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.Location = new System.Drawing.Point(213, 383);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(100, 50);
            this.btnContinuar.TabIndex = 8;
            this.btnContinuar.Text = "Continuar Sin Cerrar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarComida
            // 
            this.btnQuitarComida.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitarComida.Location = new System.Drawing.Point(21, 431);
            this.btnQuitarComida.Name = "btnQuitarComida";
            this.btnQuitarComida.Size = new System.Drawing.Size(100, 50);
            this.btnQuitarComida.TabIndex = 9;
            this.btnQuitarComida.Text = "Quitar Comida";
            this.btnQuitarComida.UseVisualStyleBackColor = true;
            // 
            // btnQuitarBebida
            // 
            this.btnQuitarBebida.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitarBebida.Location = new System.Drawing.Point(119, 431);
            this.btnQuitarBebida.Name = "btnQuitarBebida";
            this.btnQuitarBebida.Size = new System.Drawing.Size(100, 50);
            this.btnQuitarBebida.TabIndex = 10;
            this.btnQuitarBebida.Text = "Quitar Bebida";
            this.btnQuitarBebida.UseVisualStyleBackColor = true;
            // 
            // btnCerrarMesa
            // 
            this.btnCerrarMesa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarMesa.Location = new System.Drawing.Point(213, 431);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(100, 50);
            this.btnCerrarMesa.TabIndex = 11;
            this.btnCerrarMesa.Text = "Cerrar Mesa";
            this.btnCerrarMesa.UseVisualStyleBackColor = true;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(918, 574);
            this.Controls.Add(this.btnCerrarMesa);
            this.Controls.Add(this.btnQuitarBebida);
            this.Controls.Add(this.btnQuitarComida);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.brnAgregarBebida);
            this.Controls.Add(this.btnAgregarComida);
            this.Controls.Add(this.lblEmpleadoACargo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMedioDePago);
            this.Controls.Add(this.cmbMedioDePago);
            this.Controls.Add(this.chkEstacionamiento);
            this.Controls.Add(this.lblMesa);
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
        private System.Windows.Forms.Button btnQuitarComida;
        private System.Windows.Forms.Button btnQuitarBebida;
        private System.Windows.Forms.Button btnCerrarMesa;
    }
}