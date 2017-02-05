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

        public int x1 { get; set; }
        public int y1 { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public double area { get; set; }


        //method
        public void DrawRoom(System.Windows.Forms.Panel canvas, System.Drawing.Color color)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(color);
            Graphics formGraphics;
            formGraphics = canvas.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(x1, y1, width, height));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        public void ClearRoom(System.Windows.Forms.Panel canvas, System.Drawing.Color color)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(color);
            Graphics formGraphics;
            formGraphics = canvas.CreateGraphics();
            formGraphics.Clear(color);
        }

        public room SplitRoom(int split, int i, int or)
           
        {

            if (or < 10)
              {
            int diff = width / split;
                room temproom = new room { };
             temproom.x1 = x1+(diff* i);
             temproom.width = diff;
            temproom.y1 = y1;
            temproom.height  = height  ;
            temproom.area = (temproom.width* temproom.height);
            return temproom;
        }   
         else
            {int diff = height  / split;
                room temproom = new room { };
                temproom.x1 = x1;
                 temproom.width = width;
            temproom.y1 = y1 + (diff * i);
            temproom.height = diff;
            temproom.area = (temproom.width* temproom.height);
            return temproom;}
}
        private Graphics CreateGraphics()
        {
            throw new NotImplementedException();
        }
    }
}
