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
    public partial class FmMedidor : Form
    {
        public FmMedidor()
        {
            InitializeComponent();
            Inicializar();
        }
        //Metodo para llenar las tablas
        private void Inicializar()
        {
            CbTipoMedidor.SelectedItem = null;
            DataTable TablaSuscriptores = new DataTable(), TablaCuadrilla = new DataTable();
            TablaSuscriptores.Columns.Add("Suscriptor");
            TablaSuscriptores.Columns.Add("Medidor");
            TablaSuscriptores.Columns.Add("Consumo Energia");
            TablaSuscriptores.Columns.Add("Consumo Agua");
            TablaSuscriptores.Columns.Add("Consumo Gas");
            TablaSuscriptores.Columns.Add("Activo");
            TablaSuscriptores.Columns.Add("Funcional");
            TablaSuscriptores.Columns.Add("Saldo");
            TablaCuadrilla.Columns.Add("Numero Cuadrilla");
            TablaCuadrilla.Columns.Add("Medidores tipo A");
            TablaCuadrilla.Columns.Add("Medidores tipo B");
            TablaCuadrilla.Columns.Add("Medidores tipo C");
            try
            {
                //Llenar la tabla de suscriptores
                foreach (Suscriptor i in FmInicio.GetCentro.Suscriptores1)
                {
                    DataRow Fila = TablaSuscriptores.NewRow();
                    Fila[0] = i.Nombre1;
                    if (i.MedidorTipoA1 != null)
                    {
                        Fila[1] = "Tipo " + i.MedidorTipoA1.Tipo1;
                        Fila[2] = i.MedidorTipoA1.ConsumoEnergia1;
                        Fila[3] = "N/A";
                        Fila[4] = "N/A";
                        Fila[5] = i.MedidorTipoA1.Activo1;
                        Fila[6] = i.MedidorTipoA1.Funcional1;
                        Fila[7] = string.Format("{0:C}", i.MedidorTipoA1.Saldo1);
                    }
                    else if (i.MedidorTipoB1 != null)
                    {
                        Fila[1] = "Tipo " + i.MedidorTipoB1.Tipo1;
                        Fila[2] = i.MedidorTipoB1.ConsumoEnergia1;
                        Fila[3] = i.MedidorTipoB1.ConsumoAgua1;
                        Fila[4] = "N/A";
                        Fila[5] = i.MedidorTipoB1.Activo1;
                        Fila[6] = i.MedidorTipoB1.Funcional1;
                        Fila[7] = string.Format("{0:C}", i.MedidorTipoB1.Saldo1);
                    }
                    else
                    {
                        Fila[1] = "Tipo " + i.MedidorTipoC1.Tipo1;
                        Fila[2] = i.MedidorTipoC1.ConsumoEnergia1;
                        Fila[3] = i.MedidorTipoC1.ConsumoAgua1;
                        Fila[4] = i.MedidorTipoC1.ConsumoGas1;
                        Fila[5] = i.MedidorTipoC1.Activo1;
                        Fila[6] = i.MedidorTipoC1.Funcional1;
                        Fila[7] = string.Format("{0:C}", i.MedidorTipoC1.Saldo1);
                    }

                    TablaSuscriptores.Rows.Add(Fila);
                }
                //Llenar la data de cuadrilla
                for(int i = 0; i < FmInicio.GetCentro.GrupoCuadrilla1.Length; i++)
                {
                    DataRow Fila = TablaCuadrilla.NewRow();
                    Fila[0] = FmInicio.GetCentro.GrupoCuadrilla1[i].NroCuadrilla1;
                    Fila[1] = FmInicio.GetCentro.GrupoCuadrilla1[i].CantTipoA1;
                    Fila[2] = FmInicio.GetCentro.GrupoCuadrilla1[i].CantTipoB1;
                    Fila[3] = FmInicio.GetCentro.GrupoCuadrilla1[i].CantTipoC1;
                    TablaCuadrilla.Rows.Add(Fila);
                }
                //Especificar el origen de datos de ambos DataGrip
                TbSuscriptores.DataSource = TablaSuscriptores;
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
            catch(Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en el boton volver.");
            }
        }
        //Metodo para validar que se pueda facturar
        private void FmMedidor_Load(object sender, EventArgs e)
        {
            try
            {
                //Verificar que sea el fin del mes para poder facturar
                if (FmInicio.Dia.Day >= 30) BtnFacturar.Enabled = true;
                else BtnFacturar.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error al cargar la ventana.");
            }
        }
        //Metodo para facturar un suscriptor
        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            int pos;
            Suscriptor sus;
            try
            {//Validar eleccion
                if (TbSuscriptores.SelectedRows.Count == 1)
                {
                    pos = TbSuscriptores.SelectedRows[0].Index;//Obtener la posicion del suscriptor de la tabla
                    sus = FmInicio.GetCentro.Suscriptores1[pos]; //Obtener el suscriptor de la lista
                    FmInicio.GetCentro.Facturar(sus);
                    Inicializar();
                }
                else MessageBox.Show("Debe seleccionar un suscriptor");
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en el boton facturar.");
            }
        }
        //Metodo para reparar un medidor
        private void BtnReparar_Click(object sender, EventArgs e)
        {
            int pos;
            Suscriptor sus;
            try
            { //Validar eleccion
                if (TbSuscriptores.SelectedRows.Count == 1)
                {
                    pos = TbSuscriptores.SelectedRows[0].Index;//Obtener la posicion del suscriptor de la tabla
                    sus = FmInicio.GetCentro.Suscriptores1[pos]; //Obtener el suscriptor de la lista
                    FmInicio.GetCentro.RepararMedidor(sus);
                    Inicializar();
                }
                else MessageBox.Show("Debe seleccionar un suscriptor");
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en el boton reparar.");
            }
        }
        //Metodo para desconectar un medidor
        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            int pos;
            Suscriptor sus;
            try
            {//Validar la eleccion
                if (TbSuscriptores.SelectedRows.Count == 1)
                {
                    pos = TbSuscriptores.SelectedRows[0].Index;//Obtener la posicion del suscriptor de la tabla
                    sus = FmInicio.GetCentro.Suscriptores1[pos]; //Obtener el suscriptor de la lista
                    FmInicio.GetCentro.DesconectarServicio(sus);
                    Inicializar();
                }
                else MessageBox.Show("Debe seleccionar un suscriptor");
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en el boton desconectar.");
            }
        }
        //Metodo para conectar un medidor
        private void BtnConectar_Click(object sender, EventArgs e)
        {
            int pos;
            Suscriptor sus;
            try
            {
                //Validar la eleccion
                if (TbSuscriptores.SelectedRows.Count == 1)
                {
                    pos = TbSuscriptores.SelectedRows[0].Index; //Obtener la posicion del suscriptor de la tabla
                    sus = FmInicio.GetCentro.Suscriptores1[pos]; //Obtener el suscriptor de la lista
                    FmInicio.GetCentro.ConectarServicio(sus);
                    Inicializar();
                }
                else MessageBox.Show("Debe seleccionar un suscriptor");
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en el boton conectar.");
            }
        }
        //Metodo para cambiar un medidor
        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            int pos, poc;
            long saldo;
            Suscriptor sus;
            Cuadrilla cua;
            bool fin = false;
            try
            {
                //Validar las elecciones
                if (TbSuscriptores.SelectedRows.Count == 1 && TbCuadrilla.SelectedRows.Count == 1 && CbTipoMedidor.SelectedIndex >= 0)
                {
                    pos = TbSuscriptores.SelectedRows[0].Index; //Obtener la posicion del suscriptor de la tabla
                    poc = TbCuadrilla.SelectedRows[0].Index; //Obtner la posicion de la cuadrilla de la tabla
                    sus = FmInicio.GetCentro.Suscriptores1[pos]; //Obtener el suscriptor de la lista
                    cua = FmInicio.GetCentro.GrupoCuadrilla1[poc]; //obtener la cuadrilla de la empresa
                    if (sus.MedidorTipoA1 != null) saldo = sus.MedidorTipoA1.Saldo1;
                    else if (sus.MedidorTipoB1 != null) saldo = sus.MedidorTipoB1.Saldo1;
                    else saldo = sus.MedidorTipoC1.Saldo1;
                    if (saldo == 0) //Validar que no tenga saldo pendiente
                    {
                        if (CbTipoMedidor.SelectedIndex == 0 && FmInicio.GetCentro.InventarioMedidor1.DisponibleA1 > 0) //Eleccion de medidorA
                        {
                            MedidorA medidor = FmInicio.GetCentro.InventarioMedidor1.MedidoresA1[0]; //Obtener un medidor A del inventario de la empresa
                            fin = FmInicio.GetCentro.CambiarMedidor(medidor, sus, cua);
                        }
                        else if (CbTipoMedidor.SelectedIndex == 1 && FmInicio.GetCentro.InventarioMedidor1.DisponibleB1 > 0) //Eleccion de medidorB
                        {
                            MedidorB medidor = FmInicio.GetCentro.InventarioMedidor1.MedidoresB1[0]; //Obtener un medidor B del inventario de la empresa
                            fin = FmInicio.GetCentro.CambiarMedidor(medidor, sus, cua);
                        }
                        else if(CbTipoMedidor.SelectedIndex == 2 && FmInicio.GetCentro.InventarioMedidor1.DisponibleC1 > 0) //Eleccion de medidorC
                        {
                            MedidorC medidor = FmInicio.GetCentro.InventarioMedidor1.MedidoresC1[0]; //Obtener un medidor C del inventario de la empresa
                            fin = FmInicio.GetCentro.CambiarMedidor(medidor, sus, cua);
                        }
                        if (fin) Inicializar();
                        else MessageBox.Show(null, "Intenta cambiando de cuadrilla o revice el inventario", "No se pudo realizar el cambio de medidor");
                    }
                    else MessageBox.Show("El suscriptor no debe tener saldo pendiente.");
                }
                else MessageBox.Show("Debe seleccionar un suscriptor, una cuadrilla y un tipo de medidor.");
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er+"", "Error en el boton cambiar.");
            }
        }
    }
}
