using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz
{
    class api
    {
        public static bool VerificarNickName(TextBox textBox)
        {
            bool estado = false;

            if (textBox.TextLength > 0)
            {
                if (!textBox.Text.Contains(" "))
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
            }
            else
            {
                estado = false;
            }

            return estado;
        }

        public enum Curso
        {
            TURISMO, ANALISES, ELETRICIDADE, INFORMATICA
        }

        public enum MessageType
        {
            INFORMATION, WARNING, ERROR
        }

        public static void sendMessage(string message)
        {
            MessageBox.Show(message);
        }

        public static void sendMessage(string message, MessageType type)
        {
            if (type == MessageType.INFORMATION)
            {
                MessageBox.Show(message, "Aviso: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (type == MessageType.WARNING)
            {
                MessageBox.Show(message, "Aviso: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (type == MessageType.ERROR)
            {
                MessageBox.Show(message, "Aviso: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void sendMessage(string message, MessageType type, string title)
        {
            if (type == MessageType.INFORMATION)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (type == MessageType.WARNING)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (type == MessageType.ERROR)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		
        public static int getMaxLines(System.IO.StreamReader read)
        {
            int contarLinhas = 0;

            string linha = read.ReadLine();

            while (linha != null)
            {
                contarLinhas++;
                linha = read.ReadLine();
            }

            read.Close();

            return contarLinhas;
        }

        public static void Sair()
        {
            DialogResult dr = MessageBox.Show("Tem a certeza que pretende sair da aplicação?", "Confirmar: ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        Application.Exit();
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
            }
        }

        public static void Sair(string mensagem)
        {
            DialogResult dr = MessageBox.Show(mensagem, "Confirmar: ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        Application.Exit();
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
            }
        }

        public static String invalidArgument = "Insira apenas números!";
        public static String nullReference = "Preencha todos os campos!";
    }
}


