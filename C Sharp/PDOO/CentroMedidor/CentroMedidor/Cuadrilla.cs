using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedidor
{
    public class Cuadrilla
    {
        private Tecnico[] GrupoTecnico = new Tecnico[3];
        private int CantTipoA;
        private int CantTipoB;
        private int CantTipoC;
        private static int CantMaxA = 5;
        private static int CantMaxB = 3;
        private static int CantMaxC = 2;
        private int NroCuadrilla;
        private static int IdCuadrilla = 0;

        public Cuadrilla(Tecnico[] grupoTecnico)
        {
            GrupoTecnico = grupoTecnico ?? throw new ArgumentNullException(nameof(grupoTecnico));
            NroCuadrilla = IdCuadrilla;
            IdCuadrilla++;
            NewDia();
        }

        public Tecnico[] GrupoTecnico1 { get => GrupoTecnico; }
        public int CantTipoA1 { get => CantTipoA; }
        public int CantTipoB1 { get => CantTipoB; }
        public int CantTipoC1 { get => CantTipoC; }
        public int CantMaxA1 { get => CantMaxA; }
        public int CantMaxB1 { get => CantMaxB; }
        public int CantMaxC1 { get => CantMaxC; }
        public int NroCuadrilla1 { get => NroCuadrilla; }

        public bool AddInstalacion(char tipo)
        {
            bool fin = true;
            if (tipo == 'A' && CantTipoA < CantMaxA) CantTipoA++;
            else if (tipo == 'B' && CantTipoB < CantMaxB) CantTipoB++;
            else if (tipo == 'C' && CantTipoC < CantMaxC) CantTipoC++;
            else fin = false;
            return fin;
        }

        public void NewDia()
        {
            CantTipoA = 0;
            CantTipoB = 0;
            CantTipoC = 0;
        }
    }
}
