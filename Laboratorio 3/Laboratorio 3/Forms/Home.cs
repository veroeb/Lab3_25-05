using Laboratorio_3.Classes;
using Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes;
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
    public partial class Home : Form
    {
        public Home(string nombreAldea)
        {
            InitializeComponent();
            lblAldea.Text = nombreAldea;

            Aldea aldea = Aldea.GetInstancia();
            aldea.Ayu = new Ayuntamiento();

            //lblOro.Text = aldea.MostrarOro();
            //lblElixirRojo.Text = aldea.MostrarRojo();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
        }

        private void btnShop_Click_1(object sender, EventArgs e)
        {
            Hide();
            using (Shop shop = new Shop())
            {
                shop.ShowDialog();
                Application.Exit();
            }
        }
    }
}
