using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedidor
{
    public class MedidorA
    {
        protected float ConsumoEnergia;
        protected bool Funcional;
        protected bool Activo;
        protected int NroMedidor;
        protected char Tipo;
        protected long Saldo = 0;
        private static int IdMedidor=0;

        public MedidorA()
        {
            NroMedidor = IdMedidor;
            IdMedidor++;
            Funcional = true;
            Activo = true;
            Tipo = 'A';
        }

        public float ConsumoEnergia1 { get => ConsumoEnergia; }
        public bool Funcional1 { get => Funcional; }
        public bool Activo1 { get => Activo; }
        public int NroMedidor1 { get => NroMedidor; }
        public char Tipo1 { get => Tipo; }
        public long Saldo1 { get => Saldo; }

        public void Dañar()
        {
            Funcional = false;
        }

        public void Reparar()
        {
            Funcional = true;
        }

        public void Desconectar()
        {
            Activo = false;
        }

        public void Conectar()
        {
            Activo = true;
        }

        public void AumentarEnergia()
        {
            Random r = new Random(NroMedidor);
            double E = r.NextDouble();
            ConsumoEnergia += (float)E;
            Saldo += (long)(1000 * E);
        }
        
        public void ClearEnergia()
        {
            ConsumoEnergia = 0;
            Saldo = 0;
        }
        
    }
}
