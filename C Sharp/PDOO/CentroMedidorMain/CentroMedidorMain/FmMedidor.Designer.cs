namespace CentroMedidorMain
{
    partial class FmMedidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMedidor));
            this.BtnReparar = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.BtnDesconectar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.TbSuscriptores = new System.Windows.Forms.DataGridView();
            this.LbSuscriptores = new System.Windows.Forms.Label();
            this.TbCuadrilla = new System.Windows.Forms.DataGridView();
            this.LbCuadrillas = new System.Windows.Forms.Label();
            this.LbNewMedidor = new System.Windows.Forms.Label();
            this.CbTipoMedidor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TbSuscriptores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbCuadrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReparar
            // 
            this.BtnReparar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReparar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReparar.Location = new System.Drawing.Point(659, 280);
            this.BtnReparar.Name = "BtnReparar";
            this.BtnReparar.Size = new System.Drawing.Size(132, 28);
            this.BtnReparar.TabIndex = 14;
            this.BtnReparar.Text = "Reparar Medidor";
            this.BtnReparar.UseVisualStyleBackColor = true;
            this.BtnReparar.Click += new System.EventHandler(this.BtnReparar_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConectar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.Location = new System.Drawing.Point(659, 326);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(132, 28);
            this.BtnConectar.TabIndex = 13;
            this.BtnConectar.Text = "Conectar Medidor";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCambiar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiar.Location = new System.Drawing.Point(659, 392);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(132, 28);
            this.BtnCambiar.TabIndex = 12;
            this.BtnCambiar.Text = "Cambiar Medidor";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // BtnDesconectar
            // 
            this.BtnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDesconectar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesconectar.Location = new System.Drawing.Point(516, 326);
            this.BtnDesconectar.Name = "BtnDesconectar";
            this.BtnDesconectar.Size = new System.Drawing.Size(132, 28);
            this.BtnDesconectar.TabIndex = 11;
            this.BtnDesconectar.Text = "Desconectar Medidor";
            this.BtnDesconectar.UseVisualStyleBackColor = true;
            this.BtnDesconectar.Click += new System.EventHandler(this.BtnDesconectar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolver.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(759, 484);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(84, 24);
            this.BtnVolver.TabIndex = 15;
            this.BtnVolver.Text = "Volver Inicio";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturar.Location = new System.Drawing.Point(516, 280);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(132, 28);
            this.BtnFacturar.TabIndex = 17;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // TbSuscriptores
            // 
            this.TbSuscriptores.AllowUserToAddRows = false;
            this.TbSuscriptores.AllowUserToDeleteRows = false;
            this.TbSuscriptores.AllowUserToResizeColumns = false;
            this.TbSuscriptores.AllowUserToResizeRows = false;
            this.TbSuscriptores.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TbSuscriptores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbSuscriptores.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbSuscriptores.Location = new System.Drawing.Point(0, 0);
            this.TbSuscriptores.MultiSelect = false;
            this.TbSuscriptores.Name = "TbSuscriptores";
            this.TbSuscriptores.ReadOnly = true;
            this.TbSuscriptores.RowTemplate.ReadOnly = true;
            this.TbSuscriptores.Size = new System.Drawing.Size(843, 206);
            this.TbSuscriptores.TabIndex = 18;
            // 
            // LbSuscriptores
            // 
            this.LbSuscriptores.AutoSize = true;
            this.LbSuscriptores.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbSuscriptores.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSuscriptores.Location = new System.Drawing.Point(0, 206);
            this.LbSuscriptores.Name = "LbSuscriptores";
            this.LbSuscriptores.Size = new System.Drawing.Size(82, 20);
            this.LbSuscriptores.TabIndex = 19;
            this.LbSuscriptores.Text = "Suscriptores";
            // 
            // TbCuadrilla
            // 
            this.TbCuadrilla.AllowUserToAddRows = false;
            this.TbCuadrilla.AllowUserToDeleteRows = false;
            this.TbCuadrilla.AllowUserToResizeColumns = false;
            this.TbCuadrilla.AllowUserToResizeRows = false;
            this.TbCuadrilla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TbCuadrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbCuadrilla.Location = new System.Drawing.Point(12, 271);
            this.TbCuadrilla.MultiSelect = false;
            this.TbCuadrilla.Name = "TbCuadrilla";
            this.TbCuadrilla.ReadOnly = true;
            this.TbCuadrilla.RowTemplate.ReadOnly = true;
            this.TbCuadrilla.Size = new System.Drawing.Size(444, 228);
            this.TbCuadrilla.TabIndex = 20;
            // 
            // LbCuadrillas
            // 
            this.LbCuadrillas.AutoSize = true;
            this.LbCuadrillas.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCuadrillas.Location = new System.Drawing.Point(8, 248);
            this.LbCuadrillas.Name = "LbCuadrillas";
            this.LbCuadrillas.Size = new System.Drawing.Size(71, 20);
            this.LbCuadrillas.TabIndex = 21;
            this.LbCuadrillas.Text = "Cuadrillas";
            // 
            // LbNewMedidor
            // 
            this.LbNewMedidor.AutoSize = true;
            this.LbNewMedidor.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNewMedidor.Location = new System.Drawing.Point(512, 373);
            this.LbNewMedidor.Name = "LbNewMedidor";
            this.LbNewMedidor.Size = new System.Drawing.Size(103, 20);
            this.LbNewMedidor.TabIndex = 22;
            this.LbNewMedidor.Text = "Nuevo Medidor";
            // 
            // CbTipoMedidor
            // 
            this.CbTipoMedidor.DisplayMember = "Medidor";
            this.CbTipoMedidor.FormattingEnabled = true;
            this.CbTipoMedidor.Items.AddRange(new object[] {
            "Tipo A",
            "Tipo B",
            "Tipo C"});
            this.CbTipoMedidor.Location = new System.Drawing.Point(516, 398);
            this.CbTipoMedidor.Name = "CbTipoMedidor";
            this.CbTipoMedidor.Size = new System.Drawing.Size(132, 21);
            this.CbTipoMedidor.TabIndex = 23;
            this.CbTipoMedidor.Text = "--Seleccione--";
            // 
            // FmMedidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(843, 511);
            this.ControlBox = false;
            this.Controls.Add(this.CbTipoMedidor);
            this.Controls.Add(this.LbNewMedidor);
            this.Controls.Add(this.LbCuadrillas);
            this.Controls.Add(this.TbCuadrilla);
            this.Controls.Add(this.LbSuscriptores);
            this.Controls.Add(this.TbSuscriptores);
            this.Controls.Add(this.BtnFacturar);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnReparar);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnCambiar);
            this.Controls.Add(this.BtnDesconectar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmMedidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medidores";
            this.Load += new System.EventHandler(this.FmMedidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TbSuscriptores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbCuadrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReparar;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.Button BtnDesconectar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.DataGridView TbSuscriptores;
        private System.Windows.Forms.Label LbSuscriptores;
        private System.Windows.Forms.DataGridView TbCuadrilla;
        private System.Windows.Forms.Label LbCuadrillas;
        private System.Windows.Forms.Label LbNewMedidor;
        private System.Windows.Forms.ComboBox CbTipoMedidor;
    }
}