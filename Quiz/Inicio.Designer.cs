﻿namespace Quiz
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Leave_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nickname_Tb = new System.Windows.Forms.TextBox();
            this.Play_Button = new System.Windows.Forms.Button();
            this.sobre_Button = new System.Windows.Forms.Button();
            this.warning_Pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.warning_Pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Leave_Button
            // 
            this.Leave_Button.BackColor = System.Drawing.Color.White;
            this.Leave_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Leave_Button.Font = new System.Drawing.Font("Rocks__G", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leave_Button.Location = new System.Drawing.Point(310, 393);
            this.Leave_Button.Name = "Leave_Button";
            this.Leave_Button.Size = new System.Drawing.Size(187, 56);
            this.Leave_Button.TabIndex = 8;
            this.Leave_Button.Text = "SAIR";
            this.Leave_Button.UseVisualStyleBackColor = false;
            this.Leave_Button.Click += new System.EventHandler(this.Leave_Button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Rocks__G", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Indique-nos um nickname: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Nickname_Tb
            // 
            this.Nickname_Tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nickname_Tb.Font = new System.Drawing.Font("Rocks__G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nickname_Tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nickname_Tb.Location = new System.Drawing.Point(149, 134);
            this.Nickname_Tb.Name = "Nickname_Tb";
            this.Nickname_Tb.Size = new System.Drawing.Size(225, 28);
            this.Nickname_Tb.TabIndex = 7;
            this.Nickname_Tb.TextChanged += new System.EventHandler(this.Nickname_Tb_TextChanged);
            // 
            // Play_Button
            // 
            this.Play_Button.BackColor = System.Drawing.Color.White;
            this.Play_Button.Enabled = false;
            this.Play_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_Button.Font = new System.Drawing.Font("Rocks__G", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Button.Location = new System.Drawing.Point(149, 220);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(225, 80);
            this.Play_Button.TabIndex = 5;
            this.Play_Button.Text = "JOGAR";
            this.Play_Button.UseVisualStyleBackColor = false;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // sobre_Button
            // 
            this.sobre_Button.BackColor = System.Drawing.Color.White;
            this.sobre_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sobre_Button.Font = new System.Drawing.Font("Rocks__G", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobre_Button.Location = new System.Drawing.Point(22, 393);
            this.sobre_Button.Name = "sobre_Button";
            this.sobre_Button.Size = new System.Drawing.Size(187, 56);
            this.sobre_Button.TabIndex = 9;
            this.sobre_Button.Text = "SOBRE";
            this.sobre_Button.UseVisualStyleBackColor = false;
            this.sobre_Button.Click += new System.EventHandler(this.Sobre_Button_Click);
            // 
            // warning_Pb
            // 
            this.warning_Pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.warning_Pb.Image = ((System.Drawing.Image)(resources.GetObject("warning_Pb.Image")));
            this.warning_Pb.Location = new System.Drawing.Point(380, 134);
            this.warning_Pb.Name = "warning_Pb";
            this.warning_Pb.Size = new System.Drawing.Size(31, 28);
            this.warning_Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.warning_Pb.TabIndex = 10;
            this.warning_Pb.TabStop = false;
            this.warning_Pb.Visible = false;
            // 
            // Inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(519, 461);
            this.Controls.Add(this.warning_Pb);
            this.Controls.Add(this.sobre_Button);
            this.Controls.Add(this.Leave_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nickname_Tb);
            this.Controls.Add(this.Play_Button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuiZ";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warning_Pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Leave_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nickname_Tb;
        private System.Windows.Forms.Button Play_Button;
        private System.Windows.Forms.Button sobre_Button;
        private System.Windows.Forms.PictureBox warning_Pb;
    }
}

