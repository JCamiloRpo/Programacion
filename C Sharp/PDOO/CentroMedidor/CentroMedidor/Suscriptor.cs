using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedidor
{
    public class Suscriptor : Persona
    {
        private MedidorA MedidorTipoA;
        private MedidorB MedidorTipoB;
        private MedidorC MedidorTipoC;
        private int NroSuscriptor;
        private static int IdSuscriptor = 0;
        public Suscriptor(string nombre) : base(nombre)
        {
            MedidorTipoA = new MedidorA();
            MedidorTipoB = new MedidorB();
            MedidorTipoC = new MedidorC();
            NroSuscriptor = IdSuscriptor;
            IdSuscriptor++;
        }

        public MedidorA MedidorTipoA1 { get => MedidorTipoA; }
        public MedidorB MedidorTipoB1 { get => MedidorTipoB; }
        public MedidorC MedidorTipoC1 { get => MedidorTipoC; }
        public int NroSuscriptor1 { get => NroSuscriptor; }

        public void NewMedidor(MedidorA medidor)
        {
            MedidorTipoA = medidor ?? throw new ArgumentNullException(nameof(medidor));
            MedidorTipoB = null;
            MedidorTipoC = null;
        }

        public void NewMedidor(MedidorB medidor)
        {
            MedidorTipoB = medidor ?? throw new ArgumentNullException(nameof(medidor));
            MedidorTipoA = null;
            MedidorTipoC = null;
        }

        public void NewMedidor(MedidorC medidor)
        {
            MedidorTipoC = medidor ?? throw new ArgumentNullException(nameof(medidor));
            MedidorTipoA = null;
            MedidorTipoB = null;
        }

        public void Pagar()
        {
            if (MedidorTipoA != null) MedidorTipoA.ClearEnergia();
            else if(MedidorTipoB != null)
            {
                MedidorTipoB.ClearEnergia();
                MedidorTipoB.ClearAgua();
            }
            else
            {
                MedidorTipoC.ClearEnergia();
                MedidorTipoC.ClearAgua();
                MedidorTipoC.ClearGas();
            }
        }
    }
}
