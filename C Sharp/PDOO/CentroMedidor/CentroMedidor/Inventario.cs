using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedidor
{
    public class Inventario
    {
        private List<MedidorA> MedidoresA = new List<MedidorA>();
        private int DisponibleA;
        private List<MedidorB> MedidoresB = new List<MedidorB>();
        private int DisponibleB;
        private List<MedidorC> MedidoresC = new List<MedidorC>();
        private int DisponibleC;

        public Inventario()
        {
        }

        public Inventario(List<MedidorA> medidoresA, List<MedidorB> medidoresB, List<MedidorC> medidoresC)
        {
            MedidoresA = medidoresA ?? throw new ArgumentNullException(nameof(medidoresA));
            DisponibleA = MedidoresA.Count;
            MedidoresB = medidoresB ?? throw new ArgumentNullException(nameof(medidoresB));
            DisponibleB = MedidoresB.Count;
            MedidoresC = medidoresC ?? throw new ArgumentNullException(nameof(medidoresC));
            DisponibleC = MedidoresC.Count;
        }

        public List<MedidorA> MedidoresA1 { get => MedidoresA; }
        public List<MedidorB> MedidoresB1 { get => MedidoresB; }
        public List<MedidorC> MedidoresC1 { get => MedidoresC; }
        public int DisponibleA1 { get => DisponibleA; }
        public int DisponibleB1 { get => DisponibleB; }
        public int DisponibleC1 { get => DisponibleC; }

        public void AddListMedidor(List<MedidorA> listMedidor)
        {
            if (MedidoresA.Count == 0) MedidoresA = listMedidor ?? throw new ArgumentNullException(nameof(listMedidor));
            else throw new Exception("La lista de medidores A ya tiene elementos.");
            DisponibleA = MedidoresA.Count;
        }

        public void AddListMedidor(List<MedidorB> listMedidor)
        {
            if (MedidoresB.Count == 0) MedidoresB = listMedidor ?? throw new ArgumentNullException(nameof(listMedidor));
            else throw new Exception("La lista de medidores B ya tiene elementos.");
            DisponibleB = MedidoresB.Count;
        }

        public void AddListMedidor(List<MedidorC> listMedidor)
        {
            if (MedidoresC.Count == 0) MedidoresC = listMedidor ?? throw new ArgumentNullException(nameof(listMedidor));
            else throw new Exception("La lista de medidores C ya tiene elementos.");
            DisponibleC = MedidoresC.Count;
        }

        public void AddMedidor(MedidorA medidor)
        {
            foreach(MedidorA i in MedidoresA)
            {
                if (i.NroMedidor1 == medidor.NroMedidor1) throw new Exception("El medidor ya se encuentra en el inventario.");
            }

            MedidoresA.Add(medidor ?? throw new ArgumentNullException(nameof(medidor)));
            DisponibleA = MedidoresA.Count;
        }

        public void AddMedidor(MedidorB medidor)
        {
            foreach (MedidorB i in MedidoresB)
            {
                if (i.NroMedidor1 == medidor.NroMedidor1) throw new Exception("El medidor ya se encuentra en el inventario.");
            }

            MedidoresB.Add(medidor ?? throw new ArgumentNullException(nameof(medidor)));
            DisponibleB = MedidoresB.Count;
        }

        public void AddMedidor(MedidorC medidor)
        {
            foreach (MedidorC i in MedidoresC)
            {
                if (i.NroMedidor1 == medidor.NroMedidor1) throw new Exception("El medidor ya se encuentra en el inventario.");
            }

            MedidoresC.Add(medidor ?? throw new ArgumentNullException(nameof(medidor)));
            DisponibleC = MedidoresC.Count;
        }

        public bool OcuparMedidor(MedidorA medidor)
        {
            int aux = 0;
            bool fin = false;
            if (DisponibleA > 0)
            {
                foreach (MedidorA i in MedidoresA)
                {
                    if (i.NroMedidor1 == medidor.NroMedidor1)
                    {
                        MedidoresA.RemoveAt(aux);
                        DisponibleA = MedidoresA.Count;
                        fin = true;
                        break;
                    }
                    aux++;
                }
            }

            return fin;
        }

        public bool OcuparMedidor(MedidorB medidor)
        {
            int aux = 0;
            bool fin = false;
            if (DisponibleB > 0)
            {
                foreach (MedidorB i in MedidoresB)
                {
                    if (i.NroMedidor1 == medidor.NroMedidor1)
                    {
                        MedidoresB.RemoveAt(aux);
                        DisponibleB = MedidoresB.Count;
                        fin = true;
                        break;
                    }
                    aux++;
                }
            }

            return fin;
        }

        public bool OcuparMedidor(MedidorC medidor)
        {
            int aux = 0;
            bool fin = false;
            if (DisponibleC > 0)
            {
                foreach (MedidorC i in MedidoresC)
                {
                    if (i.NroMedidor1 == medidor.NroMedidor1)
                    {
                        MedidoresC.RemoveAt(aux);
                        DisponibleC = MedidoresC.Count;
                        fin = true;
                        break;
                    }
                    aux++;
                }
            }

            return fin;
        }

    }
}
