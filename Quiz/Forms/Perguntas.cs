using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quiz.Variables;
using System.IO;
using System.Data.OleDb;

namespace Quiz
{
    public partial class Perguntas : Form
    {
        int contar = 10;
        int contarPergunta = 0;
        string[] respostas = new string[4];

        static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Trabalhos\12º\Quiz\Quiz\Quiz\bin\Debug\Quiz.mdb";
        private OleDbConnection connection = new OleDbConnection(connectionString);

        public Perguntas()
        {
            InitializeComponent();
        }

        private void CarregarRespostas()
        {
            Resposta1.Text = respostas[0];
            Resposta2.Text = respostas[1];
            Resposta3.Text = respostas[2];
            Resposta4.Text = respostas[3];
        }

        private void SaveRespostas(int idPergunta)
        {
            Quiz quiz = new Quiz();
            connection.Open();
            string query = "SELECT Resposta FROM Respostas WHERE IdPergunta=" + idPergunta;
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();

            int i = 0;

            while (dr.Read())
            {
                respostas[i] = dr[0].ToString();
                i++;
            }

            connection.Close();
        }

        private void Perguntas_Load(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.SavePerguntas();
            Tema_Label.Text = quiz.GetTema();
            Pergunta_Label.Text = quiz.CarregarPergunta(0);
            SaveRespostas(quiz.GetIdPergunta());
            CarregarRespostas();


            Tempo_Label.Text = contar.ToString();
            timer1.Start();
            
        }

        private void Perguntas_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("nickname.txt", String.Empty);
            File.WriteAllText("tema.txt", String.Empty);
            File.WriteAllText("perguntas.txt", String.Empty);
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tempo_Label.Text = contar.ToString();
            Quiz quiz = new Quiz();
            Pergunta_Label.Text = quiz.CarregarPergunta(contarPergunta);
            SaveRespostas(quiz.GetIdPergunta() + contarPergunta);
            CarregarRespostas();
            contar--;

            if (contar == -1)
            {
                timer1.Stop();
                contar = 10;
                api.sendMessage("Acabou o tempo!", api.MessageType.INFORMATION);

                if (contarPergunta == 3)
                {
                    Application.Exit();
                }

                timer1.Start();
                contarPergunta++;
            }
        }

        private void Resposta1_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            int id = quiz.GetIdResposta(Resposta1.Text);
            connection.Open();
            string query = "SELECT isCorreta FROM Respostas WHERE IdResposta=" + id;
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();
            if (dr[0].Equals(true))
            {
                api.sendMessage("resposta correta");
            }
            else
            {
                api.sendMessage("resposta errada");
            }

            connection.Close();
        }

        private void Resposta2_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            int id = quiz.GetIdResposta(Resposta1.Text);
            connection.Open();
            string query = "SELECT isCorreta FROM Respostas WHERE IdResposta=" + id;
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();
            if (dr[0].Equals(true))
            {
                api.sendMessage("resposta correta");
            }
            else
            {
                api.sendMessage("resposta errada");
            }

            connection.Close();
        }

        private void Resposta3_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            int id = quiz.GetIdResposta(Resposta1.Text);
            connection.Open();
            string query = "SELECT isCorreta FROM Respostas WHERE IdResposta=" + id;
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();
            if (dr[0].Equals(true))
            {
                api.sendMessage("resposta correta");
            }
            else
            {
                api.sendMessage("resposta errada");
            }

            connection.Close();
        }

        private void Resposta4_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            int id = quiz.GetIdResposta(Resposta1.Text);
            connection.Open();
            string query = "SELECT isCorreta FROM Respostas WHERE IdResposta=" + id;
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();
            if (dr[0].Equals(true))
            {
                api.sendMessage("resposta correta");
            }
            else
            {
                api.sendMessage("resposta errada");
            }

            connection.Close();
        }
    }
}
