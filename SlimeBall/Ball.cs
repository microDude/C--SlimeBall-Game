using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SlimeBall
{
    /// <summary>
    /// Summary for Ball.
    /// </summary>
    class Ball : Sprite
    {
        public enum BallBoundries : int
        {
            NoHit = 0,
            LeftWall,
            RightWall,
            Ground,
            Ceiling
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Ball() : base() { }

        /// <summary>
        /// Constructor that accepts only the filename of the image.
        /// </summary>
        /// <param name="fileName"></param>
        public Ball(string fileName) : base(fileName)
        {                    
        }

        public Ball(string fileName, int ptX = 0, int ptY = 0) : base(fileName,ptX, ptY)
        {
        }

        /// <summary>
        /// Draws the Ball.
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(System.Drawing.Graphics g)
        {
            updateBounds();
            base.Draw(g);
        }       

        /// <summary>
        /// resets the ball location
        /// </summary>
        /// <remarks></remarks>
        public override void setPosition(Point p)
        {
            //Set the Ball to the following point            
            base.setPosition(p);           
        }

        /// <summary>
        /// Controls Movement of the Ball
        /// </summary>
        public void updateMovement()
        {
            /* Velocity Units:
             * vxball units = pixels/call
             * vyball units = pixels/call
             */
            float vxball = this.getVelocityInX();
            float vyball = this.getVelocityInY();

            //Adjust the ball position and write it back to itself.
            Point newPoint = new Point((int)(this.getPosition().X + vxball), (int)(this.getPosition().Y + vyball));
            this.setPosition(newPoint);
        }

        public int hitBoundry(int FormWidth,int FormHeight)
        {
            
            //Did the ball hit the side of the form..
            if (this.getPosition().X < 0)
                return (int)BallBoundries.LeftWall;

            if (this.getPosition().X + this.getWidth() > FormWidth)
                return (int)BallBoundries.RightWall;

            //Did the ball hit the floor?
            if (this.getPosition().Y >= (FormHeight - 100))
                return (int)BallBoundries.Ground;

            //Anything else return nothing
            return (int)BallBoundries.NoHit;
        }       
    }
}
