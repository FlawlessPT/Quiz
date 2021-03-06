﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quiz.api;
using System.IO;
using System.Data.OleDb;

namespace Quiz
{
    class Quiz
    {
        public string nickName { get; set; }
        public Curso Curso { get; set; }

        static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "/Quiz.mdb";
        private OleDbConnection connection = new OleDbConnection(connectionString);


        public Quiz() { }

        public Quiz(string nick, Curso curso)
        {
            this.nickName = nick;
            this.Curso = curso;
        }

        public string CarregarPergunta(int contar)
        {
            Stream file = File.Open("perguntas.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string linha = "";
            string pergunta = "";

            int i = 0;

            while (i <= contar)
            {
                i++;
                linha = reader.ReadLine();
                int separador = linha.IndexOf("|");
                pergunta = linha.Substring(separador + 1);
            }

            reader.Close();
            file.Close();

            return pergunta;
        }

        public void SaveNickname()
        {
            Stream file = File.Open("nickname.txt", FileMode.OpenOrCreate);
            StreamWriter writetext = new StreamWriter(file);
            writetext.WriteLine(nickName.ToString());
            writetext.Close();
            file.Close();
        }

        public string GetNickName()
        {
            string nickname = "";
            Stream file = File.Open("nickname.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            nickname = reader.ReadLine();

            reader.Close();
            file.Close();

            return nickname;
        }

        public void SaveTema()
        {
            string id = "";
            Stream file = File.Open("tema.txt", FileMode.OpenOrCreate);
            StreamWriter write = new StreamWriter(file);

            if (this.Curso == Curso.INFORMATICA)
            {
                id = "3 | Informática (TGPSI)";
            }
            else if (this.Curso == Curso.TURISMO)
            {
                id = "1 | Animação de Turismo (TAT)";
            }
            else if (this.Curso == Curso.ANALISES)
            {
                id = "2 | Áreas Laboratoriais (TAL)";
            }
            else if (this.Curso == Curso.ELETRICIDADE)
            {
                id = "4 | Instalações Elétricas (TIE)";
            }

            write.WriteLine(id);
            write.Close();
            file.Close();
        }

        public string GetTema()
        {
            string linha = "";
            Stream file = File.Open("tema.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            linha = reader.ReadLine();
            int separador = linha.IndexOf("|");

            string tema = linha.Substring(separador + 1);

            reader.Close();
            file.Close();

            return tema;
        }

        public string GetIdTema()
        {
            string linha = "";
            Stream file = File.Open("tema.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            linha = reader.ReadLine();
            int separador = linha.IndexOf("|");

            string id = linha.Substring(0, separador);

            reader.Close();
            file.Close();

            return id;
        }

        public int GetIdPergunta()
        {
            string linha = "";
            Stream file = File.Open("perguntas.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            linha = reader.ReadLine();

            int separador = linha.IndexOf("|");
            int id = Convert.ToInt32(linha.Substring(0, separador));

            reader.Close();
            file.Close();

            return id;
        }

        public string GetPergunta()
        {
            string linha = "";
            Stream file = File.Open("perguntas.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            linha = reader.ReadLine();
            int separador = linha.IndexOf("|");
            string pergunta = linha.Substring(separador + 1);

            reader.Close();
            file.Close();

            return pergunta;
        }

        public int GetIdResposta(string resposta)
        {
            int id = 0;

            
            connection.Open();
            string query = String.Format("SELECT IdResposta FROM Respostas WHERE Resposta='{0}'", resposta);
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                id = Convert.ToInt32(dr[0]);
            }

            connection.Close();
            return id;
        }

        public void SavePerguntas()
        {
            Quiz quiz = new Quiz();
            connection.Open();

            string query = "SELECT IdPergunta, Pergunta FROM Perguntas WHERE IdTema=" + quiz.GetIdTema();
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();
            Stream file = File.Open("perguntas.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);

            while (dr.Read())
            {
                writer.WriteLine(dr[0].ToString() + " | " + dr[1].ToString());
            }

            writer.Close();
            file.Close();

            connection.Close();
        }

        public void SaveNextRespostas(int idPergunta, string[] respostas)
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

        public static void CleanFiles()
        {
            File.WriteAllText("nickname.txt", String.Empty);
            File.WriteAllText("tema.txt", String.Empty);
            File.WriteAllText("perguntas.txt", String.Empty);
        }

        public void CriarFicheiroScore()
        {
            Stream file = File.Create("score.txt");
            StreamWriter writer = new StreamWriter(file);

            writer.WriteLine("0 | 0");
            writer.Close();
            file.Close();
        }

        private void EscreverFicheiro(string valor1, string valor2)
        {
            Stream file = File.Open("score.txt", FileMode.Open);
            StreamWriter writer = new StreamWriter(file);

            writer.Write(valor1 + " | " + valor2);

            writer.Close();
            file.Close();
        }

        public int GetAcertadas()
        {
            Stream file = File.Open("score.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string linha = reader.ReadLine();
            int separador = linha.IndexOf("|");
            int acertadas = Convert.ToInt32(linha.Substring(0, separador));

            reader.Close();
            file.Close();
            return acertadas;
        }

        public int GetFalhadas()
        {
            Stream file = File.Open("score.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string linha = reader.ReadLine();
            int separador = linha.IndexOf("|");
            int falhadas = Convert.ToInt32(linha.Substring(separador + 1));

            reader.Close();
            file.Close();
            return falhadas;
        }

        public void Seguinte(bool acertou, Timer timer1)
        {
            int contarCertas = GetAcertadas();
            int contarFalhadas = GetFalhadas();
            timer1.Stop();

            if (acertou == true)
            {
                contarCertas++;
            }
            else
            {
                contarFalhadas++;
            }

            EscreverFicheiro(contarCertas.ToString(), contarFalhadas.ToString());
        }

        public static void CarregarRespostas(Button Resposta1, Button Resposta2, Button Resposta3, Button Resposta4, string[] respostas)
        {
            Resposta1.Text = respostas[0];
            Resposta2.Text = respostas[1];
            Resposta3.Text = respostas[2];
            Resposta4.Text = respostas[3];
        }
    }
}
