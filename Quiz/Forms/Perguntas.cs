﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quiz.Variables;

namespace Quiz
{
    public partial class Perguntas : Form
    {
        public Perguntas()
        {
            InitializeComponent();
        }

        private void Perguntas_Load(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            carregarPerguntas(quiz.Curso.ToString());      
        }

        private void carregarPerguntas(string tema)
        {
            Pergunta.Text = tema;  
        }
    }
}
