namespace Apuestas
{
    partial class FmAutomatico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LbSaldoInicial = new System.Windows.Forms.Label();
            this.TxNroApuestas = new System.Windows.Forms.TextBox();
            this.Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CbEstConservadora = new System.Windows.Forms.CheckBox();
            this.CbEstArriesgada = new System.Windows.Forms.CheckBox();
            this.CbEstDerrochadora = new System.Windows.Forms.CheckBox();
            this.CbEstEconomizadora = new System.Windows.Forms.CheckBox();
            this.LbProGanar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbVA = new System.Windows.Forms.Label();
            this.LbPG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxSaldoInicial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(721, 30);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(75, 23);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(721, 4);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 7;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // LbSaldoInicial
            // 
            this.LbSaldoInicial.AutoSize = true;
            this.LbSaldoInicial.Location = new System.Drawing.Point(111, 12);
            this.LbSaldoInicial.Name = "LbSaldoInicial";
            this.LbSaldoInicial.Size = new System.Drawing.Size(105, 13);
            this.LbSaldoInicial.TabIndex = 10;
            this.LbSaldoInicial.Text = "Numero de apuestas";
            // 
            // TxNroApuestas
            // 
            this.TxNroApuestas.Location = new System.Drawing.Point(111, 28);
            this.TxNroApuestas.Name = "TxNroApuestas";
            this.TxNroApuestas.Size = new System.Drawing.Size(100, 20);
            this.TxNroApuestas.TabIndex = 0;
            this.TxNroApuestas.Enter += new System.EventHandler(this.TxNroApuestas_Enter);
            this.TxNroApuestas.Leave += new System.EventHandler(this.TxNroApuestas_Leave);
            // 
            // Grafica
            // 
            chartArea4.AxisX.Title = "# Apuesta";
            chartArea4.AxisY.Title = "Saldo";
            chartArea4.Name = "ChartArea1";
            this.Grafica.ChartAreas.Add(chartArea4);
            this.Grafica.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend4.Name = "Legend1";
            this.Grafica.Legends.Add(legend4);
            this.Grafica.Location = new System.Drawing.Point(0, 69);
            this.Grafica.Name = "Grafica";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "SaldoVsApuesta";
            this.Grafica.Series.Add(series4);
            this.Grafica.Size = new System.Drawing.Size(800, 381);
            this.Grafica.TabIndex = 0;
            this.Grafica.Text = "Grafica";
            // 
            // CbEstConservadora
            // 
            this.CbEstConservadora.AutoSize = true;
            this.CbEstConservadora.Location = new System.Drawing.Point(334, 10);
            this.CbEstConservadora.Name = "CbEstConservadora";
            this.CbEstConservadora.Size = new System.Drawing.Size(142, 17);
            this.CbEstConservadora.TabIndex = 2;
            this.CbEstConservadora.Text = "Estrategia Conservadora";
            this.CbEstConservadora.UseVisualStyleBackColor = true;
            this.CbEstConservadora.CheckedChanged += new System.EventHandler(this.CbEstConservadora_CheckedChanged);
            // 
            // CbEstArriesgada
            // 
            this.CbEstArriesgada.AutoSize = true;
            this.CbEstArriesgada.Location = new System.Drawing.Point(334, 34);
            this.CbEstArriesgada.Name = "CbEstArriesgada";
            this.CbEstArriesgada.Size = new System.Drawing.Size(126, 17);
            this.CbEstArriesgada.TabIndex = 3;
            this.CbEstArriesgada.Text = "Estrategia Arriesgada";
            this.CbEstArriesgada.UseVisualStyleBackColor = true;
            this.CbEstArriesgada.CheckedChanged += new System.EventHandler(this.CbEstArriesgada_CheckedChanged);
            // 
            // CbEstDerrochadora
            // 
            this.CbEstDerrochadora.AutoSize = true;
            this.CbEstDerrochadora.Location = new System.Drawing.Point(566, 34);
            this.CbEstDerrochadora.Name = "CbEstDerrochadora";
            this.CbEstDerrochadora.Size = new System.Drawing.Size(141, 17);
            this.CbEstDerrochadora.TabIndex = 6;
            this.CbEstDerrochadora.Text = "Estrategia Derrochadora";
            this.CbEstDerrochadora.UseVisualStyleBackColor = true;
            this.CbEstDerrochadora.CheckedChanged += new System.EventHandler(this.CbEstDerrochadora_CheckedChanged);
            // 
            // CbEstEconomizadora
            // 
            this.CbEstEconomizadora.AutoSize = true;
            this.CbEstEconomizadora.Location = new System.Drawing.Point(566, 10);
            this.CbEstEconomizadora.Name = "CbEstEconomizadora";
            this.CbEstEconomizadora.Size = new System.Drawing.Size(149, 17);
            this.CbEstEconomizadora.TabIndex = 5;
            this.CbEstEconomizadora.Text = "Estrategia Economizadora";
            this.CbEstEconomizadora.UseVisualStyleBackColor = true;
            this.CbEstEconomizadora.CheckedChanged += new System.EventHandler(this.CbEstEconomizadora_CheckedChanged);
            // 
            // LbProGanar
            // 
            this.LbProGanar.AutoSize = true;
            this.LbProGanar.Location = new System.Drawing.Point(216, 14);
            this.LbProGanar.Name = "LbProGanar";
            this.LbProGanar.Size = new System.Drawing.Size(110, 13);
            this.LbProGanar.TabIndex = 1;
            this.LbProGanar.Text = "Probabilidad de ganar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor apostado";
            // 
            // LbVA
            // 
            this.LbVA.AutoSize = true;
            this.LbVA.Location = new System.Drawing.Point(507, 31);
            this.LbVA.Name = "LbVA";
            this.LbVA.Size = new System.Drawing.Size(0, 13);
            this.LbVA.TabIndex = 11;
            // 
            // LbPG
            // 
            this.LbPG.AutoSize = true;
            this.LbPG.Location = new System.Drawing.Point(259, 31);
            this.LbPG.Name = "LbPG";
            this.LbPG.Size = new System.Drawing.Size(0, 13);
            this.LbPG.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Saldo Inicial";
            // 
            // TxSaldoInicial
            // 
            this.TxSaldoInicial.Location = new System.Drawing.Point(5, 28);
            this.TxSaldoInicial.Name = "TxSaldoInicial";
            this.TxSaldoInicial.Size = new System.Drawing.Size(100, 20);
            this.TxSaldoInicial.TabIndex = 0;
            this.TxSaldoInicial.Enter += new System.EventHandler(this.TxSaldoInicial_Enter);
            this.TxSaldoInicial.Leave += new System.EventHandler(this.TxSaldoInicial_Leave);
            // 
            // FmAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.BtnVolver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxSaldoInicial);
            this.Controls.Add(this.LbPG);
            this.Controls.Add(this.LbVA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbProGanar);
            this.Controls.Add(this.CbEstDerrochadora);
            this.Controls.Add(this.CbEstEconomizadora);
            this.Controls.Add(this.CbEstArriesgada);
            this.Controls.Add(this.CbEstConservadora);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.LbSaldoInicial);
            this.Controls.Add(this.TxNroApuestas);
            this.Controls.Add(this.Grafica);
            this.Controls.Add(this.BtnVolver);
            this.Name = "FmAutomatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apuestas automatica";
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label LbSaldoInicial;
        private System.Windows.Forms.TextBox TxNroApuestas;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
        private System.Windows.Forms.CheckBox CbEstConservadora;
        private System.Windows.Forms.CheckBox CbEstArriesgada;
        private System.Windows.Forms.CheckBox CbEstDerrochadora;
        private System.Windows.Forms.CheckBox CbEstEconomizadora;
        private System.Windows.Forms.Label LbProGanar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbVA;
        private System.Windows.Forms.Label LbPG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxSaldoInicial;
    }
}