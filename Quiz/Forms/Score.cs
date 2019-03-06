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
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            label4.Text = quiz.GetAcertadas().ToString();
            label5.Text = quiz.GetFalhadas().ToString();
            label7.Text = quiz.GetNickName();
        }

        private void Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            Quiz.CleanFiles();
            Application.Exit();
        }

        private void ShowInicio()
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            ShowInicio();
        }
    }
}
