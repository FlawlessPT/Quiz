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
        public Tema()
        {
            InitializeComponent();
        }

        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio voltar = new Inicio();
            voltar.Show();
        }

        private void Tema_Load(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            api.sendMessage(quiz.GetNickName());
        }
    }
}
