using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Quiz
{
    public partial class Perguntas : Form
    {
        int contar2 = 0;
        int contar = 20;
        int contarPergunta = 0;
        string[] respostas = new string[4];

        static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "/Quiz.mdb";
        private OleDbConnection connection = new OleDbConnection(connectionString);

        public Perguntas()
        {
            InitializeComponent();
        }

        private void Perguntas_Load(object sender, EventArgs e)
        {
            contarPergunta = 0;
            Quiz quiz = new Quiz();
            quiz.SavePerguntas();
            Tema_Label.Text = quiz.GetTema();
            Pergunta_Label.Text = quiz.CarregarPergunta(0);
            quiz.SaveNextRespostas(quiz.GetIdPergunta(), respostas);
            Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
            quiz.CriarFicheiroScore();

            Tempo_Label.Text = contar.ToString();
            timer1.Start();
        }

        private void Perguntas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Quiz.CleanFiles();
            Application.Exit();
        }

        public void ShowScore()
        {
            this.Hide();
            Score score = new Score();
            score.Show();
        }

        private void mudarPergunta()
        {
            Resposta1.Enabled = false;
            Resposta2.Enabled = false;
            Resposta3.Enabled = false;
            Resposta4.Enabled = false;
            Tempo_Label.Text = contar.ToString();
            Quiz quiz = new Quiz();
            Pergunta_Label.Text = quiz.CarregarPergunta(contarPergunta);
            Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
            contar--;
            timer1.Stop();
            contar = 20;
            timer1.Start();
            contarPergunta++;
            quiz.SaveNextRespostas(quiz.GetIdPergunta() + contarPergunta, respostas);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tempo_Label.Text = contar.ToString();
            Quiz quiz = new Quiz();

            if (contar == 0)
            {
                if (contarPergunta == 3)
                {
                    contarPergunta = 0;
                    Resposta1.Enabled = false;
                    Resposta2.Enabled = false;
                    Resposta3.Enabled = false;
                    Resposta4.Enabled = false;
                    quiz.Seguinte(false, timer1);
                    Tempo_Label.Text = "-";
                    timer1.Stop();
                    timer2.Start();
                    return;
                }

                Resposta1.Enabled = false;
                Resposta2.Enabled = false;
                Resposta3.Enabled = false;
                Resposta4.Enabled = false;
                timer1.Stop();
                contarPergunta++;
                Pergunta_Label.Text = quiz.CarregarPergunta(contarPergunta);
                contar = 20;
                quiz.SaveNextRespostas(quiz.GetIdPergunta() + contarPergunta, respostas);
                Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
                quiz.Seguinte(false, timer1);
                Resposta1.Enabled = true;
                Resposta2.Enabled = true;
                Resposta3.Enabled = true;
                Resposta4.Enabled = true;
                timer1.Start();
            }

            Pergunta_Label.Text = quiz.CarregarPergunta(contarPergunta);
            Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
            Tempo_Label.Text = contar.ToString();
            contar--;
        }

        private void Resposta1_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            int id = quiz.GetIdResposta(Resposta1.Text);
            connection.Open();
            string query = "SELECT isCorreta FROM Respostas WHERE IdResposta=" + id;
            OleDbCommand command = new OleDbCommand(query, connection);
            bool isCorreta = (bool)command.ExecuteScalar();

            if (isCorreta)
            {
                if (contarPergunta == 3)
                {
                    contarPergunta = 0;
                    Resposta1.Enabled = false;
                    Resposta2.Enabled = false;
                    Resposta3.Enabled = false;
                    Resposta4.Enabled = false;
                    Resposta1.BackColor = Color.Green;
                    quiz.Seguinte(true, timer1);
                    Tempo_Label.Text = "-";
                    timer1.Stop();
                    timer2.Start();
                    //ShowScore();
                }
                else
                {
                    Resposta1.BackColor = Color.Green;
                    quiz.Seguinte(true, timer1);
                    Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
                    mudarPergunta();
                }
            }
            else
            {

                if (contarPergunta == 3)
                {
                    contarPergunta = 0;
                    Resposta1.Enabled = false;
                    Resposta2.Enabled = false;
                    Resposta3.Enabled = false;
                    Resposta4.Enabled = false;
                    Resposta1.BackColor = Color.Red;
                    quiz.Seguinte(false, timer1);
                    Tempo_Label.Text = "-";
                    timer1.Stop();
                    timer2.Start();
                    //ShowScore();
                }
                else
                {
                    Resposta1.BackColor = Color.Red;
                    quiz.Seguinte(false, timer1);
                    Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
                    mudarPergunta();
                }
            }

            connection.Close();
        }

        private void Resposta2_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            int id = quiz.GetIdResposta(Resposta2.Text);
            connection.Open();
            string query = "SELECT isCorreta FROM Respostas WHERE IdResposta=" + id;
            OleDbCommand command = new OleDbCommand(query, connection);
            bool isCorreta = (bool)command.ExecuteScalar();

            if (isCorreta)
            {
                if (contarPergunta == 3)
                {
                    contarPergunta = 0;
                    Resposta1.Enabled = false;
                    Resposta2.Enabled = false;
                    Resposta3.Enabled = false;
                    Resposta4.Enabled = false;
                    Resposta2.BackColor = Color.Green;
                    quiz.Seguinte(true, timer1);
                    Tempo_Label.Text = "-";
                    timer1.Stop();
                    timer2.Start();
                    //ShowScore();
                }
                else
                {
                    Resposta2.BackColor = Color.Green;
                    quiz.Seguinte(true, timer1);
                    Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
                    mudarPergunta();
                }
            }
            else
            {
                if (contarPergunta == 3)
                {
                    contarPergunta = 0;
                    Resposta1.Enabled = false;
                    Resposta2.Enabled = false;
                    Resposta3.Enabled = false;
                    Resposta4.Enabled = false;
                    Resposta2.BackColor = Color.Red;
                    quiz.Seguinte(false, timer1);
                    Tempo_Label.Text = "-";
                    timer1.Stop();
                    timer2.Start();
                    //ShowScore();
                }
                else
                {
                    Resposta2.BackColor = Color.Red;
                    quiz.Seguinte(false, timer1);
                    Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
                    mudarPergunta();
                }
            }

            connection.Close();
        }

        private void Resposta3_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            int id = quiz.GetIdResposta(Resposta3.Text);
            connection.Open();
            string query = "SELECT isCorreta FROM Respostas WHERE IdResposta=" + id;
            OleDbCommand command = new OleDbCommand(query, connection);
            bool isCorreta = (bool)command.ExecuteScalar();

            if (isCorreta)
            {
                if (contarPergunta == 3)
                {
                    contarPergunta = 0;
                    Resposta1.Enabled = false;
                    Resposta2.Enabled = false;
                    Resposta3.Enabled = false;
                    Resposta4.Enabled = false;
                    Resposta3.BackColor = Color.Green;
                    quiz.Seguinte(true, timer1);
                    Tempo_Label.Text = "-";
                    timer1.Stop();
                    timer2.Start();
                    //ShowScore();
                }
                else
                {
                    Resposta3.BackColor = Color.Green;
                    quiz.Seguinte(true, timer1);
                    Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
                    mudarPergunta();
                }
            }
            else
            {

                if (contarPergunta == 3)
                {
                    contarPergunta = 0;
                    Resposta1.Enabled = false;
                    Resposta2.Enabled = false;
                    Resposta3.Enabled = false;
                    Resposta4.Enabled = false;
                    Resposta3.BackColor = Color.Red;
                    quiz.Seguinte(false, timer1);
                    Tempo_Label.Text = "-";
                    timer1.Stop();
                    timer2.Start();
                    //ShowScore();
                }
                else
                {
                    Resposta3.BackColor = Color.Red;
                    quiz.Seguinte(false, timer1);
                    Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
                    mudarPergunta();
                }
            }

            connection.Close();
        }

        private void Resposta4_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            int id = quiz.GetIdResposta(Resposta4.Text);
            connection.Open();
            string query = "SELECT isCorreta FROM Respostas WHERE IdResposta=" + id;
            OleDbCommand command = new OleDbCommand(query, connection);
            bool isCorreta = (bool)command.ExecuteScalar();

            if (isCorreta)
            {
                if (contarPergunta == 3)
                {
                    contarPergunta = 0;
                    Resposta1.Enabled = false;
                    Resposta2.Enabled = false;
                    Resposta3.Enabled = false;
                    Resposta4.Enabled = false;
                    Resposta4.BackColor = Color.Green;
                    quiz.Seguinte(true, timer1);
                    Tempo_Label.Text = "-";
                    timer1.Stop();
                    timer2.Start();
                    //ShowScore();
                }
                else
                {
                    Resposta4.BackColor = Color.Green;
                    quiz.Seguinte(true, timer1);
                    Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
                    mudarPergunta();
                }
            }
            else
            {
                if (contarPergunta == 3)
                {
                    contarPergunta = 0;
                    Resposta1.Enabled = false;
                    Resposta2.Enabled = false;
                    Resposta3.Enabled = false;
                    Resposta4.Enabled = false;
                    Resposta4.BackColor = Color.Red;
                    quiz.Seguinte(false, timer1);
                    Tempo_Label.Text = "-";
                    timer1.Stop();
                    timer2.Start();
                    //ShowScore();
                }
                else
                {
                    Resposta4.BackColor = Color.Red;
                    quiz.Seguinte(false, timer1);
                    Quiz.CarregarRespostas(Resposta1, Resposta2, Resposta3, Resposta4, respostas);
                    mudarPergunta();
                }
            }

            connection.Close();
        }

        private void Resposta1_TextChanged(object sender, EventArgs e)
        {
            Resposta1.Enabled = true;
            Resposta2.Enabled = true;
            Resposta3.Enabled = true;
            Resposta4.Enabled = true;
            Resposta1.BackColor = Color.White;
            Resposta2.BackColor = Color.White;
            Resposta3.BackColor = Color.White;
            Resposta4.BackColor = Color.White;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (contar2 == 1)
            {
                timer2.Stop();
                ShowScore();
            }
            else
            {
                contar2++;
            }
        }
    }
}
