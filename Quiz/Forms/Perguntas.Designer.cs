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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perguntas));
            this.Pergunta_Label = new System.Windows.Forms.Label();
            this.Resposta2 = new System.Windows.Forms.Button();
            this.Resposta1 = new System.Windows.Forms.Button();
            this.Resposta4 = new System.Windows.Forms.Button();
            this.Resposta3 = new System.Windows.Forms.Button();
            this.Tema_Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tempo_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pergunta_Label
            // 
            this.Pergunta_Label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pergunta_Label.ForeColor = System.Drawing.Color.White;
            this.Pergunta_Label.Location = new System.Drawing.Point(71, 66);
            this.Pergunta_Label.Name = "Pergunta_Label";
            this.Pergunta_Label.Size = new System.Drawing.Size(405, 58);
            this.Pergunta_Label.TabIndex = 16;
            this.Pergunta_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Resposta2
            // 
            this.Resposta2.BackColor = System.Drawing.Color.White;
            this.Resposta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resposta2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta2.Location = new System.Drawing.Point(76, 256);
            this.Resposta2.Name = "Resposta2";
            this.Resposta2.Size = new System.Drawing.Size(400, 80);
            this.Resposta2.TabIndex = 14;
            this.Resposta2.Text = "Resposta 2";
            this.Resposta2.UseVisualStyleBackColor = false;
            this.Resposta2.Click += new System.EventHandler(this.Resposta2_Click);
            // 
            // Resposta1
            // 
            this.Resposta1.BackColor = System.Drawing.Color.White;
            this.Resposta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resposta1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta1.Location = new System.Drawing.Point(76, 142);
            this.Resposta1.Name = "Resposta1";
            this.Resposta1.Size = new System.Drawing.Size(400, 80);
            this.Resposta1.TabIndex = 15;
            this.Resposta1.Text = "Resposta 1";
            this.Resposta1.UseVisualStyleBackColor = false;
            this.Resposta1.TextChanged += new System.EventHandler(this.Resposta1_TextChanged);
            this.Resposta1.Click += new System.EventHandler(this.Resposta1_Click);
            // 
            // Resposta4
            // 
            this.Resposta4.BackColor = System.Drawing.Color.White;
            this.Resposta4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resposta4.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta4.Location = new System.Drawing.Point(76, 486);
            this.Resposta4.Name = "Resposta4";
            this.Resposta4.Size = new System.Drawing.Size(400, 80);
            this.Resposta4.TabIndex = 17;
            this.Resposta4.Text = "Resposta 4";
            this.Resposta4.UseVisualStyleBackColor = false;
            this.Resposta4.Click += new System.EventHandler(this.Resposta4_Click);
            // 
            // Resposta3
            // 
            this.Resposta3.BackColor = System.Drawing.Color.White;
            this.Resposta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resposta3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta3.Location = new System.Drawing.Point(76, 372);
            this.Resposta3.Name = "Resposta3";
            this.Resposta3.Size = new System.Drawing.Size(400, 80);
            this.Resposta3.TabIndex = 18;
            this.Resposta3.Text = "Resposta 3";
            this.Resposta3.UseVisualStyleBackColor = false;
            this.Resposta3.Click += new System.EventHandler(this.Resposta3_Click);
            // 
            // Tema_Label
            // 
            this.Tema_Label.BackColor = System.Drawing.Color.Indigo;
            this.Tema_Label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tema_Label.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Tema_Label.Location = new System.Drawing.Point(144, 26);
            this.Tema_Label.Name = "Tema_Label";
            this.Tema_Label.Size = new System.Drawing.Size(319, 36);
            this.Tema_Label.TabIndex = 19;
            this.Tema_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tempo_Label
            // 
            this.Tempo_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tempo_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tempo_Label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tempo_Label.ForeColor = System.Drawing.Color.White;
            this.Tempo_Label.Location = new System.Drawing.Point(502, 67);
            this.Tempo_Label.Name = "Tempo_Label";
            this.Tempo_Label.Size = new System.Drawing.Size(53, 30);
            this.Tempo_Label.TabIndex = 20;
            this.Tempo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tema:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Perguntas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(582, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tempo_Label);
            this.Controls.Add(this.Tema_Label);
            this.Controls.Add(this.Resposta4);
            this.Controls.Add(this.Resposta3);
            this.Controls.Add(this.Resposta2);
            this.Controls.Add(this.Resposta1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pergunta_Label);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Perguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuiZ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Perguntas_FormClosing);
            this.Load += new System.EventHandler(this.Perguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Pergunta_Label;
        private System.Windows.Forms.Button Resposta2;
        private System.Windows.Forms.Button Resposta1;
        private System.Windows.Forms.Button Resposta4;
        private System.Windows.Forms.Button Resposta3;
        private System.Windows.Forms.Label Tema_Label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Tempo_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}