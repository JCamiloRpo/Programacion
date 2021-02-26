using CentroMedidor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace CentroMedidorMain
{
    public partial class FmInicio : Form
    {
        //Atributos como accesores con get
        public static DateTime Dia { get; set; }
        public static Centro GetCentro { get; set; }

        public FmInicio()
        {
            InitializeComponent();
            Inicializar();
        }
        //Metedo para inicializar los datos de la empresa
        private void Inicializar()
        {
            List<MedidorA> LisMedidoresA = new List<MedidorA>();
            List<MedidorB> LisMedidoresB = new List<MedidorB>();
            List<MedidorC> LisMedidoresC = new List<MedidorC>();
            List<Suscriptor> suscriptores = new List<Suscriptor>();
            Cuadrilla[] CuadrillaEmpresa = new Cuadrilla[7];
            Tecnico[] Tecnicos = new Tecnico[3];
            StreamReader arcTecnicos = new StreamReader( @"..\..\..\..\Tecnicos.txt"),
                arcSuscriptores = new StreamReader(@"..\..\..\..\Suscriptores.txt");
            string linea;
            try
            {
                Dia = DateTime.Now;
                LbDia.Text = Dia.ToShortDateString();
                //Crear MedidoresA
                for(int i = 0; i < 5; i++)
                {
                    LisMedidoresA.Add(new MedidorA());
                }
                //Crear MedidoresB
                for (int i = 0; i < 5; i++)
                {
                    LisMedidoresB.Add(new MedidorB());
                }
                //Crear MedidoresC
                for (int i = 0; i < 5; i++)
                {
                    LisMedidoresC.Add(new MedidorC());
                }
                //Crear Cuadrilla y sus tecnicos
                for(int i = 0; i < 7; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        Tecnicos[j] = new Tecnico(arcTecnicos.ReadLine());
                    }
                    CuadrillaEmpresa[i] = new Cuadrilla(Tecnicos);
                }
                arcTecnicos.Close();
                //Crear Suscriptores
                while ((linea = arcSuscriptores.ReadLine()) != null)
                {
                    suscriptores.Add(new Suscriptor(linea));
                }
                arcSuscriptores.Close();
                //Llenar empresa
                GetCentro = new Centro(new Inventario(LisMedidoresA, LisMedidoresB, LisMedidoresC), suscriptores, CuadrillaEmpresa);
                //Poner medidores a suscriptores
                GetCentro.InstalarMedidor(GetCentro.InventarioMedidor1.MedidoresA1[0], GetCentro.Suscriptores1[0], GetCentro.GrupoCuadrilla1[0]);
                GetCentro.InstalarMedidor(GetCentro.InventarioMedidor1.MedidoresB1[0], GetCentro.Suscriptores1[1], GetCentro.GrupoCuadrilla1[0]);
                GetCentro.InstalarMedidor(GetCentro.InventarioMedidor1.MedidoresC1[0], GetCentro.Suscriptores1[2], GetCentro.GrupoCuadrilla1[0]);
                
            }
            catch(IOException er)
            {
                MessageBox.Show(null, er.Message, "Error en los archivos.");
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en inicializar.");
            }
        }
        //Metodo para cerrar el programa
        private void FmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Metodo para avanzar al dia siguiente
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            try
            {
                Dia = Dia.AddDays(1);
                LbDia.Text = Dia.ToShortDateString();
                //Utilizar el metodo de la cuadrilla para que restauren el numero de instalaciones por día
                for(int i = 0; i < GetCentro.GrupoCuadrilla1.Length; i++)
                {
                    GetCentro.GrupoCuadrilla1[i].NewDia();
                }
                //Recorrer la lista de suscriptores
                foreach(Suscriptor i in GetCentro.Suscriptores1)
                {
                    //Utilizar el metodo del medidor para dañar el medidor
                    if(r.NextDouble() < 0.2)
                    {
                        if (i.MedidorTipoA1 != null) i.MedidorTipoA1.Dañar();
                        else if (i.MedidorTipoB1 != null) i.MedidorTipoB1.Dañar();
                        else i.MedidorTipoC1.Dañar();
                    }

                    //Utilizar el metodo del medidor para aumentar el consumo
                    if (i.MedidorTipoA1 != null)
                    {
                        i.MedidorTipoA1.AumentarEnergia();
                    }
                    else if (i.MedidorTipoB1 != null)
                    {
                        i.MedidorTipoB1.AumentarEnergia();
                        i.MedidorTipoB1.AumentarAgua();
                    }
                    else if (i.MedidorTipoC1 != null)
                    {
                        i.MedidorTipoC1.AumentarEnergia();
                        i.MedidorTipoC1.AumentarAgua();
                        i.MedidorTipoC1.AumentarGas();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en siguiente día.");
            }
        }
        //Metodo para abrir la ventada de informacion de suscriptores y medidores
        private void BtnMedidores_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                FmMedidor fmMedidor = new FmMedidor();
                fmMedidor.ShowDialog();
                Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en boton suscriptores con medidor.");
            }
        }
        //Metodo para abrir la ventana de agregar suscriptor
        private void BtnAddSuscriptor_Click(object sender, EventArgs e)
        {
            try
            {
                FmSuscriptor fmSuscriptor = new FmSuscriptor();
                Hide();
                fmSuscriptor.ShowDialog();
                Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en boton agregar suscriptor.");
            }
        }
        //Metodo para abrir la ventana del inventario
        private void BtnInventario_Click(object sender, EventArgs e)
        {
            try
            {
                FmInventario fmInventario = new FmInventario();
                Hide();
                fmInventario.ShowDialog();
                Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en boton consultar inventario.");
            }
        }
    }
}
