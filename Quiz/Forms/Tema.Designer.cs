namespace Quiz
{
    partial class Tema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tema));
            this.Eletricidade_Button = new System.Windows.Forms.Button();
            this.Analises_Button = new System.Windows.Forms.Button();
            this.Voltar_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Informatica_Button = new System.Windows.Forms.Button();
            this.Turismo_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eletricidade_Button
            // 
            this.Eletricidade_Button.BackColor = System.Drawing.Color.White;
            this.Eletricidade_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eletricidade_Button.Font = new System.Drawing.Font("Impact", 20.25F);
            this.Eletricidade_Button.Location = new System.Drawing.Point(298, 230);
            this.Eletricidade_Button.Name = "Eletricidade_Button";
            this.Eletricidade_Button.Size = new System.Drawing.Size(225, 80);
            this.Eletricidade_Button.TabIndex = 11;
            this.Eletricidade_Button.Text = "INSTALAÇÕES ELÉTRICAS";
            this.Eletricidade_Button.UseVisualStyleBackColor = false;
            this.Eletricidade_Button.Click += new System.EventHandler(this.Eletricidade_Button_Click);
            // 
            // Analises_Button
            // 
            this.Analises_Button.BackColor = System.Drawing.Color.White;
            this.Analises_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Analises_Button.Font = new System.Drawing.Font("Impact", 20.25F);
            this.Analises_Button.Location = new System.Drawing.Point(27, 230);
            this.Analises_Button.Name = "Analises_Button";
            this.Analises_Button.Size = new System.Drawing.Size(225, 80);
            this.Analises_Button.TabIndex = 10;
            this.Analises_Button.Text = "ANÁLISES LABORATORIAIS";
            this.Analises_Button.UseVisualStyleBackColor = false;
            this.Analises_Button.Click += new System.EventHandler(this.Analises_Button_Click);
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.BackColor = System.Drawing.Color.White;
            this.Voltar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Voltar_Button.Font = new System.Drawing.Font("Impact", 20.25F);
            this.Voltar_Button.Location = new System.Drawing.Point(161, 361);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(225, 80);
            this.Voltar_Button.TabIndex = 12;
            this.Voltar_Button.Text = "VOLTAR";
            this.Voltar_Button.UseVisualStyleBackColor = false;
            this.Voltar_Button.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "ESCOLHA O TEMA DO QUIZ:";
            // 
            // Informatica_Button
            // 
            this.Informatica_Button.BackColor = System.Drawing.Color.White;
            this.Informatica_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Informatica_Button.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informatica_Button.Location = new System.Drawing.Point(27, 114);
            this.Informatica_Button.Name = "Informatica_Button";
            this.Informatica_Button.Size = new System.Drawing.Size(225, 80);
            this.Informatica_Button.TabIndex = 6;
            this.Informatica_Button.Text = "INFORMÁTICA";
            this.Informatica_Button.UseVisualStyleBackColor = false;
            this.Informatica_Button.Click += new System.EventHandler(this.Informatica_Button_Click);
            // 
            // Turismo_Button
            // 
            this.Turismo_Button.BackColor = System.Drawing.Color.White;
            this.Turismo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Turismo_Button.Font = new System.Drawing.Font("Impact", 20.25F);
            this.Turismo_Button.Location = new System.Drawing.Point(298, 114);
            this.Turismo_Button.Name = "Turismo_Button";
            this.Turismo_Button.Size = new System.Drawing.Size(225, 80);
            this.Turismo_Button.TabIndex = 8;
            this.Turismo_Button.Text = "TURISMO DE ANIMAÇÃO";
            this.Turismo_Button.UseVisualStyleBackColor = false;
            this.Turismo_Button.Click += new System.EventHandler(this.Turismo_Button_Click);
            // 
            // Tema
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(550, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Voltar_Button);
            this.Controls.Add(this.Eletricidade_Button);
            this.Controls.Add(this.Analises_Button);
            this.Controls.Add(this.Turismo_Button);
            this.Controls.Add(this.Informatica_Button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuiZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Eletricidade_Button;
        private System.Windows.Forms.Button Analises_Button;
        private System.Windows.Forms.Button Voltar_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Informatica_Button;
        private System.Windows.Forms.Button Turismo_Button;
    }
}