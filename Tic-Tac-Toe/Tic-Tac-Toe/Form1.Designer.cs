namespace Tic_Tac_Toe
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
            label1 = new Label();
            label2 = new Label();
            TextPontosX = new TextBox();
            TextPontosO = new TextBox();
            BtnIniciar = new Button();
            BtnReiniciar = new Button();
            label3 = new Label();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 91);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 0;
            label1.Text = "Jogador X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(394, 91);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 1;
            label2.Text = "Jogador O";
            // 
            // TextPontosX
            // 
            TextPontosX.Enabled = false;
            TextPontosX.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextPontosX.Location = new Point(237, 91);
            TextPontosX.Name = "TextPontosX";
            TextPontosX.Size = new Size(100, 26);
            TextPontosX.TabIndex = 2;
            // 
            // TextPontosO
            // 
            TextPontosO.Enabled = false;
            TextPontosO.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextPontosO.Location = new Point(527, 91);
            TextPontosO.Name = "TextPontosO";
            TextPontosO.Size = new Size(100, 26);
            TextPontosO.TabIndex = 3;
            TextPontosO.TextChanged += TextPontosO_TextChanged;
            // 
            // BtnIniciar
            // 
            BtnIniciar.BackColor = Color.FromArgb(128, 255, 128);
            BtnIniciar.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIniciar.Location = new Point(215, 131);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(172, 57);
            BtnIniciar.TabIndex = 4;
            BtnIniciar.Tag = "";
            BtnIniciar.Text = "Iniciar Jogo";
            BtnIniciar.UseVisualStyleBackColor = false;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // BtnReiniciar
            // 
            BtnReiniciar.BackColor = Color.FromArgb(255, 255, 128);
            BtnReiniciar.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnReiniciar.Location = new Point(416, 131);
            BtnReiniciar.Name = "BtnReiniciar";
            BtnReiniciar.Size = new Size(172, 57);
            BtnReiniciar.TabIndex = 5;
            BtnReiniciar.Tag = "";
            BtnReiniciar.Text = "Reiniciar";
            BtnReiniciar.UseVisualStyleBackColor = false;
            BtnReiniciar.Click += BtnReiniciar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(309, 31);
            label3.Name = "label3";
            label3.Size = new Size(190, 33);
            label3.TabIndex = 6;
            label3.Text = "Tic-Tac-Toe";
            // 
            // b1
            // 
            b1.BackColor = Color.FromArgb(192, 192, 255);
            b1.Enabled = false;
            b1.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            b1.ForeColor = Color.Blue;
            b1.Location = new Point(288, 194);
            b1.Name = "b1";
            b1.Size = new Size(70, 70);
            b1.TabIndex = 7;
            b1.Tag = "jogo";
            b1.UseVisualStyleBackColor = false;
            b1.Click += Button_Click;
            // 
            // b2
            // 
            b2.BackColor = Color.FromArgb(192, 192, 255);
            b2.Enabled = false;
            b2.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            b2.ForeColor = Color.Blue;
            b2.Location = new Point(364, 194);
            b2.Name = "b2";
            b2.Size = new Size(70, 70);
            b2.TabIndex = 8;
            b2.Tag = "jogo";
            b2.UseVisualStyleBackColor = false;
            b2.Click += Button_Click;
            // 
            // b3
            // 
            b3.BackColor = Color.FromArgb(192, 192, 255);
            b3.Enabled = false;
            b3.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            b3.ForeColor = Color.Blue;
            b3.Location = new Point(440, 194);
            b3.Name = "b3";
            b3.Size = new Size(70, 70);
            b3.TabIndex = 9;
            b3.Tag = "jogo";
            b3.UseVisualStyleBackColor = false;
            b3.Click += Button_Click;
            // 
            // b4
            // 
            b4.BackColor = Color.FromArgb(192, 192, 255);
            b4.Enabled = false;
            b4.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            b4.ForeColor = Color.Blue;
            b4.Location = new Point(288, 270);
            b4.Name = "b4";
            b4.Size = new Size(70, 70);
            b4.TabIndex = 10;
            b4.Tag = "jogo";
            b4.UseVisualStyleBackColor = false;
            b4.Click += Button_Click;
            // 
            // b5
            // 
            b5.BackColor = Color.FromArgb(192, 192, 255);
            b5.Enabled = false;
            b5.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            b5.ForeColor = Color.Blue;
            b5.Location = new Point(364, 270);
            b5.Name = "b5";
            b5.Size = new Size(70, 70);
            b5.TabIndex = 11;
            b5.Tag = "jogo";
            b5.UseVisualStyleBackColor = false;
            b5.Click += Button_Click;
            // 
            // b6
            // 
            b6.BackColor = Color.FromArgb(192, 192, 255);
            b6.Enabled = false;
            b6.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            b6.ForeColor = Color.Blue;
            b6.Location = new Point(440, 270);
            b6.Name = "b6";
            b6.Size = new Size(70, 70);
            b6.TabIndex = 12;
            b6.Tag = "jogo";
            b6.UseVisualStyleBackColor = false;
            b6.Click += Button_Click;
            // 
            // b7
            // 
            b7.BackColor = Color.FromArgb(192, 192, 255);
            b7.Enabled = false;
            b7.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            b7.ForeColor = Color.Blue;
            b7.Location = new Point(288, 346);
            b7.Name = "b7";
            b7.Size = new Size(70, 70);
            b7.TabIndex = 13;
            b7.Tag = "jogo";
            b7.UseVisualStyleBackColor = false;
            b7.Click += Button_Click;
            // 
            // b8
            // 
            b8.BackColor = Color.FromArgb(192, 192, 255);
            b8.Enabled = false;
            b8.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            b8.ForeColor = Color.Blue;
            b8.Location = new Point(364, 346);
            b8.Name = "b8";
            b8.Size = new Size(70, 70);
            b8.TabIndex = 14;
            b8.Tag = "jogo";
            b8.UseVisualStyleBackColor = false;
            b8.Click += Button_Click;
            // 
            // b9
            // 
            b9.BackColor = Color.FromArgb(192, 192, 255);
            b9.Enabled = false;
            b9.Font = new Font("Snap ITC", 18F, FontStyle.Bold);
            b9.ForeColor = Color.Blue;
            b9.Location = new Point(440, 346);
            b9.Name = "b9";
            b9.Size = new Size(70, 70);
            b9.TabIndex = 15;
            b9.Tag = "jogo";
            b9.UseVisualStyleBackColor = false;
            b9.Click += Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(label3);
            Controls.Add(BtnReiniciar);
            Controls.Add(BtnIniciar);
            Controls.Add(TextPontosO);
            Controls.Add(TextPontosX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextPontosX;
        private TextBox TextPontosO;
        private Button BtnIniciar;
        private Button BtnReiniciar;
        private Label label3;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
    }
}
