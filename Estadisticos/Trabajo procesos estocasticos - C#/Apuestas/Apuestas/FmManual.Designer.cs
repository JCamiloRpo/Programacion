namespace Apuestas
{
    partial class FmManual
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TxSaldoInicial = new System.Windows.Forms.TextBox();
            this.LbSaldoInicial = new System.Windows.Forms.Label();
            this.LbSaldoActual = new System.Windows.Forms.Label();
            this.TxSaldoActual = new System.Windows.Forms.TextBox();
            this.BtnApostar = new System.Windows.Forms.Button();
            this.LbSaldoApostar = new System.Windows.Forms.Label();
            this.TxSaldoApostar = new System.Windows.Forms.TextBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.LbProGanar = new System.Windows.Forms.Label();
            this.TxProGanar = new System.Windows.Forms.TextBox();
            this.LbCuoApuesta = new System.Windows.Forms.Label();
            this.TxCuoApuesta = new System.Windows.Forms.TextBox();
            this.LbResultado = new System.Windows.Forms.Label();
            this.CbDecimal = new System.Windows.Forms.CheckBox();
            this.CbPorcentaje = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // Grafica
            // 
            chartArea1.AxisX.Title = "# Apuesta";
            chartArea1.AxisY.Title = "Saldo";
            chartArea1.Name = "ChartArea1";
            this.Grafica.ChartAreas.Add(chartArea1);
            this.Grafica.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.Grafica.Legends.Add(legend1);
            this.Grafica.Location = new System.Drawing.Point(0, 82);
            this.Grafica.Name = "Grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "SaldoVsApuesta";
            this.Grafica.Series.Add(series1);
            this.Grafica.Size = new System.Drawing.Size(794, 390);
            this.Grafica.TabIndex = 10;
            this.Grafica.Text = "Grafica";
            // 
            // TxSaldoInicial
            // 
            this.TxSaldoInicial.Location = new System.Drawing.Point(9, 25);
            this.TxSaldoInicial.Name = "TxSaldoInicial";
            this.TxSaldoInicial.Size = new System.Drawing.Size(100, 20);
            this.TxSaldoInicial.TabIndex = 0;
            this.TxSaldoInicial.Enter += new System.EventHandler(this.TxSaldoInicial_Enter);
            this.TxSaldoInicial.Leave += new System.EventHandler(this.TxSaldoInicial_Leave);
            // 
            // LbSaldoInicial
            // 
            this.LbSaldoInicial.AutoSize = true;
            this.LbSaldoInicial.Location = new System.Drawing.Point(9, 9);
            this.LbSaldoInicial.Name = "LbSaldoInicial";
            this.LbSaldoInicial.Size = new System.Drawing.Size(64, 13);
            this.LbSaldoInicial.TabIndex = 11;
            this.LbSaldoInicial.Text = "Saldo Inicial";
            // 
            // LbSaldoActual
            // 
            this.LbSaldoActual.AutoSize = true;
            this.LbSaldoActual.Location = new System.Drawing.Point(497, 10);
            this.LbSaldoActual.Name = "LbSaldoActual";
            this.LbSaldoActual.Size = new System.Drawing.Size(67, 13);
            this.LbSaldoActual.TabIndex = 15;
            this.LbSaldoActual.Text = "Saldo Actual";
            // 
            // TxSaldoActual
            // 
            this.TxSaldoActual.Location = new System.Drawing.Point(500, 26);
            this.TxSaldoActual.Name = "TxSaldoActual";
            this.TxSaldoActual.ReadOnly = true;
            this.TxSaldoActual.Size = new System.Drawing.Size(100, 20);
            this.TxSaldoActual.TabIndex = 6;
            // 
            // BtnApostar
            // 
            this.BtnApostar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApostar.Location = new System.Drawing.Point(623, 23);
            this.BtnApostar.Name = "BtnApostar";
            this.BtnApostar.Size = new System.Drawing.Size(75, 23);
            this.BtnApostar.TabIndex = 7;
            this.BtnApostar.Text = "Apostar";
            this.BtnApostar.UseVisualStyleBackColor = true;
            this.BtnApostar.Click += new System.EventHandler(this.BtnApostar_Click);
            // 
            // LbSaldoApostar
            // 
            this.LbSaldoApostar.AutoSize = true;
            this.LbSaldoApostar.Location = new System.Drawing.Point(124, 10);
            this.LbSaldoApostar.Name = "LbSaldoApostar";
            this.LbSaldoApostar.Size = new System.Drawing.Size(73, 13);
            this.LbSaldoApostar.TabIndex = 12;
            this.LbSaldoApostar.Text = "Saldo Apostar";
            // 
            // TxSaldoApostar
            // 
            this.TxSaldoApostar.Location = new System.Drawing.Point(124, 26);
            this.TxSaldoApostar.Name = "TxSaldoApostar";
            this.TxSaldoApostar.Size = new System.Drawing.Size(100, 20);
            this.TxSaldoApostar.TabIndex = 1;
            this.TxSaldoApostar.Enter += new System.EventHandler(this.TxSaldoApostar_Enter);
            this.TxSaldoApostar.Leave += new System.EventHandler(this.TxSaldoApostar_Leave);
            // 
            // BtnVolver
            // 
            this.BtnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(713, 22);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(75, 23);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // LbProGanar
            // 
            this.LbProGanar.AutoSize = true;
            this.LbProGanar.Location = new System.Drawing.Point(241, 10);
            this.LbProGanar.Name = "LbProGanar";
            this.LbProGanar.Size = new System.Drawing.Size(110, 13);
            this.LbProGanar.TabIndex = 13;
            this.LbProGanar.Text = "Probabilidad de ganar";
            // 
            // TxProGanar
            // 
            this.TxProGanar.Location = new System.Drawing.Point(241, 26);
            this.TxProGanar.Name = "TxProGanar";
            this.TxProGanar.Size = new System.Drawing.Size(100, 20);
            this.TxProGanar.TabIndex = 2;
            this.TxProGanar.Enter += new System.EventHandler(this.TxProGanar_Enter);
            this.TxProGanar.Leave += new System.EventHandler(this.TxProGanar_Leave);
            // 
            // LbCuoApuesta
            // 
            this.LbCuoApuesta.AutoSize = true;
            this.LbCuoApuesta.Location = new System.Drawing.Point(368, 10);
            this.LbCuoApuesta.Name = "LbCuoApuesta";
            this.LbCuoApuesta.Size = new System.Drawing.Size(91, 13);
            this.LbCuoApuesta.TabIndex = 14;
            this.LbCuoApuesta.Text = "Cuota de apuesta";
            // 
            // TxCuoApuesta
            // 
            this.TxCuoApuesta.Location = new System.Drawing.Point(368, 26);
            this.TxCuoApuesta.Name = "TxCuoApuesta";
            this.TxCuoApuesta.ReadOnly = true;
            this.TxCuoApuesta.Size = new System.Drawing.Size(100, 20);
            this.TxCuoApuesta.TabIndex = 5;
            // 
            // LbResultado
            // 
            this.LbResultado.AutoSize = true;
            this.LbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResultado.Location = new System.Drawing.Point(667, 54);
            this.LbResultado.Name = "LbResultado";
            this.LbResultado.Size = new System.Drawing.Size(79, 16);
            this.LbResultado.TabIndex = 9;
            this.LbResultado.Text = "Resultado";
            // 
            // CbDecimal
            // 
            this.CbDecimal.AutoSize = true;
            this.CbDecimal.Checked = true;
            this.CbDecimal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbDecimal.Location = new System.Drawing.Point(218, 53);
            this.CbDecimal.Name = "CbDecimal";
            this.CbDecimal.Size = new System.Drawing.Size(64, 17);
            this.CbDecimal.TabIndex = 3;
            this.CbDecimal.Text = "Decimal";
            this.CbDecimal.UseVisualStyleBackColor = true;
            this.CbDecimal.CheckedChanged += new System.EventHandler(this.CbDecimal_CheckedChanged);
            // 
            // CbPorcentaje
            // 
            this.CbPorcentaje.AutoSize = true;
            this.CbPorcentaje.Location = new System.Drawing.Point(305, 53);
            this.CbPorcentaje.Name = "CbPorcentaje";
            this.CbPorcentaje.Size = new System.Drawing.Size(77, 17);
            this.CbPorcentaje.TabIndex = 4;
            this.CbPorcentaje.Text = "Porcentaje";
            this.CbPorcentaje.UseVisualStyleBackColor = true;
            this.CbPorcentaje.CheckedChanged += new System.EventHandler(this.CbPorcentaje_CheckedChanged);
            // 
            // FmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.BtnVolver;
            this.ClientSize = new System.Drawing.Size(794, 472);
            this.ControlBox = false;
            this.Controls.Add(this.CbPorcentaje);
            this.Controls.Add(this.CbDecimal);
            this.Controls.Add(this.LbResultado);
            this.Controls.Add(this.LbCuoApuesta);
            this.Controls.Add(this.TxCuoApuesta);
            this.Controls.Add(this.LbProGanar);
            this.Controls.Add(this.TxProGanar);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.LbSaldoApostar);
            this.Controls.Add(this.TxSaldoApostar);
            this.Controls.Add(this.BtnApostar);
            this.Controls.Add(this.LbSaldoActual);
            this.Controls.Add(this.TxSaldoActual);
            this.Controls.Add(this.LbSaldoInicial);
            this.Controls.Add(this.TxSaldoInicial);
            this.Controls.Add(this.Grafica);
            this.Name = "FmManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apuestas Manual";
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
        private System.Windows.Forms.TextBox TxSaldoInicial;
        private System.Windows.Forms.Label LbSaldoInicial;
        private System.Windows.Forms.Label LbSaldoActual;
        private System.Windows.Forms.TextBox TxSaldoActual;
        private System.Windows.Forms.Button BtnApostar;
        private System.Windows.Forms.Label LbSaldoApostar;
        private System.Windows.Forms.TextBox TxSaldoApostar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label LbProGanar;
        private System.Windows.Forms.TextBox TxProGanar;
        private System.Windows.Forms.Label LbCuoApuesta;
        private System.Windows.Forms.TextBox TxCuoApuesta;
        private System.Windows.Forms.Label LbResultado;
        private System.Windows.Forms.CheckBox CbDecimal;
        private System.Windows.Forms.CheckBox CbPorcentaje;
    }
}

