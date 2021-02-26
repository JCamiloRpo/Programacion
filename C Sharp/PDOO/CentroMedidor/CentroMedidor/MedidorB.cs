using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedidor
{
    public class MedidorB : MedidorA
    {
        protected float ConsumoAgua;

        public MedidorB() : base()
        {
            Tipo = 'B';
        }

        public float ConsumoAgua1 { get => ConsumoAgua; }

        public void AumentarAgua()
        {
            Random r = new Random(NroMedidor+1);
            double A = r.NextDouble();
            ConsumoAgua += (float)A;
            Saldo += (long)(1500 * A);
        }
        
        public void ClearAgua()
        {
            ConsumoAgua = 0;
        }
    }
}
