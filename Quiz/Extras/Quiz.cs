using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quiz.api;

namespace Quiz
{
    class Quiz
    {
        public string nickName;
        public Curso curso;

        public Quiz() { }

        public Quiz(string nick, Curso curso)
        {
            this.SetNickName(nick);
            this.SetCurso(curso);
        }

        public string GetNickName()
        {
            return nickName;
        }

        public void SetNickName(string value)
        {
            nickName = value;
        }

        public Curso GetCurso()
        {
            return curso;
        }

        public void SetCurso(Curso value)
        {
            curso = value;
        }

        public bool VerificarNickName(TextBox textBox)
        {
            bool estado = false;

            if (textBox.TextLength > 0)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }

            return estado;
        }
    }
}
