namespace RollingDice
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.PcBox2 = new System.Windows.Forms.PictureBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.PcBox1 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblWhichPlayer = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PcBox2
            // 
            this.PcBox2.BackColor = System.Drawing.Color.Gray;
            this.PcBox2.Location = new System.Drawing.Point(229, 73);
            this.PcBox2.Name = "PcBox2";
            this.PcBox2.Size = new System.Drawing.Size(111, 114);
            this.PcBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBox2.TabIndex = 1;
            this.PcBox2.TabStop = false;
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.Color.DarkRed;
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRollDice.Location = new System.Drawing.Point(119, 209);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(165, 35);
            this.btnRollDice.TabIndex = 2;
            this.btnRollDice.Text = "Roll";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // PcBox1
            // 
            this.PcBox1.BackColor = System.Drawing.Color.Gray;
            this.PcBox1.Location = new System.Drawing.Point(68, 73);
            this.PcBox1.Name = "PcBox1";
            this.PcBox1.Size = new System.Drawing.Size(111, 114);
            this.PcBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBox1.TabIndex = 3;
            this.PcBox1.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer1.Location = new System.Drawing.Point(476, 37);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(78, 25);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "Player1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer2.Location = new System.Drawing.Point(560, 37);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(78, 25);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "Player2";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(502, 65);
            this.listBox1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(42, 154);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(581, 65);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(41, 154);
            this.listBox2.TabIndex = 7;
            // 
            // lblWhichPlayer
            // 
            this.lblWhichPlayer.AutoSize = true;
            this.lblWhichPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWhichPlayer.Location = new System.Drawing.Point(61, 20);
            this.lblWhichPlayer.Name = "lblWhichPlayer";
            this.lblWhichPlayer.Size = new System.Drawing.Size(133, 39);
            this.lblWhichPlayer.TabIndex = 8;
            this.lblWhichPlayer.Text = "Player1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.DarkGray;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWinner.Location = new System.Drawing.Point(200, 31);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(362, 39);
            this.lblWinner.TabIndex = 9;
            this.lblWinner.Text = "WINNER IS PLAYER1";
            this.lblWinner.Visible = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewGame.Location = new System.Drawing.Point(244, 209);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(219, 54);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuit.Location = new System.Drawing.Point(262, 286);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(171, 41);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(238, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "PLAYER1 SCORE :";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(238, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "PLAYER2 SCORE :";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(429, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "50";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(429, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "50";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblWhichPlayer);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.PcBox1);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.PcBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PcBox2;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.PictureBox PcBox1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblWhichPlayer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

