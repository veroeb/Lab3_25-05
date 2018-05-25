using Laboratorio_3.Classes;
using Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes;
using Laboratorio_3.Classes.Edificios.Defensivos.Aereos;
using Laboratorio_3.Classes.Edificios.Defensivos.Hibridos;
using Laboratorio_3.Classes.Edificios.Defensivos.Terrestres;
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
    public partial class Defensas : Form
    {
        public Defensas()
        {
            InitializeComponent();

            Aldea aldea = Aldea.GetInstancia();

            aldea.Ayu = new Ayuntamiento();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //using (Home home = new Home(nombreAldea))
            //{
            //    Home.ShowDialog();
            //    Application.Exit();
            //}
        }

        private void btnAguila_Click(object sender, EventArgs e)
        {
            Aldea aldea = Aldea.GetInstancia();

            Aguila aguila = new Aguila();

            MessageBox.Show("Ha creado un edificio defensivo 'Águila'");
        }

        private void btnBallesta_Click(object sender, EventArgs e)
        {
            Ballesta ballesta = new Ballesta();

            Aldea aldea = Aldea.GetInstancia();

            MessageBox.Show("Ha creado un edificio defensivo 'Ballesta'");
        }

        private void btnArqueras_Click(object sender, EventArgs e)
        {
            TorreArqueras torreArqueras = new TorreArqueras();

            Aldea aldea = Aldea.GetInstancia();

            MessageBox.Show("Ha creado un edificio defensivo 'Torre de Arqueras'");
        }

        private void btnInfierno_Click(object sender, EventArgs e)
        {
            TorreInfierno torreInfierno = new TorreInfierno();

            Aldea aldea = Aldea.GetInstancia();

            MessageBox.Show("Ha creado un edificio defensivo 'Torre Infierno'");
        }

        private void btnMagos_Click(object sender, EventArgs e)
        {
            TorreMagos torreMagos = new TorreMagos();

            Aldea aldea = Aldea.GetInstancia();

            MessageBox.Show("Ha creado un edificio defensivo 'Torre de Magos'");
        }

        private void btnTesla_Click(object sender, EventArgs e)
        {
            TorreTesla torreTesla = new TorreTesla();

            Aldea aldea = Aldea.GetInstancia();

            MessageBox.Show("Ha creado un edificio defensivo 'Torre de tesla'");
        }

        private void btnAntiaereo_Click(object sender, EventArgs e)
        {
            Antiaereo antiaereo = new Antiaereo();

            Aldea aldea = Aldea.GetInstancia();

            MessageBox.Show("Ha creado un edificio defensivo 'Antiaéreo'");
        }

        private void btnCañon_Click(object sender, EventArgs e)
        {
            Cañon cañon = new Cañon();

            Aldea aldea = Aldea.GetInstancia();

            MessageBox.Show("Ha creado un edificio defensivo 'Cañón'");
        }

        private void btnMortero_Click(object sender, EventArgs e)
        {
            Mortero mortero = new Mortero();

            Aldea aldea = Aldea.GetInstancia();

            MessageBox.Show("Ha creado un edificio defensivo 'Mortero'");
        }

        private void btnMuro_Click(object sender, EventArgs e)
        {
            Muro muro = new Muro();

            Aldea aldea = Aldea.GetInstancia();

            MessageBox.Show("Ha creado un edificio defensivo 'Muro'");
        }
    }
}
