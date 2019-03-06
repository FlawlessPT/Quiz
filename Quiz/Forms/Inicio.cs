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
using System.IO;

namespace Quiz
{
    public partial class Inicio : Form
    {
        Quiz quiz = new Quiz();

        private void showTema()
        {
            this.Hide();
            Tema escolherTema = new Tema();
            escolherTema.Show();
        }

        private void showSobre()
        {
            this.Hide();
            Sobre sobre = new Sobre();
            sobre.Show();
        }
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Quiz.CleanFiles();
        }

        private void Nickname_Tb_TextChanged(object sender, EventArgs e)
        {
            if (api.VerificarNickName(Nickname_Tb))
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
            quiz.nickName = nick;
            quiz.SaveNickname();
            showTema();
        }

        private void Sobre_Button_Click(object sender, EventArgs e)
        {
            showSobre();
        }

        private void Nickname_Tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Play_Button.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Quiz.CleanFiles();
        }
    }
}
