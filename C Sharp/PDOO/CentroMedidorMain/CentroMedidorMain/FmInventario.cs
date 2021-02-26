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
    public partial class FmInventario : Form
    {

        public FmInventario()
        {
            InitializeComponent();
            Inicializar();
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
        //Metodo para agregar los datos a la tabla
        private void Inicializar()
        {
            CbTipoMedidor.SelectedIndex = -1;
            TxCantidad.Text = null;
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("Medidor");
            Tabla.Columns.Add("Disponibles");
            try
            {
                DataRow Fila = Tabla.NewRow();
                Fila[0] = "Tipo A";
                Fila[1] = FmInicio.GetCentro.InventarioMedidor1.DisponibleA1;
                Tabla.Rows.Add(Fila);
                Fila = Tabla.NewRow();
                Fila[0] = "Tipo B";
                Fila[1] = FmInicio.GetCentro.InventarioMedidor1.DisponibleB1;
                Tabla.Rows.Add(Fila);
                Fila = Tabla.NewRow();
                Fila[0] = "Tipo C";
                Fila[1] = FmInicio.GetCentro.InventarioMedidor1.DisponibleC1;
                Tabla.Rows.Add(Fila);

                TbInventario.DataSource = Tabla;
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en inicializar.");
            }
        }
        //Metodo para agregar un nuevo medidor al inventario de la empresa
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int cant = (int)Convert.ToInt32(TxCantidad.Text);
                if (CbTipoMedidor.SelectedIndex >= 0 && cant > 0)
                {
                    for (int i = 0; i < cant; i++)
                    {
                        if (CbTipoMedidor.SelectedIndex == 0) FmInicio.GetCentro.InventarioMedidor1.AddMedidor(new MedidorA());
                        else if (CbTipoMedidor.SelectedIndex == 1) FmInicio.GetCentro.InventarioMedidor1.AddMedidor(new MedidorB());
                        else FmInicio.GetCentro.InventarioMedidor1.AddMedidor(new MedidorC());
                    }
                    Inicializar();
                }
                else MessageBox.Show("Debe selecionar un medidor para agregar y la cantidad debe ser mayor de cero.");
            }
            catch (Exception er)
            {
                MessageBox.Show(null, er.Message, "Error en el boton agregar.");
            }
        }
    }
}
