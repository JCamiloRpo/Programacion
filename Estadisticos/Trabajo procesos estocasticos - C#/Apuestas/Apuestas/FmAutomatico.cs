using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apuestas
{
    public partial class FmAutomatico : Form
    {
        public FmAutomatico()
        {
            InitializeComponent();
            Inicializar();
        }
        //Para volver al inicio
        private void Inicializar()
        {
            TxNroApuestas.Text = 0 + "";
            TxSaldoInicial.Text = string.Format("{0:C}", 0);
            Grafica.Series[0].Points.Clear();
            LbPG.ForeColor = Color.DarkGray;
            LbVA.ForeColor = Color.DarkGray;
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                FmInicio fmInicio = new FmInicio();
                fmInicio.Show();
            }
            catch(Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Metodo para mostrar mas agradable
        private void TxNroApuestas_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt64(TxNroApuestas.Text) == 0) TxNroApuestas.Text = "";
            }
            catch(Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Metodo para validar el numero de apuesta
        private void TxNroApuestas_Leave(object sender, EventArgs e)
        {
            
            try
            {
                if (TxNroApuestas.Text.Equals("")) TxNroApuestas.Text = 0 + "";
                else
                {
                    if (Convert.ToInt64(TxNroApuestas.Text) > 0) TxNroApuestas.Text = Convert.ToInt64(TxNroApuestas.Text) + "";
                    else
                    {
                        MessageBox.Show("El numero de apuesta debe ser mayor que 0.");
                        TxNroApuestas.Focus();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Controlar la eleccion
        private void CbEstConservadora_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbEstConservadora.Checked) CbEstArriesgada.Checked = false;
                else CbEstArriesgada.Checked = true;
            }
            catch(Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Controlar la eleccion
        private void CbEstArriesgada_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbEstArriesgada.Checked) CbEstConservadora.Checked = false;
                else CbEstConservadora.Checked = true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Controlar la eleccion
        private void CbEstEconomizadora_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbEstEconomizadora.Checked) CbEstDerrochadora.Checked = false;
                else CbEstDerrochadora.Checked = true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Controlar eleccion
        private void CbEstDerrochadora_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbEstDerrochadora.Checked) CbEstEconomizadora.Checked = false;
                else CbEstEconomizadora.Checked = true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //iniciar la simulacion
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                Grafica.Series[0].Points.Clear();
                long Inicial = (long)Convert.ToDouble(TxSaldoInicial.Text.Replace("$","")), n = Convert.ToInt64(TxNroApuestas.Text), VA, S;
                Random pg = new Random(), va = new Random(), r = new Random();
                double CA, PG, R;
                if (Inicial > 0 && (CbEstConservadora.Checked || CbEstArriesgada.Checked) && (CbEstEconomizadora.Checked || CbEstDerrochadora.Checked) && n > 0)
                {
                    S = Inicial;
                    //Calcular la probabilidad y la cuota de apuesta
                    if (CbEstConservadora.Checked)PG = pg.Next(60, 100) / 100d;
                    else PG = pg.Next(0, 20) / 100d;
                    CA = 1d / PG;
                    LbPG.Text = PG + "";
                    //Calcular el valor apostar
                    if (CbEstEconomizadora.Checked) VA = (long)((va.Next(0, 30) / 100d) * Inicial);
                    else VA = (long)((va.Next(60, 100) / 100d) * Inicial);
                    LbVA.Text = string.Format("{0:C}", VA);
                    //Simular las n apuestas
                    Grafica.Series[0].Points.AddXY(0, Inicial);
                    for (int i = 0; i < n; i++)
                    {
                        R = r.NextDouble();
                        if (R <= PG) S = S - VA + (long)(VA * CA);
                        else S = S - VA;
                        Grafica.Series[0].Points.AddXY(i + 1, S);
                    }
                    if(S > Inicial) MessageBox.Show(null, "Acaba de ganar " + string.Format("{0:C}", S - Inicial ),"¡FELICIDADES!");
                    else if(S < Inicial) MessageBox.Show(null, "Acaba de perder " + string.Format("{0:C}", Inicial - S), "¡SUERTE PARA LA PROXIMA!");
                    else MessageBox.Show(null, "No ganó ni perdió nada ", "¡SIGUE INTENTANDO!");
                }
                else MessageBox.Show("Seleccione las estrategias y/o el numero de apuestas, y también el saldo inicial.");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Metodo para mostrar la caja de texto de una mejor manera
        private void TxSaldoInicial_Enter(object sender, EventArgs e)
        {
            try
            {
                Inicializar();
                if (Convert.ToInt64(TxSaldoInicial.Text.Replace("$", "")) > 0) TxSaldoInicial.Text = TxSaldoInicial.Text.Replace("$", "");
                else TxSaldoInicial.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Validar el saldo inicial ingresado
        private void TxSaldoInicial_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxSaldoInicial.Text.Equals("")) TxSaldoInicial.Text = string.Format("{0:C}", 0);
                else
                {
                    double Saldo = Convert.ToDouble(TxSaldoInicial.Text);
                    if (Saldo > 0 && (Saldo % 50) == 0)
                    {
                        TxSaldoInicial.Text = string.Format("{0:C}", Saldo);
                        Grafica.Series[0].Points.AddXY(0, Saldo);
                    }
                    else
                    {
                        TxSaldoInicial.Focus();
                        MessageBox.Show("El saldo inicial debe ser mayor de cero y multipo de 50.");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
                TxSaldoInicial.Focus();
            }
        }
    }
}
