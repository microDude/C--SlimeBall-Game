using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SlimeBall
{
    public partial class frmGame : Form
    {
        private bool AICompleteFlag = true;
        private bool slimer1UpKeyFlag = false;
        private bool slimer2UpKeyFlag = false;
        private bool S1BallCollision = false;
        private bool S2BallCollision = false;
        private int totalGames = 5; // must be odd
        private int netDebounceTimer = 0; //Debounce Timer for the net

        /// <summary>
        /// Enumerated values for controlling the state of the game.
        /// </summary>
        private enum GameState : int
        {
            NotRun = 0,
            Running = 1,
            Paused = 2,
            PointScoredByP1 = 3,
            PointScoredByP2 = 4,
            NewServe = 5,
            Stop = 6,
            FirstTimeDrawSprites = 7,
            NewGame = 8
        }

        private long timerCounter = 0;
        
        private Score gameScore;
        private Sprite[] gameSprites;
        private Ball ball;
        private Slimer slimer1;
        private Slimer slimer2;
        private Net net;
        private GameState gameState = GameState.NotRun;

        public frmGame()
        {
            InitializeComponent();
            // reduce flicker
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            InitializeAllSprites();
        }

        /// <summary>
        /// Create instances of each sprite.  Pass the desired parameters as arguments to the class constructors.
        /// Assign each sprite a unique index in "gameSprites[]" for later drawing.
        /// </summary>
        private void InitializeAllSprites()
        {
            gameSprites = new Sprite[4];
            
            net = new Net("net.png", this.Width / 2, this.Height - 150);
            slimer1 = new Slimer("slimer.png", 0, this.Width / 2, 7f, 7f, this.Width / 4 - net.Width / 2, this.Height - 100);
            slimer2 = new Slimer("slimer.png", this.Width / 2 + net.Width / 2, this.Width, 7f, 7f, (this.Width - net.Width) * 3 / 4, this.Height - 100);
            ball = new Ball("ball.png", this.Width / 4 - net.Width / 2, 200);


            ball.setVelocityInX(0);
            ball.setVelocityInY(2);

            //Assign each sprite to a fixed index in the gameSprite[] array.  Used for drawing later on.
            gameSprites[0] = ball;
            gameSprites[1] = slimer1;
            gameSprites[2] = slimer2;
            gameSprites[3] = net;

            gameScore = new Score(2);
            lblScoreSlimer1.Text = gameScore.GetScore(0).ToString();
            lblScoreSlimer2.Text = gameScore.GetScore(1).ToString();

            gameState = GameState.FirstTimeDrawSprites; //Initalize the game state.
        }

        /// <summary>
        /// Uses the Windows API to monitor the keyboard state.
        /// If the assigned key is pressed, then preform the assigned action/method call.
        /// </summary>
        private void handleControlKeys()
        {
            byte[] keyState = new byte[256];
            for (int i = 0; i < 256; i++)
                keyState[i] = 0;

            KeyBoardState.GetKeyBoardState(ref keyState);

            if (keyState[(int)KeyBoardState.VirtualKeyCodes.Left] != 0)
            {
                slimer2.moveLeft();                
            }

            if (keyState[(int)KeyBoardState.VirtualKeyCodes.Right] != 0)
            {
                slimer2.moveRight();                
            }

            if (keyState[(int)KeyBoardState.VirtualKeyCodes.Up] != 0)
            {
                if (slimer2.getPosition().Y > 300 && slimer2UpKeyFlag == true && S2BallCollision==false)
                {                    
                    slimer2.moveUp(15); //moves the slimer up by the fixed pixel value
                }
                else
                    slimer2UpKeyFlag = false;
            }

            if (keyState[(int)KeyBoardState.VirtualKeyCodes.A] != 0)
            {
                slimer1.moveLeft();
            }

            if (keyState[(int)KeyBoardState.VirtualKeyCodes.D] != 0)
            {
                slimer1.moveRight();
            }

            if (keyState[(int)KeyBoardState.VirtualKeyCodes.W] != 0)
            {
                if (slimer1.getPosition().Y > 300 && slimer1UpKeyFlag == true && S1BallCollision == false)
                {
                    slimer1.moveUp(15); //moves the slimer up by the fixed pixel value
                }
                else
                    slimer1UpKeyFlag = false;
            }
        }

        /// <summary>
        /// Controls moving the ball location around the screen.  Does not paint the image here.
        /// </summary>
        private void moveBall()
        {
            //Boundry Condition
            int BoundryCondition = 0;
            
            //Move the ball.
            ball.updateMovement();

            BoundryCondition = ball.hitBoundry(this.Width, this.Height);

            //Check whether the ball hits the floor or walls
            switch (BoundryCondition)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        ball.setVelocityInX(-ball.getVelocityInX());
                        break;
                    }
                case 2:
                    {
                        ball.setVelocityInX(-ball.getVelocityInX());
                        break;
                    }
                case 3:
                    {
                        //Split the playing area by 2 and decide, which half the ball is on.
                        if (ball.getPosition().X < this.Width / 2)
                            gameState = GameState.PointScoredByP2;
                        else
                            gameState = GameState.PointScoredByP1;
                        break;
                    }

                default:
                    {
                        break;
                    }
            }


            //float ballx = ball.getPosition().X;
            //float bally = ball.getPosition().Y;

            ////Did the ball hit the side of the form.  If so, reverese the direction.
            //if (ballx < 0 || ballx + ball.Width > this.Width)
            //    ball.setVelocityInX(-vxball);

            ////Did the ball hit the floor?  If so, increment the score of a player.
            //if (bally> this.Height - 100)
            //{
            //    //Split the playing area by 2 and decide, which half the ball is on.
            //    if (ballx < this.Width / 2)
            //        gameState = GameState.PointScoredByP2;
            //    else
            //        gameState = GameState.PointScoredByP1;
            //}
        }

        /// <summary>
        /// Passes the values for display on the form.
        /// </summary>
        private void showScore()
        {
            int[] scores = gameScore.GetScores();
            lblScoreSlimer1.Text = scores[0].ToString();
            lblScoreSlimer2.Text = scores[1].ToString();
        }

        /// <summary>
        /// Decides if a collision has occured, if so, then change the ball velocity, which it turn will
        /// change the motion of the ball.
        /// </summary>
        private void HandleCollisions()
        {
            //Did the ball hit the net?
            if (ball.CheckCollision(net))
            {
                Point ballPos = ball.getPosition();
                Point netPos = net.getPosition();
                float vxball = ball.getVelocityInX();
                float vyball = ball.getVelocityInY();

                netDebounceTimer += 1;

                if (netDebounceTimer >= 2 || ((ball.getPosition().Y + ball.getHeight()) >= net.getPosition().Y)) 
                {
                    //If it hit the top of the net, then reverse the y-velocity
                    if (ballPos.X < net.getPosition().X && ballPos.X + ball.getWidth() > net.getPosition().X)
                    {
                        ball.setVelocityInY(-vyball);
                    }
                    //if the ball hits the rest part of the net, reverse x-direction velocity
                    else
                    ball.setVelocityInX(-vxball);
                }
            }
            if (ball.CheckCollision(slimer1))
            {

                S1BallCollision = true;
                ball.setVelocityInX((ball.getPosition().X - slimer1.getPosition().X) / 6);
                ball.setVelocityInY((ball.getPosition().Y - slimer1.getPosition().Y) / 6);
            }
            if (ball.CheckCollision(slimer2))
            {
                S2BallCollision = true;
                ball.setVelocityInX((ball.getPosition().X - slimer2.getPosition().X) / 6);
                ball.setVelocityInY((ball.getPosition().Y - slimer2.getPosition().Y) / 6);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblBallSpeedX.Text = ball.getVelocityInX().ToString();
            lblBallSpeedY.Text = ball.getVelocityInY().ToString();
            AICompleteFlag = false;
            handleControlKeys();
            HandleCollisions();
            moveBall();
            showScore();
            
            if (gameState == GameState.PointScoredByP1)
            {
                //slimer1's score is increased by 1
                gameScore.AddScore(0, 1);
                int totalScore = gameScore.GetScore(0) + gameScore.GetScore(1);
                showScore(); //Placed here to make sure that the score reflects the winning score upon exit
                if (totalScore == totalGames)
                {
                    lblPointScored.Text = gameScore.GetScore(0) < gameScore.GetScore(1) ? "Player2 Wins!!!" : "Player1 Wins";
                    lblPointScored.Visible = true;
                    tmrGameLoop.Stop();
                    tmrDecoupled.Stop();
                    gameState = GameState.Stop;                    
                }
                else
                {
                    lblPointScored.Text = "Player 1 Scores!!!";
                    lblPointScored.Visible = true;
                    tmrGameLoop.Stop();
                    tmrDecoupled.Stop();
                    tmrPointScored.Start();
                }
            }
            if (gameState == GameState.PointScoredByP2)
            {
                //slimer2's score is increased by 1
                gameScore.AddScore(1, 1);
                int totalScore = gameScore.GetScore(0) + gameScore.GetScore(1);
                showScore(); //Placed here to make sure that the score reflects the winning score upon exit
                if (totalScore == totalGames)
                {
                    lblPointScored.Text = gameScore.GetScore(0) < gameScore.GetScore(1) ? "Player2 Wins!!!" : "Player1 Wins";
                    lblPointScored.Visible = true;
                    tmrGameLoop.Stop();
                    tmrDecoupled.Stop();
                    gameState = GameState.Stop;                    
                }
                else
                {                  
                    lblPointScored.Text = "Player 2 Scores!!!";
                    lblPointScored.Visible = true;
                    tmrGameLoop.Stop();
                    tmrDecoupled.Stop();
                    tmrPointScored.Start();
                }
            }
            if (gameState == GameState.NewGame)
            {
                lblPointScored.Text = "NEW GAME!!!";
                lblPointScored.Visible = true;
                tmrGameLoop.Stop();
                tmrDecoupled.Stop();
                tmrPointScored.Start();
            }

            //simulate gravity for the ball
            float vyball = ball.getVelocityInY();
            ball.setVelocityInY(vyball + 0.09f);
            timerCounter = (timerCounter + 1) % long.MaxValue;
            
            if (timerCounter % 2 == 0)
            {
                slimer1.moveDown();
                slimer2.moveDown();
                // VYB = VYB + 0.05f;
                if (slimer1.getPosition().Y >= this.Height - 100)
                {
                    slimer1UpKeyFlag = true;    //control slimer1's height limit
                    S1BallCollision = false;    //if slimer1 hits the ball, it falls back down
                }
                if (slimer2.getPosition().Y >= this.Height - 100) 
                {
                    slimer2UpKeyFlag = true;    //control slimer2's height limit
                    S2BallCollision = false;    //if slimer2 hits the ball, it falls back down
                }
            }           
            AICompleteFlag = true;
        }

        private void frmGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < gameSprites.Length; i++)
                //polymorphism
                gameSprites[i].Draw(g);
        }

        private void tmrDecoupled_Tick(object sender, EventArgs e)
        {
            if (AICompleteFlag)
                Invalidate();
        }

        private void frmGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameState == GameState.Stop)
            {
                tmrGameLoop.Start();
                tmrDecoupled.Start();                
            }
            ResetSprites();
            gameState = GameState.NewGame;

        }

        private void tmrPointScored_Tick(object sender, EventArgs e)
        {
            tmrPointScored.Stop();
            lblPointScored.Visible = false;
            ResetSprites();     //reset sprites back to original positions            
            tmrGameLoop.Start();
            tmrDecoupled.Start();
        }

        private void ResetSprites()
        {
            slimer1.setPosition(new Point(this.Width / 4 - net.Width/2, this.Height - 100));
            slimer2.setPosition(new Point((this.Width - net.Width) * 3 / 4, this.Height - 100));
            ball.setVelocityInX(0);
            ball.setVelocityInY(2);

            if (gameState == GameState.PointScoredByP1)
            {
                ball.setPosition(new Point(this.Width / 4 - net.Width / 2, 200));
                //ball.setPosition(new Point(this.Width / 2 - net.Width, 200));
                gameState = GameState.NewServe;
            }
            if (gameState == GameState.PointScoredByP2)
            {
                ball.setPosition(new Point((this.Width - net.Width) * 3 / 4, 200));
                gameState = GameState.NewServe;
            }
            if (gameState == GameState.Stop)
            {
                ball.setPosition(new Point(this.Width / 4 - net.Width / 2, 200));
                //gameScore.SetScore(0, 0);
                //gameScore.SetScore(1, 0);
                //gameState = GameState.NewServe;
            }
            if (gameState == GameState.NewGame)
            {
                ball.setPosition(new Point(this.Width / 4 - net.Width / 2, 200));
                gameScore.ResetScores();
                gameState = GameState.NewServe;
            }
            
        }

        /// <summary>
        /// Implements Pause.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                tmrDecoupled.Enabled = !tmrDecoupled.Enabled;
                tmrGameLoop.Enabled = !tmrGameLoop.Enabled;
            }
        }
    }
}
