using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SlimeBall
{
    /// <summary>
    /// Summary for Sprite.
    /// </summary>
    class Sprite
    {
        protected Image img;
        protected Point pos;
        //protected int mass;
        protected Rectangle imgBounds;
        protected Rectangle movingBounds;
        
        protected float velocityInX;
        protected float velocityInY;
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Sprite()
        {
            img = null;
            pos = new Point();
            imgBounds = new Rectangle(0,0,0,0);
            movingBounds = new Rectangle();            
            velocityInX = 0.0f;
            velocityInY = 0.0f;
        }
        
        public Sprite(string fileName, int ptX = 0, int ptY = 0)
        {
            img = Image.FromFile(fileName);
            pos = new Point(ptX, ptY);
            imgBounds = new Rectangle(0, 0, 10, 10);
            movingBounds = new Rectangle();
            imgBounds.Width = img.Width;
            imgBounds.Height = img.Height;
            velocityInX = 0.0f;
            velocityInY = 0.0f;
        }

        /// <summary>
        /// Returns current position of Sprite as a Point object.
        /// </summary>
        /// <returns></returns>
        public Point getPosition()
        {
            return pos;
        }

        /// <summary>
        /// Sets the current position of the Sprite object.
        /// </summary>
        /// <param name="p"></param>
        public virtual void setPosition(Point p)
        {
            pos = p;
        }        

        /// <summary>
        /// Returns the width of the Sprite object.
        /// </summary>
        public int Width
        {
            get { return getWidth(); }            
        }

        /// <summary>
        /// Returns the Height of the Sprite object.
        /// </summary>
        public int Height
        {
            get { return getHeight(); }
        }

        /// <summary>
        /// Returns the width of the Sprite object.
        /// </summary>
        /// <returns></returns>
        public virtual int getWidth()
        {
            return imgBounds.Width;
        }

        /// <summary>
        /// Returns the height of the Sprite object.
        /// </summary>
        /// <returns></returns>
        public virtual int getHeight()
        {
            return imgBounds.Height;
        }

        /// <summary>
        /// Returns the image associated with the Sprite object.
        /// </summary>
        /// <returns></returns>
        public Image getImage()
        {
            return img;
        }

        /// <summary>
        /// Returns the Rectangular Boundaries of the Sprite object.
        /// </summary>
        /// <returns></returns>
        public virtual Rectangle getBounds()
        {
            return movingBounds;
        }

        /// <summary>
        /// Updates the rectangular bounds where the sprite will be drawn.
        /// </summary>
        public void updateBounds()
        {
            Point newPos = getPosition();
            movingBounds = imgBounds;
            movingBounds.Offset(newPos);            
        }

        /// <summary>
        /// Draws the Sprite object.
        /// </summary>
        /// <param name="g"></param>
        public virtual void Draw(Graphics g)
        {
            updateBounds();
            g.DrawImage(img, movingBounds, 0, 0, Width, Height, GraphicsUnit.Pixel);
        }

        public bool CheckCollision(Sprite s)
        {
            return this.getBounds().IntersectsWith(s.getBounds());
        }

        public virtual void moveLeft()
        {
        }

        public virtual void moveRight()
        {
        }

        public virtual float getVelocityInX()
        {
            return velocityInX;
        }

        public virtual float getVelocityInY()
        {
            return velocityInY;
        }

        public virtual void setVelocityInX(float v)
        {
            velocityInX = v;
        }

        public virtual void setVelocityInY(float v)
        {
            velocityInY = v;
        }
    }
}
