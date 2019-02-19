using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quiz.api;

namespace Quiz
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            Nickname_Tb.Text = quiz.GetNickName();
            api.sendMessage(quiz.GetNickName());
        }

        private void Nickname_Tb_TextChanged(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();

            if (quiz.VerificarNickName(Nickname_Tb))
            {
                Play_Button.Enabled = true;
                warning_Pb.Visible = false;
            }
            else
            {
                Play_Button.Enabled = false;
                warning_Pb.Visible = true;
            }
        }

        private void Leave_Button_Click(object sender, EventArgs e)
        {
            api.Sair();
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            string nick = Nickname_Tb.Text;
            Quiz quiz = new Quiz();
            quiz.SetNickName(nick);
            api.sendMessage(quiz.GetNickName());
            this.Hide();
            Tema escolherTema = new Tema();
            escolherTema.Show();
        }

        private void Sobre_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
