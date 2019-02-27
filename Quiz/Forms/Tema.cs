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

namespace Quiz
{
    public partial class Tema : Form
    {
        private string nome;

        private void showInicio()
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void showPerguntas()
        {
            this.Hide();
            Perguntas perguntas = new Perguntas();
            perguntas.Show();
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
            StreamReader reader = new StreamReader("nickname.txt");
            nome = reader.ReadLine();
            api.sendMessage("Olá " + nome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.INFORMATICA;
            quiz.SaveTema();
            showPerguntas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.SECRETARIADO;
            quiz.SaveTema();
            showPerguntas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.TURISMO;
            quiz.SaveTema();
            showPerguntas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.TURISMO;
            showPerguntas();
        }

        private void Eletricidade_Button_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.ELETRICIDADE;
            showPerguntas();
        }

        private void FrioClimatizacao_Button_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.ELETRICIDADE;
            quiz.SaveTema();
            showPerguntas();
        }

        private void Eletricidade_Button_Click_1(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.ANALISES;
            quiz.SaveTema();
            showPerguntas();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.FRIO;
            quiz.SaveTema();
            showPerguntas();
        }
    }
}
