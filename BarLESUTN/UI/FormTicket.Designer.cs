namespace UI
{
    partial class FormTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.rtbResumenPedido = new System.Windows.Forms.RichTextBox();
            this.rtbCostos = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctLogo.Image = global::UI.Properties.Resources.logo_utn;
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(384, 100);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // rtbResumenPedido
            // 
            this.rtbResumenPedido.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbResumenPedido.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbResumenPedido.Location = new System.Drawing.Point(0, 100);
            this.rtbResumenPedido.Name = "rtbResumenPedido";
            this.rtbResumenPedido.ReadOnly = true;
            this.rtbResumenPedido.Size = new System.Drawing.Size(273, 255);
            this.rtbResumenPedido.TabIndex = 1;
            this.rtbResumenPedido.Text = "";
            // 
            // rtbCostos
            // 
            this.rtbCostos.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbCostos.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbCostos.Location = new System.Drawing.Point(279, 100);
            this.rtbCostos.Name = "rtbCostos";
            this.rtbCostos.ReadOnly = true;
            this.rtbCostos.Size = new System.Drawing.Size(105, 255);
            this.rtbCostos.TabIndex = 2;
            this.rtbCostos.Text = "";
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 355);
            this.Controls.Add(this.rtbCostos);
            this.Controls.Add(this.rtbResumenPedido);
            this.Controls.Add(this.pctLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTicket_FormClosed);
            this.Load += new System.EventHandler(this.FormTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.RichTextBox rtbResumenPedido;
        private System.Windows.Forms.RichTextBox rtbCostos;
    }
}