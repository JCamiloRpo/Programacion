using System;
using System.Drawing;
using System.Windows.Forms;

namespace Apuestas
{
    public partial class FmManual : Form
    {
        private int Nro;
        public FmManual()
        {
            InitializeComponent();
            Inicializar();
        }
        //Metodo para inicializar todas las cajas de texto y la grafica
        private void Inicializar()
        {
            try
            {
                TxSaldoActual.Text = string.Format("{0:C}", 0);
                TxSaldoApostar.Text = string.Format("{0:C}", 0);
                TxSaldoInicial.Text = string.Format("{0:C}", 0);
                TxCuoApuesta.Text = 0 + "";
                TxProGanar.Text = 0 + "";
                Nro = 0;
                LbResultado.ForeColor = Color.Black;
                LbResultado.Text = "Resultado";
                Grafica.Series[0].Points.Clear();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error." + e.Message);
            }
        }
        //Metodo para volver al menú principal
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
        //Metodo para realizar la apuesta
        private void BtnApostar_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                double Apostar = Convert.ToDouble(TxSaldoApostar.Text.Replace("$", "")), CA = Convert.ToDouble(TxCuoApuesta.Text),
                    Actual = Convert.ToDouble(TxSaldoActual.Text.Replace("$", "")), VG = 0, g= r.NextDouble();
                //Validar los campos de textos
                if (Apostar > 0 && Actual > 0 && CA > 0)
                {
                    if (g <= (1d / CA))//Validar si ganó con el numero aleatorio generado con la probabilidad de ganar
                    {
                        LbResultado.ForeColor = Color.Green;
                        Text = "¡FELICIDADES!";
                        LbResultado.Text = "¡GANÓ!";
                        VG = Apostar * CA;
                    }
                    else
                    {
                        LbResultado.ForeColor = Color.Red;
                        Text = "¡SUERTE PARA LA PROXIMA!";
                        LbResultado.Text = "¡PERDIÓ!";
                    }
                    Nro++; //Aumentar el numero de apuesta
                    Actual = Actual - Apostar + VG; //Calcular el nuevo saldo
                    TxSaldoActual.Text = string.Format("{0:C}", Actual);
                    Grafica.Series[0].Points.AddXY(Nro, Actual); //Añadir punto
                }
                else MessageBox.Show(null,"Revise que el saldo inicial, el saldo apostar y la probabilidad sea mayor que cero.","No es posible apostar");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }
        //Validar que la probabilidad de ganar sea valida
        private void TxProGanar_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxProGanar.Text.Equals("")) TxProGanar.Text = string.Format("{0:C}", 0);
                else
                {
                    double PG = Convert.ToDouble(TxProGanar.Text), CA = 0;
                    if (CbDecimal.Checked)
                    {
                        if (PG > 0 && PG < 1) CA = 1d / PG; //Calcular cuota
                        else
                        {
                            TxProGanar.Focus();
                            MessageBox.Show("La probabilidad de ganar en decimal debe ser mayor de cero y menor de 1");
                        }
                    }
                    else
                    {
                        if ((int)PG > 0 && (int)PG < 100) CA = 1d / (PG * 0.01);
                        else
                        {
                            TxProGanar.Focus();
                            MessageBox.Show("La probabilidad de ganar en procentaje debe ser mayor que 0 y menor que 100.");
                        }
                    }
                    TxProGanar.Text = Convert.ToDouble(TxProGanar.Text) + "";
                    TxCuoApuesta.Text = CA + "";
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
                TxProGanar.Focus();
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
                        TxSaldoActual.Text = string.Format("{0:C}", Saldo);
                        Grafica.Series[0].Points.AddXY(Nro, Saldo);
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
        //Validar el saldo para apostar
        private void TxSaldoApostar_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxSaldoApostar.Text.Equals("")) TxSaldoApostar.Text = string.Format("{0:C}", 0);
                else
                {
                    double Apostar = Convert.ToDouble(TxSaldoApostar.Text), Saldo = Convert.ToDouble(TxSaldoInicial.Text.Replace("$", ""));
                    if (Apostar > 0 && Apostar <= Saldo && (Apostar % 50) == 0) TxSaldoApostar.Text = string.Format("{0:C}", Apostar);
                    else
                    {
                        TxSaldoApostar.Focus();
                        MessageBox.Show("El saldo a postar debe ser mayor de cero y menor o igual al saldo actual además debe ser multipo de 50.");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
                TxSaldoApostar.Focus();
            }
        }
        //Metodo para mostrar la caja de texto de una mejor manera
        private void TxSaldoInicial_Enter(object sender, EventArgs e)
        {
            try
            {
                bool cam = false;
                if (Convert.ToInt64(TxSaldoApostar.Text.Replace("$", "")) > 0)
                {
                    if (MessageBox.Show(null, "Si cambia el saldo inicial se reiniciarán todas las apuestas.", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes) cam = true;
                }
                else cam = true;
                if (cam)
                {
                    Inicializar();
                   if (Convert.ToInt64(TxSaldoInicial.Text.Replace("$", "")) > 0) TxSaldoInicial.Text = TxSaldoInicial.Text.Replace("$", "");
                   else TxSaldoInicial.Text = "";
                }
                else Grafica.Focus();
            }
            catch(Exception er)
            {
                MessageBox.Show("Error. "+er.Message);
            }
        }
        //Metodo para mostrar la caja de texto de una mejor manera
        private void TxSaldoApostar_Enter(object sender, EventArgs e)
        {
            try
            {
                if (TxSaldoInicial.Text.Replace("$", "").Equals("0")) TxSaldoInicial.Focus();
                else
                {
                     if (Convert.ToInt64(TxSaldoApostar.Text.Replace("$", "")) > 0) TxSaldoApostar.Text = TxSaldoApostar.Text.Replace("$", "");
                     else TxSaldoApostar.Text = "";
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Metodo para mostrar mejor
        private void TxProGanar_Enter(object sender, EventArgs e)
        {
            try
            {
                if (TxProGanar.Text.Equals("0")) TxProGanar.Text = "";
            }
            catch(Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Controlar eleccion
        private void CbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbDecimal.Checked) CbPorcentaje.Checked = false;
                else CbPorcentaje.Checked = true;
                TxProGanar.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
        //Controlar eleccion
        private void CbPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbPorcentaje.Checked) CbDecimal.Checked = false;
                else CbDecimal.Checked = true;
                TxProGanar.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error. " + er.Message);
            }
        }
    }
}
