namespace CentroMedidorMain
{
    partial class FmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmInventario));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.TbInventario = new System.Windows.Forms.DataGridView();
            this.CbTipoMedidor = new System.Windows.Forms.ComboBox();
            this.LbNewMedidor = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LbCantidad = new System.Windows.Forms.Label();
            this.TxCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TbInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnVolver, "BtnVolver");
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // TbInventario
            // 
            this.TbInventario.AllowUserToAddRows = false;
            this.TbInventario.AllowUserToDeleteRows = false;
            this.TbInventario.AllowUserToResizeColumns = false;
            this.TbInventario.AllowUserToResizeRows = false;
            this.TbInventario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TbInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.TbInventario, "TbInventario");
            this.TbInventario.MultiSelect = false;
            this.TbInventario.Name = "TbInventario";
            this.TbInventario.ReadOnly = true;
            this.TbInventario.RowTemplate.ReadOnly = true;
            // 
            // CbTipoMedidor
            // 
            this.CbTipoMedidor.DisplayMember = "Medidor";
            this.CbTipoMedidor.FormattingEnabled = true;
            this.CbTipoMedidor.Items.AddRange(new object[] {
            resources.GetString("CbTipoMedidor.Items"),
            resources.GetString("CbTipoMedidor.Items1"),
            resources.GetString("CbTipoMedidor.Items2")});
            resources.ApplyResources(this.CbTipoMedidor, "CbTipoMedidor");
            this.CbTipoMedidor.Name = "CbTipoMedidor";
            // 
            // LbNewMedidor
            // 
            resources.ApplyResources(this.LbNewMedidor, "LbNewMedidor");
            this.LbNewMedidor.Name = "LbNewMedidor";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnAgregar, "BtnAgregar");
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LbCantidad
            // 
            resources.ApplyResources(this.LbCantidad, "LbCantidad");
            this.LbCantidad.Name = "LbCantidad";
            // 
            // TxCantidad
            // 
            resources.ApplyResources(this.TxCantidad, "TxCantidad");
            this.TxCantidad.Name = "TxCantidad";
            // 
            // FmInventario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.LbCantidad);
            this.Controls.Add(this.TxCantidad);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CbTipoMedidor);
            this.Controls.Add(this.LbNewMedidor);
            this.Controls.Add(this.TbInventario);
            this.Controls.Add(this.BtnVolver);
            this.Name = "FmInventario";
            ((System.ComponentModel.ISupportInitialize)(this.TbInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.DataGridView TbInventario;
        private System.Windows.Forms.ComboBox CbTipoMedidor;
        private System.Windows.Forms.Label LbNewMedidor;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LbCantidad;
        private System.Windows.Forms.TextBox TxCantidad;
    }
}