namespace CentroMedidorMain
{
    partial class FmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmInicio));
            this.LbCentro = new System.Windows.Forms.Label();
            this.BtnMedidores = new System.Windows.Forms.Button();
            this.BtnAddSuscriptor = new System.Windows.Forms.Button();
            this.LbDia = new System.Windows.Forms.Label();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbCentro
            // 
            resources.ApplyResources(this.LbCentro, "LbCentro");
            this.LbCentro.Name = "LbCentro";
            // 
            // BtnMedidores
            // 
            this.BtnMedidores.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnMedidores, "BtnMedidores");
            this.BtnMedidores.Name = "BtnMedidores";
            this.BtnMedidores.UseVisualStyleBackColor = true;
            this.BtnMedidores.Click += new System.EventHandler(this.BtnMedidores_Click);
            // 
            // BtnAddSuscriptor
            // 
            this.BtnAddSuscriptor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnAddSuscriptor, "BtnAddSuscriptor");
            this.BtnAddSuscriptor.Name = "BtnAddSuscriptor";
            this.BtnAddSuscriptor.UseVisualStyleBackColor = true;
            this.BtnAddSuscriptor.Click += new System.EventHandler(this.BtnAddSuscriptor_Click);
            // 
            // LbDia
            // 
            resources.ApplyResources(this.LbDia, "LbDia");
            this.LbDia.Name = "LbDia";
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnSiguiente, "BtnSiguiente");
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnInventario, "BtnInventario");
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // FmInicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.LbDia);
            this.Controls.Add(this.BtnAddSuscriptor);
            this.Controls.Add(this.BtnMedidores);
            this.Controls.Add(this.LbCentro);
            this.MaximizeBox = false;
            this.Name = "FmInicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmInicio_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbCentro;
        private System.Windows.Forms.Button BtnMedidores;
        private System.Windows.Forms.Button BtnAddSuscriptor;
        private System.Windows.Forms.Label LbDia;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnInventario;
    }
}

