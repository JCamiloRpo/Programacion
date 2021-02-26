using CentroMedidor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroMedidorMain
{
    public partial class FmSuscriptor : Form
    {
        public FmSuscriptor()
        {
            InitializeComponent();
            Inicializar();
        }
        //Metodo para llenar la tabla
        private void Inicializar()
        {
            TxNombre.Text = null;
            CbTipoMedidor.SelectedItem = null;
            DataTable TablaCuadrilla = new DataTable();
            TablaCuadrilla.Columns.Add("Numero Cuadrilla");
            TablaCuadrilla.Columns.Add("Medidores tipo A");
            TablaCuadrilla.Columns.Add("Medidores tipo B");
            TablaCuadrilla.Columns.Add("Medidores tipo C");
            try
            {
                //Llenar la data de cuadrilla
                for (int i = 0; i < FmInicio.GetCentro.GrupoCuadrilla1.Length; i++)
                {
                    DataRow Fila = TablaCuadrilla.NewRow();
                    Fila[0] = FmInicio.GetCentro.GrupoCuadrilla1[i].NroCuadrilla1;
                    Fila[1] = FmInicio.GetCentro.GrupoCuadrilla1[i].CantTipoA1;
                    Fila[2] = FmInicio.GetCentro.GrupoCuadrilla1[i].CantTipoB1;
                    Fila[3] = FmInicio.GetCentro.GrupoCuadrilla1[i].CantTipoC1;
                    TablaCuadrilla.Rows.Add(Fila);
                }
                //Especificar el origen de datos del DataGrip
                TbCuadrilla.DataSource = TablaCuadrilla;
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error al llenar las tablas.");
            }
        }
        //Metodo para volver al inicio
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en el boton volver.");
            }
        }
        //Metodo para instalar un medidor al un nuevo suscriptor
        private void BtnInstalar_Click(object sender, EventArgs e)
        {
            bool fin = false;
            int poc;
            Cuadrilla cua;
            Suscriptor sus;
            try
            {//Validar elecciones
                if(TbCuadrilla.SelectedRows.Count == 1 && CbTipoMedidor.SelectedIndex >= 0 && TxNombre.Text.Length > 0)
                {
                    sus = new Suscriptor(TxNombre.Text);
                    poc = TbCuadrilla.SelectedRows[0].Index; //Obtner la posicion de la cuadrilla de la tabla
                    cua = FmInicio.GetCentro.GrupoCuadrilla1[poc]; //obtener la cuadrilla de la empresa
                    FmInicio.GetCentro.Suscriptores1.Add(sus);//Poner el suscriptor en la lista
                    if (CbTipoMedidor.SelectedIndex == 0 && FmInicio.GetCentro.InventarioMedidor1.DisponibleA1 > 0) //Eleccion de medidorA
                    {
                        MedidorA medidor = FmInicio.GetCentro.InventarioMedidor1.MedidoresA1[0]; //Obtener un medidor A del inventario de la empresa
                        fin = FmInicio.GetCentro.InstalarMedidor(medidor, sus, cua);
                    }
                    else if (CbTipoMedidor.SelectedIndex == 1 && FmInicio.GetCentro.InventarioMedidor1.DisponibleB1 > 0) //Eleccion de medidorB
                    {
                        MedidorB medidor = FmInicio.GetCentro.InventarioMedidor1.MedidoresB1[0]; //Obtener un medidor B del inventario de la empresa
                        fin = FmInicio.GetCentro.InstalarMedidor(medidor, sus, cua);
                    }
                    else if(CbTipoMedidor.SelectedIndex == 2 && FmInicio.GetCentro.InventarioMedidor1.DisponibleC1 > 0)//Eleccion de medidorC
                    {
                        MedidorC medidor = FmInicio.GetCentro.InventarioMedidor1.MedidoresC1[0]; //Obtener un medidor C del inventario de la empresa
                        fin = FmInicio.GetCentro.InstalarMedidor(medidor, sus, cua);
                    }
                    if (fin) Inicializar();
                    else
                    {
                        FmInicio.GetCentro.Suscriptores1.RemoveAt(FmInicio.GetCentro.Suscriptores1.Count - 1); //Si no se pudo añadir el medidor se elimina el suscriptor de la lista
                        MessageBox.Show(null, "Intenta cambiando de cuadrilla o revice el inventario", "No se pudo realizar la instalacion");
                    }
                }
                else MessageBox.Show("Seleccione una cuadrilla, un tipo de medidor y el nombre del suscriptor");
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en el boton instalar.");
            }
        }
    }
}
