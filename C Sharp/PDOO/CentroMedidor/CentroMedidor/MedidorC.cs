using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedidor
{
    public class MedidorC : MedidorB
    {
        private float ConsumoGas;
        
        public MedidorC() : base()
        {
            Tipo = 'C';
        }

        public float ConsumoGas1 { get => ConsumoGas; }

        public void AumentarGas()
        {
            Random r = new Random(NroMedidor+2);
            double G = r.NextDouble();
            ConsumoGas += (float)G;
            Saldo += (long)(500 * G);
        }

        public void ClearGas()
        {
            ConsumoGas = 0;
        }
    }
}
