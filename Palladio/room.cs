using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;


namespace Palladio
{
    public class room
    {
        //fields
        public int x1
        {
            get
            {
                return x1;
            }
            set
            {
                x1 = value;
            }
        }
        public int x2
        {
            get
            {
                return x2;
            }
            set
            {
                x2 = value;
            }
        }

        public int x3
        {
            get
            {
                return x4;
            }
            set
            {
                x3 = value;
            }
        }

        public int x4
        {
            get
            {
                return x4;
            }
            set
            {
                x4 = value;
            }
        }

        public int y1
        {
            get
            {
                return y1;
            }
            set
            {
                y1 = value;
            }
        }
        public int y2
        {
            get
            {
                return y2;
            }
            set
            {
                y2 = value;
            }
        }

        public int y3
        {
            get
            {
                return y4;
            }
            set
            {
                y3 = value;
            }
        }

        public int y4
        {
            get
            {
                return y4;
            }
            set
            {
                y4 = value;
            }
        }

        public int area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }


       
        //method
        public void DrawRoom(System.Windows.Forms.Panel canvas, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            Graphics formGraphics;
            formGraphics = canvas.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(10, 10, 200, 300));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private Graphics CreateGraphics()
        {
            throw new NotImplementedException();
        }
    }
}
