using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void showInicio()
        {
            this.Hide();
            Inicio voltar = new Inicio();
            voltar.Show();
        }

        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            showInicio();   
        }
    }
}
