namespace MarioBounceGameTutorial
{
    partial class Form2
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
            this.ball = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = global::MarioBounceGameTutorial.Properties.Resources.redBall;
            this.ball.Location = new System.Drawing.Point(124, 261);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(75, 71);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 9;
            this.ball.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::MarioBounceGameTutorial.Properties.Resources.pipeUp;
            this.pipeTop.Location = new System.Drawing.Point(437, -15);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(173, 216);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 8;
            this.pipeTop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::MarioBounceGameTutorial.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-44, 605);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(795, 115);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 6;
            this.ground.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::MarioBounceGameTutorial.Properties.Resources.pipedown;
            this.pipebottom.Location = new System.Drawing.Point(319, 423);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(178, 223);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 7;
            this.pipebottom.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Khaki;
            this.scoreText.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(12, 660);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(134, 36);
            this.scoreText.TabIndex = 10;
            this.scoreText.Text = "Score : 0";
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBtn.Location = new System.Drawing.Point(480, 660);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(130, 33);
            this.MainMenuBtn.TabIndex = 11;
            this.MainMenuBtn.Text = "MainMenu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.Location = new System.Drawing.Point(613, 660);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(91, 33);
            this.restartBtn.TabIndex = 12;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(707, 705);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipebottom);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Timer gameTimer;
    }
}