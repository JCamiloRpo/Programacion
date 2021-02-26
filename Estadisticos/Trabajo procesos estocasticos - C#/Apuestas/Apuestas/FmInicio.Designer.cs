namespace Apuestas
{
    partial class FmInicio
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
            this.LbBienvenido = new System.Windows.Forms.Label();
            this.BtnManual = new System.Windows.Forms.Button();
            this.BtnAutomatica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbBienvenido
            // 
            this.LbBienvenido.AutoSize = true;
            this.LbBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBienvenido.Location = new System.Drawing.Point(128, 61);
            this.LbBienvenido.Name = "LbBienvenido";
            this.LbBienvenido.Size = new System.Drawing.Size(539, 42);
            this.LbBienvenido.TabIndex = 0;
            this.LbBienvenido.Text = "Apuestas de Valor: Valuebets";
            // 
            // BtnManual
            // 
            this.BtnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManual.Location = new System.Drawing.Point(172, 197);
            this.BtnManual.Name = "BtnManual";
            this.BtnManual.Size = new System.Drawing.Size(178, 85);
            this.BtnManual.TabIndex = 1;
            this.BtnManual.Text = "Apuestas manual";
            this.BtnManual.UseVisualStyleBackColor = true;
            this.BtnManual.Click += new System.EventHandler(this.BtnManual_Click);
            // 
            // BtnAutomatica
            // 
            this.BtnAutomatica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutomatica.Location = new System.Drawing.Point(419, 197);
            this.BtnAutomatica.Name = "BtnAutomatica";
            this.BtnAutomatica.Size = new System.Drawing.Size(178, 85);
            this.BtnAutomatica.TabIndex = 2;
            this.BtnAutomatica.Text = "Apuestas automatica";
            this.BtnAutomatica.UseVisualStyleBackColor = true;
            this.BtnAutomatica.Click += new System.EventHandler(this.BtnAutomatica_Click);
            // 
            // FmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAutomatica);
            this.Controls.Add(this.BtnManual);
            this.Controls.Add(this.LbBienvenido);
            this.MaximizeBox = false;
            this.Name = "FmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valuebets";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmInicio_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbBienvenido;
        private System.Windows.Forms.Button BtnManual;
        private System.Windows.Forms.Button BtnAutomatica;
    }
}