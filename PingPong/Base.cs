using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PingPong
{
    class Base
    {
        private Rectangle rec = new Rectangle();

        public Rectangle Rectangulo
        {
            get { return rec; }
        }

        public int x
        {
            get { return  rec.X; }

            set { rec.X = value; } 
        }

        public int y
        {
            get { return  rec.Y; }

            set { rec.Y = value; } 
        }

        public Size tamano 
        {
            set { rec.Size = value; }

        }
    }
}
