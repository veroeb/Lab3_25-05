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
    public partial class AldeaForm : Form
    {
        public AldeaForm()
        {
            InitializeComponent();
            txtBoxAldea.KeyPress += new KeyPressEventHandler(CheckEnter);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //    Hide();
            //    using (Home home = new Home(txtBoxAldea.Text))
            //    {
            //        home.ShowDialog();
            //        Application.Exit();
            //    }
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Hide();
                using (Home home = new Home(txtBoxAldea.Text))
                {
                    home.ShowDialog();
                    Application.Exit();
                }
            }
        }

        private void txtBoxAldea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
