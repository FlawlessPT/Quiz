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
        private string nickName { get; set; }
        private Curso Curso { get; set; }

        public Quiz() { }

        public Quiz(string nick, Curso curso)
        {
            this.nickName = nick;
            this.Curso = curso;
            //new edit
        }
    }
}
    