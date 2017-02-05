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
            formGraphics.DrawRectangle(myPen, new Rectangle(x1,y1,width,height));
            myPen.Dispose();
            formGraphics.Dispose();
        }

       public room SplitRoomVert(int split)

        {
            double size;
            size = area;
       //     area = (width * height);
            int splitsize = split;
            room temproom = new room { };
            if (size < 5000)
            {
                MessageBox.Show("room too small to split");
            }
            else
            { 
                //for (int i = 1; i < splitsize; i++)
                //create the room and add it to the villa
                temproom.x1 = x1;
                temproom.width = width;
                temproom.y1 = y1;
                temproom.height = height / splitsize;
                temproom.area =  (temproom.width * temproom.height);
            }
            return temproom;
        }

        public room SplitRoomHor(int split)

        {
            int splitsize = split;
            room temproom = new room { };

            //for (int i = 1; i < splitsize; i++)
            //create the room and add it to the villa
            temproom.x1 = x1;
            temproom.width = width / splitsize;
            temproom.y1 = y1;
            temproom.height  = height  ;
            temproom.area = (temproom.width * temproom.height);
            return temproom;


        }

        private Graphics CreateGraphics()
        {
            throw new NotImplementedException();
        }
    }
}
