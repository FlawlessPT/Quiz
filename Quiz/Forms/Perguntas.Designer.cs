namespace Quiz
{
    partial class Perguntas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pergunta = new System.Windows.Forms.Label();
            this.Resposta2 = new System.Windows.Forms.Button();
            this.Resposta1 = new System.Windows.Forms.Button();
            this.Resposta4 = new System.Windows.Forms.Button();
            this.Resposta3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pergunta
            // 
            this.Pergunta.AutoSize = true;
            this.Pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pergunta.ForeColor = System.Drawing.Color.White;
            this.Pergunta.Location = new System.Drawing.Point(223, 39);
            this.Pergunta.Name = "Pergunta";
            this.Pergunta.Size = new System.Drawing.Size(107, 25);
            this.Pergunta.TabIndex = 16;
            this.Pergunta.Text = "Pergunta";
            // 
            // Resposta2
            // 
            this.Resposta2.BackColor = System.Drawing.Color.White;
            this.Resposta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resposta2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta2.Location = new System.Drawing.Point(76, 203);
            this.Resposta2.Name = "Resposta2";
            this.Resposta2.Size = new System.Drawing.Size(400, 80);
            this.Resposta2.TabIndex = 14;
            this.Resposta2.Text = "Resposta 2";
            this.Resposta2.UseVisualStyleBackColor = false;
            // 
            // Resposta1
            // 
            this.Resposta1.BackColor = System.Drawing.Color.White;
            this.Resposta1.Enabled = false;
            this.Resposta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resposta1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta1.Location = new System.Drawing.Point(76, 89);
            this.Resposta1.Name = "Resposta1";
            this.Resposta1.Size = new System.Drawing.Size(400, 80);
            this.Resposta1.TabIndex = 15;
            this.Resposta1.Text = "Resposta 1";
            this.Resposta1.UseVisualStyleBackColor = false;
            // 
            // Resposta4
            // 
            this.Resposta4.BackColor = System.Drawing.Color.White;
            this.Resposta4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resposta4.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta4.Location = new System.Drawing.Point(76, 433);
            this.Resposta4.Name = "Resposta4";
            this.Resposta4.Size = new System.Drawing.Size(400, 80);
            this.Resposta4.TabIndex = 17;
            this.Resposta4.Text = "Resposta 4";
            this.Resposta4.UseVisualStyleBackColor = false;
            // 
            // Resposta3
            // 
            this.Resposta3.BackColor = System.Drawing.Color.White;
            this.Resposta3.Enabled = false;
            this.Resposta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resposta3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta3.Location = new System.Drawing.Point(76, 319);
            this.Resposta3.Name = "Resposta3";
            this.Resposta3.Size = new System.Drawing.Size(400, 80);
            this.Resposta3.TabIndex = 18;
            this.Resposta3.Text = "Resposta 3";
            this.Resposta3.UseVisualStyleBackColor = false;
            // 
            // Perguntas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(550, 546);
            this.Controls.Add(this.Resposta4);
            this.Controls.Add(this.Resposta3);
            this.Controls.Add(this.Pergunta);
            this.Controls.Add(this.Resposta2);
            this.Controls.Add(this.Resposta1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Perguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuiZ";
            this.Load += new System.EventHandler(this.Perguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pergunta;
        private System.Windows.Forms.Button Resposta2;
        private System.Windows.Forms.Button Resposta1;
        private System.Windows.Forms.Button Resposta4;
        private System.Windows.Forms.Button Resposta3;
    }
}