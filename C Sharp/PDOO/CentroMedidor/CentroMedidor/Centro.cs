using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedidor
{
    public class Centro
    {
        private Inventario InventarioMedidor = new Inventario();
        private List<Suscriptor> Suscriptores = new List<Suscriptor>();
        private Cuadrilla[] GrupoCuadrilla = new Cuadrilla[7];

        public Centro(Inventario inventarioMedidor, List<Suscriptor> suscriptores, Cuadrilla[] grupoCuadrilla)
        {
            InventarioMedidor = inventarioMedidor ?? throw new ArgumentNullException(nameof(inventarioMedidor));
            Suscriptores = suscriptores ?? throw new ArgumentNullException(nameof(suscriptores));
            GrupoCuadrilla = grupoCuadrilla ?? throw new ArgumentNullException(nameof(grupoCuadrilla));
        }

        public Inventario InventarioMedidor1 { get => InventarioMedidor; }
        public List<Suscriptor> Suscriptores1 { get => Suscriptores; }
        public Cuadrilla[] GrupoCuadrilla1 { get => GrupoCuadrilla; }

        public bool CambiarMedidor(MedidorA newMedidor, Suscriptor suscriptor, Cuadrilla cuadrilla)
        {
            bool fin = false;
            for (int i =0; i < GrupoCuadrilla.Length; i++)
            {
                if (GrupoCuadrilla[i].NroCuadrilla1 == cuadrilla.NroCuadrilla1)
                {
                    if (GrupoCuadrilla[i].AddInstalacion('A') && InventarioMedidor.OcuparMedidor(newMedidor))
                    {
                        foreach(Suscriptor j in Suscriptores)
                        {
                            if(j.NroSuscriptor1 == suscriptor.NroSuscriptor1)
                            {
                                if (j.MedidorTipoA1 != null) InventarioMedidor.AddMedidor(j.MedidorTipoA1);
                                else if (j.MedidorTipoB1 != null) InventarioMedidor.AddMedidor(j.MedidorTipoB1);
                                else if (j.MedidorTipoC1 != null) InventarioMedidor.AddMedidor(j.MedidorTipoC1);
                                j.NewMedidor(newMedidor);
                                fin = true;
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            return fin;
        }

        public bool CambiarMedidor(MedidorB newMedidor, Suscriptor suscriptor, Cuadrilla cuadrilla)
        {
            bool fin = false;
            for (int i = 0; i < GrupoCuadrilla.Length; i++)
            {
                if (GrupoCuadrilla[i].NroCuadrilla1 == cuadrilla.NroCuadrilla1)
                {
                    if (GrupoCuadrilla[i].AddInstalacion('B') && InventarioMedidor.OcuparMedidor(newMedidor))
                    {
                        foreach (Suscriptor j in Suscriptores)
                        {
                            if (j.NroSuscriptor1 == suscriptor.NroSuscriptor1)
                            {
                                if (j.MedidorTipoA1 != null) InventarioMedidor.AddMedidor(j.MedidorTipoA1);
                                else if (j.MedidorTipoB1 != null) InventarioMedidor.AddMedidor(j.MedidorTipoB1);
                                else if (j.MedidorTipoC1 != null) InventarioMedidor.AddMedidor(j.MedidorTipoC1);
                                j.NewMedidor(newMedidor);
                                fin = true;
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            return fin;
        }

        public bool CambiarMedidor(MedidorC newMedidor, Suscriptor suscriptor, Cuadrilla cuadrilla)
        {
            bool fin = false;
            for (int i = 0; i < GrupoCuadrilla.Length; i++)
            {
                if (GrupoCuadrilla[i].NroCuadrilla1 == cuadrilla.NroCuadrilla1)
                {
                    if (GrupoCuadrilla[i].AddInstalacion('C') && InventarioMedidor.OcuparMedidor(newMedidor))
                    {
                        foreach (Suscriptor j in Suscriptores)
                        {
                            if (j.NroSuscriptor1 == suscriptor.NroSuscriptor1)
                            {
                                if (j.MedidorTipoA1 != null) InventarioMedidor.AddMedidor(j.MedidorTipoA1);
                                else if (j.MedidorTipoB1 != null) InventarioMedidor.AddMedidor(j.MedidorTipoB1);
                                else if (j.MedidorTipoC1 != null) InventarioMedidor.AddMedidor(j.MedidorTipoC1);
                                j.NewMedidor(newMedidor);
                                fin = true;
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            return fin;
        }

        public bool InstalarMedidor(MedidorA newMedidor, Suscriptor suscriptor, Cuadrilla cuadrilla)
        {
            bool fin = false;
            for (int i = 0; i < GrupoCuadrilla.Length; i++)
            {
                if (GrupoCuadrilla[i].NroCuadrilla1 == cuadrilla.NroCuadrilla1)
                {
                    if (GrupoCuadrilla[i].AddInstalacion('A') && InventarioMedidor.OcuparMedidor(newMedidor))
                    {
                        foreach (Suscriptor j in Suscriptores)
                        {
                            if (j.NroSuscriptor1 == suscriptor.NroSuscriptor1)
                            {
                                j.NewMedidor(newMedidor);
                                fin = true;
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            return fin;
        }

        public bool InstalarMedidor(MedidorB newMedidor, Suscriptor suscriptor, Cuadrilla cuadrilla)
        {
            bool fin = false;
            for (int i = 0; i < GrupoCuadrilla.Length; i++)
            {
                if (GrupoCuadrilla[i].NroCuadrilla1 == cuadrilla.NroCuadrilla1)
                {
                    if (GrupoCuadrilla[i].AddInstalacion('B') && InventarioMedidor.OcuparMedidor(newMedidor))
                    {
                        foreach (Suscriptor j in Suscriptores)
                        {
                            if (j.NroSuscriptor1 == suscriptor.NroSuscriptor1)
                            {
                                j.NewMedidor(newMedidor);
                                fin = true;
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            return fin;
        }

        public bool InstalarMedidor(MedidorC newMedidor, Suscriptor suscriptor, Cuadrilla cuadrilla)
        {
            bool fin = false;
            for (int i = 0; i < GrupoCuadrilla.Length; i++)
            {
                if (GrupoCuadrilla[i].NroCuadrilla1 == cuadrilla.NroCuadrilla1)
                {
                    if (GrupoCuadrilla[i].AddInstalacion('C') && InventarioMedidor.OcuparMedidor(newMedidor))
                    {
                        foreach (Suscriptor j in Suscriptores)
                        {
                            if (j.NroSuscriptor1 == suscriptor.NroSuscriptor1)
                            {
                                j.NewMedidor(newMedidor);
                                fin = true;
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            return fin;
        }

        public void RepararMedidor(Suscriptor suscriptor)
        {
            foreach (Suscriptor j in Suscriptores)
            {
                if (j.NroSuscriptor1 == suscriptor.NroSuscriptor1)
                {
                    if (j.MedidorTipoA1 != null) j.MedidorTipoA1.Reparar();
                    else if (j.MedidorTipoB1 != null) j.MedidorTipoB1.Reparar();
                    else j.MedidorTipoC1.Reparar();
                    break;
                }
            }
        }

        public void DesconectarServicio(Suscriptor suscriptor)
        {
            foreach (Suscriptor j in Suscriptores)
            {
                if (j.NroSuscriptor1 == suscriptor.NroSuscriptor1)
                {
                    if (j.MedidorTipoA1 != null) j.MedidorTipoA1.Desconectar();
                    else if (j.MedidorTipoB1 != null) j.MedidorTipoB1.Desconectar();
                    else j.MedidorTipoC1.Desconectar();
                }
            }
        }

        public void ConectarServicio(Suscriptor suscriptor)
        {
            foreach (Suscriptor j in Suscriptores)
            {
                if (j.NroSuscriptor1 == suscriptor.NroSuscriptor1)
                {
                    if (j.MedidorTipoA1 != null) j.MedidorTipoA1.Conectar();
                    else if (j.MedidorTipoB1 != null) j.MedidorTipoB1.Conectar();
                    else j.MedidorTipoC1.Conectar();
                    break;
                }
            }
        }

        public void Facturar(Suscriptor suscriptor)
        {
            foreach (Suscriptor j in Suscriptores)
            {
                if (j.NroSuscriptor1 == suscriptor.NroSuscriptor1)
                {
                    j.Pagar();
                    break;
                }
            }
        }

    }
}
