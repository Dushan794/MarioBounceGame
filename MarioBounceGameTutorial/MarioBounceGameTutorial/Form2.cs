using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarioBounceGameTutorial
{
    public partial class Form2 : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        Thread th2;
        Thread thRestart;

        public Form2()
        {
            InitializeComponent();
        }
        //Timer Event
        private void gameTimerEvent(object sender, EventArgs e)
        {
            ball.Top += gravity;
            pipebottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;
            if(pipebottom.Left < -70)
            {
                pipebottom.Left = 750;
                score++;
            }
            if (pipeTop.Left < -70)
            {
                pipeTop.Left = 700;
                score++;
            }

            //Checking for Collitions
            if (ball.Bounds.IntersectsWith(pipebottom.Bounds)||
               ball.Bounds.IntersectsWith(pipeTop.Bounds) ||
               ball.Bounds.IntersectsWith(ground.Bounds) ||
                ball.Top < -10 
                )
            {
                endGame();
            }

            //Increasing Pipe Speed
            if(score > 5)
            {
                pipeSpeed = 12;
            }
            if (score > 14)
            {
                pipeSpeed = 16;
            }
            if (score > 25)
            {
                pipeSpeed = 20;
            }
            if (score > 35)
            {
                pipeSpeed = 25;
            }
        }
        //On Form Load
        private void Form2_Load(object sender, EventArgs e)
        {
            restartBtn.Visible = false;
            MainMenuBtn.Visible = false;
        }
        //Game Over Method
        private void endGame()
        {
            //Game SOUNDS
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\bgMusic.wav";
            sp.Stop();

            //Game Over Sound
            SoundPlayer gameOver = new SoundPlayer();
            gameOver.SoundLocation = @".\gameOver.wav";
            gameOver.Play();

            gameTimer.Stop();
            scoreText.Text += " Game Over !";
            restartBtn.Visible = true;
            MainMenuBtn.Visible = true;
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\bgMusic.wav";
            sp.Play();
            this.Close();
            thRestart = new Thread(restartGame);
            thRestart.SetApartmentState(ApartmentState.STA);
            thRestart.Start();

        }

        private void restartGame()
        {
            Application.Run(new Form2());
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th2 = new Thread(openMainMenu);
            th2.SetApartmentState(ApartmentState.STA);
            th2.Start();
        }

        private void openMainMenu()
        {
            Application.Run(new MainMenu());
        }
    }
}
