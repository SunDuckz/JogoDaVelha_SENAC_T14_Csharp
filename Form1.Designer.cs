﻿namespace JogoDaVelha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gpxInicial = new GroupBox();
            lblJogadorO = new Label();
            LblJogadorX = new Label();
            btnIniciar = new Button();
            btnO = new Button();
            btnX = new Button();
            gpxButtons = new GroupBox();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            gpxInicial.SuspendLayout();
            gpxButtons.SuspendLayout();
            SuspendLayout();
            // 
            // gpxInicial
            // 
            gpxInicial.Controls.Add(lblJogadorO);
            gpxInicial.Controls.Add(LblJogadorX);
            gpxInicial.Controls.Add(btnIniciar);
            gpxInicial.Controls.Add(btnO);
            gpxInicial.Controls.Add(btnX);
            gpxInicial.Location = new Point(35, 23);
            gpxInicial.Name = "gpxInicial";
            gpxInicial.Size = new Size(455, 449);
            gpxInicial.TabIndex = 0;
            gpxInicial.TabStop = false;
            // 
            // lblJogadorO
            // 
            lblJogadorO.AutoSize = true;
            lblJogadorO.Location = new Point(182, 333);
            lblJogadorO.Name = "lblJogadorO";
            lblJogadorO.Size = new Size(48, 25);
            lblJogadorO.TabIndex = 4;
            lblJogadorO.Text = "<<<";
            // 
            // LblJogadorX
            // 
            LblJogadorX.AutoSize = true;
            LblJogadorX.Location = new Point(182, 84);
            LblJogadorX.Name = "LblJogadorX";
            LblJogadorX.Size = new Size(48, 25);
            LblJogadorX.TabIndex = 3;
            LblJogadorX.Text = "<<<";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.White;
            btnIniciar.Enabled = false;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Old English Text MT", 30F);
            btnIniciar.Location = new Point(216, 185);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(218, 88);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnO
            // 
            btnO.BackColor = Color.Blue;
            btnO.FlatStyle = FlatStyle.Flat;
            btnO.Font = new Font("Papyrus", 52F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnO.ImageAlign = ContentAlignment.TopCenter;
            btnO.Location = new Point(6, 280);
            btnO.Name = "btnO";
            btnO.Size = new Size(158, 149);
            btnO.TabIndex = 1;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = false;
            btnO.Click += btnO_Click;
            // 
            // btnX
            // 
            btnX.BackColor = Color.Red;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Papyrus", 52F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnX.ImageAlign = ContentAlignment.TopCenter;
            btnX.Location = new Point(6, 30);
            btnX.Name = "btnX";
            btnX.Size = new Size(158, 149);
            btnX.TabIndex = 0;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // gpxButtons
            // 
            gpxButtons.Controls.Add(btn9);
            gpxButtons.Controls.Add(btn8);
            gpxButtons.Controls.Add(btn7);
            gpxButtons.Controls.Add(btn6);
            gpxButtons.Controls.Add(btn5);
            gpxButtons.Controls.Add(btn4);
            gpxButtons.Controls.Add(btn3);
            gpxButtons.Controls.Add(btn2);
            gpxButtons.Controls.Add(btn1);
            gpxButtons.Location = new Point(536, 23);
            gpxButtons.Name = "gpxButtons";
            gpxButtons.Size = new Size(612, 514);
            gpxButtons.TabIndex = 1;
            gpxButtons.TabStop = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Papyrus", 52F);
            btn9.Location = new Point(403, 340);
            btn9.Name = "btn9";
            btn9.Size = new Size(199, 149);
            btn9.TabIndex = 8;
            btn9.Text = "O";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Papyrus", 52F);
            btn8.Location = new Point(203, 340);
            btn8.Name = "btn8";
            btn8.Size = new Size(199, 149);
            btn8.TabIndex = 7;
            btn8.Text = "O";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Papyrus", 52F);
            btn7.Location = new Point(3, 340);
            btn7.Name = "btn7";
            btn7.Size = new Size(199, 149);
            btn7.TabIndex = 6;
            btn7.Text = "O";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Papyrus", 52F);
            btn6.Location = new Point(404, 185);
            btn6.Name = "btn6";
            btn6.Size = new Size(199, 149);
            btn6.TabIndex = 5;
            btn6.Text = "O";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Papyrus", 52F);
            btn5.Location = new Point(204, 185);
            btn5.Name = "btn5";
            btn5.Size = new Size(199, 149);
            btn5.TabIndex = 4;
            btn5.Text = "O";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Papyrus", 52F);
            btn4.Location = new Point(4, 185);
            btn4.Name = "btn4";
            btn4.Size = new Size(199, 149);
            btn4.TabIndex = 3;
            btn4.Text = "O";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Papyrus", 52F);
            btn3.Location = new Point(403, 30);
            btn3.Name = "btn3";
            btn3.Size = new Size(199, 149);
            btn3.TabIndex = 2;
            btn3.Text = "O";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Papyrus", 52F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(203, 30);
            btn2.Name = "btn2";
            btn2.Size = new Size(199, 149);
            btn2.TabIndex = 1;
            btn2.Text = "O";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Papyrus", 52F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(3, 30);
            btn1.Name = "btn1";
            btn1.Size = new Size(199, 149);
            btn1.TabIndex = 0;
            btn1.Text = "O";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1151, 545);
            Controls.Add(gpxButtons);
            Controls.Add(gpxInicial);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gpxInicial.ResumeLayout(false);
            gpxInicial.PerformLayout();
            gpxButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxInicial;
        private Button btnIniciar;
        private Button btnO;
        private Button btnX;
        private GroupBox gpxButtons;
        private Label LblJogadorX;
        private Label lblJogadorO;
        private Button btn1;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
    }
}
