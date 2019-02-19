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
    public partial class Tema : Form
    {
        private void showInicio()
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        public Tema()
        {
            InitializeComponent();
        }

        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            showInicio();
        }

        private void Tema_Load(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
        }
    }
}
