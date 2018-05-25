using Laboratorio_3.Classes;
using Laboratorio_3.Classes.Edificios.Almacenamiento;
using Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes;
using Laboratorio_3.Classes.Edificios.Recolectores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3.Forms
{
    public partial class Recursos : Form
    {
        public Recursos()
        {
            InitializeComponent();

            Aldea aldea = Aldea.GetInstancia();

            aldea.Ayu = new Ayuntamiento();

            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Home home = new Home(nombreAldea);
            //home.Show();
            //if(ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new Home(Aldea.lbl));
            //    Hide();
            //}
            //using (Home home = new Home(nombreAldea))
            //{
            //    Home.ShowDialog();
            //    Application.Exit();
            //}
        }

        private void btnAlmOro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha creado un Almacen de oro");

            Aldea aldea = Aldea.GetInstancia();

            AlmacenOro almacenOro = new AlmacenOro();

            if (aldea.CapacidadAlmacenOro())
            {

                btnAlmOro.Show();
                AlmacenOro n = new AlmacenOro();
                aldea.AgregarAlmacenOro(n);

            }
            else
            {
                MessageBox.Show("Capacidad Maxima alcanzada");
                //Mensaje lleno , error.

            }

            //Crear una funcion que haga automaticamente esto para todos los almacenes
            if (aldea.CapacidadProdOro())
            {
                btnRecolectorOro.Show();
                RecolectorOro n = new RecolectorOro();
                aldea.AgregarProductorOro(n);

            }
            else
            {
                MessageBox.Show("Capacidad Maxima alcanzada");
                //Mensaje lleno , error.

            }
        }

        private void btnRecolectorOro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha creado un Recolector de oro");

            Aldea aldea = Aldea.GetInstancia();

            RecolectorOro recolectorOro = new RecolectorOro();

            aldea.RecolectarOro();

            MessageBox.Show(aldea.MostrarOro());
        }

        private void btnAlmElixirRojo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha creado un Almacen de elixir rojo");

            Aldea aldea = Aldea.GetInstancia();

            AlmacenElixirRojo almacenElixirRojo = new AlmacenElixirRojo();

            if (aldea.CapacidadAlmacenRojo())
            {
                btnAlmElixirRojo.Show();
                AlmacenElixirRojo n = new AlmacenElixirRojo();

                aldea.AgregarAlmacenRojo(n);

            }
            else
            {
                MessageBox.Show("Capacidad Maxima alcanzada");
                //Mensaje lleno , error.

            }

            if (aldea.CapacidadProdRojo())
            {
                RecolectorElixirRojo n = new RecolectorElixirRojo();
                aldea.AgregarProductorRojo(n);
                btnRecElixirRojo.Show();

            }
            else
            {
                MessageBox.Show("Capacidad Maxima alcanzada");
                //Mensaje lleno , error.

            }
        }

        private void btnRecElixirRojo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha creado un Recolector de elixir rojo");

            Aldea aldea = Aldea.GetInstancia();

            RecolectorElixirRojo recolectorElixirRojo = new RecolectorElixirRojo();

            aldea.RecolectarRojo();

            //MessageBox.Show(aldea.MostrarRojo());
            //MessageBox.Show("Rojo ayu: " + aldea.Ayu.CapacidadActualElixirRojo);
            MessageBox.Show(aldea.MostrarRojo());
        }


        private void btnAlmElixirNegro_Click(object sender, EventArgs e)
        {
            //AlmacenElixirNegro almacenElixirNegro = new AlmacenElixirNegro();
            MessageBox.Show("Ha creado un Almacen de elixir oscuro");

            Aldea aldea = Aldea.GetInstancia();

            AlmacenElixirNegro almacenElixirNegro = new AlmacenElixirNegro();

            if (aldea.AlmacenNegro == null)
            {
                btnAlmElixirNegro.Show();
                AlmacenElixirNegro n = new AlmacenElixirNegro();
                //aldea.AlmacenNegro = n;
            }
            else
            {
                MessageBox.Show("Capacidad Maxima alcanzada");
            }
        }

        private void btnRecElixirNegro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha creado un Recolector de elixir oscuro");

            Aldea aldea = Aldea.GetInstancia();

            RecolectorElixirNegro recolectorElixirNegro = new RecolectorElixirNegro();
                                    
            if (aldea.AlmacenNegro != null)
            {
                aldea.RecolectarNegro();
                //MessageBox.Show(aldea.AlmacenNegro.CantActual.ToString());
                MessageBox.Show($"Elixir oscuro en ayuntamiento: {aldea.AlmacenNegro.CantActual.ToString()}");
                //MessageBox.Show($"Elixir oscuro en ayuntamiento: {aldea.Ayu.CantActual}");
            }
            else
            {
                MessageBox.Show("Debe crear un almacen de elixir negro.");
            }

            if (aldea.CapacidadProdNegro())
            {
                RecolectorElixirNegro r = new RecolectorElixirNegro();
                aldea.AgregarProductorNegro(r);
                btnRecElixirNegro.Show();
            }
            else
            {
                MessageBox.Show("Capacidad Máxima alcanzada");
                //Mensaje lleno , error.
            }
        }


        private void btnCampamento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha creado un Campamento");

            Aldea aldea = Aldea.GetInstancia();

            Campamento campamento = new Campamento();

            if (aldea.CapacidadCampamento())
            {

                Campamento c = new Campamento();
                aldea.AgregarCampamento(c);
            }
            else
            {
                MessageBox.Show("Capacidad Maxima alcanzada");
                //Mensaje lleno , error.

            }
        }
    }
}
