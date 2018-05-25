using Laboratorio_3.Classes.Edificios;
using Laboratorio_3.Classes.Edificios.Almacenamiento;
using Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes;
using Laboratorio_3.Classes.Edificios.Cuarteles;
using Laboratorio_3.Classes.Edificios.Defensivos;
using Laboratorio_3.Classes.Edificios.Recolectores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes
{
    public class Aldea
    {
        //Codigo de Singleton para que no se pueda crear mas de una Aldea
        public static Aldea Instancia = null;

        public static Aldea GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Aldea();
            }
            return Instancia;
        }

        //Limites de los edificios
        const Int32 cuartelMax = 4;
        const Int32 campMax = 4;
        const Int32 cuartelOscuroMax = 2;
        const Int32 almacenRojoMax = 4;
        const Int32 almacenOroMax = 4;
        const Int32 prodOroMax = 6;
        const Int32 prodRojoMax = 6;
        const Int32 prodNegroMax = 3;


        //Atributos y constructor de la aldea
        protected String Nombre { get; set; }
        protected int CantOro { get; set; }
        protected int CantElixirRojo { get; set; }
        protected int CantElixirNegro { get; set; }

        private Aldea()
        {
            this.CantElixirNegro = 200;
            this.CantElixirRojo = 500;
            this.CantOro = 1000;
        }

        List<Cuarteles> Cuarteles = new List<Cuarteles>(); //4 max
        List<CuartelOscuro> CuartelesO = new List<CuartelOscuro>(); //2 max
        List<Campamento> Campamentos = new List<Campamento>(); //4 max
        List<AlmacenElixirRojo> AlmacenesRojo = new List<AlmacenElixirRojo>(); //4 max
        List<AlmacenOro> AlmacenesOro = new List<AlmacenOro>();//4 max
        List<RecolectorElixirNegro> ProdNegro = new List<RecolectorElixirNegro>();//3 max
        List<RecolectorElixirRojo> ProdRojo = new List<RecolectorElixirRojo>();//6 max
        List<RecolectorOro> ProdOro = new List<RecolectorOro>();//6 max
        List<EdificioDefensivo> Defensivos = new List<EdificioDefensivo>();


        //Metodos para agregar todos los edificios a sus respectivas listas
        public void AgregarCampamento(Campamento c)
        {
            Campamentos.Add(c);
        }
        public void AgregarCuartelO(CuartelOscuro ar)
        {
            CuartelesO.Add(ar);
        }
        public void AgregarCuartel(Cuarteles ar)
        {
            Cuarteles.Add(ar);
        }

        public void AgregarProductorOro(RecolectorOro ar)
        {
            ProdOro.Add(ar);
        }
        public void AgregarProductorNegro(RecolectorElixirNegro ar)
        {
            ProdNegro.Add(ar);
        }

        public void AgregarProductorRojo(RecolectorElixirRojo ar)
        {
            ProdRojo.Add(ar);
        }

        public void AgregarAlmacenOro(AlmacenOro ao)
        {
            AlmacenesOro.Add(ao);
        }

        public void AgregarAlmacenRojo(AlmacenElixirRojo ar)
        {
            AlmacenesRojo.Add(ar);
        }


        //Metodos para chequear la cantidad de los edificios
        public Boolean CapacidadProdOro()
        {
            return ProdOro.Count() < prodOroMax;
        }
        public Boolean CapacidadProdRojo()
        {
            return ProdRojo.Count() < prodRojoMax;
        }
        public Boolean CapacidadProdNegro()
        {
            return ProdNegro.Count() < prodNegroMax;
        }
        public Boolean CapacidadAlmacenOro()
        {
             return AlmacenesOro.Count() < almacenOroMax;
        }

        public Boolean CapacidadCuartel()
        {
            return Cuarteles.Count() < cuartelMax;
        }
        public Boolean CapacidadCuartelO()
        {
            return CuartelesO.Count() < cuartelOscuroMax;
        }
        public Boolean CapacidadCampamento()
        {
            return Campamentos.Count() < campMax;
        }
        public Boolean CapacidadAlmacenRojo()
        {
            return AlmacenesRojo.Count() < almacenRojoMax;
        }
        public Ayuntamiento Ayu { get; set; }
        public Castillo Cas { get; set; }
        public AlmacenElixirNegro AlmacenNegro { get; set; }

        //Funcion de los recolectores (ORO)
        public void RecolectarOro()
        {
            int ultimo = AlmacenesOro.Count() - 1;
            int oro = 0;
            foreach (RecolectorOro ro in ProdOro)
            {
                oro += ro.ProduccionPorSegundo;
            }
            int a = 100;

            while (a > 0)
            {
                foreach (AlmacenOro al in AlmacenesOro)
                {
                    if (al.Lleno() != true)
                    {
                        a = al.Guardar(oro);
                        oro = a;
                    }

                    else if (al == AlmacenesOro[ultimo] && al.Lleno())
                    {
                        int b = Ayu.Guardar(oro);
                        oro = b;

                        if (oro > 0)
                        {
                            int final = Cas.Guardar(oro);
                        }
                    }
                    else if (oro == 0) break;
                }
                break;
            }


        }
        public String MostrarOro()
        {
            int total = 0;
            if (AlmacenesOro.Count > 0)
            {
                foreach (AlmacenOro ok in AlmacenesOro)
                {
                    int ultimo = AlmacenesOro.Count() - 1;

                    if (ok == AlmacenesOro[ultimo])
                    {
                        total += ok.CantActual;
                        String r = "El oro es: " + total.ToString();
                        return r;
                    }
                    else
                    {
                        total += ok.CantActual;
                    }
                }
            }
            return "Debe crear almacenes para almacenar oro";
        }

        //Metodo para calcular el oro total de la aldea
        public void CalcularOro()
        {
            int oroTotal;
            foreach (AlmacenOro Ao in AlmacenesOro)
            {
                oroTotal = Ao.CantActual;
                CantOro = CantOro + oroTotal;
            }

            if (AlmacenesOro.Count == almacenOroMax && Ayu != null)
            {
                CantOro += Ayu.CantActual;
            }
            else if (AlmacenesOro.Count == almacenOroMax && Cas != null)
            {
                CantOro += Cas.CantActual;
            }
        }

        //Funcion de los recolecotores (ELIXIR ROJO)
        public void RecolectarRojo()
        {
            int ultimo = AlmacenesRojo.Count() - 1;
            int rojo = 0;
            foreach (RecolectorElixirRojo pr in ProdRojo)
            {
                rojo += pr.ProduccionPorSegundo;
            }
            int a = 100;

            while (a > 0)
            {
                foreach (AlmacenElixirRojo ar in AlmacenesRojo)
                {
                    if (ar.Lleno() != true)
                    {
                        a = ar.Guardar(rojo);
                        rojo = a;
                    }
                    else if (ar == AlmacenesRojo[ultimo] && ar.Lleno())
                    {
                        int b = Ayu.GuardarElixirRojo(rojo);
                        rojo = b;

                        if (rojo > 0)
                        {
                            int final = Cas.GuardarElixirRojo(rojo);
                        }
                    }
                    else if (rojo == 0) break;
                }
                break;
            }
        }
        public String MostrarRojo()
        {
            int total = 0;
            if (AlmacenesRojo.Count > 0)
            {
                foreach (AlmacenElixirRojo ok in AlmacenesRojo)
                {
                    int ultimo = AlmacenesRojo.Count() - 1;

                    if (ok == AlmacenesRojo[ultimo])
                    {
                        total += ok.CantActual;
                        String r = "El elixir rojo es: " + total.ToString();
                        return r;
                    }
                    else
                    {
                        total += ok.CantActual;
                    }
                }
            }
            return "Debe crear almacenes para almacenar elixir rojo";
        }

        public void RecolectarNegro()
        {
            int negro = 0;
            int a = 100;

            foreach (RecolectorElixirNegro pn in ProdNegro)
            {
                negro += pn.ProduccionPorSegundo;
            }
            while (a > 0)
            {
                if (AlmacenNegro.Lleno() != true)
                {
                    a = AlmacenNegro.Guardar(negro);
                    negro = a;
                }
                else if (negro > 0)
                {
                    int fin = Cas.GuardarElixirNegro(negro);
                }
                break;
            }
        }
    }
}

