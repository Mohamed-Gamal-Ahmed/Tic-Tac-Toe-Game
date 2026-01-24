namespace Tic_Tac_Toe_Game
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlayerTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(133, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turn";
            // 
            // lbPlayerTurn
            // 
            this.lbPlayerTurn.AutoSize = true;
            this.lbPlayerTurn.Font = new System.Drawing.Font("Arial Black", 20F);
            this.lbPlayerTurn.ForeColor = System.Drawing.Color.White;
            this.lbPlayerTurn.Location = new System.Drawing.Point(107, 257);
            this.lbPlayerTurn.Name = "lbPlayerTurn";
            this.lbPlayerTurn.Size = new System.Drawing.Size(129, 38);
            this.lbPlayerTurn.TabIndex = 2;
            this.lbPlayerTurn.Text = "Player1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(125, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Winner";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Arial Black", 20F);
            this.lbWinner.ForeColor = System.Drawing.Color.Lime;
            this.lbWinner.Location = new System.Drawing.Point(84, 380);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(187, 38);
            this.lbWinner.TabIndex = 4;
            this.lbWinner.Text = "In Progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.AutoSize = true;
            this.btnRestartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartGame.Font = new System.Drawing.Font("Arial Black", 22F);
            this.btnRestartGame.Location = new System.Drawing.Point(62, 437);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(253, 52);
            this.btnRestartGame.TabIndex = 5;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(542, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tic-Tac-Toe Game";
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(796, 355);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 101);
            this.button9.TabIndex = 15;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(795, 228);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 101);
            this.button8.TabIndex = 14;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(796, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 93);
            this.button7.TabIndex = 13;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(641, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 101);
            this.button6.TabIndex = 12;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(646, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 101);
            this.button5.TabIndex = 11;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(641, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 101);
            this.button4.TabIndex = 10;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(486, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 101);
            this.button3.TabIndex = 9;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(486, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 101);
            this.button2.TabIndex = 8;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button1.Location = new System.Drawing.Point(486, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 101);
            this.button1.TabIndex = 7;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.Tic_Tac_Toe_logo;
            this.pictureBox1.Location = new System.Drawing.Point(79, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1013, 543);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPlayerTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPlayerTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

