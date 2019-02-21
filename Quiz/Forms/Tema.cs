﻿using System;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.INFORMATICA;
            showPerguntas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.SECRETARIADO;
            showPerguntas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.TURISMO;
            showPerguntas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Curso = api.Curso.ANALISES;
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
            quiz.Curso = api.Curso.FRIO;
            showPerguntas();
        }
    }
}
