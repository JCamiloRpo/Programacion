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
    public partial class FmInicio : Form
    {
        public FmInicio()
        {
            InitializeComponent();
        }

        private void BtnManual_Click(object sender, EventArgs e)
        {
            this.Hide();
            FmManual fmManual = new FmManual();
            fmManual.Show();
        }

        private void BtnAutomatica_Click(object sender, EventArgs e)
        {
            this.Hide();
            FmAutomatico fmAutomatico = new FmAutomatico();
            fmAutomatico.Show();
        }

        private void FmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
