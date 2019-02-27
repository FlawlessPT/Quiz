using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quiz.api;
using System.IO;

namespace Quiz
{
    class Quiz
    {   
        public string nickName { get; set; }
        public Curso Curso { get; set; }

        public Quiz() { }

        public Quiz(string nick, Curso curso)
        {
            this.nickName = nick;
            this.Curso = curso;
        }

        public void SaveNickname()
        {
            Stream file = File.Open("nickname.txt", FileMode.OpenOrCreate);
            StreamWriter writetext = new StreamWriter(file);
            writetext.WriteLine(nickName.ToString());
            writetext.Close();
            file.Close();
        }

        public void SaveTema()
        {
            string texto = "";
            Stream file = File.Open("tema.txt", FileMode.OpenOrCreate);
            StreamWriter write = new StreamWriter(file);

            if (this.Curso == Curso.INFORMATICA)
            {
                texto = "Informática";
            }
            else if (this.Curso == Curso.SECRETARIADO)
            {
                texto = "Secretariado";
            }
            else if (this.Curso == Curso.TURISMO1)
            {
                texto = "Turismo de Animação";
            }
            else if (this.Curso == Curso.TURISMO2)
            {
                texto = "Turismo Ambiental e Rural";
            }
            else if (this.Curso == Curso.ANALISES)
            {
                texto = "Análises Laboratoriais";
            }
            else if (this.Curso == Curso.ELETRICIDADE)
            {
                texto = "Instalações Elétricas";
            }
            else if (this.Curso == Curso.FRIO)
            {
                texto = "Frio e Climatização";

            }

            write.WriteLine(texto);
            write.Close();
            file.Close();
        }

        public string GetSelectedTema()
        {
            string tema = "";
            Stream file = File.Open("tema.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            tema = reader.ReadLine();

            return tema;
        }

        public void carregarPerguntas(string tema)
        {

        }
    }
}
    