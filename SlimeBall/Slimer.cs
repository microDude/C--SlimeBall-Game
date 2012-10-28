using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlimeBall
{
    /// <summary>
    /// Summary for Slimer.
    /// </summary>
    class Slimer : Sprite
    {
        private int lMoveLimit;
        private int rMoveLimit;
        protected float moveIntervalX;
        protected float moveIntervalY;


        public Slimer(string fileName, int leftMoveLimit, int rightMoveLimit, float moveIntervalX, float moveIntervalY, int ptX = 0, int ptY = 0) : base(fileName, ptX, ptY)
        {
            lMoveLimit = leftMoveLimit;
            rMoveLimit = rightMoveLimit;
            this.moveIntervalX = moveIntervalX;
            this.moveIntervalY = moveIntervalY;
        }

        /// <summary>
        /// Moves the slimer to the left.
        /// </summary>
        public override void moveLeft()
        {
            if ((pos.X - (int)moveIntervalX) >= lMoveLimit)
            {
                pos.X -= (int)moveIntervalX;                
            }
            
        }

        /// <summary>
        /// Moves the slimer to the right.
        /// </summary>
        public override void moveRight()
        {
            if ((pos.X + (int) moveIntervalX) < (rMoveLimit - getWidth()))
            {
                pos.X += (int) moveIntervalX;                
            }
        }

        /// <summary>
        /// Moves the slimer up.
        /// </summary>
        public void moveUp()
        {
            if ((pos.Y - (int)moveIntervalY) > (0 ))
            {
                pos.Y -= (int)moveIntervalY;
            }
        }


        /// <summary>
        /// Moves the slimer up.
        /// </summary>
        public void moveUp(int offset)  //overload method; different signature
        {
            if ((pos.Y - (int)moveIntervalY) > (0))
            {
                pos.Y -= (int)offset;
            }
        }

        public void moveDown()
        {
            if ((pos.Y + (int)moveIntervalY) < (400 - getHeight()))
            {
                pos.Y += (int)moveIntervalY;
            }
            else if (pos.Y < 400)
                pos.Y += (int)moveIntervalY;           
        }

        /// <summary>
        /// Draws the slimer.
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(System.Drawing.Graphics g)
        {
            base.Draw(g);
        }
    }
}
