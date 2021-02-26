namespace CentroMedidorMain
{
    partial class FmSuscriptor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSuscriptor));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.LbCuadrillas = new System.Windows.Forms.Label();
            this.TbCuadrilla = new System.Windows.Forms.DataGridView();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.CbTipoMedidor = new System.Windows.Forms.ComboBox();
            this.LbMedidor = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.BtnInstalar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TbCuadrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolver.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(378, 424);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(84, 24);
            this.BtnVolver.TabIndex = 18;
            this.BtnVolver.Text = "Volver Inicio";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // LbCuadrillas
            // 
            this.LbCuadrillas.AutoSize = true;
            this.LbCuadrillas.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbCuadrillas.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCuadrillas.Location = new System.Drawing.Point(0, 201);
            this.LbCuadrillas.Name = "LbCuadrillas";
            this.LbCuadrillas.Size = new System.Drawing.Size(71, 20);
            this.LbCuadrillas.TabIndex = 23;
            this.LbCuadrillas.Text = "Cuadrillas";
            // 
            // TbCuadrilla
            // 
            this.TbCuadrilla.AllowUserToAddRows = false;
            this.TbCuadrilla.AllowUserToDeleteRows = false;
            this.TbCuadrilla.AllowUserToResizeColumns = false;
            this.TbCuadrilla.AllowUserToResizeRows = false;
            this.TbCuadrilla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TbCuadrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbCuadrilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbCuadrilla.Location = new System.Drawing.Point(0, 0);
            this.TbCuadrilla.MultiSelect = false;
            this.TbCuadrilla.Name = "TbCuadrilla";
            this.TbCuadrilla.ReadOnly = true;
            this.TbCuadrilla.RowTemplate.ReadOnly = true;
            this.TbCuadrilla.Size = new System.Drawing.Size(462, 201);
            this.TbCuadrilla.TabIndex = 22;
            // 
            // TxNombre
            // 
            this.TxNombre.Location = new System.Drawing.Point(43, 265);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(132, 20);
            this.TxNombre.TabIndex = 24;
            // 
            // CbTipoMedidor
            // 
            this.CbTipoMedidor.DisplayMember = "Medidor";
            this.CbTipoMedidor.FormattingEnabled = true;
            this.CbTipoMedidor.Items.AddRange(new object[] {
            "Tipo A",
            "Tipo B",
            "Tipo C"});
            this.CbTipoMedidor.Location = new System.Drawing.Point(254, 264);
            this.CbTipoMedidor.Name = "CbTipoMedidor";
            this.CbTipoMedidor.Size = new System.Drawing.Size(132, 21);
            this.CbTipoMedidor.TabIndex = 26;
            this.CbTipoMedidor.Text = "--Seleccione--";
            // 
            // LbMedidor
            // 
            this.LbMedidor.AutoSize = true;
            this.LbMedidor.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMedidor.Location = new System.Drawing.Point(250, 241);
            this.LbMedidor.Name = "LbMedidor";
            this.LbMedidor.Size = new System.Drawing.Size(61, 20);
            this.LbMedidor.TabIndex = 25;
            this.LbMedidor.Text = "Medidor";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.Location = new System.Drawing.Point(39, 241);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(144, 20);
            this.LbNombre.TabIndex = 27;
            this.LbNombre.Text = "Nombre del suscriptor";
            // 
            // BtnInstalar
            // 
            this.BtnInstalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInstalar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstalar.Location = new System.Drawing.Point(150, 335);
            this.BtnInstalar.Name = "BtnInstalar";
            this.BtnInstalar.Size = new System.Drawing.Size(132, 28);
            this.BtnInstalar.TabIndex = 28;
            this.BtnInstalar.Text = "Instalar Medidor";
            this.BtnInstalar.UseVisualStyleBackColor = true;
            this.BtnInstalar.Click += new System.EventHandler(this.BtnInstalar_Click);
            // 
            // FmSuscriptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BtnInstalar);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.CbTipoMedidor);
            this.Controls.Add(this.LbMedidor);
            this.Controls.Add(this.TxNombre);
            this.Controls.Add(this.LbCuadrillas);
            this.Controls.Add(this.TbCuadrilla);
            this.Controls.Add(this.BtnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmSuscriptor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suscriptor nuevo";
            ((System.ComponentModel.ISupportInitialize)(this.TbCuadrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label LbCuadrillas;
        private System.Windows.Forms.DataGridView TbCuadrilla;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.ComboBox CbTipoMedidor;
        private System.Windows.Forms.Label LbMedidor;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Button BtnInstalar;
    }
}